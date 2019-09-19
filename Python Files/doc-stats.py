def getTextFile():
    fileName = input("Enter the text file name: ")
    textFile = open( fileName, 'r' )
    return fileName, textFile

def outputCountResults( fileName, lineCount, wordCount, charCount, nonArtWords ):
    print( "******* {} *******".format( fileName ))
    print( "Line Count: {}".format( lineCount ))
    print( "Word Count: {}".format( wordCount ))
    print( "Char Count: {}".format( charCount ))
    print( "Non-Article Word Count: {}".format( nonArtWords ))
    
    
def countCharacters(line):
    charCount = 0
    for c in line:
        if not c.isspace():
            charCount = charCount + 1
    return charCount
    
def countWords( line ):
    words = line.split()
    return len( words )

def countNonArtWords( line ):
    nonAW = 0
    words = line.split()
    for i in range(len(words)):
        if stringCheck(words[i]) == True:
            nonAW += 1
    return nonAW

def countDocStats( docFile ):
    lineCount = 0
    totalCharacters = 0
    totalWords = 0
    nonArtWords = 0
    for line in docFile:
        lineCount = lineCount + 1
        totalCharacters = totalCharacters + countCharacters( line )
        totalWords = totalWords + countWords( line )
        nonArtWords = nonArtWords + countNonArtWords( line )
    return lineCount, totalCharacters, totalWords, nonArtWords

def stringCheck(s):
    if s.lower() == 'an':
        return False
    elif s.lower() == 'a':
        return False
    elif s.lower() == 'the':
        return False
    else:
        return True

def main():
    fileName, textFile = getTextFile()
    lineCount, totalCharacters, totalWords, nonArtWords = countDocStats( textFile )
    outputCountResults( fileName, lineCount, totalWords, totalCharacters, nonArtWords )
    
main()