#Mark Rogers
#Unique List Checker

#Checks the number provided against the existing list
#Returns a boolean to set the unique flag
def checkAgainstList(num, numList):
    if num in numList:
        return False
    else:
        return True
#=================================================================================================================================

#Displays final result
def displayResult(isUnique, numList):
    #Produce results based on flag
    if isUnique == False:
        print("The sequence {} is NOT unique!".format (numList))
    else:
        print("The sequence {} is unique!".format (numList))
#=================================================================================================================================

#Main
def main():
#Declare variables and list
    x = 0
    numList = []
    
    #Give user info
    print("This program tests if the sequence of positive numbers you input are unique")
    print("Enter -1 to quit")
    
    #Try-Except for alphabetical characters
    try:
        x = int(input("Enter the first number: "))
    except ValueError:
        print("ERROR: Received an impoper value!")
        x = int(input("Enter a number value greater than -1: "))
    
    #Manually set first interval due to unique prompt
    isUnique = checkAgainstList(x, numList)    
    numList.append(x)    
    
    #Enter loop for remaining prompts
    #Will skip loop if user declares -1 at start
    while x != -1:
        try:
            x = int(input("Next number: "))
        except ValueError:
            print("ERROR: Received an improper value!")
            x = int(input("Enter a number value greater than -1: "))
        while x < -1:
            print("ERROR: Positive integers only!")
            x = int(input("Enter a number value greater than -1: "))
        
        if x == -1:
            break
        
        #Prevent further checking if flag is already identified as false
        if isUnique == True:
            isUnique = checkAgainstList(x, numList)
        
        numList.append(x)
    
    displayResult(isUnique, numList)
#=================================================================================================================================

main()