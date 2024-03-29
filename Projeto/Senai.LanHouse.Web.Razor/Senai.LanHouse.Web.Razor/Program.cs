﻿using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;

namespace Senai.LanHouse.Web.Razor
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateWebHostBuilder(args).Build().Run();
        }

        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>();
    }
}
