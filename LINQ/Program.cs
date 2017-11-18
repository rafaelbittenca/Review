using System;
using System.Collections.Generic;
using System.Linq;

namespace LINQ
{
	class Program
	{

		#region Class Definitions
		public class Customer
		{
			public string First { get; set; }
			public string Last { get; set; }
			public string State { get; set; }
			public double Price { get; set; }
			public string[] Purchases { get; set; }
		}

		public class Distributor
		{
			public string Name { get; set; }
			public string State { get; set; }
		}

		public class CustDist
		{
			public string custName { get; set; }
			public string distName { get; set; }
		}

		public class CustDistGroup
		{
			public string custName { get; set; }
			public IEnumerable<string> distName { get; set; }
		}
		#endregion

		#region Create data sources

		static List<Customer> customers = new List<Customer>
	  {
		new Customer {First = "Cailin", Last = "Alford", State = "GA", Price = 930.00, Purchases = new string[] {"Panel 625", "Panel 200"}},
		new Customer {First = "Theodore", Last = "Brock", State = "AR", Price = 2100.00, Purchases = new string[] {"12V Li"}},
		new Customer {First = "Jerry", Last = "Gill", State = "MI", Price = 585.80, Purchases = new string[] {"Bulb 23W", "Panel 625"}},
		new Customer {First = "Owens", Last = "Howell", State = "GA", Price = 512.00, Purchases = new string[] {"Panel 200", "Panel 180"}},
		new Customer {First = "Adena", Last = "Jenkins", State = "OR", Price = 2267.80, Purchases = new string[] {"Bulb 23W", "12V Li", "Panel 180"}},
		new Customer {First = "Medge", Last = "Ratliff", State = "GA", Price = 1034.00, Purchases = new string[] {"Panel 625"}},
		new Customer {First = "Sydney", Last = "Bartlett", State = "OR", Price = 2105.00, Purchases = new string[] {"12V Li", "AA NiMH"}},
		new Customer {First = "Malik", Last = "Faulkner", State = "MI", Price = 167.80, Purchases = new string[] {"Bulb 23W", "Panel 180"}},
		new Customer {First = "Serena", Last = "Malone", State = "GA", Price = 512.00, Purchases = new string[] {"Panel 180", "Panel 200"}},
		new Customer {First = "Hadley", Last = "Sosa", State = "OR", Price = 590.20, Purchases = new string[] {"Panel 625", "Bulb 23W", "Bulb 9W"}},
		new Customer {First = "Nash", Last = "Vasquez", State = "OR", Price = 10.20, Purchases = new string[] {"Bulb 23W", "Bulb 9W"}},
		new Customer {First = "Joshua", Last = "Delaney", State = "WA", Price = 350.00, Purchases = new string[] {"Panel 200"}}
	  };

		static List<Distributor> distributors = new List<Distributor>
	  {
		new Distributor {Name = "Edgepulse", State = "UT"},
		new Distributor {Name = "Jabbersphere", State = "GA"},
		new Distributor {Name = "Quaxo", State = "FL"},
		new Distributor {Name = "Yakijo", State = "OR"},
		new Distributor {Name = "Scaboo", State = "GA"},
		new Distributor {Name = "Innojam", State = "WA"},
		new Distributor {Name = "Edgetag", State = "WA"},
		new Distributor {Name = "Leexo", State = "HI"},
		new Distributor {Name = "Abata", State = "OR"},
		new Distributor {Name = "Vidoo", State = "TX"}
	  };

		static double[] exchange = { 0.89, 0.65, 120.29 };

		static double[] ExchangedPrices = {827.70, 604.50, 111869.70,
							    1869.00, 1,365.00, 252609.00,
							    521.36, 380.77, 70465.88,
							    455.68, 332.80, 61588.48,
							    2018.34, 1474.07, 272793.66,
							    920.26, 672.10, 124379.86,
							    1873.45, 1368.25, 253210.45,
							    149.34, 109.07, 20184.66,
							    455.68, 332.80, 61588.48,
							    525.28, 383.63, 70995.16,
							    9.08, 6.63, 1226.96,
							    311.50, 227.50, 42101.50};

