#Mark Rogers
#Madlib Maker

#Function for Formating the Strings
def madlib():
    print("After hiding the painting in his {a} for two".format(a=nounA))
    print("years, he grew {adj} and tried to {v} it".format(adj=adjective, v=verb))
    print("to a/an {b} in Florence, but was caught.".format(b=nounB))

print('Madlib Maker')

#Get User Data
nounA = input('noun ')
adjective = input('adjective ')
verb = input('verb ')
nounB = input('noun ')

#Make Madlib statement
madlib()