using MLBPlayersApp.Services;
using Prism.Commands;
using Prism.Navigation;
using Prism.Services;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;

namespace MLBInfo.ViewModels
{
    public class BaseViewModel
    {
        protected INavigationParameters NavigationParameter { get; set; }
        protected INavigationService NavigationService { get; set; }
        protected IApiService ApiService { get; set; }
        protected IPageDialogService PageDialogService { get; set; }

        public BaseViewModel(INavigationService navigationService, IApiService apiService, PageDialogService pagedialogservice, INavigationParameters navigationParameter)
        {
            NavigationService = navigationService;
            ApiService = apiService;
            PageDialogService = pagedialogservice;
            NavigationParameter = navigationParameter;
        }

        public async Task<bool> HasInternet()
        {
            if (Connectivity.NetworkAccess != NetworkAccess.Internet)
                await PageDialogService.DisplayAlertAsync("Alert", "No tienes internet", "OK");

            return (Connectivity.NetworkAccess == NetworkAccess.Internet);

        }
    }
}
