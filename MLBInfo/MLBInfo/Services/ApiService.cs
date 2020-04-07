using MLBApp;
using MLBInfo.Models;
using MLBPlayersApp.Models;
using MLBTeamsApp.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Linq;
using Xamarin.Forms;

namespace MLBPlayersApp.Services
{
    public class ApiService:Config, IApiService
    {
        public async Task<IList<Team>> GetTeamsList(string seasonType, string season)
        {
            HttpClient httpClient = new HttpClient();

            var result = await httpClient.GetStringAsync($"{url}all_star_sw='{seasonType}'&sort_order='name_asc'&season={season}");
            var data = JsonConvert.DeserializeObject<TeamQuery>(result);
            return data?.TeamAllSeason?.QueryResults?.Teams;

        }

        public async Task<QueryResults> GetPlayersList(string search, string active)
        {
            search = search.Trim().Replace(" ", "_").ToLower();
            HttpClient httpClient = new HttpClient();
            var result = await httpClient.GetStringAsync($"{uri}.search_player_all.bam?sport_code='mlb'&active_sw='{active}'&name_part='{search}%25'");

            return JsonConvert.DeserializeObject<SearchQuery>(result)?.SearchPlayerAll?.QueryResults;
        }

        public async Task<PlayerData> GetPlayerData(string id)
        {
            HttpClient httpClient = new HttpClient();
            var result = await httpClient.GetStringAsync($"{uri}.player_info.bam?sport_code='mlb'&player_id={id}");

            return JsonConvert.DeserializeObject<PlayerInfoResult>(result)?.PlayerInfo?.QueryResults?.PlayerData;
        }

        public async Task<IList<TeamRoster>> GetRowData(string startSeason, string endSeason, string teamId)
        {
            HttpClient httpClient = new HttpClient();

            var result = await httpClient.GetStringAsync($"{url1}.roster_team_alltime.bam?start_season='{startSeason}'&end_season='{endSeason}'&team_id='{teamId}'");
            var data = JsonConvert.DeserializeObject<TeamRosterExample>(result);
            return data?.TeamRosterRosterTeamAlltime?.TeamRosterQueryResults?.TeamRoster;
        }

        public async Task<GamesResults> GetUpcomingGames()
        {
            string season = DateTime.Now.ToString("yyyy");
            string currentDate = DateTime.Now.ToString("yyyyMMdd");
            string lastDate = DateTime.Now.AddDays(30).ToString("yyyyMMdd");

            HttpClient httpClient = new HttpClient();
            var result = await httpClient.GetStringAsync($"{url1}.mlb_broadcast_info.bam?src_type='TV'&src_comment='National'&tcid=mm_mlb_schedule&sort_by='game_time_et_asc'&start_date='{currentDate}'&end_date='{lastDate}'&season={season}");
            GamesResults gamesResults = JsonConvert.DeserializeObject<UpcomingGames>(result)?.MlbBroadcastInfo?.GamesResults;

            httpClient.DefaultRequestHeaders.Add("x-rapidapi-key", "44a347ecac0e3450b4fc668536b1a191");

            var logos = await httpClient.GetStringAsync(logos_url);
            TeamLogos teamLogos = JsonConvert.DeserializeObject<TeamLogos>(logos);

            foreach (Games game in gamesResults.GamesList)
            {
                string homeTeamName = game.HomeTeamFull.Replace(" ", "");
                var homeTeamLogo = from homeTeam in teamLogos.TeamsList where homeTeamName == homeTeam.TeamName select homeTeam.Logo;
                game.HomeTeamLogo = ImageSource.FromUri(new Uri(homeTeamLogo.First<string>()));
            
                string awayTeamName = game.AwayTeamFull.Replace(" ", "");
                var awayTeamLogo = from awayTeam in teamLogos.TeamsList where awayTeamName == awayTeam.TeamName select awayTeam.Logo;
                game.AwayTeamLogo = ImageSource.FromUri(new Uri(awayTeamLogo.First<string>()));
            }

            return gamesResults;
        }
    }
}
