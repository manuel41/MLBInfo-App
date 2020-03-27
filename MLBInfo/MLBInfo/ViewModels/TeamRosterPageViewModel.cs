using MLBPlayersApp.Services;
using Prism.Commands;
using Prism.Navigation;
using Prism.Services;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MLBInfo.ViewModels
{
    public class TeamRosterPageViewModel : BaseViewModel
    {
        public string Start_Seasson { get; set; }
        public string End_Seasson { get; set; }
        public string Team_ID { get; set; }

        public DelegateCommand GetTeamInformationCommand { get; set; }
        public TeamRosterPageViewModel(INavigationService navigationService, IApiService apiService, PageDialogService pagedialogservice, INavigationParameters navigationParameter) :base(navigationService, apiService, pagedialogservice, navigationParameter)
        {

            GetTeamInformationCommand = new DelegateCommand(async () =>
            {
                await GetRosterData();
            });

        }

        async Task GetRosterData() {

            if (await this.HasInternet())
            {

            }
        
        
        }

        public void Initialize(INavigationParameters parameters)
        {
            //if (parameters.ContainsKey("Name"))
            //{
            //    Name = parameters["Name"].ToString();
            //}


            //if (parameters.ContainsKey("LastName"))
            //{
            //    LastName = parameters["LastName"].ToString();
            //}

        }
    }
}
