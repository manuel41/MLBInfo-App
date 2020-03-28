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
        public ObservableCollection<TeamRoster> TeamRosters { get; set; }
        public string Start_Season { get; set; }
        public string End_Season { get; set; }
        public string Team_ID { get; set; }

        public DelegateCommand GetTeamInformationCommand { get; set; }

        public DelegateCommand PopPage { get; set; }
        public TeamRosterPageViewModel(INavigationService navigationService, IApiService apiService, PageDialogService pagedialogservice) :base(navigationService, apiService, pagedialogservice)
        {

        }

        public event PropertyChangedEventHandler PropertyChanged;

  

        public async void Initialize(INavigationParameters parameters)
        {
            if (parameters.ContainsKey("StarSeason"))
            {
                Start_Season = $"{parameters["StarSeason"]}";
            }


            if (parameters.ContainsKey("EndSeason"))
            {
                End_Season = $"{parameters["EndSeason"]}";
            }

            if (parameters.ContainsKey("TeamID"))
            {
                Team_ID = $"{parameters["TeamID"]}";
            }
            
            if (await this.HasInternet())
            {
                TeamRosters = new ObservableCollection<TeamRoster>(await ApiService.GetRowData(Start_Season, End_Season, Team_ID));
            }

        }
    }
}
