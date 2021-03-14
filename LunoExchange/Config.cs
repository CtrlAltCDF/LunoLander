using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LunoExchange
{
    public class Config
    {
        public string ApiKey {get; private set;}
        public string ApiSecret {get; private set; }
        public string Url { get; set; }

        public Config(string apiKey, string apiSecret, string url = "https://api.luno.com/api/1{0}")
        {
            ApiKey = apiKey;
            ApiSecret = apiSecret;
            Url = url;
        }

        public string ReturnUrl(string appendment)
        {
            return string.Format(Url, appendment);
        }
    }
}
