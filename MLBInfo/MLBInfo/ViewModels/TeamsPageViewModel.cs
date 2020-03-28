using MLBApp;
using MLBInfo;
using MLBInfo.ViewModels;
using MLBPlayersApp.Services;
using MLBTeamsApp.Models;
using Prism.Commands;
using Prism.Navigation;
using Prism.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Essentials;
using Xamarin.Forms;


namespace MLBTeamsApp.ViewModels
{
   public class TeamsPageViewModel : BaseViewModel, INotifyPropertyChanged
    {
        public ObservableCollection<Team> Teams { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;

        public string Entry { get; set; }

        public Team teamSelected;
       
        public string SecondEntry { get; set; }
        public bool IsActiveCheckBox { get; set; }
        public string SearchEntry { get; set; }
        public DelegateCommand GetTeamInformationCommand { get; set; }
        public DelegateCommand NavigateToTeamRoster { get; set; }
        public Team TeamSelected
        {

            get
            {
                return teamSelected;
            }


            set
            {
                teamSelected = value;

                if (teamSelected != null) NavigateToTeamRoster.Execute();
            }

        }

        public TeamsPageViewModel(INavigationService navigationService, IApiService apiService, PageDialogService pagedialogservice) : base(navigationService, apiService, pagedialogservice)
        {
            GetTeamInformationCommand = new DelegateCommand(async() =>
            {
              await GetPlayerData();
            });

            NavigateToTeamRoster = new DelegateCommand(async () =>
            {
                await GoToTeamRosterPage();
            });

        }

        async Task GetPlayerData()
        {
            if (await this.HasInternet())
            {
                try
                {
                    Entry = (IsActiveCheckBox) ? "Y" : "N";
                    Teams = new ObservableCollection<Team>(await ApiService.GetTeamsList(Entry, SecondEntry));
                }
                catch (Exception ex)
                {
                    Debug.WriteLine($"API EXCEPTION {ex}");
                }

            }
        }
       
        async Task GoToTeamRosterPage() {

            try
            {
                var nav = new NavigationParameters();
                nav.Add("StarSeason", TeamSelected.Season);
                int x = Convert.ToInt32(TeamSelected.Season) + 1;
                nav.Add("EndSeason", $"{x}");
                nav.Add("TeamID", TeamSelected.TeamId);
                await NavigationService.NavigateAsync(NavConstants.TeamRoster, nav);
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"API EXCEPTION {ex}");
            }

        }





   }
}

