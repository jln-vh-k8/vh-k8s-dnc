using System;
using System.Net;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using System.Security.Cryptography.X509Certificates;

namespace com.example.dotnet.webapi
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //CreateWebHostBuilder(args).Build().Run();

            Model.Database db = new  Model.Database();
            var res = db.fillCollection();

            string developmentEnvironment = Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT");
            string developmentOS = Environment.GetEnvironmentVariable("ENVIRONMENT_OS");
            var config = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddEnvironmentVariables()
            .AddJsonFile("certificate.json", optional: true, reloadOnChange: true)
            .AddJsonFile($"certificate.{developmentEnvironment}.json", optional: true, reloadOnChange: true)
            .AddJsonFile($"hosting.{developmentEnvironment}.json", optional: true, reloadOnChange: true)
            .Build();

        var certificateSettings = config.GetSection("certificateSettings");
        string certificateFileName = certificateSettings.GetValue<string>("filename");
        string certificatePassword = certificateSettings.GetValue<string>("password");

        var certificate = new X509Certificate2(certificateFileName, certificatePassword);
        
        var host = new WebHostBuilder()
            .UseKestrel(
                options =>
                {
                    options.AddServerHeader = false;
                    options.Listen(IPAddress.Loopback, 44363, listenOptions =>
                    {
                        listenOptions.UseHttps(certificate);
                    });
                }
            )
            .UseConfiguration(config)
            .UseContentRoot(Directory.GetCurrentDirectory())
            .UseStartup<Startup>()
            //.UseUrls("https://127.0.0.1:44363")
            .Build();

        host.Run();
        }

        
    }
}
