using System;
using System.Collections.Generic;
using System.Linq;

namespace EmployeeTree
{
	class Program
	{
		static void Main(string[] args)
		{
			var root = new Employee()
			{
				Id = 15,
				Name = "President",
				employees = new List<Employee>()
				{
					new Employee() {

						Id = 23, ManagerId = 15, Name = "Director23",
						employees = new List<Employee>()
						{
							new Employee() {
								Id = 21, ManagerId = 23, Name = "Manager21",
								employees = new List<Employee>()
								{
									new Employee() { Id = 31, ManagerId=21, Name = "Employee31" },
									new Employee() { Id = 41, ManagerId=21, Name = "Employee41" },
									new Employee() { Id = 51, ManagerId=21, Name = "Employee51" }
								}
							},

							new Employee() {
								Id = 22, ManagerId = 23, Name = "Manager22",
								employees = new List<Employee>()
								{
									new Employee() { Id = 32, ManagerId=22, Name = "Employee32" },
									new Employee() { Id = 42, ManagerId=22, Name = "Employee42" },
									new Employee() { Id = 52, ManagerId=22, Name = "Employee52" }
								}
							}
						}
					},

					new Employee() {

						Id = 25, ManagerId = 15, Name = "Director25",
						employees = new List<Employee>()
						{
							new Employee() {
								Id = 51, ManagerId = 25, Name = "Manager51",
								employees = new List<Employee>()
								{
									new Employee() { Id = 61, ManagerId=51, Name = "Employee61" },
									new Employee() { Id = 71, ManagerId=51, Name = "Employee71" },
									new Employee() { Id = 81, ManagerId=51, Name = "Employee81" }
								}
							},

							new Employee() {
								Id = 62, ManagerId = 25, Name = "Manager62",
								employees = new List<Employee>()
								{
									new Employee() { Id = 72, ManagerId=62, Name = "Employee72" },
									new Employee() { Id = 82, ManagerId=62, Name = "Employee82" }
								}
							}
						}
					}

				}
			};

			//Solucao01
			//var emp = FindById(root, 81);
			//var manager = emp.ManagerId.HasValue ? FindById(root, emp.ManagerId.Value) : null;


			//Solucao02
			//var id = 81;
			//var dict = EmployeesToDictionary(root);
			//var employee = dict[id];
			//var manager = dict[employee.ManagerId.Value];


			////Solucao03
			//var employee = new Employee();
			//var manager = new Employee();
			//FindById(root, 82, out employee, out manager);

			//var id = 82;
			//var dict = EmployeesToDictionary(root);
			//var employee = dict[id];
			//var manager = dict[employee.ManagerId.Value];


			//int[] myIntArray = { 0, 10, 2, 30, 14, 5, 110, 11, 33 };
			//var x = Foo(myIntArray, 10, 0, 8);
			
		}


		public static int Foo(int[] A, int searchValue, int low, int high)
		{
			//if (?? < ??)
			if (high < low)
			{
				Console.WriteLine("Not Found");
				return 0;
			}

			int mid = low + ((high - low) / 2);

			if (A[mid] > searchValue)
				//return Foo(A, searchValue, ??, ??);
				return Foo(A, searchValue, mid, high);
			else if (A[mid] < searchValue)
				//return Foo(A, searchValue, ??, ??);
				return Foo(A, searchValue, low, mid);
			else
				return mid;
		}

		public static void FindById(Employee root, int id, out Employee employee, out Employee manager)
		{
			employee = manager = null;
			// todo stack
			var stack = new Stack<Employee>();
			stack.Push(root);
			// all managers seens
			var managers = new List<Employee>();
			while (stack.Count > 0)
			{
				var e = stack.Pop();
				if (e.Id == id) // if found
				{
					employee = e;
					manager = managers.FirstOrDefault(m => m.Id == e.ManagerId);
					return;
				}
				else if (e.employees != null)
				{
					// add only managers with employee
					managers.Add(e);
					foreach (var ep in e.employees)
					{
						stack.Push(ep);
					}
				}
			}
		}

		public static IDictionary<int, Employee> EmployeesToDictionary(Employee employees)
		{
			var dictionary = new Dictionary<int, Employee>();
			EmployeesToDictionary(employees, dictionary);
			return dictionary;
		}

		private static void EmployeesToDictionary(Employee employees, IDictionary<int, Employee> dictionary)
		{
			if (employees == null) return;
			dictionary.Add(employees.Id, employees);
			if (employees.employees == null) return;
			foreach (var sub in employees.employees)
			{
				EmployeesToDictionary(sub);
			}
		}


		//public static Employee FindById(Employee root, int id)
		//{
		//	if (root.Id == id)
		//	{
		//		return root;
		//	}
		//	else if (root.employees != null)
		//	{
		//		foreach (var e in root.employees)
		//		{
		//			var pe = FindById(e, id);
		//			if (pe != null)
		//			{
		//				return pe;
		//			}
		//		}
		//	}
		//	return null;
		//}

	}
}
