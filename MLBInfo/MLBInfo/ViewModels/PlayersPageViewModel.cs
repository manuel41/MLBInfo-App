﻿using MLBInfo.ViewModels;
using MLBPlayersApp.Models;
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
using System.Windows.Input;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace MLBPlayersApp.ViewModels
{
    public class PlayersPageViewModel :BaseViewModel, INotifyPropertyChanged
    {
        public ObservableCollection<Player> Players { get; set; }

 

        public event PropertyChangedEventHandler PropertyChanged;

        public bool IsActiveCheckBox { get; set; }
        public string SearchEntry { get; set; }
        public DelegateCommand SearchPlayerCommand { get; set; }

        public PlayersPageViewModel(INavigationService navigationService, IApiService apiService, PageDialogService pagedialogservice) : base(navigationService, apiService, pagedialogservice)
        {
            SearchPlayerCommand = new DelegateCommand(async() =>
            {
                if(!string.IsNullOrEmpty(SearchEntry)) await GetPlayerData(SearchEntry); 
            });
        }

        public async Task GetPlayerData(string search)
        {
            Players?.Clear();
            string status = (IsActiveCheckBox) ? "Y" : "N";
            if (Connectivity.NetworkAccess == NetworkAccess.Internet)
            {
                try
                {
                    QueryResults results = await ApiService.GetPlayersList(search, status);
                    Players = new ObservableCollection<Player>(results.PlayersList as List<Player>);
                }
                catch (Exception ex)
                {
                    Debug.WriteLine($"API EXCEPTION {ex}");
                }

            }
            else
            {
                
                await PageDialogService.DisplayAlertAsync("Alert", "Internet connection is not available", "OK");
            }
        }
    }
}
