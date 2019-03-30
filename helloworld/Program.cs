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

            Thread.Sleep(3000);
            Console.WriteLine("Download Complete");

        }
        static async void Download()
        {
            await Network.Download();
            Console.WriteLine("Download Complete");
        }
        class Network
        {
            static ArrayList WebPageContents = new ArrayList();
            public static async Task Download()
            {
                HttpClient client = new HttpClient();
                var data = await client.GetStringAsync("http://torontopubliclibrary.com");
                // Console.WriteLine(data);
                foreach (var i in data)
                {
                    WebPageContents.Add(i);
                }
            }
        }
    }
}
