using Patterns.Singleton;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns
{
	class Program
	{
		static void Main(string[] args)
		{
			#region SimpleSingleton

			//Do not work because the private constructor and the singleton purpose
			//SimpleSingleton anyObject = new SimpleSingleton();

			SimpleSingleton anyClass = SimpleSingleton.GetInstance;
			anyClass.AnyMethod("My anyClass call instance of singleton");

			SimpleSingleton anyClass2 = SimpleSingleton.GetInstance;
			anyClass2.AnyMethod("My anyClass2 use the same instance of singleton");
			#endregion

			Console.ReadLine();
		}
	}
}
