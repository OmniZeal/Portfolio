# Please do your work for problem three in this file
#Mark Rogers
#House Simluation

import graphics as g

#Constructor
win = g.GraphWin("House Simlulation", 500, 350)

#Build Rectangle for House
houseTL = g.Point(50, 150)
houseBR = g.Point(450, 300)
house = g.Rectangle(houseTL, houseBR)
house.setFill('blue')
house.draw(win)

#Build a Door with a Circular Window
doorTL = g.Point(225, 225)
doorBR = g.Point(275, 300)
door = g.Rectangle(doorTL, doorBR)
door.setFill('brown')
door.draw(win)

doorWindowCenter = g.Point(250, 250)
doorWindow = g.Circle(doorWindowCenter, 12)
doorWindow.setFill('white')
doorWindow.draw(win)

#Build Rectangular Windows
leftWindowTL = g.Point(125, 200)
leftWindowBR = g.Point(175, 250)
leftWindow = g.Rectangle(leftWindowTL, leftWindowBR)
leftWindow.setFill('white')
leftWindow.draw(win)

rightWindowTL = g.Point(325, 200)
rightWindowBR = g.Point(375, 250)
rightWindow = g.Rectangle(rightWindowTL, rightWindowBR)
rightWindow.setFill('white')
rightWindow.draw(win)

#Build Roof
leftRoofA = houseTL
leftRoofB = g.Point(250, 100)
leftRoof = g.Line(leftRoofA, leftRoofB)
leftRoof.draw(win)

rightRoofA = leftRoofB
rightRoofB = g.Point (450, 150)
rightRoof = g.Line(rightRoofA, rightRoofB)
rightRoof.draw(win)

textMessage = g.Text( g.Point(250, 325), 'Someone is home')
textMessage.draw(win)

win.getMouse()
leftWindow.setFill('black')
rightWindow.setFill('black')
doorWindow.setFill('black')
textMessage.setText('No one is home')