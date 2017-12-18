using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID
{
	public class Product
	{
		public string Name { get; set; }
	}

	//public class ProductService
	//{
	//	public virtual void Add(Product product)
	//	{
	//		// add implementation
	//	}

	//	public Product Get()
	//	{
	//		Product p = new Product();
	//		// get implementation
	//		return p;
	//	}
	//}

	//public class ReadOnlyProductService : ProductService
	//{
	//	public override void Add(Product product)
	//	{
	//		throw new InvalidOperationException();
	//	}
	//}

	/// <summary>
	/// 
	/// ** Liskov Substitution Principal **
	/// Use Derived classes without knowing it
	/// Subclasses must operate in the same 
	/// manner as their baseclass
	/// 
	/// ** Interface Segregation Principal **
	/// Classes may have interfaces that are not cohesive
	/// Clients should not be forced to depend upon 
	/// interfaces they do not use.
	/// ISP recommends multiple, smaller, cohesive interfaces
	/// Interfaces become tightly focused
	/// Easier to implement
	/// 
	/// </summary>
	/// 
	
	public interface IReadableProductService
	{
		Product Get();
	}

	public interface IWriteableProductService 
	{
		void Add(Product p);
	}

	public class ReadOnlyProductService : IReadableProductService
	{
		public Product Get()
		{
			Product p = new Product();
			// get implementation
			return p;
		}
	}

	public class ReadWriteProductService : IReadableProductService, IWriteableProductService
	{
		public void Add(Product p)
		{
			// add implementatio
		}

		public Product Get()
		{
			Product p = new Product();
			// get implementation
			return p;
		}
	}

}
