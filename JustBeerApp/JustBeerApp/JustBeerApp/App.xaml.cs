﻿using JustBeerApp.Services;
using JustBeerApp.ViewModels;
using JustBeerApp.Views;
using Prism;
using Prism.Ioc;
using Prism.Unity;
using System;
using Unity.Lifetime;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace JustBeerApp
{
    public partial class App : PrismApplication
    {
        public App(IPlatformInitializer initializer = null) : base(initializer) { }
        protected override void OnInitialized()
        {
            InitializeComponent();
            NavigationService.NavigateAsync(new Uri(NavigationConstants.Tab, UriKind.Relative));
        }
        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterForNavigation<NavigationPage>();
            containerRegistry.RegisterForNavigation<MenuTabbedPage>();
            containerRegistry.RegisterForNavigation<MainAppPage, MainAppPageViewModel>();
            containerRegistry.RegisterForNavigation<HomePage, HomePageViewModel>();
            containerRegistry.RegisterForNavigation<FavoriteBeerInfoPage, FavoritesBeerInfoPageViewModel>();
            containerRegistry.RegisterForNavigation<FavoritesListInfoPage, FavoritesListInfoPageViewModel>();
            containerRegistry.RegisterForNavigation<RandomBeerPage, RandomBeerPageViewModel>();
            containerRegistry.RegisterForNavigation<SearchBeerPage, SearchBeerPageViewModel>();
            containerRegistry.RegisterForNavigation<BeerInfoPage, BeerInfoPageViewModel>();
            containerRegistry.Register<IApiBeerService, ApiBeerService>();
            containerRegistry.Register<IApiManager, ApiManager>();
            containerRegistry.RegisterForNavigation<RandomBeerDetailedPage, RandomBeerPageViewModel>();
            containerRegistry.RegisterForNavigation<SearchBeerDetailedPage, SearchBeerPageViewModel>();

        }
    }
}
