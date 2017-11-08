using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace General
{
	public class Person
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public int Age { get; set; }

		public static List<string> MoreThanNYears(int years, List<Person> persons)
		{
			var newList = persons.Where(a => a.Age > years).Select(a => a.Name).ToList();
			return newList;
		}
	}

	public class Program
	{
		public static void Main(string[] args)
		{
			#region Telogis

			var myList = new List<Person>();
			var person01 = new Person() { Id = 21, Age = 25, Name = "Name01" };
			var person02 = new Person() { Id = 22, Age = 15, Name = "Name02" };
			var person03 = new Person() { Id = 23, Age = 21, Name = "Name03" };
			var person04 = new Person() { Id = 24, Age = 18, Name = "Name04" };
			myList.Add(person01);
			myList.Add(person02);
			myList.Add(person03);
			myList.Add(person04);
			var newList = Person.MoreThanNYears(22, myList);

			#endregion


			#region types
			//int val1 = 0;
			//byte val2 = 15;
			//val1 = val2;
			//Console.WriteLine(val1.GetType());
			//Console.WriteLine(val2.GetType());
			//Console.WriteLine(12 + 12.5);
			//Console.WriteLine("12" + 12);

			//float a;
			//double b = 13.51234567;
			//int c;

			//a = (float)b;
			//c = (int)a;

			//Console.WriteLine(a);
			//Console.WriteLine(b);
			//Console.WriteLine(c);
			#endregion


			#region String
			//string name = "Jane";
			//string name2 = name.Replace('J', 'K');
			//string name3 = name2.Replace('n', 't');

			//Console.WriteLine(name);
			//Console.WriteLine(name3);

			//StringBuilder sb = new StringBuilder("Jane");
			//Console.WriteLine(sb);

			//sb.Replace('J', 'K', 0, 1);
			//sb.Replace('n', 't', 2, 1);
			//Console.WriteLine(sb);

			//char[] crs = { 'Z', 'e', 't', 'C', 'o', 'd', 'e' };
			//String s = new String(crs);
			//Console.WriteLine(s);

			//char c1 = s[0];
			//char c2 = s[(s.Length - 1)];

			//Console.WriteLine(c1);
			//Console.WriteLine(c2);

			//string[] items = new string[] {"C#", "Visual Basic","Java", "Perl"};

			//string langs = string.Join(",", items);
			//Console.WriteLine(langs);

			//string[] ls = langs.Split(',');

			//foreach (string lang in ls)
			//{
			//	Console.WriteLine(lang);
			//}


			//string str = "Determination";

			//Console.WriteLine(str.Contains("e"));
			//Console.WriteLine(str.IndexOf("e"));
			//Console.WriteLine(str.LastIndexOf("i"));

			//Console.WriteLine(str.ToUpper());
			//Console.WriteLine(str.ToLower());

			#endregion

			// --delegate findall--
			//List<int> list = new List<int>() { 3, 2, 1, 8, 6, 4, 7, 9, 5 };

			//List<int> sublist = list.FindAll(delegate (int i) { return i > 3; });

			//foreach (int i in sublist)
			//{
			//	Console.WriteLine(i);
			//}


			//-- continue --
			//int num = 0;

			//while (num < 1000)
			//{
			//	num++;

			//	if ((num % 2) == 0)
			//		continue;

			//	Console.Write(num + " ");
			//}

			#region OOP

			// --Access modifiers--
			//var dog = new Dog(1, "rex", "yellow");
			//dog.Legs = 3;
			//dog.SetFather("Kevin");
			//Console.WriteLine("Test const:" + Dog.eyes.ToString());

			// --inheritance--
			//new Human();
			//Dog2 dog2 = new Dog2();
			//dog2.GetCount();

			// --Abstract classes and methods--
			//Circle c = new Circle(12, 45, 22);
			//Console.WriteLine(c);
			//Console.WriteLine("Area of circle: {0}", c.Area());
			//Console.WriteLine(c.GetCoordinates());

			// --MultipleParams--
			//Sum(1, 2, 3);
			//Sum(1, 2, 3, 4, 5);

			// --Recursion--
			//Console.WriteLine(Factorial(6));

			// --Hiding methods--
			//Derived d = new Derived();
			//d.Info();
			#endregion

			// --seleadclass--
			//DerivedMath dm = new DerivedMath();
			//dm.Say();

			// --Exception--
			//int x = 340004;
			//const int LIMIT = 333;

			//try
			//{
			//	if (x > LIMIT)
			//	{
			//		throw new BigValueException("Exceeded the maximum value");
			//	}

			//}
			//catch (BigValueException e)
			//{
			//	Console.WriteLine(e.Message);
			//}

			// --Delegates--
			// -- -- Simple -- --
			//SimpleDelegate myDelegate = new SimpleDelegate(MyFunc);
			//OR
			SimpleDelegate myDelegate = MyFunc;
			myDelegate();

			MyClass myClass = new MyClass();
			// Crate an instance of the delegate, pointing to the logging function.
			// This delegate will then be passed to the Process() function.
			MyClass.LogHandler myLogger = new MyClass.LogHandler(Logger);
			myClass.Process(myLogger);

			//Multicast Delegate
			Mdelegate del = new Mdelegate(Oper.Add);
			del += new Mdelegate(Oper.Sub);
			del(6, 4);
			del -= new Mdelegate(Oper.Sub);
			del(2, 8);

			//Anonymous Delegate method
			Mdelegate mydel = delegate (int x, int y)
			{
				Console.WriteLine("Anonymous...x: " + x + " ..y:" + y);
			};
			mydel(1,2);

			//As a parameter
			DoOperation(4, 2, Multiply);
			DoOperation(40, 4, Divide);

			Console.Write('\n');

			Console.ReadLine();
		}
		#region delegates

		//Delegates are used in the following cases:
		//Event handlers, Callbacks, LINQ, Implementation of design patterns
		public delegate void SimpleDelegate();
		delegate void Mdelegate(int x, int y);

		delegate int Arithm(int x, int y);

		public static void MyFunc() { Console.WriteLine("I was called by delegate"); }

		public class Oper
		{
			public static void Add(int x, int y)
			{
				Console.WriteLine("{0} + {1} = {2}", x, y, x + y);
			}

			public static void Sub(int x, int y)
			{
				Console.WriteLine("{0} - {1} = {2}", x, y, x - y);
			}
		}

		//Delegate as parameter
		static void DoOperation(int x, int y, Arithm del)
		{
			int z = del(x, y);
			Console.WriteLine(z);
		}

		static int Multiply(int x, int y)
		{
			return x * y;
		}

		static int Divide(int x, int y)
		{
			return x / y;
		}

		// Static Function: To which is used in the Delegate. To call the Process()
		// function, we need to declare a logging function: Logger() that matches
		// the signature of the delegate.
		static void Logger(string s)
		{
			Console.WriteLine("from delegate: " + s);
		}

		
		// The FileLogger class merely encapsulates the file I/O
		public class FileLogger
		{
			FileStream fileStream;
			StreamWriter streamWriter;

			// Constructor
			public FileLogger(string filename)
			{
				fileStream = new FileStream(filename, FileMode.Create);
				streamWriter = new StreamWriter(fileStream);
			}

			// Member Function which is used in the Delegate
			public void Logger(string s)
			{
				streamWriter.WriteLine(s);
			}

			public void Close()
			{
				streamWriter.Dispose();
				fileStream.Dispose();
			}
		}
		
		// Delegate Specification
		public class MyClass
		{
			// Declare a delegate that takes a single string parameter
			// and has no return type.
			public delegate void LogHandler(string message);

			// The use of the delegate is just like calling a function directly,
			// though we need to add a check to see if the delegate is null
			// (that is, not pointing to a function) before calling the function.
			public void Process(LogHandler logHandler)
			{
				if (logHandler != null)
				{
					logHandler("Process() begin");
				}

				if (logHandler != null)
				{
					logHandler("Process() end");
				}
			}
		}
		#endregion

		#region Access modifiers--
		//public class Animal
		//{
		//	//public members can be accessed from anywhere. 
		//	//protected members can be accessed only within the class itself and by inherited and parent classes. 
		//	//private members are limited to the containing type, e.g. only within its class or interface. 
		//	//internal members may be accessed from within the same assembly (exe or DLL).

		//	public int Id { get; private set; }
		//	public string Name { get; private set; }

		//	protected string Father { get; set; }
		//	public const int eyes = 2;

		//	internal int Legs { get; set; }

		//	public Animal(int id, string name)
		//	{
		//		Id = id;
		//		Name = name;
		//	}
		//}

		//public class Dog : Animal
		//{
		//	public string Color { get; set; }

		//	public Dog(int id, string name, string color) : base (id, name)
		//	{
		//		this.Color = color;
		//		this.Legs = 4;
		//	}

		//	public void SetFather(string father)
		//	{
		//		this.Father = father;
		//	}
		//}
		#endregion


		#region Inheritance
		//public class Being
		//{
		//	static int count = 0;

		//	public Being()
		//	{
		//		count++;
		//		Console.WriteLine("Being is created");
		//	}

		//	public void GetCount()
		//	{
		//		Console.WriteLine("There are {0} Beings", count);
		//	}
		//}

		//public class Human : Being
		//{
		//	public Human()
		//	{
		//		Console.WriteLine("Human is created");
		//	}
		//}

		//public class Animal2 : Being
		//{
		//	public Animal2()
		//	{
		//		Console.WriteLine("Animal is created");
		//	}
		//}

		//public class Dog2 : Animal2
		//{
		//	public Dog2()
		//	{
		//		Console.WriteLine("Dog is created");
		//	}
		//}
		#endregion


		#region Abstract classes and methods
		//public abstract class Drawing
		//{
		//	protected int x = 0;
		//	protected int y = 0;

		//	public abstract double Area();

		//	public string GetCoordinates()
		//	{
		//		return string.Format("x: {0}, y: {1}", this.x, this.y);
		//	}
		//}

		//public class Circle : Drawing
		//{
		//	private int r;

		//	public Circle(int x, int y, int r)
		//	{
		//		this.x = x;
		//		this.y = y;
		//		this.r = r;
		//	}

		//	public override double Area()
		//	{
		//		return this.r * this.r * Math.PI;
		//	}

		//	public override string ToString()
		//	{
		//		return string.Format("Circle at x: {0}, y: {1}, radius: {2}",
		//		    this.x, this.y, this.r);
		//	}
		//}
		#endregion


		#region MultipleParams
		static void Sum(params int[] list)
		{
			Console.WriteLine("There are {0} items", list.Length);

			int sum = 0;
			foreach (int i in list)
			{
				sum = sum + i;
			}

			Console.WriteLine("Their sum is {0}", sum);
		}
		#endregion

		#region Recursion
		static int Factorial(int n)
		{
			Console.WriteLine(string.Format("N is: {0}" , n));
			if (n == 0)
			{
				return 1;
			}
			else
			{
				return n * Factorial(n - 1);
			}
		}
		#endregion


		#region Hiding methods
		public class Base
		{
			public Base()
			{
				Console.WriteLine("Base constructor");
			}

			public void Info()
			{
				Console.WriteLine("This is Base class");
			}
		}

		public class Derived : Base
		{
			public Derived()
			{
				Console.WriteLine("Derived constructor");
			}

			public new void Info()
			{
				//base.Info();
				Console.WriteLine("This is Derived class");
			}
		}
		#endregion


		#region sealedclass
		sealed class Math
		{
			public static double GetPI()
			{
				return 3.141592;
			}
		}

		public class DerivedMath 
			//: Math
		{

			public void Say()
			{
				Console.WriteLine("Derived class");
			}
		}
		#endregion


		#region Exception
		class BigValueException : Exception
		{
			public BigValueException(string msg) : base(msg) { }
		}
		#endregion

	}
}
