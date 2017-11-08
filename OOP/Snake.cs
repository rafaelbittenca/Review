using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
	public class Snake : Reptile, IEat, ISwim
	{
		public Snake()
		{
			this.Legs = 0;
		}

		public override void Describe()
		{
			base.Describe();
			Console.WriteLine(string.Format("Snake: {1}, Skin Color {0}", this.skinColor, this.ScientificName));
		}

		
		public void isEating()
		{
			Console.WriteLine("I'm a snake and I'm eating");
		}

		public void isSwim()
		{
			Console.WriteLine("I'm a snake and I'm swim");
		}
	}
}
