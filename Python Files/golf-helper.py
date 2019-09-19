#Mark Rogers
#Golf Helper

#Into
print("Welcome to the Golf Club Helper!")
print("Tell me your situation, and I'll recommend a club")
print("")

#Get user data
green = input("Did you hit it on the green? ")
distance = int(input("How far is the ball from the hole? "))

#Check to see if its on the Green
if green == "y":
    club = "Putter"
#Check distance if not on the green
elif distance >= 200:
    club = "Driver"
elif distance < 200 and distance > 140:
    club = "9-Iron"
elif distance < 140:
    club = "Pitching Wedge"
   
#Assign a club
print("I'd recommend using your {c}".format(c = club))