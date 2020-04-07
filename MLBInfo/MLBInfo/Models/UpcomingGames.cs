using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using Xamarin.Forms;

namespace MLBInfo.Models
{
    public class Games: INotifyPropertyChanged
    {

        [JsonProperty("away_team_id")]
        public string AwayTeamId { get; set; }

        [JsonProperty("home_team_short")]
        public string HomeTeamShort { get; set; }

        [JsonProperty("game_time_local")]
        public DateTime GameTimeLocal { get; set; }

        [JsonProperty("game_time_home")]
        public DateTime GameTimeHome { get; set; }

        [JsonProperty("source_id")]
        public string SourceId { get; set; }

        [JsonProperty("home_team_full")]
        public string HomeTeamFull { get; set; }

        [JsonProperty("game_date")]
        public DateTime GameDate { get; set; }

        [JsonProperty("source_type")]
        public string SourceType { get; set; }

        [JsonProperty("foreign_language")]
        public string ForeignLanguage { get; set; }

        [JsonProperty("game_pk")]
        public string GamePk { get; set; }

        [JsonProperty("game_time_away")]
        public DateTime GameTimeAway { get; set; }

        [JsonProperty("game_day")]
        public string GameDay { get; set; }

        [JsonProperty("source_comment")]
        public string SourceComment { get; set; }

        [JsonProperty("source_desc")]
        public string SourceDesc { get; set; }

        [JsonProperty("away_team_abbrev")]
        public string AwayTeamAbbrev { get; set; }

        [JsonProperty("away_team_full")]
        public string AwayTeamFull { get; set; }

        [JsonProperty("game_id")]
        public string GameId { get; set; }

        [JsonProperty("home_team_abbrev")]
        public string HomeTeamAbbrev { get; set; }

        [JsonProperty("home_team_id")]
        public string HomeTeamId { get; set; }

        [JsonProperty("sort_order")]
        public string SortOrder { get; set; }

        [JsonProperty("game_time_et")]
        public DateTime GameTimeEt { get; set; }

        [JsonProperty("away_team_short")]
        public string AwayTeamShort { get; set; }

        [JsonProperty("home_away")]
        public string HomeAway { get; set; }

        [JsonIgnore]
        public string AwayTeamLogo { get; set; }

        [JsonIgnore]
        public string HomeTeamLogo { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;
    }

    public class GamesResults
    {
        [JsonIgnore]
        public List<Games> GamesList
        {
            get
            {
                if (this.SearchResult is JArray list) return list.ToObject<List<Games>>();
                else if (this.SearchResult is JObject obj) return new List<Games>() { obj.ToObject<Games>() };
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

    public class MlbBroadcastInfo
    {

        [JsonProperty("copyRight")]
        public string CopyRight { get; set; }

        [JsonProperty("queryResults")]
        public GamesResults GamesResults { get; set; }
    }

    public class UpcomingGames
    {

        [JsonProperty("mlb_broadcast_info")]
        public MlbBroadcastInfo MlbBroadcastInfo { get; set; }
    }
}
