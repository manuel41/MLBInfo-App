using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace MLBInfo.Models
{  
        public class Row
        {

            [JsonProperty("name_first_last")]
            public string name_first_last { get; set; }

            [JsonProperty("weight")]
            public string weight { get; set; }

            [JsonProperty("primary_position")]
            public string primary_position { get; set; }

            [JsonProperty("birth_date")]
            public DateTime birth_date { get; set; }

            [JsonProperty("throws")]
            public string throws { get; set; }

            [JsonProperty("stat_years")]
            public string stat_years { get; set; }

            [JsonProperty("height_inches")]
            public string height_inches { get; set; }

            [JsonProperty("name_sort")]
            public string name_sort { get; set; }

            [JsonProperty("status_short")]
            public string status_short { get; set; }

            [JsonProperty("jersey_number")]
            public string jersey_number { get; set; }

            [JsonProperty("player_first_last_html")]
            public string player_first_last_html { get; set; }

            [JsonProperty("bats")]
            public string bats { get; set; }

            [JsonProperty("primary_position_cd")]
            public string primary_position_cd { get; set; }

            [JsonProperty("position_desig")]
            public string position_desig { get; set; }

            [JsonProperty("forty_man_sw")]
            public string forty_man_sw { get; set; }

            [JsonProperty("player_html")]
            public string player_html { get; set; }

            [JsonProperty("height_feet")]
            public string height_feet { get; set; }

            [JsonProperty("player_id")]
            public string player_id { get; set; }

            [JsonProperty("name_last_first")]
            public string name_last_first { get; set; }

            [JsonProperty("current_sw")]
            public string current_sw { get; set; }

            [JsonProperty("roster_years")]
            public string roster_years { get; set; }

            [JsonProperty("team_id")]
            public string team_id { get; set; }

            [JsonProperty("active_sw")]
            public string active_sw { get; set; }
        }

        public class RowQueryResults
        {

            [JsonProperty("created")]
            public DateTime created { get; set; }

            [JsonProperty("totalSize")]
            public string totalSize { get; set; }

            [JsonProperty("row")]
            public IList<Row> row { get; set; }
        }

        public class RowRosterTeamAlltime
        {

            [JsonProperty("copyRight")]
            public string copyRight { get; set; }

            [JsonProperty("queryResults")]
            public RowQueryResults queryResults { get; set; }
        }

        public class RowExample
        {

            [JsonProperty("roster_team_alltime")]
            public RowRosterTeamAlltime roster_team_alltime { get; set; }
        }
    }

