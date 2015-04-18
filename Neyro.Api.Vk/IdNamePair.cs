using Newtonsoft.Json;

namespace Neyro.Vk
{
    public class IdNamePair
    {
        [JsonProperty("id")]
        public int Id { get; set; }
        [JsonProperty("title")]
        public string Name { get; set; }
    }
}
