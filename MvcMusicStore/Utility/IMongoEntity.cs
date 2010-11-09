using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MongoDB.Driver;

namespace MvcMusicStore.Utility
{
    public interface IMongoEntity 
    { 
        Document InternalDocument { get; set; } 
    }
}