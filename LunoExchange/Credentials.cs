using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LunoExchange
{
    public class Credentials
    {
        public string ApiKey {get; private set;}
        public string ApiSecret {get; private set; }

        public Credentials(string apiKey, string apiSecret)
        {
            ApiKey = apiKey;
            ApiSecret = apiSecret;
        }
    }
}
