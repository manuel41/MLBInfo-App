using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace MLBPlayersApp.Models
{
    public class SearchQuery
    {
        [JsonProperty("search_player_all")]
        public SearchPlayerAll SearchPlayerAll { get; set; }
    }
}
