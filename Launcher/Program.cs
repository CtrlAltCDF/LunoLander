using System;
using LunoExchange;

namespace Launcher
{
    class Program
    {
        static void Main(string[] args)
        {
            var config = new Config("x", "y");
            Console.WriteLine(config.ReturnUrl("/test/123/sdfsdf"));
        }
    }
}
