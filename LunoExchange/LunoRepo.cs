using System;
using LunoExchange.ApiSections;

namespace LunoExchange
{
    public class LunoRepo
    {
        private Credentials Credentials;
        private bool IsInitialized = false;

        // Api Sections
        public CoinAccount CoinAccount;

        public LunoRepo(string apiKey, string apiSecret)
        {
            if (!IsInitialized)
            {
                Credentials = new Credentials(apiKey, apiSecret);

                // Initialize Api Sections
                CoinAccount = new CoinAccount(Credentials);
            }
            else
            {
                throw new Exception("This instance has already been initialized");
            }
        }
    }
}
