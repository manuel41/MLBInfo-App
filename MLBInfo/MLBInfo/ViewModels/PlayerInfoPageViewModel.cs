using MLBInfo.Models;
using MLBPlayersApp.Services;
using Prism.Commands;
using Prism.Navigation;
using Prism.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace MLBInfo.ViewModels
{
    public class PlayerInfoPageViewModel: BaseViewModel, INotifyPropertyChanged, IInitialize
    {
        public PlayerData Player { get; set; } = new PlayerData();

        public event PropertyChangedEventHandler PropertyChanged;
        public DelegateCommand ViewTeamRosterCommand { get; set; }
        public PlayerInfoPageViewModel(INavigationService navigationService, IApiService apiService, PageDialogService pagedialogservice) : base(navigationService, apiService, pagedialogservice)
        {
            //ViewTeamRosterCommand = new DelegateCommand(async () =>
            //{
            //    //if (!string.IsNullOrEmpty(Player.TeamId)) await GetPlayerData(SearchEntry);
            //});
        }

        public void Initialize(INavigationParameters parameters)
        {
            if (parameters.ContainsKey("Name")) this.Player.NameDisplayFirstLast = $"{parameters["Name"]}";
            if (parameters.ContainsKey("TeamName")) this.Player.TeamName = $"{parameters["TeamName"]}";
            if (parameters.ContainsKey("PrimaryPosition")) this.Player.PrimaryPosition = $"{parameters["PrimaryPosition"]}";
            if (parameters.ContainsKey("JerseyNumber")) this.Player.JerseyNumber = $"{parameters["JerseyNumber"]}";
            if (parameters.ContainsKey("Weight")) this.Player.Weight = $"{parameters["Weight"]}";
            if (parameters.ContainsKey("Age")) this.Player.Age = $"{parameters["Age"]}";
            if (parameters.ContainsKey("BirthCountry")) this.Player.BirthCountry = $"{parameters["BirthCountry"]}";
            if (parameters.ContainsKey("Status")) this.Player.Status = $"{parameters["Status"]}";
            if (parameters.ContainsKey("TeamId")) this.Player.TeamId = $"{parameters["TeamId"]}";
            if (parameters.ContainsKey("Twitter")) this.Player.TwitterId = $"{parameters["Twitter"]}";
        }
    }
}
