using System;

namespace DelegatesExample
{
	public class PhotoFilters
	{

		public void ApplyShadow(Photo photo)
		{
			Console.WriteLine("Shadow filter");
		}

		public void ApplyContrast(Photo photo)
		{
			Console.WriteLine("Contrast filter");
		}
	}
}