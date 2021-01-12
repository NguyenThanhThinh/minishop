using Microsoft.AspNetCore.Hosting;

[assembly: HostingStartup(typeof(minishop.Areas.Identity.IdentityHostingStartup))]
namespace minishop.Areas.Identity
{

	public class IdentityHostingStartup : IHostingStartup
	{
		public void Configure(IWebHostBuilder builder)
		{
			builder.ConfigureServices((context, services) =>
			{
			});
		}
	}
}

