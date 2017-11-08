using System;

namespace OOP
{
	public abstract class Animal
	{
		public int Legs { get; set; }
		public string ScientificName { get; set; }

		public virtual void Describe()
		{
			Console.WriteLine(string.Format("Animal name: {0}, Legs: {1}.", this.ScientificName, this.Legs));
		}
	}
}
