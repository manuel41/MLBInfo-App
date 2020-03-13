using MLBApp;
using MLBPlayersApp.Models;
using MLBTeamsApp.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace MLBPlayersApp.Services
{
    public class ApiService :Config, IApiService
    {
        public async Task<IList<Team>> GetTeamsList(string SeassonType, string Seasson)
        {
            HttpClient httpClient = new HttpClient();

            var result = await httpClient.GetStringAsync($"{url}all_star_sw='{SeassonType}'&sort_order='name_asc'&season={Seasson}");
            var data = JsonConvert.DeserializeObject<TeamQuery>(result);
            return data.TeamAllSeason.QueryResults.Teams;

        }

        public async Task<QueryResults> GetPlayersList(string search, string active)
        {
            
            search.Replace(" ", "_");
            search.ToLower();
            HttpClient httpClient = new HttpClient();
            var result = await httpClient.GetStringAsync($"{uri}.search_player_all.bam?sport_code='mlb'&active_sw='{active}'&name_part='{search}%25'");

            return JsonConvert.DeserializeObject<SearchQuery>(result).SearchPlayerAll.QueryResults;
        }

    }
}
