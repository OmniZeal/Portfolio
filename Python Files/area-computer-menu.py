#Mark Rogers
#Area Calculator

def main ():
    printMenu()
    uI = getInput()
    
    print("You chose: {}".format(uI))

def printMenu():
    print("Welcome to the area computation tool!")
    print("")
    print("****** MENU ******")
    print("tri --- Compute area of a triangle")
    print("trap -- Compute area of a trapezoid")
    print("rec --- Compute area of a rectangle")
    print("quit -- Quit the tool")
    
def getInput():
    uI = input("Please enter your choice: ")
    
    while uI.lower() != 'tri' and uI != 'trap' and uI != 'rec' and uI != 'quit':
        print("'{}' is an invalid choice".format(uI))
        uI = input("Please enter your choice: ")
        
    return uI
        
main() 