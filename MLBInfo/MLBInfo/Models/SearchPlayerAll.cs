using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace MLBPlayersApp.Models
{
    public class SearchPlayerAll
    {
        [JsonProperty("copyRight")]
        public string CopyRight { get; set; }

        [JsonProperty("queryResults")]
        public QueryResults QueryResults { get; set; }
    }
}
