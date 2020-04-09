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

        public const string MLBTwitter = "https://twitter.com/MLB";
        public const string Github_Repo = "https://github.com/manuel41/MLBInfo-App";
        public const string Insta_Url = "https://www.instagram.com/mlb/";
        public const string TwitterError = "Twitter profile not available";
        public const string GitHubError = "Could not open repository";
        public const string InstaError = "Instagram profile not available";

        public UpcomingGamesPageViewModel(INavigationService navigationService, IApiService apiService, PageDialogService pagedialogservice, SeassonData seassonData) : base(navigationService, apiService, pagedialogservice, seassonData)
        {
            ViewMLBTwitterCommand = new DelegateCommand(async () =>
            {
                if (await this.HasInternet())
                {
                    try
                    {
                        await Browser.OpenAsync(new Uri($"{MLBTwitter}"), BrowserLaunchMode.SystemPreferred);
                    }
                    catch (Exception)
                    {
                        await pagedialogservice.DisplayAlertAsync("Alert", TwitterError, "OK");
                    }
                }
            });
            ViewGitHubRepoCommand = new DelegateCommand(async () =>
            {
                if (await this.HasInternet())
                {
                    try
                    {
                        await Browser.OpenAsync(new Uri($"{Github_Repo}"), BrowserLaunchMode.SystemPreferred);
                    }
                    catch (Exception)
                    {
                        await pagedialogservice.DisplayAlertAsync("Alert", GitHubError, "OK");
                    }
                }
            });
            ViewMLBInstagramCommand = new DelegateCommand(async () =>
            {
                if (await this.HasInternet())
                {
                    try
                    {
                        await Browser.OpenAsync(new Uri($"{Insta_Url}"), BrowserLaunchMode.SystemPreferred);
                    }
                    catch (Exception)
                    {
                        await pagedialogservice.DisplayAlertAsync("Alert", InstaError, "OK");
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
