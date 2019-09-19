// FILE: pqtest.cpp
// An interactive test program for the new List ADT.
#include <cctype>     // Provides toupper
#include <iostream>   // Provides cout and cin
#include <cstdlib>    // Provides EXIT_SUCCESS and size_t
#include "pqueue.h"  // With tItem defined as int
using namespace std;

// PROTOTYPES for functions used by this test program:
void DisplayMenu( );
// Postcondition: A menu of choices for this program has been written to cout.

char GetUserCommand( );
// Postcondition: The user has been prompted to enter a one character command.
// The next character has been read (skipping blanks and newline characters), 
// and this character has been returned.

void GetNumbers(int&, unsigned int&);
// Postcondition: The user has been prompted to enter an integer. The
// number has been read, echoed to the screen, and returned by the function.


int main( )
{
    tPriorityQueue test1, test2;    // A PriorityQueue that we'll perform tests on
    char choice;           // A command character entered by the user
    int i;
	unsigned int p;
    
    cout << "I have initialized an empty Priority Queue." << endl;
    cout << "The data entered into this Priority Queue will be integers,\n";
    cout << "and each item also has an unsigned int for its priority." << endl;

    do
    {
        DisplayMenu( );
        choice = toupper(GetUserCommand( ));
        switch (choice)
        {
            case 'P': if (test1.IsEmpty( ))
		                  cout << "The Priority Queue is empty." << endl;
                      else
			               cout << "The Priority Queue is not empty." << endl;
	              break;
            case 'D': if (!test1.IsEmpty( ))
                           cout << "Front item is: " << test1.DeQueue( ) << endl;
                      else
                           cout << "There is no current item." << endl;
                      break;
            case 'E': GetNumbers(i, p);
						test1.EnQueue(i, p);
                      break;
            case 'S': cout << "The size is " << test1.size( ) << endl;
                      break;
            case 'Q': cout << "All good things must come to an end..." << endl;
                      break;
            case 'C': cout << "Generating copy..." << endl;
            			test2 = test1;
            			cout << test2.size() << endl;
            			break;
            default:  cout << choice << " is invalid. Sorry." << endl;
        }
    }
    while ((choice != 'Q'));

    return EXIT_SUCCESS;
}

void DisplayMenu( )
// Library facilities used: iostream.h
{
    cout << endl; // Print blank line before the menu
    cout << "The following choices are available: " << endl;
    cout << " P   Display the result from the IsEmpty( ) function" << endl;
    cout << " D   Display the result from the DeQueue( ) function" << endl;
    cout << " E   Insert a new item with the EnQueue(...) function" << endl;
    cout << " S   Display the result from the GetSize( ) function" << endl;
    cout << " C   Copy test1 to test2 function" << endl;
    cout << " Q   Quit this test program" << endl;
}

char GetUserCommand( )
// Library facilities used: iostream.h
{
    char command;

    cout << "Enter choice: ";
    cin >> command; // Input of characters skips blanks and newline character

    return command;
}

void GetNumbers(int& i, unsigned int& p)
// Library facilities used: iostream.h
{
    int item;
	unsigned int priority;
    
    cout << "Please enter the next item: " << endl;
    cin  >> i;
    cout << "The item's priority: " << endl;
    cin  >> p;
    cout << i << " has been read." << endl;
    return;
}
