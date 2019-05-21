using ClassLibrary1.First;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            WebSocketServer server = new WebSocketServer();
            server.StartServer();
            Console.ReadKey();
        }
    }
}
