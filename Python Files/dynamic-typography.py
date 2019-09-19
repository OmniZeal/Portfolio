#Mark Rogers
#Dynamic Typography Image

import graphics as g

#Function to Draw each letter
def drawText(sP, uT):
        newLetter = g.Text(sP, uT)
        #newLetter.setSize(int(ord(uT)))
        newLetter.setTextColor(g.color_rgb(round(ord(uT)), round((ord(uT)*2)), round((ord(uT)/2))))
        newLetter.setStyle('bold')
        newLetter.draw(win)
 
#Get user data
userText = input('Please enter some text: ')

#Draw Screen
win = g.GraphWin("Dynamic Typography Image", 900, 700)

#Set starting point
startPoint = g.Point(5, 350)

#Run loop to draw each letter
for i in range(len(userText)):
    drawText(startPoint, userText[i])
    startPoint.move(20, ord(userText[i])-100)