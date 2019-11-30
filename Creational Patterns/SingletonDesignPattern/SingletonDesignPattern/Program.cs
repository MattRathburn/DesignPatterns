using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using SingletonDesignPattern.Data;
using SingletonDesignPattern.Models;

namespace SingletonDesignPattern
{
  public class Program
  {
    public static void Main(string[] args)
    {
      //var db = SingletonDataContainer.Instance;
      //var db2 = SingletonDataContainer.Instance;
      //var db3 = SingletonDataContainer.Instance;
      //var db4 = SingletonDataContainer.Instance;

      var host = CreateWebHostBuilder(args).Build();

      using (var scope = host.Services.CreateScope())
      {
        var services = scope.ServiceProvider;

        try
        {
          var context = services.GetRequiredService<AppDbContext>();
          DbInitializer.Initialize(context);
        }
        catch(Exception ex)
        {
          var logger = services.GetRequiredService<ILogger<Program>>();
          logger.LogError(ex, "An error occurred creating the DB.");
        }
      }

      host.Run();
    }

    public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
        WebHost.CreateDefaultBuilder(args)
            .UseStartup<Startup>();
  }
}
