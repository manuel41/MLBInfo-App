using MLBInfo.Models;
using MLBPlayersApp.Models;
using MLBTeamsApp.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;

namespace MLBPlayersApp.Services
{
    public interface IApiService
    {
        Task<IList<Team>> GetTeamsList(string seasonType, string season);
        Task<QueryResults> GetPlayersList(string search, string active);

        Task<PlayerData> GetPlayerData(string id);
        Task<IList<Row>> GetRowData(string startSeason, string endSeason, string teamId);
    }
}
