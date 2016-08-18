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


        private /*async*/ void ListView_ItemClick(object sender, ItemClickEventArgs e)
        {
            //var d = new ContentDialog();
            //d.ContentTemplate = Resources["RestaurantDetailTemplate"] as DataTemplate;
            //d.DataContext = e.ClickedItem;
            //d.PrimaryButtonText = "Close";
            //await d.ShowAsync();
        }

        private void searchInput_KeyDown(object sender, KeyRoutedEventArgs e)
        {

        }
        private async void search_Click(object sender, RoutedEventArgs e)
        {
            
            var mainPage = new MainPageViewModel();
            await mainPage.DisplayResults();
        }

        private async void spinButton_Click(object sender, RoutedEventArgs e)
        {
            //var spin = new MainPageViewModel();
            //await spin.SlotMachine();
        }
    }
}
