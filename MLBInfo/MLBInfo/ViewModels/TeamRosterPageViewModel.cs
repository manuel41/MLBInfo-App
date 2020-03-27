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

            GetTeamInformationCommand = new DelegateCommand(async () =>
            {
                await GetRosterData();
            });

        }

        public event PropertyChangedEventHandler PropertyChanged;

        public async Task GetRosterData() {

            if (await this.HasInternet())
            {
                Rows = new ObservableCollection<Row>(await ApiService.GetRowData(Start_Season, End_Season, Team_ID));
            }
        
        
        }

        public void Initialize(INavigationParameters parameters)
        {
            if (parameters.ContainsKey("StarSeason"))
            {
                Start_Season = parameters["Name"].ToString();
            }


            if (parameters.ContainsKey("EndSeason"))
            {
                End_Season = parameters["LastName"].ToString();
            }

            if (parameters.ContainsKey("TeamID"))
            {
                Team_ID = parameters["LastName"].ToString();
            }
        }
    }
}
