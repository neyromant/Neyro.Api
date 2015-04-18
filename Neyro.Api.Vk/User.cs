﻿using Newtonsoft.Json;

namespace Neyro.Vk
{
    public class User
    {
        [JsonProperty("id")]
        public int Id { get; set; }
        [JsonProperty("first_name")]
        public string FirstName { get; set; }
        [JsonProperty("last_name")]
        public string SecondName { get; set; }
        [JsonProperty("deactivated")]
        public bool IsDeactivated { get; set; }
        [JsonProperty("hidden")]
        public bool IsHidden { get; set; }


        [JsonProperty("photo_id")]
        public string PhotoId { get; set; }
        [JsonProperty("verified")]
        public bool? IsVerified { get; set; }
        [JsonProperty("sex")]
        public int Sex { get; set; }
        [JsonProperty("bdate")]
        public string BirthDate { get; set; }
        [JsonProperty("city")]
        public IdNamePair City { get; set; }
        [JsonProperty("country")]
        public IdNamePair Country { get; set; }
        [JsonProperty("home_town")]
        public string HomeTown { get; set; }
        [JsonProperty("photo_50")]
        public string Photo50 { get; set; }
        [JsonProperty("photo_100")]
        public string Photo100 { get; set; }
        [JsonProperty("photo_200_orig")]
        public string Photo200Orig { get; set; }
        [JsonProperty("photo_200")]
        public string Photo200 { get; set; }
        [JsonProperty("photo_400_orig")]
        public string Photo400Orig { get; set; }
        [JsonProperty("photo_max")]
        public string PhotoMax { get; set; }
        [JsonProperty("photo_max_orig")]
        public string PhotoMaxOrig { get; set; }
        [JsonProperty("online")]
        public bool? IsOnline { get; set; }
        [JsonProperty("online_mobile")]
        public bool? IsOnlineMobile { get; set; }
        [JsonProperty("online_app")]
        public int? OnlineAppId { get; set; }
        public bool IsOnlineAny { get { return this.IsOnline == true || this.IsOnlineMobile == true; } }
        [JsonProperty("domain")]
        public string Domain { get; set; }
        [JsonProperty("has_mobile")]
        public bool IsHasMobilePhone { get; set; }
        [JsonProperty("mobile_phone")]
        public string MobilePhone { get; set; }
        [JsonProperty("home_phone")]
        public string HomePhone { get; set; }
        [JsonProperty("site")]
        public string Site { get; set; }
        [JsonProperty("status")]
        public string Status { get; set; }
        /*
         education	информация о высшем учебном заведении пользователя. Возвращаются следующие поля: 
        university — идентификатор университета; 
        положительное число 
        university_name — название университета; 
        строка 
        faculty — идентификатор факультета; 
        положительное число 
        faculty_name — название факультета; 
        строка 
        graduation — год окончания. 
        положительное число 
        
         * universities	список высших учебных заведений, в которых учился текущий пользователь. Возвращается массив universities, содержащий объекты university со следующими полями: 
        id — идентификатор университета; 
        положительное число 
        country — идентификатор страны, в которой расположен университет; 
        положительное число 
        city — идентификатор города, в котором расположен университет; 
        положительное число 
        name — наименование университета; 
        строка 
        faculty — идентификатор факультета; 
        положительное число 
        faculty_name — наименование факультета; 
        строка 
        chair — идентификатор кафедры; 
        положительное число 
        chair_name — наименование кафедры; 
        строка 
        graduation — год окончания обучения. 
        положительное число 
        
         * schools	список школ, в которых учился пользователь. Возвращается массив schools, содержащий объекты school со следующими полями: 
        id — идентификатор школы; 
        положительное число 
        country — идентификатор страны, в которой расположена школа; 
        положительное число 
        city — идентификатор города, в котором расположена школа; 
        положительное число 
        name — наименование школы; 
        строка 
        year_from — год начала обучения; 
        положительное число 
        year_to — год окончания обучения; 
        положительное число 
        year_graduated — год выпуска; 
        положительное число 
        class — буква класса; 
        строка 
        
         * speciality — специализация; 
        строка 
        type — идентификатор типа; 
        положительное число 
        type_str — название типа. 
        строка 
        
       
         * last_seen	время последнего посещения. Возвращается объект last_seen со следующими полями:
        
         * time - время последнего посещения в формате unixtime. 
        положительное число
        
         * platform - тип платформы, через которую был осуществлён последний вход. Подробнее cмотрите на странице Подключение к LongPoll серверу. 
        положительное число 
        
         * followers_count	количество подписчиков пользователя.
        положительное число 
        
         * common_count	количество общих друзей с текущим пользователем.
        положительное число 
        
         * counters	количество различных объектов у пользователя. Может быть использовано только в методе users.get при запросе информации об одном пользователе, с передачей access_token. 
         Возвращается объект, содержащий следующие поля: 
        albums — количество фотоальбомов; 
        положительное число 
        videos — количество видеозаписей; 
        положительное число 
        audios — количество аудиозаписей; 
        положительное число 
        photos — количество фотографий;
        положительное число 
        notes — количество заметок; 
        положительное число 
        friends — количество друзей; 
        положительное число 
        groups — количество сообществ; 
        положительное число 
        online_friends — количество друзей онлайн; 
        положительное число 
        mutual_friends — количество общих друзей; 
        положительное число 
        user_videos — количество видеозаписей с пользователем; 
        положительное число 
        followers — количество подписчиков; 
        положительное число 
        Поля, возвращаемые только для desktop-приложений: 
        user_photos — количество фотографий с пользователем; 
        положительное число 
        subscriptions — количество подписок.
        положительное число
         * 
         * occupation	информация о текущем роде занятия пользователя. Возвращаются следующие поля: 
type — может принимать значения work, school, university; 
строка 
id — идентификатор школы, вуза, группы компании (в которой пользователь работает); 
положительное число 
name — название школы, вуза или места работы; 
строка
         * 
         * nickname	никнейм (отчество) пользователя. 
строка 

         * relatives	список родственников текущего пользователя. Возвращает список объектов, cодержащих поля id, type. (name вместо id в случаях, когда родственник не является пользователем ВКонтакте).
         * 
         * relation	семейное положение пользователя. Возвращаемые значения: 
1 — не женат/не замужем; 
2 — есть друг/есть подруга; 
3 — помолвлен/помолвлена; 
4 — женат/замужем: 
5 — всё сложно; 
6 — в активном поиске; 
7 — влюблён/влюблена; 
0 — не указано. 

положительное число

 Если в семейном положении указан другой пользователь, дополнительно возвращается объект relation_partner, содержащий id и имя этого человека.
         * 
         * personal	информация о полях из раздела «Жизненная позиция». 
political — политические предпочтения:
положительное число 1 — коммунистические; 
2 — социалистические; 
3 — умеренные; 
4 — либеральные; 
5 — консервативные; 
6 — монархические; 
7 — ультраконсервативные; 
8 — индифферентные; 
9 — либертарианские. 
langs — языки.
массив строк 
religion — мировоззрение.
строка 
inspired_by — источники вдохновения.
строка 
people_main — главное в людях:
положительное число 1 — ум и креативность; 
2 — доброта и честность; 
3 — красота и здоровье; 
4 — власть и богатство; 
5 — смелость и упорство; 
6 — юмор и жизнелюбие. 
life_main — главное в жизни:
положительное число 1 — семья и дети; 
2 — карьера и деньги; 
3 — развлечения и отдых; 
4 — наука и исследования; 
5 — совершенствование мира; 
6 — саморазвитие; 
7 — красота и искусстсво; 
8 — слава и влияние; 
smoking — отношение к курению:
положительное число 1 — резко негативное; 
2 — негативное; 
3 — нейтральное; 
4 — компромиссное; 
5 — положительное. 
alcohol — отношение к алкоголю:
положительное число 1 — резко негативное; 
2 — негативное; 
3 — нейтральное; 
4 — компромиссное; 
5 — положительное.
         * 
         * 
         * connections	возвращает данные об указанных в профиле сервисах пользователя, таких как: skype, facebook, twitter, livejournal, instagram. 
exports	внешние сервисы, в которые настроен экспорт из ВК (twitter, facebook, livejournal, instagram). 
wall_comments	доступно ли комментирование стены (1 — доступно, 0 — недоступно).
int(числовое значение) 
activities	деятельность.
строка 
interests	интересы.
строка 
music	любимая музыка.
строка 
movies	любимые фильмы.
строка 
tv	любимые телешоу.
строка 
books	любимые книги.
строка 
games	любимые игры.
строка 
about	«О себе».
строка 
quotes	любимые цитаты.
строка 
can_post	информация о том, разрешено ли оставлять записи на стене у пользователя. Возвращаемые значения: 1 —разрешено, 0 — не разрешено. 
флаг, может принимать значения 1 или 0 
can_see_all_posts	информация о том, разрешено ли видеть чужие записи на стене пользователя. Возвращаемые значения: 1 —разрешено, 0 — не разрешено. 
флаг, может принимать значения 1 или 0 
can_see_audio	информация о том, разрешено ли видеть чужие аудиозаписи на стене пользователя. Возвращаемые значения: 1 —разрешено, 0 — не разрешено. 
флаг, может принимать значения 1 или 0 
can_write_private_message	информация о том, разрешено ли написание личных сообщений данному пользователю. Возвращаемые значения: 1 —разрешено, 0 — не разрешено. 
флаг, может принимать значения 1 или 0 
can_send_friend_request	информация о том, будет ли отправлено уведомление пользователю о заявке в друзья. Возвращаемые значения: 1 — уведомление будет отправлено, 0 — уведомление не будет оптравлено. 
флаг, может принимать значения 1 или 0 
is_favorite	возвращается 1, если пользователь находится в закладках у текущего пользователя.
флаг, может принимать значения 1 или 0 
timezone	временная зона пользователя. Возвращается только при запросе информации о текущем пользователе.
int (числовое значение) 
screen_name	короткое имя (поддомен) страницы пользователя.
строка 
maiden_name	девичья фамилия. 
строка
         * 
         * 
         * crop_photo	возвращает данные о точках, по которым вырезаны профильная и миниатюрная фотографии пользователя. 
photo — объект photo фотографии пользователя из которой вырезается профильная аватарка. 
crop — вырезанная фотография пользователя, поля: x, y, x2, y2, координаты указаны в процентах. 
rect — миниатюрная квадратная фотография, вырезанная из фотографии crop: x, y, x2, y2, координаты также указаны в процентах; объект 
is_friend	1 – пользователь друг, 2 – пользователь не в друзьях. 
friend_status	статус дружбы с пользователем: 
0 – пользователь не является другом, 
1 – отправлена заявка/подписка пользователю, 
2 – имеется входящая заявка/подписка от пользователя, 
3 – пользователь является другом;
         */
    }
}
