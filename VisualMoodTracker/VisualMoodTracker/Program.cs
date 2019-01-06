using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.Configuration;

namespace WebApplicationNETCore
{
    public class Program
    {
        private static string url;

        public static void Main(string[] args)
        {
            var config = new ConfigurationBuilder().AddEnvironmentVariables("").Build();
            url = config["ASPNETCORE_URLS"] ?? "http://*:8080";
            BuildWebHost(args).Run();
        }

        public static IWebHost BuildWebHost(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>()
                .UseUrls(url)
                .Build();
    }
}
