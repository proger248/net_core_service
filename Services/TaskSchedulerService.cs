using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Service.Services
{
	public class TaskSchedulerService : IHostedService, IDisposable
	{
		private Timer timer;

		public TaskSchedulerService(IServiceProvider services)
		{

		}

		public Task StartAsync(CancellationToken cancellationToken)
		{
			timer = new Timer(
				(e) => ProcessTask(),
				null,
				TimeSpan.Zero,
				TimeSpan.FromSeconds(10));

			return Task.CompletedTask;
		}

		private void ProcessTask()
		{
			throw new NotImplementedException();
		}

		public Task StopAsync(CancellationToken cancellationToken)
		{
			throw new NotImplementedException();
		}

		public void Dispose()
		{
			throw new NotImplementedException();
		}
	}
}
