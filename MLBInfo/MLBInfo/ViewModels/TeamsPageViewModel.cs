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

        public string SecondEntry { get; set; }
        public bool IsActiveCheckBox { get; set; } = true;
        public string SearchEntry { get; set; }
        public DelegateCommand GetTeamInformationCommand { get; set; }

        public TeamsPageViewModel(INavigationService navigationService, IApiService apiService, PageDialogService pagedialogservice,INavigationParameters navigationParameter) : base(navigationService, apiService, pagedialogservice, navigationParameter)
        {
            GetTeamInformationCommand = new DelegateCommand(async() =>
            {
              await GetPlayerData();
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
                             
   }
}

