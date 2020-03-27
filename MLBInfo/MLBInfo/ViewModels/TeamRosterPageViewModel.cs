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
        public string Start_Seasson { get; set; }
        public string End_Seasson { get; set; }
        public string Team_ID { get; set; }

        public DelegateCommand GetTeamInformationCommand { get; set; }
        public TeamRosterPageViewModel(INavigationService navigationService, IApiService apiService, PageDialogService pagedialogservice) :base(navigationService, apiService, pagedialogservice)
        {

        }

        public event PropertyChangedEventHandler PropertyChanged;

  

        public async void Initialize(INavigationParameters parameters)
        {
            if (parameters.ContainsKey("StarSeasson"))
            {
                Start_Seasson = parameters["Name"].ToString();
            }


            if (parameters.ContainsKey("EndSeasson"))
            {
                End_Seasson = parameters["LastName"].ToString();
            }

            if (parameters.ContainsKey("TeamID"))
            {
                Team_ID = parameters["LastName"].ToString();
            }
            
            if (await this.HasInternet())
            {
                Rows = new ObservableCollection<Row>(await ApiService.GetRowData(Start_Seasson, End_Seasson, Team_ID));
            }

        }
    }
}
