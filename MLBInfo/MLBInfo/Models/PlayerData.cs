using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace MLBInfo.Models
{
    public class PlayerData: INotifyPropertyChanged
    {
        [JsonProperty("birth_country")]
        public string BirthCountry { get; set; }

        [JsonProperty("name_prefix")]
        public string NamePrefix { get; set; }

        [JsonProperty("name_display_first_last")]
        public string NameDisplayFirstLast { get; set; }

        [JsonProperty("college")]
        public string College { get; set; }

        [JsonProperty("height_inches")]
        public string HeightInches { get; set; }

        [JsonProperty("death_country")]
        public string DeathCountry { get; set; }

        [JsonProperty("age")]
        public string Age { get; set; }

        [JsonProperty("name_display_first_last_html")]
        public string NameDisplayFirstLastHtml { get; set; }

        [JsonProperty("gender")]
        public string Gender { get; set; }

        [JsonProperty("height_feet")]
        public string HeightFeet { get; set; }

        [JsonProperty("pro_debut_date")]
        public DateTime ProDebutDate { get; set; }

        [JsonProperty("death_date")]
        public string DeathDate { get; set; }

        [JsonProperty("primary_position")]
        public string PrimaryPosition { get; set; }

        [JsonProperty("birth_date")]
        public DateTime BirthDate { get; set; }

        [JsonProperty("team_abbrev")]
        public string TeamAbbrev { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("name_display_last_first_html")]
        public string NameDisplayLastFirstHtml { get; set; }

        [JsonProperty("throws")]
        public string Throws { get; set; }

        [JsonProperty("death_city")]
        public string DeathCity { get; set; }

        [JsonProperty("primary_position_txt")]
        public string PrimaryPositionTxt { get; set; }

        [JsonProperty("high_school")]
        public string HighSchool { get; set; }

        [JsonProperty("name_display_roster_html")]
        public string NameDisplayRosterHtml { get; set; }

        [JsonProperty("name_use")]
        public string NameUse { get; set; }

        [JsonProperty("player_id")]
        public string PlayerId { get; set; }

        [JsonProperty("status_date")]
        public DateTime StatusDate { get; set; }

        [JsonProperty("primary_stat_type")]
        public string PrimaryStatType { get; set; }

        [JsonProperty("team_id")]
        public string TeamId { get; set; }

        [JsonProperty("active_sw")]
        public string ActiveSw { get; set; }

        [JsonProperty("primary_sport_code")]
        public string PrimarySportCode { get; set; }

        [JsonProperty("birth_state")]
        public string BirthState { get; set; }

        [JsonProperty("weight")]
        public string Weight { get; set; }

        [JsonProperty("name_middle")]
        public string NameMiddle { get; set; }

        [JsonProperty("name_display_roster")]
        public string NameDisplayRoster { get; set; }

        [JsonProperty("end_date")]
        public string EndDate { get; set; }

        [JsonProperty("jersey_number")]
        public string JerseyNumber { get; set; }

        [JsonProperty("death_state")]
        public string DeathState { get; set; }

        [JsonProperty("name_first")]
        public string NameFirst { get; set; }

        [JsonProperty("bats")]
        public string Bats { get; set; }

        [JsonProperty("team_code")]
        public string TeamCode { get; set; }

        [JsonProperty("birth_city")]
        public string BirthCity { get; set; }

        [JsonProperty("name_nick")]
        public string NameNick { get; set; }

        [JsonProperty("status_code")]
        public string StatusCode { get; set; }

        [JsonProperty("name_matrilineal")]
        public string NameMatrilineal { get; set; }

        [JsonProperty("team_name")]
        public string TeamName { get; set; }

        [JsonProperty("name_display_last_first")]
        public string NameDisplayLastFirst { get; set; }

        [JsonProperty("twitter_id")]
        public string TwitterId { get; set; }

        [JsonProperty("name_title")]
        public string NameTitle { get; set; }

        [JsonProperty("file_code")]
        public string FileCode { get; set; }

        [JsonProperty("name_last")]
        public string NameLast { get; set; }

        [JsonProperty("start_date")]
        public DateTime StartDate { get; set; }

        [JsonProperty("name_full")]
        public string NameFull { get; set; }

        [JsonIgnore]
        public string PlayerPicture { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
