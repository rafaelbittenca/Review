using System;

namespace BinaryTree
{
	class Node
	{
		public int item;
		public Node leftc;
		public Node rightc;
		public void display()
		{
			Console.Write("[");
			Console.Write(item);
			Console.Write("]");
		}
	}
}
