using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Serilog;

namespace HotelListings
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Log.Logger = new LoggerConfiguration()
                .WriteTo.File(path: "c:\\HotelListing\\Logging\\log.txt",
                outputTemplate: "{Timestamp:yyyy-mm-dd HH:mm:ss.fff zzz}[{Level:u3}]{Message:lj}{NewLine}{Exception}",
                rollingInterval: RollingInterval.Day,
                restrictedToMinimumLevel: Serilog.Events.LogEventLevel.Information).CreateLogger();
            try
            {
                Log.Information("Hey application is going to start.");
                CreateHostBuilder(args).Build().Run();
            }
            catch(Exception ex)
            {
                Log.Fatal(ex, "Application failed to start");
            }
            finally
            {
                Log.CloseAndFlush();
            }
            
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
            .UseSerilog()
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
