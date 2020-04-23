import socket
import pigpio
import time
import curses
import curses.wrapper
import cv2
import numpy as np

HOST = ''
PASSO = 5
PWH = 1500
PWV = 1500
PINV = 18
PINH = 15

pi = pigpio.pi()
pi.set_mode(PINV, pigpio.OUTPUT)
pi.set_mode(PINH, pigpio.OUTPUT)

def center():
	pi.set_servo_pulsewidth(PINH, 1500)
	pi.set_servo_pulsewidth(PINV, 1500)
	time.sleep(1)

def moveSERVO(direction):
	global PWV
	global PWH
	global PASSO
	global PINV
	global PINH
	if direction == "U":
		PWV = PWV - PASSO

	if direction == "D":
		PWV = PWV + PASSO

	if direction == "R":
		PWH = PWH - PASSO

	if direction == "L":
		PWH = PWH + PASSO
	if direction == "C":
		PWH = 1500
		PWV = 1500
	if PWV > 760 and PWV < 2200:
		pi.set_servo_pulsewidth(PINV, PWV)
	elif PWV < 760:
		PWV = PWV + PASSO
	elif PWV > 2200:
		PWV = PWV - PASSO

	if PWH > 660 and PWH < 2320:
		pi.set_servo_pulsewidth(PINH, PWH)
	elif PWH < 660:
		PWH = PWH + PASSO
	elif PWH > 2320:
		PWH = PWH - PASSO
		
def trackSERVO():
	
	center()
	cap = cv2.VideoCapture(0)

	cap.set(3, 480)
	cap.set(4, 320)
	_, frame = cap.read()
	rows, cols, _ = frame.shape

	xc = int(cols / 2)
	yc = int(rows / 2)
	x = 0
	y = 0 
	w = 0
	h = 0
	x_medium = 0
	y_medium = 0
	
	while True:
		_, frame = cap.read()
		hsv_frame = cv2.cvtColor(frame, cv2.COLOR_BGR2HSV)
		
		# red color
		low_red = np.array([161, 155, 84])
		high_red = np.array([179, 255, 255])
		red_mask = cv2.inRange(hsv_frame, low_red, high_red)
		contours, _ = cv2.findContours(red_mask, cv2.RETR_TREE, cv2.CHAIN_APPROX_SIMPLE)
		contours = sorted(contours, key=lambda x:cv2.contourArea(x), reverse=True)
		
		for cnt in contours:
			(x, y, w, h) = cv2.boundingRect(cnt)
			
			x_medium = int(x + w / 2)
			y_medium = int(y + h / 2)
			break
		
		cv2.rectangle(frame, (x, y), (x + w, y + h), (0, 255, 0), 2)
		cv2.rectangle(frame, (x_medium, y_medium), (x_medium +3, y_medium+3), (255, 0, 0), 2)
		
		cv2.imshow("Frame", frame)
		
		if x_medium > xc:
			moveSERVO("L")
		if x_medium < xc:
			moveSERVO("R")
		if y_medium > yc:
			moveSERVO("U")
		if y_medium < yc:
			moveSERVO("D")	
		
		
		key = cv2.waitKey(1)
		
		if key == 27:
			break
		
		
	cap.release()
	cv2.destroyAllWindows()

center()

#socket
server = socket.socket(socket.AF_INET, socket.SOCK_STREAM)
server.bind((HOST, 8081))
server.listen(5)

print ("server started")
print ("waiting for client request")

while True:
	clientConnection,clientAddress = server.accept()
	print ("connected client: ", clientAddress)
	data = clientConnection.recv(1024)
	#data = "T"
	if data == "T":
		trackSERVO()
	else:	
		moveSERVO(data)
	print ("from client: ", data.decode())
	clientConnection.send('successfully connected to server!')
	clientConnection.close()