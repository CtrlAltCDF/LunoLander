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

        public CoinAccount(Credentials credentials)
        {
            Credentials = credentials;
        }

        private static readonly HttpClient client = new HttpClient();

        public async Task<List<XResponse>> GetAllPairPrices()
        {
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));
            client.DefaultRequestHeaders.Add("User-Agent", ".Net Trader");

            var streamTask = client.GetStreamAsync("https://api.github.com/orgs/dotnet/repos");
            var res = await JsonSerializer.DeserializeAsync<List<XResponse>>(await streamTask);

            return res;

        }
    }
}
