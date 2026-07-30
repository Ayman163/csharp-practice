using System;

namespace MyFirstApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string rawServerList = " WebServer-01, DatabaseServer , BackupServer ";

            // 1. Segmenting text based on commas into a matrix
            string[] servers = rawServerList.Split(',');

            foreach (string server in servers)
            {
                // 2. Clean the server name of spaces and convert it to capital letters
                string cleanedServer = server.Trim().ToUpper();
                Console.WriteLine($"Server Registered: {cleanedServer}");
            }
         
        }
        
    }
}
