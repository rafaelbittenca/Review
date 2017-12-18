using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Singleton
{
	//Simple thread-safe
    public sealed class ThreadSafeSingleton
    {
		private static int counter = 0;
		private static ThreadSafeSingleton instance = null;
		private static readonly object plock = new object();

		public static ThreadSafeSingleton GetInstance
		{
			get
			{
				lock (plock)
				{
					if (instance == null)
						instance = new ThreadSafeSingleton();
					return instance;
				}
			}
		}

		//private - can't use new Singleton
		private ThreadSafeSingleton()
		{
			// This is just to show the unique Instance
			counter++;
			Console.WriteLine("Instances counter: {0}", counter);
		}

		public void AnyMethod(string message)
		{
			Console.WriteLine("Executing any method: {0}", message);
		}
	}
}
