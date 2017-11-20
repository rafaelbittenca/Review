using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace DataStructures
{
	class Program
	{
		static void Main(string[] args)
		{
			//-------------------------------------------------------------------------------------
			//Array
			// Most common, objects same type(most case), specific number
			int[] myIntArray = { 0, 1, 2, 3, 4, 5, 1, 0 ,3 };
			//foreach (var x in myIntArray) { Console.WriteLine(x); }
			//Operation becomes costly if you have to expanded
			//-------------------------------------------------------------------------------------
			//ArrayList
			//Dynamic arry any amount any type
			ArrayList myArrayList = new ArrayList() { "rafa", 1, "joao", 10 };
			myArrayList.Add("maria");
			//foreach (var i in myArrayList) { Console.WriteLine(i); }
			//-------------------------------------------------------------------------------------
			//List
			//Generic version ArrayList. Same way but specified type
			List<int> myList = new List<int>() { 1, 2, 5, 1, 8, 0 };
			myList.Add(5);
			//foreach (var i in myList) { Console.WriteLine(i); }
			//-------------------------------------------------------------------------------------
			//Dictionary
			//
			//A C# Dictionary is a generic data structure added to the .NET Framework in version 2.0. 
			//It is a way to store key/value pairs. In contrast, a List (or ArrayList) can only store values.
			//A Dictionary keeps elements in the order the were added. Meanwhile a SortedDictionary 
			//keeps elements sorted based on their comparer.

			//Inserting elements is faster.
			//Similarly because elements are not sorted, it makes searching more complicated, meaning searching is slower.
			Dictionary<string, int> myDictionary = new Dictionary<string, int>();
			myDictionary.Add("one", 1);
			myDictionary.Add("twenty", 20);
			myDictionary.Add("two", 2);
			//Dictionary<int, string> myDc = new Dictionary<int, string>();
			//int x = 0;
			//while(x < 100)
			//{
			//	myDc.Add(x, "Name" + x);
			//	x += 1;
			//}
			//for(int i = 0; i < myDc.Count; i++)
			//{
			//	Console.WriteLine(myDc[i]);
			//};
			//List<string> keys = new List<string>(myDictionary.Keys);
			//for (int i = 0; i < keys.Count; i++)
			//{
			//	int j = myDictionary[keys[i]];
			//}

			//In a SortedDictionary elements must be sorted when they are added, making insertion times slower.
			//But since elements are kept stored, searching can be done with binary search, meaning searching is faster.

			//SortedDictionary<string, int> mySortedDictionary = new SortedDictionary<string, int>();
			//mySortedDictionary.Add("1", 1);
			//mySortedDictionary.Add("20", 20);
			//mySortedDictionary.Add("2", 2);

			//List<string> sKeys = new List<string>(mySortedDictionary.Keys);
			//for (int i = 0; i < sKeys.Count; i++)
			//{
			//    int j = mySortedDictionary[sKeys[i]];
			//}

			//-------------------------------------------------------------------------------------
			//Hashtable
			//
			//The C# Hashtable data structure is very much like the Dictionary data structure. 
			//Values are then stored in order according to their key's HashCode. 
			//Meaning that the order in which items are added to a C# Hashtable is not preserved. 
			//On the other hand, the Dictionary data structure does keep items in the same order.
			//The reason is speed.A C# Hashtable stores items faster than a C# Dictionary, which 
			//sacrifices speed for the sake of order..

			//Hashtable myHashTable = new Hashtable();
			//myHashTable.Add("one", 1);
			//myHashTable.Add("two", 2);
			//myHashTable.Add("three", 3);
			//-------------------------------------------------------------------------------------
			//HashSet
			//This particular C# data structure very strongly resembles the List<> data strucuture.
			//So what is the difference? A HashSet has the very important characteristic that it 
			//does not allow duplicate values
			HashSet<int> mySet = new HashSet<int>();
			mySet.Add(3);
			mySet.Add(5);
			mySet.Add(3);
			mySet.Add(10);
			List<int> myListFromSet = mySet.ToList<int>();
			int myInt = myListFromSet[2];
			//
			int[] numbers =  { 1, 2, 4, 9, 2, 6, 4, 2, 0 };

			string[] myArray =  { "rafa","day","joao","maria","rafa","jose","rafa"};
			HashSet<string> myNames = new HashSet<string>(myArray);
			myNames.Add("jose");
			myNames.Add("rodrigo");
			myNames.Add("rafa");
			//foreach (var i in myNames) { Console.WriteLine(i); }

			//-------------------------------------------------------------------------------------
			//Stack
			//To add to a stack data structure, you need to use the Push call, which is the Add equivalent 
			//of an List.Retrieving a value is slightly different.The stack has a Pop call, which returns 
			//and removes the last object added. If you want to check the top value in a Stack, use the Peek call.
			//LIFO, which stands for Last-In-First-Out.
			//Stack<string> stack = new Stack<string>();
			//stack.Push("1");
			//stack.Push("2");
			//stack.Push("3");
			//while (stack.Count > 0)
			//{
			//    Console.WriteLine(stack.Pop());
			//}
			//-------------------------------------------------------------------------------------
			//Queue
			//Rather than follow a LIFO behavior, a Queue data structure goes by FIFO, which stands 
			//for First - In - First - Out
			//Queue<string> queue = new Queue<string>();
			//queue.Enqueue("1");
			//queue.Enqueue("2");
			//queue.Enqueue("3");

			//while (queue.Count > 0)
			//{
			//    Console.WriteLine(queue.Dequeue());
			//}
			//-------------------------------------------------------------------------------------
			Console.ReadLine();
		}
	}
}
