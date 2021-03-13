using System;
using System.Net.Http;

namespace LunoExchange.ApiSections
{
    public class Api
    {
        // vars for api sections here
        public CoinAccount CoinAccount;
        public Api(Credentials credentials, HttpClient client)
        {
            // init api sections here
            CoinAccount = new CoinAccount(credentials, client);
        }
    }
}
