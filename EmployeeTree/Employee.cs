using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeTree
{
	public class Employee
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public int? ManagerId { get; set; }
		public List<Employee> employees { get; set; }
	}
}
