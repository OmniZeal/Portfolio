# Please do your work for problem one in this file
# Mark Rogers
# Ball Filler Calculation Tool

import math

#Get User Data
ballsManufactured = int(input('How many bowling balls will be manufactured? '))
ballDiameter = float(input('What is the diameter of each ball in inches? '))

#Input validate, as diameter is constricted 
while ballDiameter > 8.6 or ballDiameter < 8.4:
    ballDiameter = float(input('ERROR: Please enter a value between 8.4 or 8.6: '))

coreVolume = float(input('What is the core volume in inches cubed? '))

#Calculate Filler Volume
fillerVolume = ((4/3) * math.pi * ((ballDiameter / 2) ** 3)) - coreVolume

#Print Needed Filler for the amount manufactured
print ('You will need', str(fillerVolume * ballsManufactured), 'inches cubed of filler')
