using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestPatterns.Contracts;

namespace TestPatterns.Factory
{
    public class ProductManagerFactory
    {
		public IProductManager GetProductManager(int categoryId)
		{
			IProductManager value = null;

			switch (categoryId)
			{
				case 1:
					value = new LowProductManager();
					break;
				case 2:
					value = new MediumProductManager();
					break;
				case 3:
					value = new HighTaxProductManager();
					break;
				default:
					break;
			}
			return value;
		}
	}
}
