using System;
using System.Collections.Generic;
using System.Linq;

namespace IComparableImp
{
	class Program
	{
		public class Employee : IComparable<Employee>
		{
			public int Id { get; set; }
			public string Name { get; set; }
			public decimal Salary { get; set; }

			public int CompareTo(Employee obj)
			{
				return this.Salary.CompareTo(obj.Salary);
			}

		}

		public class SortEmployeeByName : IComparer<Employee>
		{
			public int Compare(Employee x, Employee y)
			{
				return x.Name.CompareTo(y.Name);
			}
		}

		static void Main(string[] args)
		{
			var emp01 = new Employee() { Id = 10, Name = "Rafael", Salary = 5000 };
			var emp02 = new Employee() { Id = 5, Name = "Maria", Salary = 6000 };
			var emp03 = new Employee() { Id = 8, Name = "Joao", Salary = 3000 };

			List<Employee> eList = new List<Employee>();
			eList.Add(emp01);
			eList.Add(emp02);
			eList.Add(emp03);

			Console.WriteLine("Before Sorting");
			PrintList(eList);

			Console.WriteLine("After Sorting");
			eList.Sort();
			PrintList(eList);
			eList.Reverse();
			PrintList(eList);
			Console.WriteLine("Sorting ByName");
			SortEmployeeByName sortName = new SortEmployeeByName();
			eList.Sort(sortName);
			PrintList(eList);
			Console.WriteLine("Sorting Salary with Delegates");
			eList.Sort((x, y) => x.Salary.CompareTo(y.Salary));
			PrintList(eList);
			Console.WriteLine("Sorting ID with Delegates");
			eList.Sort((x, y) => x.Id.CompareTo(y.Id));
			PrintList(eList);
			Console.WriteLine("Sorting with Linq");
			PrintList(eList.OrderBy(e => e.Salary).ToList());

			Console.ReadLine();
		}

		private static void PrintList(List<Employee> eList)
		{
			foreach (var e in eList)
				Console.WriteLine("{0} - {1} - {2}", e.Id, e.Name, e.Salary);
			Console.WriteLine("---------------------");
		}
	}
}
