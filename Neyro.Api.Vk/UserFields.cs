using System.Collections.Generic;

namespace Neyro.Vk
{
    public class UserFields
    {
        private bool all;

        public bool Verified { get; set; }
        public bool Sex { get; set; }
        public bool BDate { get; set; }
        public bool City { get; set; }
        public bool Country { get; set; }
        public bool Photo50 { get; set; }
        public bool Photo100 { get; set; }
        public bool Photo200Orig { get; set; }
        public bool Photo200 { get; set; }
        public bool Photo400Orig { get; set; }
        public bool PhotoMax { get; set; }
        public bool PhotoMaxOrig { get; set; }
        public bool PhotoId { get; set; }
        public bool Online { get; set; }
        public bool OnlineMobile { get; set; }
        public bool Domain { get; set; }
        public bool HasMobile { get; set; }
        public bool Contacts { get; set; }
        public bool Connections { get; set; }
        public bool Site { get; set; }
        public bool Education { get; set; }
        public bool Universities { get; set; }
        public bool Schools { get; set; }
        public bool CanPost { get; set; }
        public bool CanSeeAllPosts { get; set; }
        public bool CanSeeAudio { get; set; }
        public bool CanWritePrivateMessage { get; set; }
        public bool Status { get; set; }
        public bool LastSeen { get; set; }
        //public bool CommonCount { get; set; }
        public bool Relation { get; set; }
        public bool Relatives { get; set; }
        public bool Counters { get; set; }
        public bool ScreenName { get; set; }
        public bool MaidenName { get; set; }
        public bool TimeZone { get; set; }
        public bool Occupation { get; set; }
        public bool Activities { get; set; }
        public bool Interests { get; set; }
        public bool Music { get; set; }
        public bool Movies { get; set; }
        public bool Tv { get; set; }
        public bool Books { get; set; }
        public bool Games { get; set; }
        public bool About { get; set; }
        public bool Quotes { get; set; }
        public bool Personal { get; set; }
        public bool FriendsStatus { get; set; }

        public static UserFields All
        {
            get { return new UserFields(true); }
        }

        public UserFields(bool isAll = false)
        {
            this.all = isAll;
        }

        public override string ToString()
        {
            var res = new List<string>();
            if (this.all || this.Verified) res.Add("verified");
            if (this.all || this.Sex) res.Add("sex");
            if (this.all || this.BDate) res.Add("bdate");
            if (this.all || this.City) res.Add("city");
            if (this.all || this.Country) res.Add("country");
            if (this.all || this.Photo50) res.Add("photo_50");
            if (this.all || this.Photo100) res.Add("photo_100");
            if (this.all || this.Photo200Orig) res.Add("photo_200_orig");
            if (this.all || this.Photo200) res.Add("photo_200");
            if (this.all || this.Photo400Orig) res.Add("photo_400_orig");
            if (this.all || this.PhotoMax) res.Add("photo_max");
            if (this.all || this.PhotoMaxOrig) res.Add("photo_max_orig");
            if (this.all || this.PhotoId) res.Add("photo_id");
            if (this.all || this.Online) res.Add("online");
            if (this.all || this.OnlineMobile) res.Add("online_mobile");
            if (this.all || this.Domain) res.Add("domain");
            if (this.all || this.HasMobile) res.Add("has_mobile");
            if (this.all || this.Contacts) res.Add("contacts");
            if (this.all || this.Connections) res.Add("connections");
            if (this.all || this.Site) res.Add("site");
            if (this.all || this.Education) res.Add("education");
            if (this.all || this.Universities) res.Add("universities");
            if (this.all || this.Schools) res.Add("schools");
            if (this.all || this.CanPost) res.Add("can_post");
            if (this.all || this.CanSeeAllPosts) res.Add("can_see_all_posts");
            if (this.all || this.CanSeeAudio) res.Add("can_see_audio");
            if (this.all || this.CanWritePrivateMessage) res.Add("can_write_private_message");
            if (this.all || this.Status) res.Add("status");
            if (this.all || this.LastSeen) res.Add("last_seen");
            //if (this.all || this.CommonCount) res.Add("common_count");
            if (this.all || this.Relation) res.Add("relation");
            if (this.all || this.Relatives) res.Add("relatives");
            if (this.all || this.Counters) res.Add("counters");
            if (this.all || this.ScreenName) res.Add("screen_name");
            if (this.all || this.MaidenName) res.Add("maiden_name");
            if (this.all || this.TimeZone) res.Add("timezone");
            if (this.all || this.Occupation) res.Add("occupation");
            if (this.all || this.Activities) res.Add("activities");
            if (this.all || this.Interests) res.Add("interests");
            if (this.all || this.Music) res.Add("music");
            if (this.all || this.Movies) res.Add("movies");
            if (this.all || this.Tv) res.Add("tv");
            if (this.all || this.Books) res.Add("books");
            if (this.all || this.Games) res.Add("games");
            if (this.all || this.About) res.Add("about");
            if (this.all || this.Quotes) res.Add("quotes");
            if (this.all || this.Personal) res.Add("personal");
            if (this.all || this.FriendsStatus) res.Add("friends_status");

            return string.Join(",", res);
        }
    }
}
