using System;

namespace DelegatesExample
{
	class Program
	{
		static void Main(string[] args)
		{

			var processor = new PhotoProcessor();
			var filters = new PhotoFilters();
			//PhotoProcessor.PhotoFilterHandler filterHandler = filters.ApplyShadow;
			Action<Photo> filterHandler = filters.ApplyShadow;
			filterHandler += filters.ApplyContrast;
			filterHandler += RemoveRedEye;
			processor.Process("teste.jpg", filterHandler);

			//------------------------------------------------------------------------

			//lambda and delegate
			Func<int, int> square = number => number * number;
			Console.WriteLine(square(5));

			//another lambda
			const int factor = 5;
			Func<int, int> multipleFactor = n => n * factor;
			Console.WriteLine(multipleFactor(10));

			//------------------------------------------------------------------------

			var books = new BookRepository().GetBooks();
			var cheapers = books.FindAll(b => b.Price < 10);


			Console.ReadLine();
		}

		static void RemoveRedEye(Photo photo)
		{
			Console.WriteLine("Redeye filter");
		}

		//move to lambda with delegate
		//static int Square(int x, int y)
		//{
		//	return x * y;
		//}
	}
}
