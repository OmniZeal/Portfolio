//Mark Rogers
//Project 2: Priority Queue
//COMP 2270
//Class establishes a priority queue through a linked list and performs queue operations.

//Header Files
#include <iostream>
#include <cctype> 
#include <stdlib.h>
#include <cstdlib> 
#include "pqueue.h"

using namespace std;

//Default Constructor
//=================================================================================================
tPriorityQueue::tPriorityQueue()
{
	//Test line
	//cout << "Creating Dummy Node..." << endl;
	
	headPtr = new tNode;
	
	headPtr->data = 0;
	headPtr->priority = 0;
	headPtr->link = NULL;
	
	tPriorityQueue::numNodes = 0;
	
	//Test line
	//cout << "Dummy Header created; List initialized" << endl;
}

//Copy Constructor
//=================================================================================================
tPriorityQueue::tPriorityQueue(const tPriorityQueue& other)
{
	//Test Line
	//cout << "Copy Constructor initializing..." << endl;
	
	headPtr->data = other.headPtr->data;
	headPtr->priority = other.headPtr->priority;
	headPtr->link = NULL;
	
		//Check to see if list has links
	if (other.headPtr->link != NULL)
	{
		//Test Line
		//cout << "Copy-list has links; allocating pointers to copy list..." << endl;
		
		tNode *currentPtr, *nextPtr, *previousPtr;
		
		int counter = 0;
		
		previousPtr = headPtr;
		currentPtr = other.headPtr->link;
		nextPtr = currentPtr->link;
		
		//Test line
		//cout << "Previvous = headPtr, currentPtr = Copy list's headPtr link. nextPtr = current's link" << endl;
		
		while (currentPtr != NULL)
		{
			tNode *newPtr;
			newPtr = new tNode;
			
			//Test line
			//cout << "Copy loop in progress; newPtr initialized..." << endl;
			
			newPtr->data = currentPtr->data;
			newPtr->priority = currentPtr->priority;
			newPtr->link = NULL;
			
			//Test line
			//cout << "newPtr Struct data initialized from Current's copy" << endl;
			
			if (counter == 0)
			{
				headPtr->link = newPtr;
				counter++;
				
				//Test line
				//cout << "This newPtr is the first link copied. Assigning it has this list's headPtr's link." << endl;
			}
			
			else
			{
				previousPtr->link = newPtr;
				
				//Test line
				//cout << "PreviousPtr link assigned to newPtr." << endl;
			}
			
			previousPtr = newPtr;
			currentPtr = nextPtr;
			
			if (currentPtr == NULL)
			{
				//Test Line
				//cout << "Current is pointing to NULL. Breaking from loop to prevent next being assigned garbage..." << endl;
				break;
			}
			nextPtr = nextPtr->link;
			
			//Test line
			//cout << "Previous assinged current, Current assigned next, next assigned next's link." << endl;
		}
	}
	tPriorityQueue::numNodes = other.size();
	
	//Test line
	//cout << "headPtr copied from other headPtr. numNodes initialized to other.size." << endl;
	
	//Test Line
	//cout << "Copy Constructor initialized test2!" << endl;
}

//Destructor
//=================================================================================================
tPriorityQueue::~tPriorityQueue()
{
	//Test line
	//cout << "Checking for remaining items in list..." << endl;
	
	//Loop to deallocate remaining 
	while (tPriorityQueue::numNodes > 0)
	{
		//Test line
		//cout << "Item found in headPtr link. Dequeue'ing..." << endl;
		tPriorityQueue::DeQueue();	
	}
	
	//Test Line
	//cout << "No items remaining in queue. Deallocating memory..." << endl;
	delete headPtr;
	headPtr = NULL;
	
	//Test Line
	//cout << "Memory Deallocated. Good-bye!" << endl;
}

//EnQueue Operation for Priority Queue
//=================================================================================================
void tPriorityQueue::EnQueue(tItem i, unsigned int p)
{
	//Establish new pointer for new node
	tNode *newPtr;
	newPtr = new tNode;
	
	//Test Line
	//cout << "newPtr initialized" << endl;
	
	//Fill node with user-input data and priority; Set link to NULL.
	newPtr->data = i;
	newPtr->priority = p;
	newPtr->link = NULL;
	
	//Test line
	//cout << "newPtr assigned data and priority" << endl;
	
	
	//Check to see if List is empty, and if so, establish item as first in list.
	if (tPriorityQueue::IsEmpty() == true)
	{
		headPtr->link = newPtr;
		
		//Test line
		//cout << "headPtr link assinged to newPtr, newPtr is 1st item" << endl;
	}
	
	//Else, find placement for the item in the list at or behind the
	//specified priority items
	else
	{
		//Pointer variables to walk through list
		tNode *currentPtr;
		tNode *previousPtr; 
		
		//Test line
		//cout << "currentPtr and previousPtr initialized" << endl;
		
		previousPtr = headPtr; //Holds the value of the previously viewed node
		currentPtr = headPtr->link; //Looks at the current node
		
		//Test line
		//cout << "previousPtr = headPtr, currentPtr = headPtr link" << endl;
		
		//Loop through each item in the linked list until the priority is greater
		//than the current pointer
		int counter = 0;
		
		while (currentPtr->priority <= newPtr->priority)
		{	
			previousPtr = currentPtr;
			currentPtr = currentPtr->link;
			
			counter++;
			
			//Test line
			//cout << "Checking Node # " << counter << endl;
			
			//If-Break statement to break loop if currentPtr = NULL
			//as end of the list has been reached, so item has lowest priority.
			if (currentPtr == NULL)
			{
				//Test line
				//cout << "Reached end of list. Item added has lowest priority." << endl;
				
				break;
			}
		}
		
		//Assign the current pointer as the new Pointer's link
		//Assign the previous pointer link to new pointer
		newPtr->link = currentPtr;
		previousPtr->link = newPtr; 
		
		//Test line
		//cout << "newPtr link assigned to currentPtr, previousPtr link assigned to newPtr" << endl;
	}
	
	//Increment number of nodes by one
	tPriorityQueue::numNodes++;
	
	//Test Line
	//cout << "numNodes incremented" << endl;
}

