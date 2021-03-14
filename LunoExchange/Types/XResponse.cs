using System;
using System.Text.Json.Serialization;

namespace LunoExchange.Types
{
    public class CoinAccountCreateResponseX
    {
        [JsonPropertyName("id")]
        public int String { get; set; }
        [JsonPropertyName("currency")]
        public string Currency { get; set; }
        [JsonPropertyName("name")]
        public string Name { get; set; }
    }
}
