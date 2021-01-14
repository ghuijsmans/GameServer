using System;

namespace UnityGameServer
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Server Window";
            Server.Start(50, 26950);
            Console.ReadKey();
        }
    }
}
