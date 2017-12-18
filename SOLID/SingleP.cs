using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID
{
	//	OLD
	//public class Product
	//{
	//	public int StockLevel;

	//	public void CheckStockLevel()
	//	{
	//		using (StockService s = new StockService())
	//		{
	//			StockLevel = s.GetStock();
	//		}
	//	}

	//	public bool StockLow()
	//	{
	//		return StockLevel < 5;
	//	}

	//	public void ShowStockAlert()
	//	{
	//		Console.WriteLine("Stock is low {0}", StockLevel);
	//	}

	//}

	internal class StockService : IDisposable
	{
		public StockService()
		{
			//....
		}

		public void Dispose()
		{
			throw new NotImplementedException();
		}

		internal int GetStock()
		{
			throw new NotImplementedException();
		}
	}

	/// <summary>
	/// ** Single Responsibility **
	/// There should never be more than one reason for a class change
	/// A class should only have one job to perform
	/// Chance of any one class containing bugs is lower, therefore change is less fragile
	/// Classes become smaller and cleaner
	/// Simpler to understand and maintain
	/// </summary>

	public class StockChecker
	{
		public int StockLevel;

		public void CheckStockLevel()
		{
			using (StockService s = new StockService())
			{
				StockLevel = s.GetStock();
			}
		}
	}

	public class StockLevelChecker
	{
		public bool StockLow(StockChecker s)
		{
			return s.StockLevel > 5;
		}
	}

	public class StockAlert
	{
		public void ShowStockAlert(StockChecker s)
		{
			Console.WriteLine("Stock level is {0}", s.StockLevel);
		}
	}
}
