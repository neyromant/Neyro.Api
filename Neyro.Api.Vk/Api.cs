using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;

namespace Neyro.Vk
{
    public class Api
    {
        public const string Version = "5.30";

        /// <summary>
        /// Получение пользователей по идентификатору
        /// </summary>
        /// <param name="ids">Id пользователей</param>
        /// <param name="fields">Список нужных полей</param>
        /// <param name="nameCase">Падеж для имен</param>
        /// <returns>Список пользователей</returns>
        public static async Task<IEnumerable<User>> GetUsers(IEnumerable<int> ids, UserFields fields, UserNameCases nameCase = UserNameCases.Nom)
        {
            var answer = await QueryAsync("users.get", new { user_ids = string.Join(",", ids), fields = fields.ToString(), name_case = nameCase.AsString() });
            return PrepareAnswerObject<IEnumerable<User>>(answer);
        }

        /// <summary>
        /// Получение пользователя по идентификатору
        /// </summary>
        /// <param name="id">Id пользователя</param>
        /// <param name="fields">Список нужных полей</param>
        /// <param name="nameCase">Падеж для имен</param>
        /// <returns>Пользователь</returns>
        public static async Task<User> GetUser(int id, UserFields fields, UserNameCases nameCase = UserNameCases.Nom)
        {
            var answer = await QueryAsync("users.get", new { user_ids = id, fields = fields.ToString(), name_case = nameCase.AsString() });
            return PrepareAnswerObject<IEnumerable<User>>(answer).FirstOrDefault();
        }

        /// <summary>
        /// Осуществляет поиск изображений по местоположению или описанию.
        /// </summary>
        /// <param name="q">строка поискового запроса, например, "Nature".</param>
        /// <param name="lat">географическая широта отметки, заданная в градусах (от -90 до 90). </param>
        /// <param name="lon">географическая долгота отметки, заданная в градусах (от -180 до 180). </param>
        /// <param name="startTime">время не раньше которого должны были быть загружены найденные фотографии. </param>
        /// <param name="endTime">время не позже которого должны были быть загружены найденные фотографии. </param>
        /// <param name="radius">радиус поиска в метрах</param>
        /// <param name="offset">смещение относительно первой найденной фотографии для выборки определенного подмножества. </param>
        /// <param name="count">количество возвращаемых фотографий. максимальное значение 1000</param>
        /// <param name="isSortByLikes">сортировать по количеству отметок «Мне нравится», иначе сортировать по дате добавления фотографии.</param>
        /// <returns>Список найденных фотографий</returns>
        public static async Task<ItemsList<Photo>> SearchPhotos(string lat, string lon, DateTime startTime, DateTime endTime, int radius = 10, int offset = 0, int count = 100, string q = null, bool isSortByLikes = false)
        {
            if (count > 1000) throw new ArgumentException("count must be <= 1000");
            var answer = await QueryAsync("photos.search", new { q, lat, @long = lon, start_time = startTime.ToUnixTimestamp(), end_time = endTime.ToUnixTimestamp(), sort = isSortByLikes ? 1 : 0, offset, count, radius });
            return PrepareAnswerObject<ItemsList<Photo>>(answer);
        }

        private static T PrepareAnswerObject<T>(string answerString)
        {
            IDictionary<string, JToken> o = JObject.Parse(answerString);
            if (o.ContainsKey("response")) return o["response"].ToObject<T>();
            if (o.ContainsKey("error")) throw new ApiException(o["error"].ToObject<ApiError>());
            throw new NotSupportedException(answerString);
        }

        private static Task<string> QueryAsync(string method, object args)
        {
            var url = new Uri(string.Concat("https://api.vk.com/method/", method, "?v=", Version, "&lang=ru&", string.Join("&", args.GetType().GetProperties().Select(p => string.Concat(p.Name, "=", p.GetValue(args, null))))));
            using (var wc = new WebClient { Encoding = Encoding.UTF8 })
            {
                return wc.DownloadStringTaskAsync(url);
            }
        }
    }
}
