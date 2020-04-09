using MLBInfo.Models;
using MLBPlayersApp.Services;
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
using Xamarin.Essentials;

namespace MLBInfo.ViewModels
{
    public class UpcomingGamesPageViewModel : BaseViewModel, INotifyPropertyChanged, IInitialize
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public ObservableCollection<Game> UpcomingGamesList { get; set; }
        public DelegateCommand ViewMLBTwitterCommand { get; set; }
        public DelegateCommand ViewGitHubRepoCommand { get; set; }
        public DelegateCommand ViewMLBInstagramCommand { get; set; }

        public const string twitter_url = "https://twitter.com/MLB";
        public const string github_repo = "https://github.com/manuel41/MLBInfo-App";
        public const string insta_url = "https://www.instagram.com/mlb/";

        public UpcomingGamesPageViewModel(INavigationService navigationService, IApiService apiService, PageDialogService pagedialogservice, SeassonData seassonData) : base(navigationService, apiService, pagedialogservice, seassonData)
        {
            ViewMLBTwitterCommand = new DelegateCommand(async () =>
            {
                if (await this.HasInternet())
                {
                    try
                    {
                        await Browser.OpenAsync(new Uri($"{twitter_url}"), BrowserLaunchMode.SystemPreferred);
                    }
                    catch (Exception)
                    {
                        await pagedialogservice.DisplayAlertAsync("Alert", "Twitter profile not available", "OK");
                    }
                }
            });
            ViewGitHubRepoCommand = new DelegateCommand(async () =>
            {
                if (await this.HasInternet())
                {
                    try
                    {
                        await Browser.OpenAsync(new Uri($"{github_repo}"), BrowserLaunchMode.SystemPreferred);
                    }
                    catch (Exception)
                    {
                        await pagedialogservice.DisplayAlertAsync("Alert", "Could not open repository", "OK");
                    }
                }
            });
            ViewMLBInstagramCommand = new DelegateCommand(async () =>
            {
                if (await this.HasInternet())
                {
                    try
                    {
                        await Browser.OpenAsync(new Uri($"{insta_url}"), BrowserLaunchMode.SystemPreferred);
                    }
                    catch (Exception)
                    {
                        await pagedialogservice.DisplayAlertAsync("Alert", "Instagram profile not available", "OK");
                    }
                }

            });
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
