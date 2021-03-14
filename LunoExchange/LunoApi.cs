using System;
using System.Net.Http;
using System.Net.Http.Headers;
using LunoExchange.ApiSections;


namespace LunoExchange
{
    public class LunoApi
    {
        public Api Api;

        private Config Config;
        private bool IsInitialized = false;
        private readonly HttpClient Client = new HttpClient();

        public LunoApi(Config config)
        {
            if (!IsInitialized)
            {
                Config = config;

                // set default client headers
                Client.DefaultRequestHeaders.Accept.Clear();
                Client.DefaultRequestHeaders.Accept.Add(
                    new MediaTypeWithQualityHeaderValue("application/json"));

                Client.DefaultRequestHeaders.Add("User-Agent", "CDF-Luno-Lander");

                // Initialize Api Sections
                Api = new Api(config, Client);
            }
            else
            {
                throw new Exception("This instance has already been initialized");
            }
        }
    }
}
