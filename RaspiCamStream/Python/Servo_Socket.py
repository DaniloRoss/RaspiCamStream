import socket
import pigpio
import time
import curses
import curses.wrapper

PASSO = 5
PWH = 1500
PWV = 1500
PINV = 18
PINH = 15

pi = pigpio.pi()
pi.set_mode(PINV, pigpio.OUTPUT)
pi.set_mode(PINH, pigpio.OUTPUT)

pi.set_servo_pulsewidth(PINH, 1500)
pi.set_servo_pulsewidth(PINV, 1500)
time.sleep(1)

def moveSERVO(direction):
	global PWV
	global PWH
	global PASSO
	global PINV
	global PINH
	print "prima", PWH
	if direction == "1":
		PWV = PWV - PASSO

	if direction == "2":
		PWV = PWV + PASSO

	if direction == "3":
		PWH = PWH - PASSO

	if direction == "4":
		PWH = PWH + PASSO
	if direction == "c":
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
		print "dopo: ",PWH
	elif PWH < 660:
		PWH = PWH + PASSO
	elif PWH > 2320:
		PWH = PWH - PASSO


#socket
server = socket.socket(socket.AF_INET, socket.SOCK_STREAM)
server.bind(('192.168.1.85', 8081))
server.listen(5)

print ("server started")
print ("waiting for client request")

while True:
	clientConnection,clientAddress = server.accept()
	print ("connected client: ", clientAddress)
	data = clientConnection.recv(1024)
	moveSERVO(data)
	print ("from client: ", data.decode())
	clientConnection.send('successfully connected to server!')
	clientConnection.close()


#curses.nocbreak(); screen.keypad(0); curses.echo()
#curses.endwin()
