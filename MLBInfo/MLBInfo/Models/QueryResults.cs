using MLBInfo.Models;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Text;

namespace MLBPlayersApp.Models
{
    public class QueryResults
    {
        [JsonIgnore]
        public List<Player> PlayersList
        {
            get
            {
                if (this.SearchResult is JArray list) return list.ToObject<List<Player>>();
                else if (this.SearchResult is JObject obj) return new List<Player>() { obj.ToObject<Player>() };
                return null;
            }
        }

        [JsonIgnore]
        public PlayerData PlayerData
        {
            get
            {
                if (this.SearchResult is JObject obj) return obj.ToObject<PlayerData>();
                return null;
            }
        }

        [JsonProperty("created")]
        public DateTime Created { get; set; }

        [JsonProperty("totalSize")]
        public string TotalSize { get; set; }

        [JsonProperty("row")]
        public Object SearchResult { get; set; }
    }
}
