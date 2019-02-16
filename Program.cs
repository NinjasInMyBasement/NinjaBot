using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Discord.WebSocket;
using Unity;
using NinjaBot.Storage.Implementations;

namespace NinjaBot
{
    class Program
    {
        static void Main(string[] args)
        {
            Unity.RegisterTypes();
            if (args.Any() && args[0] == "--version") Console.WriteLine("NinjaBOT v0.0.1");
            Console.WriteLine("Hello World!");

            
        }

        private static async Task MyWeirdTask()
        {
            await Task.Delay(1000);
            Console.WriteLine("Here I am!");
        }
    }
}
