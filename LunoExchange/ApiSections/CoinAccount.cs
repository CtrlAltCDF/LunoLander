using System;
using System.Net.Http;
using System.Threading.Tasks;
using System.Collections.Generic;
using LunoExchange.Types;
using System.Net.Http.Headers;
using System.Text.Json;

namespace LunoExchange.ApiSections
{
    public class CoinAccount
    {
        public Credentials Credentials;
        private HttpClient Client;

        public CoinAccount(Credentials credentials, HttpClient client)
        {
            Credentials = credentials;
            Client = client;
        }

         //client = new HttpClient();

        public async Task<List<XResponse>> GetAllPairPrices()
        {
            Client.DefaultRequestHeaders.Accept.Clear();
            Client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));
            Client.DefaultRequestHeaders.Add("User-Agent", ".Net Trader");

            var streamTask = Client.GetStreamAsync("https://api.github.com/orgs/dotnet/repos");
            var res = await JsonSerializer.DeserializeAsync<List<XResponse>>(await streamTask);

            return res;

        }
    }
}
