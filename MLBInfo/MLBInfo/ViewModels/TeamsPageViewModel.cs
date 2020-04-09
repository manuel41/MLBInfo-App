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

        public Team teamSelected;

        
        public string SecondEntry { get; set; }
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

        Seasson seassonSelected;
        public Seasson SeassonSelected
        {
            get {
                return seassonSelected;
            
            }
            set 
            {

                seassonSelected = value;
                if (SeassonSelected != null)  GetTeamInformationCommand.Execute(); WSeasson = "La temporada seleccionada: " + seassonSelected.Year;                
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

