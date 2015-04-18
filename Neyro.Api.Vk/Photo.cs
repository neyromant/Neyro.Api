using Newtonsoft.Json;

namespace Neyro.Vk
{
    public class Photo
    {
        /// <summary>
        /// идентификатор фотографии
        /// </summary>
        [JsonProperty("id")]
        public int Id { get; set; }
        /// <summary>
        /// идентификатор альбома, в котором находится фотография
        /// </summary>
        [JsonProperty("album_id")]
        public int AlbumId { get; set; }
        /// <summary>
        /// идентификатор владельца фотографии. 
        /// </summary>
        [JsonProperty("owner_id")]
        public int OwnerId { get; set; }
        /// <summary>
        /// идентификатор пользователя, загрузившего фото (если фотография размещена в сообществе). Для фотографий, размещенных от имени сообщества, user_id=100. 
        /// </summary>
        [JsonProperty("user_id")]
        public int UserId { get; set; }
        /// <summary>
        /// url копии фотографии с максимальным размером 75x75px. 
        /// </summary>
        [JsonProperty("photo_75")]
        public string Photo75 { get; set; }
        /// <summary>
        /// url копии фотографии с максимальным размером 130x130px. 
        /// </summary>
        [JsonProperty("photo_130")]
        public string Photo130 { get; set; }
        /// <summary>
        /// url копии фотографии с максимальным размером 604x604px.
        /// </summary>
        [JsonProperty("photo_604")]
        public string Photo604 { get; set; }
        /// <summary>
        /// url копии фотографии с максимальным размером 807x807px. 
        /// </summary>
        [JsonProperty("photo_807")]
        public string Photo807 { get; set; }
        /// <summary>
        /// url копии фотографии с максимальным размером 1280x1024px.
        /// </summary>
        [JsonProperty("photo_1280")]
        public string Photo1280 { get; set; }
        /// <summary>
        /// url копии фотографии с максимальным размером 2560x2048px. 
        /// </summary>
        [JsonProperty("photo_2560")]
        public string Photo2560 { get; set; }
        /// <summary>
        /// ширина оригинала фотографии в пикселах. 
        /// </summary>
        [JsonProperty("width")]
        public int Width { get; set; }
        /// <summary>
        /// высота оригинала фотографии в пикселах. 
        /// </summary>
        [JsonProperty("height")]
        public int Height { get; set; }
        /// <summary>
        /// текст описания фотографии. 
        /// </summary>
        [JsonProperty("text")]
        public string Text { get; set; }
        /// <summary>
        /// дата добавления в формате unixtime. 
        /// </summary>
        [JsonProperty("date")]
        public int UnixDate { get; set; }
    }
}
