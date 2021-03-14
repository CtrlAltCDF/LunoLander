using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using LunoExchange.ApiSections;


namespace LunoExchange
{
    public class Luno
    {
        public Api Api;

        private Config Config;
        private bool IsInitialized = false;
        private readonly HttpClient Client = new HttpClient();

        public Luno(Config config)
        {
            if (!IsInitialized)
            {
                Config = config;

                // set default client headers
                Client.DefaultRequestHeaders.Accept.Clear();
                Client.DefaultRequestHeaders.Accept.Add(
                    new MediaTypeWithQualityHeaderValue("application/json"));

                //Console.WriteLine(string.Format("{0}:{1}", config.ApiKey, config.ApiSecret));

                Console.WriteLine($"{Config.ApiKey}:{Config.ApiSecret}");

                Client.DefaultRequestHeaders.Add("User-Agent", "CDF-Luno-Lander");

                Client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue(
                    "Basic",
                    Convert.ToBase64String(ASCIIEncoding.ASCII.GetBytes($"{Config.ApiKey}:{Config.ApiSecret}"))
                );

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
