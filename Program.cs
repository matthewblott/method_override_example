using System;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;

namespace method_override_example
{
  public class Program
  {
    public static void Main(string[] args) =>
      WebHost.CreateDefaultBuilder(args).UseStartup<Startup>().Build().Run();

  }

}