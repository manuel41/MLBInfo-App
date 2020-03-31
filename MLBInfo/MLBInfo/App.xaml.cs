using System;
using MLBApp;
using MLBInfo.ViewModels;
using MLBInfo.Views;
using MLBPlayersApp.Models;
using MLBPlayersApp.Services;
using MLBPlayersApp.ViewModels;
using MLBTeamsApp.Models;
using MLBTeamsApp.ViewModels;
using Prism;
using Prism.Ioc;
using Prism.Modularity;
using Prism.Unity;
using Xamarin.Forms;

namespace MLBInfo
{
    public partial class App : PrismApplication
    {
        public App(IPlatformInitializer initializer = null) : base(initializer) { }
        protected override void OnInitialized()
        {
            InitializeComponent();

            // NavigationService.NavigateAsync(new Uri(NavConstants.Home, UriKind.Absolute));

            //Example using Tab
            //NavigationService.NavigateAsync(new Uri(NavConstants.TabMenu, UriKind.Absolute));

            //Example using Master Detail
            NavigationService.NavigateAsync(new Uri(NavConstants.TabMenu, UriKind.Absolute));

        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterForNavigation<NavigationPage>();
            containerRegistry.Register<IApiService, ApiService>();
            containerRegistry.RegisterForNavigation<TabbedHomePage>();
            containerRegistry.RegisterForNavigation<TeamPage, TeamsPageViewModel>();
            containerRegistry.RegisterForNavigation<PlayerPage, PlayersPageViewModel>();
            containerRegistry.RegisterForNavigation<PlayerInfoPage, PlayerInfoPageViewModel>();
            containerRegistry.RegisterForNavigation<TeamRosterPage, TeamRosterPageViewModel>();

        }
    }
}
