inputFileName = input("Enter the file to be encrypted: ")
key = int( input("Enter the shift key: " ))
outputFileName = input("Enter the output file name: " )

#Open file and store the text
inputFile = open(inputFileName, "r")
message = inputFile.read()

alphabet = " ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz"
shiftedAlphabetStart = alphabet[len(alphabet) - key:]
shiftedAlphabetEnd = alphabet[:len(alphabet) - key]
shiftedAlphabet = shiftedAlphabetStart + shiftedAlphabetEnd

#print( alphabet )
#print( shiftedAlphabet )

encryptedMessage = ''

for character in message:
    letterIndex = alphabet.find( character )
    encryptedCharacter = shiftedAlphabet[letterIndex]
    #print( "{0} -> {1}".format( character, encryptedCharacter ) )
    
    encryptedMessage = encryptedMessage + encryptedCharacter
    
print( "The encrypted message is: {0}".format( encryptedMessage ))

outputFile = open( outputFileName, "w" )
print( encryptedMessage, file=outputFile )
outputFile.close()

print( "Done writing encrypted message to file {0}".format( outputFileName) )

inputFile.close()