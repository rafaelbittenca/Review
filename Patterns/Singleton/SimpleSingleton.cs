using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Singleton
{

	// Works just for single thread situations 
	// Selead to not be inherited
	public sealed class SimpleSingleton
    {
		private static int counter = 0;
		private static SimpleSingleton instance = null;

		public static SimpleSingleton GetInstance
		{
			get
			{
				if (instance == null)
					instance = new SimpleSingleton();
				return instance;
			}
		}

		//private - can't use new SimpleSingleton
		private SimpleSingleton()
		{
			counter++;
			Console.WriteLine("Instances counter: {0}", counter);
		}

		public void AnyMethod(string message)
		{
			Console.WriteLine("Executing any method: {0}", message);
		}
    }
}
