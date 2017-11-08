using System;

namespace EventsExamples
{
	public class MessageService
	{
		public void OnVideoEncoded(object source, VideoEventArgs args)
		{
			Console.WriteLine("Sending Message..." + args.Video.Title);
		}
	}
}
