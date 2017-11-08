using System;

namespace AlgortGeneral
{
	public interface IMyInterface
	{
		// Any class that implements IMyInterface must define a method
		// that matches the following signature.
		void MethodB();
	}

	class A : IMyInterface
	{
		public void MethodB() { Console.WriteLine("A.MethodB()"); }
	}

	class B : IMyInterface
	{
		public void MethodB() { Console.WriteLine("B.MethodB()"); }
		public void MethodA(int i) { Console.WriteLine("B.MethodA(int i)"); }
	}

	class C : IMyInterface
	{
		public void MethodB() { Console.WriteLine("C.MethodB()"); }
		public void MethodA(object obj)
		{
			Console.WriteLine("C.MethodA(object obj)");
		}
	}
}
