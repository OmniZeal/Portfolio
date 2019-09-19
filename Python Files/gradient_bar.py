# Please do your work for problem four in this file
#Mark Rogers
#Gradient Bar Display For Static Red, Six Bars

import graphics as g
import math as m

win = g.GraphWin("Gradient Bar", 400, 200)

#Define Static and Starting values
numBars = 6
currentTLX = 0
currentBRX = round(400 / numBars)
colorInterval = 0

#Define Function to Build Rectangles as called
def buildRectangle(tlx, brx, index):
#Check Index to ensure final block meets the edge
    if index == numBars - 1:
        bottomRight = g.Point(400, 200)
    else:
        bottomRight = g.Point(brx, 200)
    topLeft = g.Point(tlx, 0)
    rectangle = g.Rectangle(topLeft, bottomRight)
    rectangle.setFill(g.color_rgb(colorInterval, 0, 0))
    rectangle.setOutline(g.color_rgb(colorInterval, 0, 0))
    rectangle.draw(win)

#Set loop to draw out each rectangle for set interval
for i in range(0, numBars):
    buildRectangle(currentTLX, currentBRX, i)
    currentTLX = currentBRX
    currentBRX += round(400 / numBars, 0)
#Validate that input hasn't exceeded 255 (just to be safe)
    if colorInterval > 255:
        colorInterval = 255
    else:
        colorInterval += round(255 / numBars)

