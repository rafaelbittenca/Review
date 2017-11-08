using System;
using System.Threading;

namespace EventsExamples
{
	public class VideoEventArgs : EventArgs
	{
		public Video Video { get; set; }
	}

	public class VideoEncoder
	{
		// 1- Define a delegate
		//public delegate void VideoEncodeEventHandler(object source, EventArgs args);

		// 2- Define an event based on that delegate
		//public event VideoEncodeEventHandler VideoEncoded;
		public EventHandler<VideoEventArgs> VideoEncoded;

		public void Encode(Video video)
		{
			Console.WriteLine("Encoding " + video.Title + "...");
			Thread.Sleep(3000);


			// 3- Raise the event
			OnVideoEncoded(video);
		}

		protected virtual void OnVideoEncoded(Video video)
		{
			if (VideoEncoded != null)
				//VideoEncoded(this, EventArgs.Empty);
				VideoEncoded(this, new VideoEventArgs() { Video = video });
		}
	}
}
