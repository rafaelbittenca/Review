using System;

namespace EventsExamples
{

	public class EmailService
	{
		public void OnVideoEncoded(object source, VideoEventArgs  args)
		{
			Console.WriteLine("Sending Email.." + args.Video.Title);
		}
	}
}