//DeQueue Operation for Priority Queue
//=================================================================================================
tPriorityQueue::tItem tPriorityQueue::DeQueue()
{
	//Establish the value of the dequeued item to be displayed
	tPriorityQueue::tItem value;
	
	//Test Line
	//cout << "Value initialized as tItem" << endl;
	
	//Pointer variables to Dequeue next priority in list
	tNode *currentPtr;
	tNode *nextPtr;
	
	//Test line
	//cout << "Current and Next pointers initialized." << endl;
	
	//Assigns the current pointer to the next priority in list
	//Assigns the Value of current pointer's data to value
	currentPtr = headPtr->link;
	value = currentPtr->data;
	
	//Test line
	//cout << "Current assigned head pointer's link, and value is assigned it's data." << endl;
	
	//Removes current pointer's node from the list by
	//Assigning nextPointer to current pointer's link
	//then placing it as headPtr's link.
	nextPtr = currentPtr->link;
	headPtr->link = nextPtr;
	
	//Test line
	//cout << "Next pointer assigned to Current's link, headPtr link assigned to nextPtr" << endl;
	
	//Deallocate the memory for current pointer and it's link pointer
	delete currentPtr;
	currentPtr = NULL;
	
	//Test line
	//cout << "Deallocated currentPtr's node." << endl;
		
	//Decrement the number of nodes by one 
	tPriorityQueue::numNodes--;
	
	//Test line
	//cout << "Decremented numNodes" << endl;
	//cout << "Returning " << value << endl;
	//Returns the DeQueue'd Item's value
	return value;
}

//Size Operation returns size of linked list
//=================================================================================================
size_t tPriorityQueue::size() const
{return tPriorityQueue::numNodes;}

//IsEmpty(?) Operation returns bool depending if list is empty or not
//True = Empty; False = Not Empty
//=================================================================================================
bool tPriorityQueue::IsEmpty() const
{
	if (tPriorityQueue::numNodes == 0)
	return true;
	
	else
	return false;
}

//Assignment Operator
//=================================================================================================
tPriorityQueue& tPriorityQueue::operator= (const tPriorityQueue& other)
{	
	//Test line
	//cout << "Assignment Operator running..." << endl;
	
	if (headPtr->link != NULL)
	{
		DeQueue();
	}
	
	headPtr->data = other.headPtr->data;
	headPtr->priority = other.headPtr->priority;
	headPtr->link = NULL;
	
		//Check to see if list has links
	if (other.headPtr->link != NULL)
	{
		//Test Line
		//cout << "Copy-list has links; allocating pointers to copy list..." << endl;
		
		tNode *currentPtr, *nextPtr, *previousPtr;
		previousPtr = new tNode;
		currentPtr = new tNode;
		nextPtr = new tNode;
		int counter = 0;
		
		previousPtr = headPtr;
		currentPtr = other.headPtr->link;
		nextPtr = currentPtr->link;
		
		//Test line
		//cout << "Previvous = headPtr, currentPtr = Copy list's headPtr link. nextPtr = current's link" << endl;
		
		while (currentPtr != NULL)
		{
			tNode *newPtr;
			newPtr = new tNode;
			
			//Test line
			//cout << "Copy loop in progress; newPtr initialized..." << endl;
			
			newPtr->data = currentPtr->data;
			newPtr->priority = currentPtr->priority;
			newPtr->link = NULL;
			
			//Test line
			//cout << "newPtr Struct data initialized from Current's copy" << endl;
			
			if (counter == 0)
			{
				headPtr->link = newPtr;
				counter++;
				
				//Test line
				//cout << "This newPtr is the first link copied. Assigning it has this list's headPtr's link." << endl;
			}
			
			else
			{
				previousPtr->link = newPtr;
				
				//Test line
				//cout << "PreviousPtr link assigned to newPtr." << endl;
			}
			
			previousPtr = newPtr;
			currentPtr = nextPtr;
			
			if (currentPtr == NULL)
			{
				//Test Line
				//cout << "Current is pointing to NULL. Breaking from loop to prevent next being assigned garbage..." << endl;
				break;
			}
			nextPtr = nextPtr->link;
			
			//Test line
			//cout << "Previous assinged current, Current assigned next, next assigned next's link." << endl;
		}
	}
	
	tPriorityQueue::numNodes = other.size();
}
