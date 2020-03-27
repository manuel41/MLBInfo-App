using MLBPlayersApp.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace MLBInfo.Models
{
    public class PlayerInfo
    {
        [JsonProperty("copyRight")]
        public string CopyRight { get; set; }

        [JsonProperty("queryResults")]
        public QueryResults QueryResults { get; set; }
    }
    public class PlayerInfoResult
    {

        [JsonProperty("player_info")]
        public PlayerInfo PlayerInfo { get; set; }
    }
}
