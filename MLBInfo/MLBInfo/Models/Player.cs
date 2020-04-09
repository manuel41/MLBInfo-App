using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace MLBPlayersApp.Models
{
    public class Player
    {

        [JsonProperty("position")]
        public string Position { get; set; }

        [JsonProperty("birth_country")]
        public string BirthCountry { get; set; }

        [JsonProperty("weight")]
        public string Weight { get; set; }

        [JsonProperty("birth_state")]
        public string BirthState { get; set; }

        [JsonProperty("name_display_first_last")]
        public string NameDisplayFirstLast { get; set; }

        [JsonProperty("college")]
        public string College { get; set; }

        [JsonProperty("height_inches")]
        public string HeightInches { get; set; }

        [JsonProperty("name_display_roster")]
        public string NameDisplayRoster { get; set; }

        [JsonProperty("sport_code")]
        public string SportCode { get; set; }

        [JsonProperty("bats")]
        public string Bats { get; set; }

        [JsonProperty("name_first")]
        public string NameFirst { get; set; }

        [JsonProperty("team_code")]
        public string TeamCode { get; set; }

        [JsonProperty("birth_city")]
        public string BirthCity { get; set; }

        [JsonProperty("height_feet")]
        public string HeightFeet { get; set; }

        [JsonProperty("pro_debut_date")]
        public DateTime ProDebutDate { get; set; }

        [JsonProperty("team_full")]
        public string TeamFull { get; set; }

        [JsonProperty("team_abbrev")]
        public string TeamAbbrev { get; set; }

        [JsonProperty("birth_date")]
        public DateTime BirthDate { get; set; }

        [JsonProperty("throws")]
        public string Throws { get; set; }

        [JsonProperty("league")]
        public string League { get; set; }

        [JsonProperty("name_display_last_first")]
        public string NameDisplayLastFirst { get; set; }

        [JsonProperty("position_id")]
        public string PositionId { get; set; }

        [JsonProperty("high_school")]
        public string HighSchool { get; set; }

        [JsonProperty("name_use")]
        public string NameUse { get; set; }

        [JsonProperty("player_id")]
        public string PlayerId { get; set; }

        [JsonProperty("name_last")]
        public string NameLast { get; set; }

        [JsonProperty("team_id")]
        public string TeamId { get; set; }

        [JsonProperty("service_years")]
        public string ServiceYears { get; set; }

        [JsonProperty("active_sw")]
        public string ActiveSw { get; set; }

        [JsonIgnore]
        public string PlayerPicture { get; set; }
    }
}
