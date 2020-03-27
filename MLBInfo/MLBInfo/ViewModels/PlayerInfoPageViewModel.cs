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
        public PlayerData Player { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;

        public DelegateCommand ViewTeamRosterCommand { get; set; }

        public PlayerInfoPageViewModel(INavigationService navigationService, IApiService apiService, PageDialogService pagedialogservice, INavigationParameters navigationParameter) : base(navigationService, apiService, pagedialogservice, navigationParameter)
        {
            //ViewTeamRosterCommand = new DelegateCommand(async () =>
            //{
            //    //if (!string.IsNullOrEmpty(Player.TeamId)) await GetPlayerData(SearchEntry);
            //});
        }

        public async void Initialize(INavigationParameters parameters)
        {
            if (parameters.ContainsKey("Id")) Player = await ApiService.GetPlayerData(parameters["Id"].ToString());
        }
    }
}
