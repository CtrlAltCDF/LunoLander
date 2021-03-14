using System;
using System.Net.Http;

namespace LunoExchange.ApiSections
{
    public class Api
    {
        // vars for api sections here
        public CoinAccount CoinAccount;
        public Api(Config config, HttpClient client)
        {
            // init api sections here
            CoinAccount = new CoinAccount(config, client);
        }
    }
}
