using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace helloworld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Download the file");
            Download();
            Console.ReadLine();

        }
        static void Download()
        {
            Task.Run(() =>
            {
                Thread.Sleep(3000);
                Console.WriteLine("Download Complete");
            });
        }
    }

}
