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
using Meal_Match.Models;
using Windows.UI.Xaml.Media.Imaging;
using System.Threading.Tasks;
using Windows.Storage;

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
            InitializeComponent();
            NavigationCacheMode = Windows.UI.Xaml.Navigation.NavigationCacheMode.Enabled;
        }

        private async void spinButton_Click(object sender, RoutedEventArgs e)
        {

            myMediaElement.Play();
            #region Slot Spining
            Random num = new Random();

            for (int i = 0; i < 20; i++)
            {
                await Task.Delay(100);
                imageslot1.Source = new BitmapImage(new Uri("ms-appx:///Assets/Matrix0.PNG"));
                imageslot2.Source = new BitmapImage(new Uri("ms-appx:///Assets/Matrix1.PNG"));
                imageslot3.Source = new BitmapImage(new Uri("ms-appx:///Assets/Matrix0.PNG"));

                await Task.Delay(100);
                imageslot1.Source = new BitmapImage(new Uri("ms-appx:///Assets/Matrix1.PNG"));
                imageslot2.Source = new BitmapImage(new Uri("ms-appx:///Assets/Matrix0.PNG"));
                imageslot3.Source = new BitmapImage(new Uri("ms-appx:///Assets/Matrix1.PNG"));

            }
            int slot1 = num.Next(0, 2);
            if (slot1 == 0)
            {
                imageslot1.Source = new BitmapImage(new Uri("ms-appx:///Assets/Matrix0.PNG"));
            }
            else
            {
                imageslot1.Source = new BitmapImage(new Uri("ms-appx:///Assets/Matrix1.PNG"));
            }
            for (int j = 0; j < 2; j++)
            {
                await Task.Delay(100);
                imageslot2.Source = new BitmapImage(new Uri("ms-appx:///Assets/Matrix1.PNG"));
                imageslot3.Source = new BitmapImage(new Uri("ms-appx:///Assets/Matrix0.PNG"));

                await Task.Delay(100);
                imageslot2.Source = new BitmapImage(new Uri("ms-appx:///Assets/Matrix0.PNG"));
                imageslot3.Source = new BitmapImage(new Uri("ms-appx:///Assets/Matrix1.PNG"));
            }
            int slot2 = num.Next(0, 2);

            if (slot2 == 0)
            {
                imageslot2.Source = new BitmapImage(new Uri("ms-appx:///Assets/Matrix0.PNG"));
            }
            else
            {
                imageslot2.Source = new BitmapImage(new Uri("ms-appx:///Assets/Matrix1.PNG"));
            }
            for (int k = 0; k < 2; k++)
            {
                await Task.Delay(100);
                imageslot3.Source = new BitmapImage(new Uri("ms-appx:///Assets/Matrix0.PNG"));

                await Task.Delay(100);
                imageslot3.Source = new BitmapImage(new Uri("ms-appx:///Assets/Matrix1.PNG"));
            }
            int slot3 = num.Next(0, 2);
            if (slot3 == 0)
            {
                imageslot3.Source = new BitmapImage(new Uri("ms-appx:///Assets/Matrix0.PNG"));
            }
            else
            {
                imageslot3.Source = new BitmapImage(new Uri("ms-appx:///Assets/Matrix1.PNG"));
            }
            
            #endregion

        }
        private void TextBlock_Tapped(object sender, TappedRoutedEventArgs e)
        {
            Frame.Navigate(typeof(AboutPage));
        }        
    }
}