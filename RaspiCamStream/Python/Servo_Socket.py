import socket
import pigpio
import time
import curses
import curses.wrapper
import cv2
import numpy as np
import os

HOST = ''
PASSO = 5
PWH = 1500
PWV = 1500
PINV = 18
PINH = 15

pi = pigpio.pi()
pi.set_mode(PINV, pigpio.OUTPUT)
pi.set_mode(PINH, pigpio.OUTPUT)

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

def trackSERVO(TRACK):
	
	threshold = 30
	x = 0
	y = 0 
	w = 0
	h = 0
	x_medium = 0
	y_medium = 0

	face_cascade = cv2.CascadeClassifier('/home/pi/opencv/data/haarcascades/haarcascade_frontalface_default.xml')
	eye_cascade = cv2.CascadeClassifier('/home/pi/opencv/data/haarcascades/haarcascade_eye.xml')

	while TRACK != "Q":
		
		frames = os.listdir("/home/pi/frames/")
		frame = cv2.imread("/home/pi/frames/" + frames[0])

		if not frame is None:
			height, width, _ = frame.shape	
			xc = width/2
			yc = height/2

			if TRACK == "T":
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

			else:

				gray = cv2.cvtColor(frame, cv2.COLOR_BGR2GRAY)
				faces = face_cascade.detectMultiScale(gray, 1.3, 5)
				for (x, y, w, h) in faces:
					frame = cv2.rectangle(frame, (x,y), (x+w,y+h), (255,0,0), 2)
					roi_gray = gray[y:y+h, x:x+w]
					roi_color = frame[y:y+h, x:x+w]
					eyes = eye_cascade.detectMultiScale(roi_gray)
					for (ex, ey, ew, eh) in eyes:
						cv2.rectangle(roi_color, (ex,ey), (ex+ew, ey+eh), (0,255,0), 2)
					x_medium = int(x + w / 2)
					y_medium = int(y + h / 2)

			if x_medium > xc and abs(x_medium - xc) > threshold:
				moveSERVO("R")
			if x_medium < xc and abs(x_medium - xc) > threshold:
				moveSERVO("L")
			if y_medium > yc and abs(y_medium - yc) > threshold:
				moveSERVO("D")
			if y_medium < yc and abs(y_medium - yc) > threshold:
				moveSERVO("U")

		TRACK = getCommand()

server = socket.socket(socket.AF_INET, socket.SOCK_STREAM)
server.bind((HOST, 8081))
server.listen(5)

print ("server started")
print ("waiting for client request")

def getCommand():
	clientConnection,clientAddress = server.accept()
	print ("connected client: ", clientAddress)
	socketData = clientConnection.recv(1024)
	clientConnection.close()
	return socketData

moveSERVO("C")

while True:
	data = getCommand()
	if data == "T" or data == "F" or data == "Q":
		trackSERVO(data)
	else:
		moveSERVO(data)
	print ("from client: ", data.decode())