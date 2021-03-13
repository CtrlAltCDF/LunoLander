using System;
using System.Threading.Tasks;
using LunoExchange;

namespace LunoLander
{
    class Program
    {
        static async Task Main(string[] args)
        {
            var Luno = new LunoApi("kt2dhghgqdn3n", "YkomD6yHeCgAbe8fzbx9XbLXY9CObBgvHzrjNK16XjU");
            await Luno.Api.CoinAccount.GetAllPairPrices();

            //foreach (var repo in await lunoRepo.CoinAccount.there())
            //{
            //    Console.WriteLine(repo.Name);
            //}

            //Console.ReadLine();
        }
    }
}
