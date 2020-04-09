using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace MLBTeamsApp.Models
{
    public class Team : INotifyPropertyChanged
    {

        [JsonProperty("phone_number")]
        public string PhoneNumber { get; set; }

        [JsonProperty("venue_name")]
        public string VenueName { get; set; }

        [JsonProperty("franchise_code")]
        public string FranchiseCode { get; set; }

        [JsonProperty("all_star_sw")]
        public string AllStarSw { get; set; }

        [JsonProperty("sport_code")]
        public string SportCode { get; set; }

        [JsonProperty("address_city")]
        public string AddressCity { get; set; }

        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("name_display_full")]
        public string NameDisplayFull { get; set; }

        [JsonProperty("spring_league_abbrev")]
        public string SpringLeagueAbbrev { get; set; }

        [JsonProperty("time_zone_alt")]
        public string TimeZoneAlt { get; set; }

        [JsonProperty("sport_id")]
        public string SportId { get; set; }

        [JsonProperty("venue_id")]
        public string VenueId { get; set; }

        [JsonProperty("mlb_org_id")]
        public string MlbOrgId { get; set; }

        [JsonProperty("time_zone_generic")]
        public string TimeZoneGeneric { get; set; }

        [JsonProperty("mlb_org")]
        public string MlbOrg { get; set; }

        [JsonProperty("last_year_of_play")]
        public string LastYearOfPlay { get; set; }

        [JsonProperty("league_full")]
        public string LeagueFull { get; set; }

        [JsonProperty("home_opener_time")]
        public string HomeOpenerTime { get; set; }

        [JsonProperty("address_province")]
        public string AddressProvince { get; set; }

        [JsonProperty("league_id")]
        public string LeagueId { get; set; }

        [JsonProperty("name_abbrev")]
        public string NameAbbrev { get; set; }

        [JsonProperty("bis_team_code")]
        public string BisTeamCode { get; set; }

        [JsonProperty("league")]
        public string League { get; set; }

        [JsonProperty("spring_league")]
        public string SpringLeague { get; set; }

        [JsonProperty("base_url")]
        public string BaseUrl { get; set; }

        [JsonProperty("address_zip")]
        public string AddressZip { get; set; }

        [JsonProperty("sport_code_display")]
        public string SportCodeDisplay { get; set; }

        [JsonProperty("mlb_org_short")]
        public string MlbOrgShort { get; set; }

        [JsonProperty("time_zone")]
        public string TimeZone { get; set; }

        [JsonProperty("address_line1")]
        public string AddressLine1 { get; set; }

        [JsonProperty("mlb_org_brief")]
        public string MlbOrgBrief { get; set; }

        [JsonProperty("address_line2")]
        public string AddressLine2 { get; set; }

        [JsonProperty("season")]
        public string Season { get; set; }

        [JsonProperty("address_line3")]
        public string AddressLine3 { get; set; }

        [JsonProperty("division_abbrev")]
        public string DivisionAbbrev { get; set; }

        [JsonProperty("name_display_short")]
        public string NameDisplayShort { get; set; }

        [JsonProperty("team_id")]
        public string TeamId { get; set; }

        [JsonProperty("active_sw")]
        public string ActiveSw { get; set; }

        [JsonProperty("address_intl")]
        public string AddressIntl { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("address_country")]
        public string AddressCountry { get; set; }

        [JsonProperty("mlb_org_abbrev")]
        public string MlbOrgAbbrev { get; set; }

        [JsonProperty("division")]
        public string Division { get; set; }

        [JsonProperty("team_code")]
        public string TeamCode { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("website_url")]
        public string WebsiteUrl { get; set; }

        [JsonProperty("sport_code_name")]
        public string SportCodeName { get; set; }

        [JsonProperty("first_year_of_play")]
        public string FirstYearOfPlay { get; set; }

        [JsonProperty("league_abbrev")]
        public string LeagueAbbrev { get; set; }

        [JsonProperty("name_display_long")]
        public string NameDisplayLong { get; set; }

        [JsonProperty("store_url")]
        public string StoreUrl { get; set; }

        [JsonProperty("time_zone_text")]
        public string TimeZoneText { get; set; }

        [JsonProperty("name_short")]
        public string NameShort { get; set; }

        [JsonProperty("home_opener")]
        public DateTime HomeOpener { get; set; }

        [JsonProperty("address_state")]
        public string AddressState { get; set; }

        [JsonProperty("division_full")]
        public string DivisionFull { get; set; }

        [JsonProperty("time_zone_num")]
        public string TimeZoneNum { get; set; }

        [JsonProperty("spring_league_full")]
        public string SpringLeagueFull { get; set; }

        [JsonProperty("address")]
        public string Address { get; set; }

        [JsonProperty("name_display_brief")]
        public string NameDisplayBrief { get; set; }

        [JsonProperty("file_code")]
        public string FileCode { get; set; }

        [JsonProperty("division_id")]
        public string DivisionId { get; set; }

        [JsonProperty("spring_league_id")]
        public string SpringLeagueId { get; set; }

        [JsonProperty("venue_short")]
        public string VenueShort { get; set; }

        [JsonIgnore]
        public string Logo { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;
    }

    public class QueryResultsTeam
    {

        [JsonProperty("created")]
        public DateTime Created { get; set; }

        [JsonProperty("totalSize")]
        public string TotalSize { get; set; }

        [JsonProperty("row")]
        public IList<Team> Teams { get; set; }
    }

    public class TeamAllSeason
    {

        [JsonProperty("copyRight")]
        public string CopyRight { get; set; }

        [JsonProperty("queryResults")]
        public QueryResultsTeam QueryResults { get; set; }
    }

    public class TeamQuery
    {

        [JsonProperty("team_all_season")]
        public TeamAllSeason TeamAllSeason { get; set; }
    }

}