		static string[] Purchases = {  "Panel 625", "Panel 200",
							"12V Li",
							"Bulb 23W", "Panel 625",
							"Panel 200",
							"Bulb 23W", "12V Li",
							"Panel 625",
							"12V Li", "AA NiMH",
							"Bulb 23W", "Panel 180",
							"Panel 180", "Panel 200",
							"Panel 625", "Bulb 23W", "Bulb 9W",
							"Bulb 23W", "Bulb 9W",
							"Panel 200"
						   };
		#endregion


		static void Main(string[] args)
		{
			var query01 = customers.Select(c => 
				new {
					Name = c.First ,
					OriginalValue = c.Price,
					Total = c.Price * 0.89
				    }
			);
			//foreach(var a in query01)
			//{
			//	Console.WriteLine("{0} - {1:C} - {2:C}", a.Name, a.OriginalValue, a.Total);
			//}

			IEnumerable<double> exchangeQuery = customers
				.SelectMany(c => exchange, (c, e) => c.Price * e);

			IEnumerable<string> purchasesQuery = customers
				.SelectMany(c => c.Purchases);

			//foreach (var p in exchangeQuery)
			//{
			//	Console.WriteLine("{0}", p);
			//}

			var exchangeQuery2 = customers
				.SelectMany(c => exchange, (c, e) => new { finalPrice = c.Price * e, name = c.First });
			//foreach(var o in exchangeQuery2)
			//	Console.WriteLine("{0} - {1} ", o.name, o.finalPrice);

			Console.WriteLine("----------------Filtering----------------------");
			#region Filtering
			IEnumerable<Customer> query02L = from c in customers
					   where c.Price > 1000 && c.State == "OR"
					   select c;

			var query02 = customers.Where(c => c.Price > 1000 && c.State == "OR");

			//foreach (var a in query02L)
			//{
			//	Console.WriteLine("{0} - {1:C} ", a.First, a.Price);
			//}
			#endregion
			Console.WriteLine("---------------Ordering------------------------");
			#region Ordering
			IEnumerable<Customer> orderBy01 = from c in customers
								   orderby c.Last descending
								   select c;

			var orderBy02 = customers.OrderByDescending(c => c.Last);

			//foreach (var a in orderBy02)
			//	Console.WriteLine("{0} - {1:C} ", a.Last, a.Price);

			Console.WriteLine(" ");

			var orderBy03 = customers.OrderBy(c => c.State).ThenBy(c => c.First);
			//foreach (var c in orderBy03)
			//	Console.WriteLine("{0} - {1} ", c.State, c.First);

			var xx = customers.Where(c => c.Price > 800).OrderBy(c=> c.First).Select(c=> c.First);
			foreach(var c in xx)
				Console.WriteLine(c);
			#endregion
			Console.WriteLine("---------------GroupBy-------------------------");
			#region GroupBy
			IEnumerable<IGrouping<string, Customer>> groupBy01 =
				from c in customers
				group c by c.State;

			//foreach(IGrouping<string,Customer> group in groupBy01)
			//{
			//	Console.WriteLine("{0}", group.Key);

			//	foreach(Customer c in group)
			//		Console.WriteLine("  {0} {1}: {2:C}", c.First, c.Last, c.Price);
			//}
			Console.WriteLine(" ");

			IEnumerable<IGrouping<string, Customer>> groupBy04 =
				customers.GroupBy(c => c.State);
			//foreach(IGrouping<string,Customer> group in groupBy04)
			//{
			//	Console.WriteLine("{0}",group.Key);
			//	foreach(var c in group)
			//		Console.WriteLine("  {0} {1}: {2:C}", c.First, c.Last, c.Price);
			//}

			Console.WriteLine(" ");
			IEnumerable<IGrouping<bool, Customer>> groupBy02 =
				from c in customers
				group c by c.Price > 1000;

			//foreach(IGrouping<bool,Customer> group in groupBy02)
			//{
			//	Console.WriteLine("{0}", group.Key);
			//	foreach(Customer c in group)
			//		Console.WriteLine("  {0} - {1:C}", c.First, c.Price);
			//}
			Console.WriteLine(" ");

			IEnumerable<IGrouping<bool, Customer>> groupby03 = customers.GroupBy(c => c.Price > 1000);
			//foreach(IGrouping<bool,Customer> group in groupby03)
			//{
			//	Console.WriteLine("{0}", group.Key);
			//	foreach(var c in group)
			//		Console.WriteLine("  {0} - {1:C}", c.First, c.Price);
			//}
			Console.WriteLine(" ");
			#endregion
			Console.WriteLine("---------------JOIN----------------------------");
			#region JOIN
			var joinQuery01 =
				from c in customers
				join d in distributors on c.State equals d.State
				select new { custName = c.First, distName = d.Name };
			//foreach(var c in joinQuery01)
			//	Console.WriteLine("{0} - {1}", c.custName, c.distName);

			Console.WriteLine("");

			var join02 = customers
				.GroupJoin(
				distributors,
				c => c.State,
				d => d.State,
				(c, d) => new { custName = c.First, distName = d.Select( dist => dist.Name)});
			foreach (var c in join02)
			{
				//Console.WriteLine("{0}", c.custName);
				//foreach(var d in c.distName)
				//	Console.WriteLine("{0} - {1}", c.custName, d);
			}
			#endregion
			Console.WriteLine("---------------GroupJOIN-----------------------");
			#region GroupJOIN
			var groupJoin01 =
				from c in customers
				join d in distributors on c.State equals d.State into cdJoin
				select new
				{
					custName = c.First,
					distName = cdJoin.Select(d => d.Name)
				};
			//foreach(var cd in groupJoin01)
			//{
			//	Console.WriteLine("{0}", cd.custName);
			//	foreach(var d in cd.distName)
			//		Console.WriteLine("  {0}", d);
			//}
			#endregion

			Console.WriteLine("---------------Distinct------------------------");
			#region Distinct
			IEnumerable<double> testQuery = ExchangedPrices
				.Where((n, index) => index % 3 == 0);
			//foreach(var i in testQuery)
			//	Console.WriteLine(i);

			Console.WriteLine(" ");

			IEnumerable<string> distQuery = Purchases
				.Distinct();
			//foreach (var i in distQuery)
			//	Console.WriteLine(i);
			#endregion
			Console.WriteLine(" -----------------SKIP TAKE--------------------");
			#region SKIP TAKE
			IEnumerable<string> skipTakeQuery = distQuery
				.Skip(3).Take(3);
			//foreach (var i in skipTakeQuery)
			//	Console.WriteLine(i);

			Console.WriteLine(" ");

			IEnumerable<string> displayQuery = distQuery
				.TakeWhile(p => p.Contains("Panel"));
			//foreach (var i in displayQuery)
			//	Console.WriteLine(i);

			Console.WriteLine("");
			#endregion

			Console.WriteLine(" -----------------Channing---------------------");
			#region Channing
			IEnumerable<string> chainQuery = customers
				.Where(c => c.State == "OR")
				.OrderBy(c => c.Price)
				.Select(c => c.Last);
			//foreach (string c in chainQuery)
			//{
			//	Console.WriteLine("{0}", c);
			//}
			Console.WriteLine("");
			#endregion

			Console.WriteLine(" -----------------LINQ XML---------------------");
			#region XML
			//XDocument document = new XDocument
			//(
			//    new XDeclaration("1.0", "utf-8", "yes"),
			//    new XComment("Customer List xml"),

			//    new XElement("Customers",
			//	  from c in customers
			//	  //where c.State == "OR"
			//	  select new XElement("Customer", new XAttribute("ID", c.First),
			//		new XElement("First", c.First),
			//		new XElement("Last", c.Last),
			//		new XElement("State", c.State)
			//		))
			//);

			//document.Save("Customers.xml");


			//IEnumerable<Customer> xmlQuery2 = XDocument.Load("Customers.xml").Element("Customers")
			//	.Descendants("Customer")
			//	.Select(x => new Customer
			//	{
			//		State = x.Element("State").Value,
			//		First = x.Element("First").Value,
			//		Last = x.Element("Last").Value
			//	});
			//foreach (var c in xmlQuery2)
			//	Console.WriteLine(c.First);
			#endregion
			Console.ReadLine();
		}
	}
}
