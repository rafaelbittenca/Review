using System;
//Mechanism for comunication between objects

namespace EventsExamples
{
	class Program
	{
		static void Main(string[] args)
		{
			var video = new Video() { Title = "Video01" };
			var videoEncoder = new VideoEncoder(); //Publisher
			var emailService = new EmailService(); //Subscriber
			var messageService = new MessageService();

			videoEncoder.VideoEncoded += emailService.OnVideoEncoded;
			videoEncoder.VideoEncoded += messageService.OnVideoEncoded;


			videoEncoder.Encode(video);		   

			Console.ReadLine();
		}
	}
}
