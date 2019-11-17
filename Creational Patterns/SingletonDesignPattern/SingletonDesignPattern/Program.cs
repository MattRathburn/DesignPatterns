using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

namespace SingletonDesignPattern
{
  public class Program
  {
    public static void Main(string[] args)
    {
      var db = SingletonDataContainer.Instance;
      var db2 = SingletonDataContainer.Instance;
      var db3 = SingletonDataContainer.Instance;
      var db4 = SingletonDataContainer.Instance;

      CreateWebHostBuilder(args).Build().Run();
    }

    public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
        WebHost.CreateDefaultBuilder(args)
            .UseStartup<Startup>();
  }
}
