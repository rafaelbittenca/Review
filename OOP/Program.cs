using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
	class Program
	{
		static void Main(string[] args)
		{
			#region OOPAnimal

			Dog dog = new Dog() { Age = 5, Father = "Father01", Mother = "Mother01", Legs = 4, ScientificName = "Golden", Weight = 15 };
			dog.Describe();
			dog.isEating();
			dog.isMoving();

			Console.WriteLine("\n");

			var snake = new Snake() { ScientificName = "AnyOne", skinColor = "green" };
			snake.Describe();
			snake.isEating();
			snake.isSwim();

			#endregion


			Console.ReadLine();
		}
	}
}
