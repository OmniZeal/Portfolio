#Mark Rogers
#Sales Invoice Finder

#Try to open the file
try:
    salesFile = open( 'sales_data.csv', "r" )
except FileNotFoundError:
    print("{0} was not found".format ( 'sales_data.csv' ))

#Get Search Type from user
searchType = str(input("Search by invoice id (id) or customer last name (lname)? "))
#Input validate Search Type
while (searchType != 'id' and searchType != 'lname'):
    print("ERROR: You must enter either 'id' for invoice id search or 'lname' for customer last name search")
    searchType = input("Search by invoice id (id) or customer last name (lname)? ")

currentLine = salesFile.readline()
records = 0

#Search by Invoice ID
if searchType == 'id':
    invoice = str(input("Enter your search term: "))

    while currentLine != '':
        currentLineToken = currentLine.split(",")
        if invoice == currentLineToken[0]:
            print(currentLine)
            records += 1
        currentLine = salesFile.readline()
        
#Search by Last Name
elif searchType == 'lname':
    lname = str(input("Enter your search term: "))
    
    while currentLine != '':
        currentLineToken = currentLine.split(",")
        if lname == currentLineToken[2]:
            print(currentLine)
            records += 1
        currentLine = salesFile.readline()

print('{num} records found'.format(num = records))

salesFile.close()
    