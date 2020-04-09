using MLBApp;
using MLBInfo;
using MLBInfo.ViewModels;
using MLBPlayersApp.Services;
using MLBTeamsApp.Models;
using Prism.Commands;
using Prism.Navigation;
using Prism.Services;
using System;
using Prism.Navigation.TabbedPages;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Essentials;
using Xamarin.Forms;
using MLBInfo.Models;

namespace MLBTeamsApp.ViewModels
{
    public class TeamsPageViewModel : BaseViewModel, INotifyPropertyChanged
    {
        public ObservableCollection<Team> Teams { get; set; }

        public IList<Seasson> SeassonsFromViewModelCollector { get; set; }

        SeassonData SeassonD { get; set; }


        public event PropertyChangedEventHandler PropertyChanged;

        public string Entry { get; set; }

        //public Team teamSelected;

        private Team oldTeam;
        
        public string SecondEntry { get; set; }
        public string SearchEntry { get; set; }
        public DelegateCommand GetTeamInformationCommand { get; set; }
        public DelegateCommand NavigateToTeamRoster { get; set; }
        //public Team TeamSelected
        //{

        //    get
        //    {
        //        return teamSelected;
        //    }


        //    set
        //    {
        //        teamSelected = value;

        //        if (teamSelected != null) NavigateToTeamRoster.Execute();   
        //    }

        //}

        Seasson seassonSelected;
        public Seasson SeassonSelected
        {
            get {
                return seassonSelected;
            
            }
            set 
            {

                seassonSelected = value;
                if (SeassonSelected != null)  GetTeamInformationCommand.Execute(); WSeasson = $"Selected Season: {seassonSelected.Year}";                
            }

        }
        public string wSeasson;
        public string WSeasson {

            get {

                return wSeasson;
            }
            set {


              if(wSeasson != value)  wSeasson = value;
            
            }
        
        
        }
        public TeamsPageViewModel(INavigationService navigationService, IApiService apiService, PageDialogService pagedialogservice, SeassonData seassonData) : base(navigationService, apiService, pagedialogservice, seassonData)
        {
            
            SeassonsFromViewModelCollector = seassonData.Seassons;
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
                    Teams = new ObservableCollection<Team>(await ApiService.GetTeamsList(SeassonSelected.Year));
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
                nav.Add("TeamID", oldTeam.TeamId);
                await NavigationService.NavigateAsync(NavConstants.TeamRoster, nav);
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"API EXCEPTION {ex}");
            }

        }

        public void HideOrShowTeamInfo(Team team)
        {
            if (oldTeam == team)
            {
                team.IsVisible = !team.IsVisible;
                UpdateTeamsList(team);
            }
            else
            {
                if (oldTeam != null)
                {
                    oldTeam.IsVisible = false;
                    UpdateTeamsList(oldTeam);
                }
                team.IsVisible = true;
                UpdateTeamsList(team);

            }
            oldTeam = team;
        }

        private void UpdateTeamsList(Team team)
        {
            int index = Teams.IndexOf(team);
            Teams.Remove(team);
            Teams.Insert(index, team);
        }



    }
}

