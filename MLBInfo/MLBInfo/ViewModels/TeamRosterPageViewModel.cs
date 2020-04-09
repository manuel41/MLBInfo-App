using MLBApp;
using MLBInfo.Models;
using MLBPlayersApp.Services;
using Prism.Commands;
using Prism.Navigation;
using Prism.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Text;
using System.Threading.Tasks;

namespace MLBInfo.ViewModels
{
    public class TeamRosterPageViewModel : BaseViewModel, INotifyPropertyChanged, IInitialize
    {
        public ObservableCollection<Row> TeamRoster { get; set; }

        public Row selectedPlayer;

        public Row SelectedPlayer
        {
            get
            {
                return selectedPlayer;
            }
            set
            {
                selectedPlayer = value;
                if (selectedPlayer != null) ViewPlayerInfoCommand.Execute();
                selectedPlayer = null;
            }
        }

        public string Team_ID { get; set; }

        public DelegateCommand GetTeamInformationCommand { get; set; }

        public DelegateCommand PopPage { get; set; }
        public DelegateCommand ViewPlayerInfoCommand { get; set; }
        public TeamRosterPageViewModel(INavigationService navigationService, IApiService apiService, PageDialogService pagedialogservice, SeassonData seassonData) :base(navigationService, apiService, pagedialogservice, seassonData)
        {
            ViewPlayerInfoCommand = new DelegateCommand(async () =>
            {
                await ViewPlayerInfo();
            });
        }

        public event PropertyChangedEventHandler PropertyChanged;

  

        public async void Initialize(INavigationParameters parameters)
        {

            if (parameters.ContainsKey("TeamID"))
            {
                Team_ID = $"{parameters["TeamID"]}";
            }
            
            if (await this.HasInternet())
            {
                TeamRoster = new ObservableCollection<Row>(await ApiService.GetRowData(Team_ID));
            }

        }
        public async Task ViewPlayerInfo()
        {
            if (await this.HasInternet())
            {
                var nav = new NavigationParameters();
                nav.Add("Picture", selectedPlayer.PlayerPicture);
                PlayerData player = await ApiService.GetPlayerData(selectedPlayer.PlayerId);
                nav.Add("Name", player.NameDisplayFirstLast);
                nav.Add("TeamName", player.TeamName);
                nav.Add("PrimaryPosition", player.PrimaryPosition);
                nav.Add("JerseyNumber", player.JerseyNumber);
                nav.Add("Weight", player.Weight);
                nav.Add("Age", player.Age);
                nav.Add("BirthCountry", player.BirthCountry);
                nav.Add("Status", player.Status);
                nav.Add("TeamId", player.TeamId);
                nav.Add("Twitter", player.TwitterId);
                await NavigationService.NavigateAsync(NavConstants.PlayerInfoPage, nav);
            }
        }
    }
}
