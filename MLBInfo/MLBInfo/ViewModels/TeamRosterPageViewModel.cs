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
        public ObservableCollection<Row> Rows { get; set; }
        public string Start_Season { get; set; }
        public string End_Season { get; set; }
        public string Team_ID { get; set; }

        public DelegateCommand GetTeamInformationCommand { get; set; }
        public TeamRosterPageViewModel(INavigationService navigationService, IApiService apiService, PageDialogService pagedialogservice) :base(navigationService, apiService, pagedialogservice)
        {

        }

        public event PropertyChangedEventHandler PropertyChanged;

  

        public async void Initialize(INavigationParameters parameters)
        {
            if (parameters.ContainsKey("StarSeason"))
            {
                Start_Season = parameters["StarSeason"].ToString();
            }


            if (parameters.ContainsKey("EndSeason"))
            {
                End_Season = parameters["EndSeason"].ToString();
            }

            if (parameters.ContainsKey("TeamID"))
            {
                Team_ID = parameters["TeamID"].ToString();
            }
            
            if (await this.HasInternet())
            {
                Rows = new ObservableCollection<Row>(await ApiService.GetRowData(Start_Season, End_Season, Team_ID));
            }

        }
    }
}
