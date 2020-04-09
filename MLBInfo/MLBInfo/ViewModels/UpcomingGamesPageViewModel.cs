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
    public class UpcomingGamesPageViewModel : BaseViewModel, INotifyPropertyChanged, IInitialize
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public ObservableCollection<Game> UpcomingGamesList { get; set; }

        public UpcomingGamesPageViewModel(INavigationService navigationService, IApiService apiService, PageDialogService pagedialogservice, SeassonData seassonData) : base(navigationService, apiService, pagedialogservice, seassonData)
        {
            
        }

        public async Task GetFutureGames()
        {
            if(await this.HasInternet())
            {
                try
                {
                    var results = await ApiService.GetUpcomingGames();
                    UpcomingGamesList = new ObservableCollection<Game>(results as List<Game>);
                }
                catch(Exception ex)
                {
                    Debug.WriteLine($"API EXCEPTION {ex}");
                }
            }
        }

        public async void Initialize(INavigationParameters parameters)
        {
            await GetFutureGames();
        }
    }
}
