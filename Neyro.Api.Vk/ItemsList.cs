using System.Collections.Generic;
using Newtonsoft.Json;

namespace Neyro.Vk
{
    public class ItemsList<T>
    {
        [JsonProperty("count")]
        public int Count { get; set; }
        [JsonProperty("items")]
        public IEnumerable<T> Items { get; set; }
    }
}
