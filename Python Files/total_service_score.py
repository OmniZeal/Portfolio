# Please do your work for problem two in this file
#Mark Rogers
#Resturant Service Report

#Get Range
r = int(input('How many days of scores? '))

#Set score to zero
score = 0

#Get Scores
for i in range(0, r):
    score = score + int(input('Enter the score for day ' + str(i + 1) + ': '))

#Check if r=1 for proper grammer string
if r < 2:
    print('The total score of the', r , 'day is', score)
else:
    print('The total score of the', r , 'days is', score)