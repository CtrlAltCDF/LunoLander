using System;
using System.Threading.Tasks;
using LunoRepository;

namespace LunoLander
{
    class Program
    {
        // kt2dhghgqdn3n
        // YkomD6yHeCgAbe8fzbx9XbLXY9CObBgvHzrjNK16XjU
        //static void Main(string[] args)
        //{
        //    Console.WriteLine("Hello World!");
        //}
        static async Task Main(string[] args)
        {
            var lunoRepo = new LunoRepo("kt2dhghgqdn3n", "YkomD6yHeCgAbe8fzbx9XbLXY9CObBgvHzrjNK16XjU");

            foreach (var repo in await lunoRepo.CoinAccount.there())
            {
                Console.WriteLine(repo.Name);
            }

            Console.ReadLine();
        }
    }
}
