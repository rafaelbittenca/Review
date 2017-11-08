using System;
using System.IO;
using System.Net;
using System.Threading.Tasks;

namespace AsyncAwait
{
	class Program
	{
		static void Main(string[] args)
		{
			GetUrl();
			Console.ReadLine();
		}

		public async static Task GetUrl()
		{
			var html = await GetHtmlAsync("https://docs.microsoft.com/en-us/dotnet/csharp/whats-new/csharp-6#exception-filters");
			Console.WriteLine(html.Substring(1, 50));
		}

		public async static Task<string> GetHtmlAsync(string url)
		{
			var webClient = new WebClient();
			System.Threading.Thread.Sleep(3000);
			return await webClient.DownloadStringTaskAsync(url);
		}

		public static string GetHtml(string url)
		{
			var webClient = new WebClient();
			System.Threading.Thread.Sleep(3000);
			return webClient.DownloadString(url);
		}

		public async static Task DownLoadHtmlAsync(string url)
		{
			try
			{
				var webCliente = new WebClient();
				var html = await webCliente.DownloadDataTaskAsync(url);

				System.Threading.Thread.Sleep(8000);

				using (var streamWriter = new StreamWriter(@"C:\Users\rafae\OneDrive\CA\Job Hunt\AplicacoesRafael\Codes\Review\Review\AsyncAwait\test.html"))
				{
					await streamWriter.WriteAsync(System.Text.Encoding.UTF8.GetString(html));
				}

			}
			catch (System.Exception ex)
			{

				System.Console.WriteLine("Some error ocurrer (" + ex.Message + ")");
			}

		}

		public static void DownLoadHtml(string url)
		{
			var webCliente = new WebClient();
			var html = webCliente.DownloadData(url);

			System.Threading.Thread.Sleep(3000);

			using (var streamWriter = new StreamWriter(@"C:\Users\rafae\OneDrive\CA\Job Hunt\AplicacoesRafael\Codes\Review\Review\AsyncAwait\test.html"))
			{
				streamWriter.Write(System.Text.Encoding.UTF8.GetString(html));
			}
		}
	}
}
