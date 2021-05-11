using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace examProject21
{
    public class Program
    {

        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
            FileReader fr = new FileReader();
            fr.dataReader();


        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });

       
        

    }

    public class FileReader
    {
        public void dataReader() { 
        string text = System.IO.File.ReadAllText(@"C:\Users\Bruger\Desktop\data.csv");

        // Display the file contents to the console. Variable text is a string.

        Console.WriteLine("Contents of WriteText.txt = {0}", text);
        }
    }


}

