// FILE: pqueue.h
// Mark Rogers mogers9@students.fairmontstate.edu
// CLASS PROVIDED: tPriorityQueue (a priority queue of items)
//
// TYPEDEF for the tPriorityQueue class:
//   typedef _____ tItem 
//     The type tItem is the data type of the items in the Priority Queue.
//     It may be any of the C++ built-in types (int, char, etc.), or a class 
//     with a default constructor, a copy constructor, and assignment operator.
//
// CONSTRUCTOR for the tPriorityQueue class:
//   tPriorityQueue( )
//     Postcondition: The PriorityQueue has been initialized with no Items.
//
// MODIFICATION MEMBER FUNCTIONS for the tPriorityQueue class:
//   void EnQueue(const tItem& entry, unsigned int priority)
//     Postcondition: A new copy of entry has been inserted with the specified
//     priority.
//
//   tItem DeQueue( )
//     Precondition: GetSize( ) > 0.
//     Postcondition: The highest priority item has been returned and has been
//     removed from the PriorityQueue. (If several items have equal priority,
//     then the one that entered first will come out first.)
//
// CONSTANT MEMBER FUNCTIONS for the tPriorityQueue class:
//   size_t GetSize( ) const
//     Postcondition: Return value is the total number of items in the
//     PriorityQueue.
//
//   bool IsEmpty( ) const
//     Postcondition: Return value is true if the PriorityQueue is empty.
//

#ifndef __PQUEUE_H
#define __PQUEUE_H
#include <stdlib.h> // Provides size_t type

    struct tNode; // This will be completely defined below.

    class tPriorityQueue
    {
    public:
        typedef int tItem;
        
        tPriorityQueue();
        tPriorityQueue(const tPriorityQueue& obj);
        ~tPriorityQueue();
        tPriorityQueue & operator= (const tPriorityQueue& obj);
        
        void EnQueue(tItem, unsigned int);
        tItem DeQueue();
        void initialize();
        
        size_t size() const;
        bool IsEmpty() const;
        //student must list all the prototypes here including
        //assignment operator
    private:
        // Note: headPtr is the head pointer for a linked list that
        // contains the items along with their priorities. These nodes are
        // kept in order from highest priority (at the head of the list)
        // to lowest priority (at the tail of the list). The private member
        // variable, numNodes, indicates how many nodes are in the list.
        // The data type tNode is completely defined below.
        tNode *headPtr;
        size_t numNodes;
    };

    struct tNode
    {   // Node for a linked list
        tPriorityQueue::tItem data;
        unsigned int priority;
        tNode *link;
    };

#endif
