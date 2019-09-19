#Mark Rogers
#Polygon Tool

import graphics as g

#Function for the First Point Plot
def firstPlot(first):
    firstCircle = g.Circle(first, 5)
    firstCircle.setFill('black')
    firstCircle.draw(win)

#Function for every point after the first, returning the point it makes as the previous point
def newPlot(new, previousPoint):
    newCircle = g.Circle(new, 5)
    newCircle.setFill('black')
    newCircle.draw(win)
    newLine = g.Line(new, previousPoint)
    newLine.setFill('black')
    newLine.draw(win)
    previousPoint = new
    return previousPoint

#Check to see if the 'End Button' has been clicked
def click(nextPoint, button):
    lowerLeft = button.getP1()
    upperRight = button.getP2()
    
    if lowerLeft.getX() < nextPoint.getX() < upperRight.getX() and lowerLeft.getY() < nextPoint.getY() < upperRight.getY():
        return True
    else:
        return False

#Close the Polygon
def end(firstPoint, previousPoint):
    newLine = g.Line(firstPoint, previousPoint)
    newLine.setFill('black')
    newLine.draw(win)

#Construct Window
win = g.GraphWin("Polygon Tool", 700, 500)

#End Button
endButtonTL = g.Point(0, 0)
endButtonBR = g.Point(35, 20)
endButton = g.Rectangle(endButtonTL, endButtonBR)
endButton.setFill('white')
endButton.draw(win)
textMessage = g.Text( g.Point(15, 8), 'End')
textMessage.draw(win)

#Get first point
firstPoint = win.getMouse()
firstPlot(firstPoint)

#Once made, assign to Previous Point
previousPoint = firstPoint

#Get second point
nextPoint = win.getMouse()
previousPoint = newPlot(nextPoint, previousPoint)

#Loop remaining points
while click(nextPoint, endButton) == False:
    
    nextPoint = win.getMouse()

#Check for click, end if true
    if click(nextPoint, endButton) == False:
        previousPoint = newPlot(nextPoint, previousPoint)
    else:
        end(firstPoint, previousPoint)