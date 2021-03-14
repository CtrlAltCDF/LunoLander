using System;
using System.Net.Http;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Net.Http.Headers;
using System.Text.Json;
using LunoExchange.Types;
using Newtonsoft.Json;

namespace LunoExchange.ApiSections
{
    public class CoinAccount
    {
        public Config Config;
        private HttpClient Client;

        public CoinAccount(Config config, HttpClient client)
        {
            Config = config;
            Client = client;
        }

        public async Task<CoinAccountCreateResponse> CreateAccount(string currency, string accountName)
        {
            var postContent = new FormUrlEncodedContent(new[]
            {
                new KeyValuePair<string, string>("currency", currency),
                new KeyValuePair<string, string>("name", accountName)
            });

            var postResponse = await Client.PostAsync(Config.ReturnUrl("/accounts"), postContent).Result.Content.ReadAsStringAsync();

            return JsonConvert.DeserializeObject<CoinAccountCreateResponse>(postResponse);
        }
    }
}
