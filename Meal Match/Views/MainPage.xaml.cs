using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using Meal_Match.ViewModels;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace Meal_Match.Views
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
            NavigationCacheMode = Windows.UI.Xaml.Navigation.NavigationCacheMode.Enabled;
        }

        

        private async void spinButton_Click(object sender, RoutedEventArgs e)
        {
            //var spin = new MainPageViewModel();
            //await spin.SlotMachine();
        }

        







        //public async Task SlotMachine()
        //{
        //    int tempTime1 = randomNumber1();
        //    await DelaySlot1(tempTime1, rootObject);

        //    int tempTime2 = randomNumber2();
        //    await DelaySlot2(tempTime2, rootObject);

        //    int tempTime3 = randomNumber3();
        //    await DelaySlot3(tempTime3, rootObject);
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


        //   // testnum.Text = randomTime2.ToString();
        //    return randomTime2;

        //}

        //public int randomNumber3()
        //{
        //    Random randomNum3 = new Random();
        //    int randomTime3 = randomNum3.Next(0, 100);


        //   // testnum.Text = randomTime3.ToString();
        //    return randomTime3;

        //}


        //private async Task DelaySlot1(int randomTime1, RootObject rootObject)
        //{
        //    await Task.Delay(TimeSpan.FromSeconds(3));
        //    if (randomTime1 % 2 == 0 && rootObject.results_shown > 4)
        //    {
        //        imageslot1.Source = new BitmapImage(new Uri("ms-appx:///Assets/Matrix0.PNG"));
        //    }
        //    else if (randomTime1 % 2 == 1 && rootObject.results_shown > 4)
        //    {
        //        imageslot1.Source = new BitmapImage(new Uri("ms-appx:///Assets/Matrix1.PNG"));
        //    }
        //    else
        //    {
        //        imageslot1.Source = new BitmapImage(new Uri("ms-appx:///Assets/MatrixX.PNG"));
        //    }

        //    await Task.CompletedTask;
        //}


        //private async Task DelaySlot2(int randomTime2, RootObject rootObject)
        //{
        //    await Task.Delay(TimeSpan.FromSeconds(1));

        //    if (randomTime2 % 2 == 0 && rootObject.results_shown > 2)
        //    {
        //        imageslot2.Source = new BitmapImage(new Uri("ms-appx:///Assets/Matrix0.PNG"));
        //    }
        //    else if (randomTime2 % 2 == 1 && rootObject.results_shown > 2)
        //    {
        //        imageslot2.Source = new BitmapImage(new Uri("ms-appx:///Assets/Matrix1.PNG"));
        //    }
        //    else
        //    {
        //        imageslot2.Source = new BitmapImage(new Uri("ms-appx:///Assets/MatrixX.PNG"));
        //    }

        //    await Task.CompletedTask;

        //}

        //private async Task DelaySlot3(int randomTime3, RootObject rootObject)
        //{
        //    await Task.Delay(TimeSpan.FromSeconds(1));

        //    if (randomTime3 % 2 == 0 && rootObject.results_shown > 0)
        //    {
        //        imageslot3.Source = new BitmapImage(new Uri("ms-appx:///Assets/Matrix0.PNG"));
        //    }
        //    else if (randomTime3 % 2 == 1 && rootObject.results_shown > 0)
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
