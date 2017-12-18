using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestPatterns.Contracts
{
    public class MediumProductManager : IProductManager
	{
		public decimal GetBonus()
		{
			return 2;
		}

		public decimal GetTax()
		{
			return 5;
		}
	}
}
