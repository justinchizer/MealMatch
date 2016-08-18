using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Template10.Mvvm;
using System.Collections.ObjectModel;
using Meal_Match.Models;
using System.Threading;
using Template10.Utils;
using Template10.Common;
using Windows.UI.Xaml.Navigation;
using System.Runtime.CompilerServices;
using Windows.UI.Xaml.Media.Imaging;
using Meal_Match.Views;



namespace Meal_Match.ViewModels
{
    public class MainPageViewModel : ViewModelBase
    {
        readonly List<CancellationTokenSource> _cancellationTokens = new List<CancellationTokenSource>();
        Services.DataService _dataService;

        public MainPageViewModel()
        {
            _dataService = new Services.DataService();
            //PropertyChanged += async (s,e) =>
            //{
                _cancellationTokens.ForEach(x => x.Cancel());
                DisplayResults();
            //};

        }

        public async Task DisplayResults()
        {
            var source = _cancellationTokens.AddAndReturn(new CancellationTokenSource());
            await Task.Factory.StartNew(() =>
            {
            var restaurants = _dataService.listOfRestaurants().Result;
            if (!source.Token.IsCancellationRequested)
            {
                DispatcherWrapper.Current().Dispatch(() => 
                    {
                    Restaurants.Clear();
                    foreach (var restaurant in restaurants)
                    {
                        Restaurants.Add(restaurant);
                    }
                });
                }
            }, source.Token);
        }

        public ObservableCollection<Restaurant> Restaurants { get; } = new ObservableCollection<Restaurant>();




    }
}
