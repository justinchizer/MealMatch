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
           // {
                _cancellationTokens.ForEach(x => x.Cancel());
                 DisplayResults();
           // };

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


        string _CuisineType = default(string);
        public string CuisineType { get { return _CuisineType; } set { Set(ref _CuisineType, value); } }














        //public async Task SlotMachine()
        //{
        //    int tempTime1 = randomNumber1();
        //    await DelaySlot1(tempTime1);

        //    int tempTime2 = randomNumber2();
        //    await DelaySlot2(tempTime2);

        //    int tempTime3 = randomNumber3();
        //    await DelaySlot3(tempTime3);
        //}

        //public int randomNumber1()
        //{
        //    Random randomNum1 = new Random();
        //    int randomTime1 = randomNum1.Next(0, 100);


        //    //testnum.Text = randomTime1.ToString();
        //    return randomTime1;

        //}

        //public int randomNumber2()
        //{
        //    Random randomNum2 = new Random();
        //    int randomTime2 = randomNum2.Next(0, 100);


        //    //testnum.Text = randomTime2.ToString();
        //    return randomTime2;

        //}

        //public int randomNumber3()
        //{
        //    Random randomNum3 = new Random();
        //    int randomTime3 = randomNum3.Next(0, 100);


        //    //testnum.Text = randomTime3.ToString();
        //    return randomTime3;

        //}


        //public async Task DelaySlot1(int randomTime1)
        //{
        //    await Task.Delay(TimeSpan.FromSeconds(3));
        //    if (randomTime1 % 2 == 0)
        //    {
        //        imageslot1.Source = new BitmapImage(new Uri("ms-appx:///Assets/Matrix0.PNG"));
        //    }
        //    else if (randomTime1 % 2 == 1)
        //    {
        //        imageslot1.Source = new BitmapImage(new Uri("ms-appx:///Assets/Matrix1.PNG"));
        //    }
        //    else
        //    {
        //        imageslot1.Source = new BitmapImage(new Uri("ms-appx:///Assets/MatrixX.PNG"));
        //    }

        //    await Task.CompletedTask;
        //}


        //public async Task DelaySlot2(int randomTime2)
        //{
        //    await Task.Delay(TimeSpan.FromSeconds(1));

        //    if (randomTime2 % 2 == 0)
        //    {
        //        imageslot2.Source = new BitmapImage(new Uri("ms-appx:///Assets/Matrix0.PNG"));
        //    }
        //    else if (randomTime2 % 2 == 1)
        //    {
        //        imageslot2.Source = new BitmapImage(new Uri("ms-appx:///Assets/Matrix1.PNG"));
        //    }
        //    else
        //    {
        //        imageslot2.Source = new BitmapImage(new Uri("ms-appx:///Assets/MatrixX.PNG"));
        //    }

        //    await Task.CompletedTask;

        //}

        //public async Task DelaySlot3(int randomTime3)
        //{
        //    await Task.Delay(TimeSpan.FromSeconds(1));

        //    if (randomTime3 % 2 == 0)
        //    {
        //        imageslot3.Source = new BitmapImage(new Uri("ms-appx:///Assets/Matrix0.PNG"));
        //    }
        //    else if (randomTime3 % 2 == 1)
        //    {
        //        imageslot3.Source = new BitmapImage(new Uri("ms-appx:///Assets/Matrix1.PNG"));
        //    }
        //    else
        //    {
        //        imageslot3.Source = new BitmapImage(new Uri("ms-appx:///Assets/MatrixX.PNG"));
        //    }

        //    await Task.CompletedTask;

        //}


    }
}
