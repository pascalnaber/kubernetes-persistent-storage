using System;
using System.IO;
using System.Threading;

namespace PascalNaber.K8s.StorageDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = "/storage/log.txt";

            while (true)
            {
                string now = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                File.AppendAllLines(path, new[] { now });
                Console.WriteLine(now);
                Thread.Sleep(5000);
            }
        }
    }
}
