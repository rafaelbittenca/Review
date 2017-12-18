using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestPatterns.Models
{
    public class Product
    {
		[Required]
		public int Id { get; set; }

		[Required]
		public string Name { get; set; }

		[Required]
		public string Description { get; set; }

		public decimal Bonus { get; set; }
		public decimal Tax { get; set; }

		public decimal Internal { get; set; }
		public decimal Import { get; set; }
		public decimal Manufactory { get; set; }

		[Required]
		public int CategoryId { get; set; }
		public ProductCategory Category { get; set; }
	}
}
