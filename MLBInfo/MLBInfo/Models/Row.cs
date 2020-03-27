using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace MLBInfo.Models
{
    public class Row : INotifyPropertyChanged
    {

        [JsonProperty("name_first_last")]
        public string NameFirstLast { get; set; }

        [JsonProperty("weight")]
        public string Weight { get; set; }

        [JsonProperty("primary_position")]
        public string PrimaryPosition { get; set; }

        [JsonProperty("birth_date")]
        public DateTime BirthDate { get; set; }

        [JsonProperty("throws")]
        public string Throws { get; set; }

        [JsonProperty("stat_years")]
        public string StatYears { get; set; }

        [JsonProperty("height_inches")]
        public string HeightInches { get; set; }

        [JsonProperty("name_sort")]
        public string NameSort { get; set; }

        [JsonProperty("status_short")]
        public string StatusShort { get; set; }

        [JsonProperty("jersey_number")]
        public string JerseyNumber { get; set; }

        [JsonProperty("player_first_last_html")]
        public string PlayerFirstLastHtml { get; set; }

        [JsonProperty("bats")]
        public string Bats { get; set; }

        [JsonProperty("primary_position_cd")]
        public string PrimaryPositionCd { get; set; }

        [JsonProperty("position_desig")]
        public string PositionDesig { get; set; }

        [JsonProperty("forty_man_sw")]
        public string FortyManSw { get; set; }

        [JsonProperty("player_html")]
        public string PlayerHtml { get; set; }

        [JsonProperty("height_feet")]
        public string HeightFeet { get; set; }

        [JsonProperty("player_id")]
        public string PlayerId { get; set; }

        [JsonProperty("name_last_first")]
        public string NameLastFirst { get; set; }

        [JsonProperty("current_sw")]
        public string CurrentSw { get; set; }

        [JsonProperty("roster_years")]
        public string RosterYears { get; set; }

        [JsonProperty("team_id")]
        public string TeamId { get; set; }

        [JsonProperty("active_sw")]
        public string ActiveSw { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;
    }

    public class RowQueryResults
    {

        [JsonProperty("created")]
        public DateTime Created { get; set; }

        [JsonProperty("totalSize")]
        public string TotalSize { get; set; }

        [JsonProperty("row")]
        public IList<Row> Rows { get; set; }
    }

    public class RowRosterTeamAlltime
    {

        [JsonProperty("copyRight")]
        public string CopyRight { get; set; }

        [JsonProperty("queryResults")]
        public RowQueryResults RowQueryResults { get; set; }
    }

    public class RowExample
    {

        [JsonProperty("roster_team_alltime")]
        public RowRosterTeamAlltime RowRosterTeamAlltime { get; set; }
    }

}

