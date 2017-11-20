using System;
using System.Collections.Generic;

namespace LinkedListExample
{
	class Program
	{
		static void Main(string[] args)
		{

			#region Example01
			//LinkedList<Employee> linked = new LinkedList<Employee>();
			//var e = new Employee() { ID = 10, Name = "Boss", Boss = null };
			//linked.AddFirst(e);
			//LinkedListNode<Employee> node = linked.Find(e);

			//var m1 = new Employee() { ID = 1, Name = "Manager1", Boss = e };
			//var m2 = new Employee() { ID = 2, Name = "Manager2", Boss = e };
			//var m3 = new Employee() { ID = 3, Name = "Manager3", Boss = e };
			//linked.AddAfter(node, m1);
			//linked.AddAfter(node, m2);
			//linked.AddAfter(node, m3);

			//node = linked.Find(m1);
			//var e11 = new Employee() { ID = 11, Name = "Employee11", Boss = m1 };
			//var e22 = new Employee() { ID = 22, Name = "Employee22", Boss = m1 };
			//linked.AddAfter(node, e11);
			//linked.AddAfter(node, e22);

			//node = linked.Find(m2);
			//var e13 = new Employee() { ID = 13, Name = "Employee13", Boss = m1 };
			//linked.AddAfter(node, e13);

			//foreach(var item in linked)
			//	Console.WriteLine(item.Name);
			#endregion

			#region Example02
			bool addFirst = true;
			LinkedList<int> linkInt = new LinkedList<int>();
			for(int i=0; i < 5000000; i++)
			{
				if (addFirst)
				{
					linkInt.AddFirst(i);
					addFirst = false;
				}
				else
				{
					linkInt.AddLast(i);
					addFirst = true;
				}
			}

			LinkedListNode<int> Node = linkInt.Find(545342);
			Console.WriteLine(Node.Value);

			

			List<int> listInt = new List<int>();
			for (int i = 0; i < 5000000; i++)
			{
				listInt.Add(i);
			}
			var number = listInt.Find(n => n.Equals(545342));
			Console.WriteLine(number);

			#endregion
			Console.Read();

		}
	}

	internal class Employee
	{
		public int ID { get; set; }
		public string Name { get; set; }
		public Employee Boss { get; set; }
	}

	// BigBoss -> Manager01 -> Employee11
	//				-> Employee22
	//	     -> Manager02 -> Employee13
}
