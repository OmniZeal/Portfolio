# You should probably start by copying and pasting the contents of
# your original my-house.py file into this one.

#Mark Rogers
#House Simluation v2

import graphics as g

def main():
    #Constructor
    win = g.GraphWin("House Simlulation", 500, 350)
    buildHouse()

def buildHouse():
    #Build Rectangle for House
    house = rectangleCall(50, 150, 450, 300)
    house.setFill('blue')
    draw(house)
    
    buildDoor()
    buildWindows()
    buildRoof()

def buildDoor():
    #Build a Door with a Circular Window
    door = rectangleCall(225, 225, 275, 300)
    door.setFill('brown')
    draw(door)

def buildWindows():
    doorWindow = circleCall(250, 250, 12)
    doorWindow.setFill('white')
    draw(doorWindow)
    
    #Build Rectangular Windows
    leftWindow = rectangleCall(125, 200, 175, 250)
    leftWindow.setFill('white')
    draw(leftWindow)

    rightWindow = rectangleCall(325, 200, 375, 250)
    rightWindow.setFill('white')
    draw(rightWindow)

def buildRoof():
    leftRoofA = houseTL
    leftRoofB = g.Point(250, 100)
    leftRoof = g.Line(leftRoofA, leftRoofB)
    leftRoof.draw(win)

    rightRoofA = leftRoofB
    rightRoofB = g.Point (450, 150)
    rightRoof = g.Line(rightRoofA, rightRoofB)
    rightRoof.draw(win)

def draw(obj):
    obj.draw(win)

def rectangleCall(tLX, tLY, bRX, bRY):
    #Construct a rectangle by being passed basic int data required for
    #the top left and bottom right G Point objects
    topLeft = g.Point(tLX, tLY)
    bottomRight = g.Point(bRX, bRY)
    return g.Rectangle(topLeft, bottomRight)

def circleCall(centerX, centerY, size):
    center = g.Point(centerX, centerY)
    return g.Circle(center, size)

textMessage = g.Text( g.Point(250, 325), 'Someone is home')
textMessage.draw(win)

win.getMouse()
leftWindow.setFill('black')
rightWindow.setFill('black')
doorWindow.setFill('black')
textMessage.setText('No one is home')

main()
