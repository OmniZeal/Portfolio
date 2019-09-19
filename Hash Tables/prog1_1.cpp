//COMP 2270
//Project 1: Basic I/O Hash Table
//Mark Rogers

//Header Files
//=================================================================================================
#include <stdlib.h>
#include <stdio.h>
#include <iostream>
#include <fstream>
#include <string>
#include <cstring>


using namespace std;

//Global Constants
//=================================================================================================
const int TSIZE = 19;

//Prototype Functions
//=================================================================================================
void initialize(string [TSIZE]);
void getFile(string[TSIZE]);
void getWord(string[TSIZE]);
void calcHash(string[TSIZE], string);
void displayTable(string[TSIZE]);
void deleteWord(string[TSIZE]);
bool searchTable(string[TSIZE], string, int&);
bool isFull(string[TSIZE]);
bool checkPosition(string[TSIZE], int&);

//Main Function
//=================================================================================================
int main ()
{
	string selection = "0";
	string *table = new string[TSIZE];
	
	initialize(table);
	
	string searchWord;
	int x = 0;
	
	//Initialize Menu
	while (selection != "6")
	{
		
		cout << "Please select a choice (1-6): " << endl
		<< endl
		<< "1 - Add a Word" << endl
		<< "2 - Import a File" << endl
		<< "3 - Delete a Word" << endl
		<< "4 - Search the Table" << endl
		<< "5 - Display the Table" << endl
		<< "6 - Exit" << endl;
	
		cin >> selection;
	
	//Execute Selection's Function
		while (selection < "1" || selection > "6")
		{
			cout << "ERROR: Please choose a number 1-6 with no additional characters" << endl;
			cin >> selection;
		}
		
		if (selection == "1")	
			getWord(table);
			
		else if (selection == "2")
			getFile(table);
			
		else if (selection == "3")
			deleteWord(table);
		
		else if (selection == "4")
		{
			cout << "Please input the word to search for: ";
			cin >> searchWord;
			cout << endl
			<< "Searching..." << endl;
			searchTable(table, searchWord, x);
		}
		
		else if (selection == "5")
			displayTable(table);
		
		else if (selection == "6")
			break;
	}
	
	cout << "Good-Bye!" << endl;
	
	return 0;
}

//Initialize String Array
//=================================================================================================
void initialize (string x[TSIZE])
{
	x = NULL;
	cout << "Hello!" << endl;
}

//Get Word Function
//=================================================================================================
void getWord (string newTable[TSIZE])
{
	string newWord;
	
	//isFull Check
	if (isFull(newTable) == true)
		cout << "ERROR: Table is full! Please delete an element before adding." << endl;
		
	else
	{
		cout << "Please input the word you'd like to insert into the table: ";
		cin >> (newWord);
		
		calcHash(newTable, newWord);
	}
}

//Get File Function
//=================================================================================================
void getFile (string newTable[TSIZE])
{
	char filename[500];
	ifstream tableFile;
	int position = 0;
	string import[TSIZE];
	
	cout << "Please insert the filename with file type (Ex: 'file.txt'): ";
	cin >> filename;
	
	tableFile.open(filename);
	
	if (tableFile.fail())
	{
		cout << "ERROR: Cannot open file!" << endl;
	}
	
	else 
	{
		while (!tableFile.eof())
    	{
        	getline(tableFile, import[position]);
        	//tableFile.getline(import[position]);
        	calcHash (newTable, import[position]);
			position++;
        	
        	if (position == 19)
        	{
        		cout << "WARNING: Table is limited to 19 elements and your file has more than 19." << endl
        		<< "Only the first 19 elements were imported from the file!" << endl;
        		
        		break;
			}
   		}
   		
   		tableFile.close();
   	}
}

//Delete a Word Function
//=================================================================================================
void deleteWord (string newTable[TSIZE])
{
	string deletion;
	int position;
	
	cout << "Please input the word to delete: ";
	cin >> deletion;
	cout << endl
	<< "Searching..." << endl;
	
	if (searchTable(newTable, deletion, position) == false)
	;
	else 
	{
		cout << "Deleting Word..." << endl;
		
		newTable[position] = "";
	}
}

//Search Table Function
//=================================================================================================

bool searchTable (string array[TSIZE], string searchWord, int& position)
{
	for (int counter = 0; counter < TSIZE; counter++)
	{
		if (searchWord == array[counter]) 
		{
			position = counter;
			cout << "Word Found! Position: " << position << endl;
			return true;
		}
		
		else
			continue;
	}
	
	cout << "ERROR: Word not found in table!" << endl;
	
	return false;
}

//List isFull Check
//=================================================================================================
bool isFull (string array[TSIZE])
{
	for (int counter = 0; counter < TSIZE; counter++)
		{
			if (array[counter] == "")
				return false;
			else
				continue;
		}
		
	return true;
}

//Disaply the Table Function
//=================================================================================================
void displayTable (string array[TSIZE])
{
	cout << "Displaying table..." << endl
	<< "=== Start of Table ===" << endl;
	
	for (int counter = 0; counter < TSIZE; counter++)
	{
		cout << counter << ". " << array[counter] << endl;
	}
	
	cout << "=== End of Table ===" << endl;
}

//Calculate the Hash and Store the Word Function
//=================================================================================================
void calcHash(string array[TSIZE], string newWord)
{
	int hash, increment, position , x;
	
	x = 0;
	
	for (int i = 0; i < newWord.length(); i++)
	{
		x = x + (int)newWord[i];
		
		//Test ASCII Value
		//cout << x;
	}
	
	position = 0;
	
	//Set Hash and Increment for Double Hash
	hash = 11 * x % TSIZE;
	increment = 11 * x / TSIZE;
	
	for (int counterOne = 0; counterOne <= hash; counterOne++)
	{
		position++;
		
		if (position >= TSIZE)
		{
			position = 0;
		}
	}
	
	while ((checkPosition(array, position)) == false)
	{
		cout << "Position is filled. Moving position..." << endl;
		
		for (int counterTwo = 0; counterTwo <= increment; counterTwo++)
		{
			position++;
			
			if (position >= TSIZE)
			{
				position = 0;
			}
		}
	}
	
	array[position] = newWord;
	
	cout << "Success! " << newWord << " is stored in position: " << position << endl;
}

//Check the Position if Filled Function
//=================================================================================================
bool checkPosition(string array[TSIZE], int& x)
{
	//Empty if True, Filled if False
	
	if (array[x] == "")
		return true;
	else
		return false;
}
