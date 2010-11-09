using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MongoDB.Driver;

namespace MvcMusicStore.Utility
{
    public class Movie : IMongoEntity
    {
        public string Name
        {
            get { return InternalDocument["Name"].ToString(); }
            set { InternalDocument["Name"] = value; }
        }

        public int ProductionYear
        {
            get { return (int)InternalDocument["Year"]; }
            set { InternalDocument["Year"] = value; }
        }

        public Dictionary<int, string> Actors
        {
            get { return JsonConvert.DeserializeObject<Dictionary<int, string>>(InternalDocument["Actors"].ToString()); }
            set { InternalDocument["Actors"] = value; }
        }

        public Document InternalDocument { get; set; }
    }
}