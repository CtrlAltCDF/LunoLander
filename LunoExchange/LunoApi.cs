using System;
using System.Net.Http;
using System.Net.Http.Headers;
using LunoExchange.ApiSections;


namespace LunoExchange
{
    public class LunoApi
    {
        public Api Api;

        private Credentials Credentials;
        private bool IsInitialized = false;
        private readonly HttpClient Client = new HttpClient();
        private readonly string Url = "https:////api.luno.com//api//1//{0}";

        public LunoApi(Credentials credentials)
        {
            if (!IsInitialized)
            {
                Credentials = credentials;

                // set default client headers
                Client.DefaultRequestHeaders.Accept.Clear();
                Client.DefaultRequestHeaders.Accept.Add(
                    new MediaTypeWithQualityHeaderValue("application/json"));

                Client.DefaultRequestHeaders.Add("User-Agent", "CDF-Luno-Lander");

                // Initialize Api Sections
                Api = new Api(Credentials, Client);
            }
            else
            {
                throw new Exception("This instance has already been initialized");
            }
        }
    }
}
