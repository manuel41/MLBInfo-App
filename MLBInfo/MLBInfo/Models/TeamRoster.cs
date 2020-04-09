using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace MLBInfo.Models
{
    public class Row
    {

        [JsonProperty("position_txt")]
        public string PositionTxt { get; set; }

        [JsonProperty("weight")]
        public string Weight { get; set; }

        [JsonProperty("name_display_first_last")]
        public string NameDisplayFirstLast { get; set; }

        [JsonProperty("college")]
        public string College { get; set; }

        [JsonProperty("height_inches")]
        public string HeightInches { get; set; }

        [JsonProperty("starter_sw")]
        public string StarterSw { get; set; }

        [JsonProperty("jersey_number")]
        public string JerseyNumber { get; set; }

        [JsonProperty("end_date")]
        public string EndDate { get; set; }

        [JsonProperty("name_first")]
        public string NameFirst { get; set; }

        [JsonProperty("bats")]
        public string Bats { get; set; }

        [JsonProperty("team_code")]
        public string TeamCode { get; set; }

        [JsonProperty("height_feet")]
        public string HeightFeet { get; set; }

        [JsonProperty("pro_debut_date")]
        public object ProDebutDate { get; set; }

        [JsonProperty("status_code")]
        public string StatusCode { get; set; }

        [JsonProperty("primary_position")]
        public string PrimaryPosition { get; set; }

        [JsonProperty("birth_date")]
        public DateTime BirthDate { get; set; }

        [JsonProperty("team_abbrev")]
        public string TeamAbbrev { get; set; }

        [JsonProperty("throws")]
        public string Throws { get; set; }

        [JsonProperty("team_name")]
        public string TeamName { get; set; }

        [JsonProperty("name_display_last_first")]
        public string NameDisplayLastFirst { get; set; }

        [JsonProperty("name_use")]
        public string NameUse { get; set; }

        [JsonProperty("player_id")]
        public string PlayerId { get; set; }

        [JsonProperty("name_last")]
        public string NameLast { get; set; }

        [JsonProperty("team_id")]
        public string TeamId { get; set; }

        [JsonProperty("start_date")]
        public DateTime StartDate { get; set; }

        [JsonProperty("name_full")]
        public string NameFull { get; set; }

        [JsonIgnore]
        public string PlayerPicture { get; set; }

        [JsonIgnore]
        public string AboutPlayer { get; set; }
    }

    public class RosterQueryResults
    {

        [JsonProperty("created")]
        public DateTime Created { get; set; }

        [JsonProperty("totalSize")]
        public string TotalSize { get; set; }

        [JsonProperty("row")]
        public IList<Row> Row { get; set; }
    }

    public class Roster40
    {

        [JsonProperty("copyRight")]
        public string CopyRight { get; set; }

        [JsonProperty("queryResults")]
        public RosterQueryResults QueryResults { get; set; }
    }

    public class TeamRoster
    {

        [JsonProperty("roster_40")]
        public Roster40 Roster40 { get; set; }
    }



}

