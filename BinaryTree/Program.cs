using System;

namespace BinaryTree
{
	class Program
	{
		static void Main(string[] args)
		{
			Tree theTree = new Tree();
			theTree.Insert(20);
			theTree.Insert(25);
			theTree.Insert(45);
			theTree.Insert(15);
			theTree.Insert(67);
			theTree.Insert(43);
			theTree.Insert(80);
			theTree.Insert(33);
			theTree.Insert(67);
			theTree.Insert(99);
			theTree.Insert(91);
			Console.WriteLine("Inorder Traversal : ");
			theTree.Inorder(theTree.ReturnRoot());
			Console.WriteLine(" ");
			Console.WriteLine();
			Console.WriteLine("Preorder Traversal : ");
			theTree.Preorder(theTree.ReturnRoot());
			Console.WriteLine(" ");
			Console.WriteLine();
			Console.WriteLine("Postorder Traversal : ");
			theTree.Postorder(theTree.ReturnRoot());
			Console.WriteLine(" ");
			Console.ReadLine();
		}
	}
}
