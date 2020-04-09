using System;
using System.Collections.Generic;
using System.Text;

namespace MLBApp
{
    public class Config
    {
      public const string Url = "https://lookup-service-prod.mlb.com/json/named.team_all_season.bam?sport_code='mlb'&all_star_sw='N'";
      public const string Url2 = "https://lookup-service-prod.mlb.com/json/named";
        public const string logos_url = "https://v1.baseball.api-sports.io/teams?country=USA";
        public const string player_image = "https://www.thesportsdb.com/api/v1/json/1/searchplayers.php?p=";
    }
}
