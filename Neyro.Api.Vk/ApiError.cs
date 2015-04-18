using Newtonsoft.Json;

namespace Neyro.Vk
{
    public class ApiError
    {
        [JsonProperty("error_code")]
        public int Code { get; set; }
        [JsonProperty("error_msg")]
        public string Message { get; set; }
    }
}
