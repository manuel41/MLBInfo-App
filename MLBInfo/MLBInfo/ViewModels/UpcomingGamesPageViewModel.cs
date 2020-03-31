using MLBInfo.Models;
using MLBPlayersApp.Services;
using Prism.Navigation;
using Prism.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using System.Text;
using System.Threading.Tasks;

namespace MLBInfo.ViewModels
{
    public class UpcomingGamesPageViewModel : BaseViewModel, INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public ObservableCollection<Games> UpcomingGamesList { get; set; }

        public UpcomingGamesPageViewModel(INavigationService navigationService, IApiService apiService, PageDialogService pagedialogservice) : base(navigationService, apiService, pagedialogservice)
        {

        }

        public async Task GetFutureGames()
        {
            if(await this.HasInternet())
            {
                try
                {
                    GamesResults results = await ApiService.GetUpcomingGames();
                    UpcomingGamesList = new ObservableCollection<Games>(results.GamesList as List<Games>);
                }
                catch(Exception ex)
                {
                    Debug.WriteLine($"API EXCEPTION {ex}");
                }
            }
        }
    }
}
