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

namespace Meal_Match.ViewModels
{
    public class MainPageViewModel : ViewModelBase
    {
        readonly List<CancellationTokenSource> _cancellationTokens = new List<CancellationTokenSource>();
        Services.DataService _dataService;

        public MainPageViewModel()
        {

        }


        //public void DisplayResults()
        //{
        //    //Info for Restaurant 0
        //    if (rootObject.results_found > 0)
        //    {
        //        name0.Text = rootObject.restaurants[0].restaurant.name;
        //        address0.Text = rootObject.restaurants[0].restaurant.location.address;
        //        average_cost_for_two0.Text = "Cost for two: $" + rootObject.restaurants[0].restaurant.average_cost_for_two.ToString();
        //        image0.Source = new BitmapImage(new Uri(rootObject.restaurants[0].restaurant.thumb, UriKind.Absolute));
        //    }
        //    else
        //    {
        //        resultsNum.Text = "There are no matches in the area";
        //    }


        //    //Info for Restaurant 1
        //    if (rootObject.results_found > 1)
        //    {
        //        name1.Text = rootObject.restaurants[1].restaurant.name;
        //        address1.Text = rootObject.restaurants[1].restaurant.location.address;
        //        average_cost_for_two1.Text = "Cost for two: $" + rootObject.restaurants[1].restaurant.average_cost_for_two.ToString();
        //        image1.Source = new BitmapImage(new Uri(rootObject.restaurants[1].restaurant.thumb, UriKind.Absolute));

        //    }
        //    else
        //    {
        //        resultsNum.Text = "There were only " + rootObject.results_found.ToString() + " restaurants that were a match.";
        //    }

        //    //Info for Restaurant 2
        //    if (rootObject.results_found > 2)
        //    {
        //        name2.Text = rootObject.restaurants[2].restaurant.name;
        //        address2.Text = rootObject.restaurants[2].restaurant.location.address;
        //        average_cost_for_two2.Text = "Cost for two: $" + rootObject.restaurants[2].restaurant.average_cost_for_two.ToString();
        //        image2.Source = new BitmapImage(new Uri(rootObject.restaurants[2].restaurant.thumb, UriKind.Absolute));
        //    }
        //    else
        //    {
        //        resultsNum.Text = "There were only " + rootObject.results_found.ToString() + " restaurants that were a match.";
        //    }
        //    //Info for Restaurant 3
        //    if (rootObject.results_found > 3)
        //    {
        //        name3.Text = rootObject.restaurants[3].restaurant.name;
        //        address3.Text = rootObject.restaurants[3].restaurant.location.address;
        //        average_cost_for_two3.Text = "Cost for two: $" + rootObject.restaurants[3].restaurant.average_cost_for_two.ToString();
        //        image3.Source = new BitmapImage(new Uri(rootObject.restaurants[3].restaurant.thumb, UriKind.Absolute));
        //    }
        //    else
        //    {
        //        resultsNum.Text = "There were only " + rootObject.results_found.ToString() + " restaurants that were a match.";
        //    }

        //    //Info for Restaurant 4
        //    if (rootObject.results_found > 4)
        //    {
        //        name4.Text = rootObject.restaurants[4].restaurant.name;
        //        address4.Text = rootObject.restaurants[4].restaurant.location.address;
        //        average_cost_for_two4.Text = "Cost for two: $" + rootObject.restaurants[4].restaurant.average_cost_for_two.ToString();
        //        image4.Source = new BitmapImage(new Uri(rootObject.restaurants[4].restaurant.thumb, UriKind.Absolute));
        //    }
        //    else
        //    {
        //        resultsNum.Text = "There were only " + rootObject.results_found.ToString() + " restaurants that were a match.";
        //    }

        //    //Info for Restaurant 5
        //    if (rootObject.results_found > 5)
        //    {
        //        name5.Text = rootObject.restaurants[5].restaurant.name;
        //        address5.Text = rootObject.restaurants[5].restaurant.location.address;
        //        average_cost_for_two5.Text = "Cost for two: $" + rootObject.restaurants[5].restaurant.average_cost_for_two.ToString();
        //        image5.Source = new BitmapImage(new Uri(rootObject.restaurants[5].restaurant.thumb, UriKind.Absolute));
        //    }
        //    else
        //    {
        //        resultsNum.Text = "There were only " + rootObject.results_found.ToString() + " restaurants that were a match.";
        //    }

        //    //Info for Restaurant 6
        //    if (rootObject.results_found > 6)
        //    {
        //        name6.Text = rootObject.restaurants[6].restaurant.name;
        //        address6.Text = rootObject.restaurants[6].restaurant.location.address;
        //        average_cost_for_two6.Text = "Cost for two: $" + rootObject.restaurants[6].restaurant.average_cost_for_two.ToString();
        //        image6.Source = new BitmapImage(new Uri(rootObject.restaurants[6].restaurant.thumb, UriKind.Absolute));
        //    }
        //    else
        //    {
        //        resultsNum.Text = "There were only " + rootObject.results_found.ToString() + " restaurants that were a match.";
        //    }

        //    //Info for Restaurant 7
        //    if (rootObject.results_found > 7)
        //    {
        //        name7.Text = rootObject.restaurants[7].restaurant.name;
        //        address7.Text = rootObject.restaurants[7].restaurant.location.address;
        //        average_cost_for_two7.Text = "Cost for two: $" + rootObject.restaurants[7].restaurant.average_cost_for_two.ToString();
        //        image7.Source = new BitmapImage(new Uri(rootObject.restaurants[7].restaurant.thumb, UriKind.Absolute));

        //    }
        //    else
        //    {
        //        resultsNum.Text = "There were only " + rootObject.results_found.ToString() + " restaurants that were a match.";
        //    }

        //    if (rootObject.results_found > 8)
        //    {
        //        resultsNum.Text = "";
        //    }
        //}
    }
}
