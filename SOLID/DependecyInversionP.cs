using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace SOLID
{
	//   public class BankAccount
	//   {
	//	public string AccountNumber { get; set; }
	//	public decimal Balance { get; set; }

	//	public void AddFunds(decimal value)
	//	{
	//		Balance += value;
	//	}

	//	public void RemoveFunds(decimal value)
	//	{
	//		Balance -= value;
	//	}
	//}

	//public class TransferManager
	//{
	//	public BankAccount Source { get; set; }
	//	public BankAccount Destination { get; set; }
	//	public decimal Value { get; set; }

	//	public void Transfer()
	//	{
	//		Source.RemoveFunds(Value);
	//		Destination.AddFunds(Value);
	//	}
	//}

	/// <summary>
	/// ** Dependency Inversion Principal **
	/// High level modules should not depend on low level modules,
	/// both should depend on abstractions 
	/// Clients should not be forced to depend upon interfaces they do not use.
	/// DIP removes direct dependencies between classes
	/// Classes become loosely coupled, making it easier to substitute alternative implementations
	/// </summary>

	public interface ITransferSource
	{
		void RemoveFunds(decimal value);
	}

	public interface ITransferDestination
	{
		void AddFunds(decimal value);
	}

	public class BankAccount : ITransferDestination, ITransferSource
	{
		public string AccountNumber { get; set; }
		public decimal Balance { get; set; }

		public void AddFunds(decimal value)
		{
			Balance += value;
		}

		public void RemoveFunds(decimal value)
		{
			Balance -= value;
		}
	}

	public class TransferManager
	{
		public ITransferSource Source { get; set; }
		public ITransferDestination Destination { get; set; }
		public decimal Value { get; set; }

		public void Transfer()
		{
			Source.RemoveFunds(Value);
			Destination.AddFunds(Value);
		}
	}
}
