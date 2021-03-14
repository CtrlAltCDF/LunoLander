using System;
using System.Threading.Tasks;
using LunoExchange;

namespace Launcher
{
    class Program
    {
        static async Task Main(string[] args)
        {
            var config = new Config("fr56kzvtr3n8w", "kZzsB-VZDRP3L46go0IbZdg2b7LmgoHgdZvbXDlDsW0");
            var luno = new Luno(config);

            var res = await luno.Api.CoinAccount.CreateAccount("LTC", "testAccount");
        }
    }
}

