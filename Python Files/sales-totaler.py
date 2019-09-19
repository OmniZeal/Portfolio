#Mark Rogers
#Sales Totaler 

#Get file names and open
inputFileName = input('Enter sales file name: ')
outputFileName = input('Enter name for total sales file: ')

inputFile = open(inputFileName, "r")
outputFile = open(outputFileName, "w")

#Read File text
inputText = inputFile.read()

#Split each value
strSales = inputText.split()

#Remove non-numerical data
for i in range(len(strSales)):
    strSales[i] = strSales[i].replace('$', '')

#Set i to zero
i = 0

#Write loop to output file, including math in nested statements)
while i < len(strSales):
    outputFile.write('$ {str1: 8.2f} $ {str2: 8.2f} $ {str3} \n'.format(str1 = float(strSales[i]), str2 = float(strSales[i+1]), str3 = float(float(strSales[i])) + float (float(strSales[i+1]))))
    i = i + 2

print('Dont writing totals to {opf}'.format(opf = outputFileName))

inputFile.close()
outputFile.close()