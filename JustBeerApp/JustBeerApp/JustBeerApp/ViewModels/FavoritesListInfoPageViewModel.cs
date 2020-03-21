﻿using JustBeerApp.Models;
using JustBeerApp.Services;
using Prism.Navigation;
using Prism.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;

namespace JustBeerApp.ViewModels
{
    public class FavoritesListInfoPageViewModel : BaseViewModel 
    {
        protected IApiManager ApiManager = new ApiManager();
        public ObservableCollection<Data> Data { get; set; }
        public bool IsRunning { get; set; }
        public string BeerId { get; set; }
        public FavoritesListInfoPageViewModel(INavigationService navigationService, IApiBeerService apiService, IPageDialogService pageDialogService) : base(navigationService, apiService, pageDialogService)
        {
            GetBeerData();
        }
        public async Task GetBeerData()
        {
            IsRunning = true;
            var result = await ApiManager.GetBeerAsync(BeerId);
            if (result != null)
                Data = new ObservableCollection<Data>(result);
            IsRunning = false;
        }
    }
}