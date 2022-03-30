using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Threading.Tasks;

namespace Service
{
	class Program
	{
		static async Task Main(string[] args)
		{
			var builder = new HostBuilder()
				.ConfigureAppConfiguration(confBuilder => 
				{
					confBuilder.AddJsonFile("config.json");
					confBuilder.AddCommandLine(args);
				})
				.ConfigureLogging((configLogging) =>
				{
					configLogging.AddConsole();
					configLogging.AddDebug();
				})
				.ConfigureServices((services) =>
				{
					
				});


			await builder.RunConsoleAsync();
		}
	}
}
