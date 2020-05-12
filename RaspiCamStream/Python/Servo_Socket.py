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

	old_frame_name = ""

	if TRACK == "T":
		color = getCommand()
		if not color is None:
			range_decoded = color.decode("utf-8")
			range = range_decoded.split()

			smin_h = range[0]
			smin_s = range[1]
			smin_v = range[2]
			min_h = int(smin_h)
			min_s = int(smin_s)
			min_v = int(smin_v)

			smax_h = range[3]
			smax_s = range[4]
			smax_v = range[5]
			max_h = int(smax_h)
			max_s = int(smax_s)
			max_v = int(smax_v)

	while TRACK != "Q":
		
		time.sleep(0.1)

		frames = os.listdir("/home/pi/frames/")
		frame = cv2.imread("/home/pi/frames/" + frames[0])

		if (frames[0] != old_frame_name) and (not frame is None):

			height, width, _ = frame.shape	
			xc = width/2
			yc = height/2

			if TRACK == "T":
				hsv_frame = cv2.cvtColor(frame, cv2.COLOR_BGR2HSV)
				# red color
				low_red = np.array([min_h, min_s, min_v])
				high_red = np.array([max_h, max_s, max_v])
				red_mask = cv2.inRange(hsv_frame, low_red, high_red)
				contours, _ = cv2.findContours(red_mask, cv2.RETR_TREE, cv2.CHAIN_APPROX_SIMPLE)
				contours = sorted(contours, key=lambda x:cv2.contourArea(x), reverse=True)

				for cnt in contours:
					(x, y, w, h) = cv2.boundingRect(cnt)
					coordinate = str(x) + "-" + str(y) + "-" + str(w) + "-" + str(h)
					sendCommand(coordinate)
					x_medium = int(x + w / 2)
					y_medium = int(y + h / 2)
					break

				#cv2.rectangle(frame, (x, y), (x + w, y + h), (0, 255, 0), 2)
				#cv2.rectangle(frame, (x_medium, y_medium), (x_medium +3, y_medium+3), (255, 0, 0), 2)

			else:

				gray = cv2.cvtColor(frame, cv2.COLOR_BGR2GRAY)
				faces = face_cascade.detectMultiScale(gray, 1.3, 5)
				for (x, y, w, h) in faces:
					#frame = cv2.rectangle(frame, (x,y), (x+w,y+h), (255,0,0), 2)
					coordinate = str(x) + "-" + str(y) + "-" + str(w) + "-" + str(h)
					# print coordinate
					sendCommand(coordinate)
					#roi_gray = gray[y:y+h, x:x+w]
					#roi_color = frame[y:y+h, x:x+w]
					#eyes = eye_cascade.detectMultiScale(roi_gray)
					#for (ex, ey, ew, eh) in eyes:
					#	cv2.rectangle(roi_color, (ex,ey), (ex+ew, ey+eh), (0,255,0), 2)
					x_medium = int(x + w / 2)
					y_medium = int(y + h / 2)
			if TRACK == "T":
				if x_medium > xc and abs(x_medium - xc) > threshold:
					moveSERVO("R")
				if x_medium < xc and abs(x_medium - xc) > threshold:
					moveSERVO("L")
				if y_medium > yc and abs(y_medium - yc) > threshold:
					moveSERVO("D")
				if y_medium < yc and abs(y_medium - yc) > threshold:
					moveSERVO("U")

		if not frame is None:
			old_frame_name = frames[0]
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

def sendCommand(COORDINATE):
	clientConnection,clientAddress = server.accept()
	coordinate = clientConnection.send(COORDINATE)
	clientConnection.close()

moveSERVO("C")

while True:
	data = getCommand()
	if data == "T" or data == "F" or data == "Q":
		trackSERVO(data)
	else:
		moveSERVO(data)
	print ("from client: ", data.decode())