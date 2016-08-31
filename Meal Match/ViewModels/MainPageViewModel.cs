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
            PropertyChanged += async (s,e) =>
            {
                _cancellationTokens.ForEach(x => x.Cancel());
                 await DisplayResults();
            };

        }

        public async Task DisplayResults()
        {
            var source = _cancellationTokens.AddAndReturn(new CancellationTokenSource());
            await Task.Factory.StartNew(() =>
            {
                _dataService.CuisineType = CuisineType;
                var restaurants = _dataService.listOfRestaurants().Result;
                if (!source.Token.IsCancellationRequested)
                {
                    DispatcherWrapper.Current().Dispatch(() => 
                        {
                            Restaurants.Clear();
                            foreach (var restaurant in restaurants)
                            {
                                Restaurants.Add(restaurant);
                                var Indexes = Restaurants.Count -1;
                                _FinalIndexes = Indexes.ToString(); //Find Out How to show this on the XAML!!!!!
                                
                            }
                        });
                }
            }, source.Token);
        }

        public ObservableCollection<Restaurant> Restaurants { get; } = new ObservableCollection<Restaurant>();

        string _CuisineType = default(string);
        public string CuisineType { get { return _CuisineType; } set { Set(ref _CuisineType, value); } }

        string _FinalIndexes = default(string);
        public string FinalIndexes { get { return _FinalIndexes; } set { Set(ref _FinalIndexes, value); } }
    }
}
