using MLBApp;
using MLBInfo.Models;
using MLBPlayersApp.Services;
using Prism.Commands;
using Prism.Navigation;
using Prism.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace MLBInfo.ViewModels
{
    public class PlayerInfoPageViewModel: BaseViewModel, INotifyPropertyChanged, IInitialize
    {
        public PlayerData Player { get; set; } = new PlayerData();
        public const string TwitterUrl = "https://twitter.com/";

        public event PropertyChangedEventHandler PropertyChanged;
        public DelegateCommand ViewTeamRosterCommand { get; set; }
        public DelegateCommand OpenTwitterProfileCommand { get; set; }
        public PlayerInfoPageViewModel(INavigationService navigationService, IApiService apiService, PageDialogService pagedialogservice, SeassonData seassonData) : base(navigationService, apiService, pagedialogservice, seassonData)
        {
            ViewTeamRosterCommand = new DelegateCommand(async () =>
            {
                if (!string.IsNullOrEmpty(Player.TeamId)) await GoToTeamRosterPage();
            });
            OpenTwitterProfileCommand = new DelegateCommand(async() =>
            {
                if(await this.HasInternet())
                {
                    if (!string.IsNullOrEmpty(Player.TwitterId))
                    {
                        try
                        {
                            await Browser.OpenAsync(new Uri($"{TwitterUrl}{Player.TwitterId.Replace("@", "")}"), BrowserLaunchMode.SystemPreferred);
                        }
                        catch (Exception)
                        {
                            await pagedialogservice.DisplayAlertAsync("Alert", "Twitter profile does not exist", "OK");
                        }
                    }
                    else
                    {
                        await pagedialogservice.DisplayAlertAsync("Alert", "Twitter profile does not exist", "OK");
                    }
                }
            });
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
            if (parameters.ContainsKey("Picture")) this.Player.PlayerPicture = $"{parameters["Picture"]}";
        }
        public async Task GoToTeamRosterPage()
        {

            try
            {
                var nav = new NavigationParameters();
                nav.Add("TeamID", this.Player.TeamId);
                await NavigationService.NavigateAsync(NavConstants.TeamRoster, nav);
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"API EXCEPTION {ex}");
            }

        }
    }
}
