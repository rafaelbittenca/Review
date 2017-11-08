using System;
namespace DelegatesExample
{
	public class PhotoProcessor
	{
		//Pointer for a function
		//Object knows how to call a method
		// Use: - An eventing design pattern is used
		//	  - the caller dosen't need to access other properties or methods 
		//        on the object implementing the method

		//public delegate void PhotoFilterHandler(Photo photo);

		//public void Process(string path)
		//public void Process(string path, PhotoFilterHandler filterHandler)
		public void Process(string path, Action<Photo> filterHandler)
		{
			var photo = Photo.Load(path);

			//var filters = new PhotoFilters();
			//filters.ApplyShadow(photo);
			//filters.ApplyContrast(photo);

			filterHandler(photo);

			photo.Save();
		}
	}
}
