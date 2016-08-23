using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Meal_Match.Models
{
    public class Restaurant
    {

        public Restaurant(Restaurant2 restaurant)
        {
            Name = restaurant.name;
            Thumbnail = restaurant.thumb;
            Address = restaurant.location.address;
            #region Price
            if (restaurant.price_range == 1)
            {
                Price = "$";
            }
            else if (restaurant.price_range == 2)
            {
                Price = "$$";
            }
            else if (restaurant.price_range == 3)
            {
                Price = "$$$";
            }
            else
            {
                Price = "$$$$";
            }
            #endregion
            #region Rating
            // Rating = "\xE1CE \xE1CF \xE7C6"; // Star, Filled Star, Half star
            if (restaurant.user_rating.aggregate_rating == "0" ||
                restaurant.user_rating.aggregate_rating == "0.1" ||
                restaurant.user_rating.aggregate_rating == "0.2" ||
                restaurant.user_rating.aggregate_rating == "0.3" ||
                restaurant.user_rating.aggregate_rating == "0.4")
            {
                Rating = "\xE1CE\xE1CE\xE1CE\xE1CE\xE1CE"; //0
            }
            else if (restaurant.user_rating.aggregate_rating == "0.5" ||
                     restaurant.user_rating.aggregate_rating == "0.6" ||
                     restaurant.user_rating.aggregate_rating == "0.7" ||
                     restaurant.user_rating.aggregate_rating == "0.8" ||
                     restaurant.user_rating.aggregate_rating == "0.9")
            {
                Rating = "\xE7C6\xE1CE\xE1CE\xE1CE\xE1CE"; //0.5
            }
            else if (restaurant.user_rating.aggregate_rating == "1.0" ||
                     restaurant.user_rating.aggregate_rating == "1.1" ||
                     restaurant.user_rating.aggregate_rating == "1.2" ||
                     restaurant.user_rating.aggregate_rating == "1.3" ||
                     restaurant.user_rating.aggregate_rating == "1.4")
            {
                Rating = "\xE1CF\xE1CE\xE1CE\xE1CE\xE1CE"; //1
            }
            else if (restaurant.user_rating.aggregate_rating == "1.5" ||
                     restaurant.user_rating.aggregate_rating == "1.6" ||
                     restaurant.user_rating.aggregate_rating == "1.7" ||
                     restaurant.user_rating.aggregate_rating == "1.8" ||
                     restaurant.user_rating.aggregate_rating == "1.9")
            {
                Rating = "\xE1CF\xE7C6\xE1CE\xE1CE\xE1CE"; //1.5
            }
            else if (restaurant.user_rating.aggregate_rating == "2.0" ||
                     restaurant.user_rating.aggregate_rating == "2.1" ||
                     restaurant.user_rating.aggregate_rating == "2.2" ||
                     restaurant.user_rating.aggregate_rating == "2.3" ||
                     restaurant.user_rating.aggregate_rating == "2.4")
            {
                Rating = "\xE1CF\xE1CF\xE1CE\xE1CE\xE1CE"; //2
            }
            else if (restaurant.user_rating.aggregate_rating == "2.5" ||
                     restaurant.user_rating.aggregate_rating == "2.6" ||
                     restaurant.user_rating.aggregate_rating == "2.7" ||
                     restaurant.user_rating.aggregate_rating == "2.8" ||
                     restaurant.user_rating.aggregate_rating == "2.9")
            {
                Rating = "\xE1CF\xE1CF\xE7C6\xE1CE\xE1CE"; //2.5
            }
            else if (restaurant.user_rating.aggregate_rating == "3.0" ||
                     restaurant.user_rating.aggregate_rating == "3.1" ||
                     restaurant.user_rating.aggregate_rating == "3.2" ||
                     restaurant.user_rating.aggregate_rating == "3.3" ||
                     restaurant.user_rating.aggregate_rating == "3.4")
            {
                Rating = "\xE1CF\xE1CF\xE1CF\xE1CE\xE1CE"; //3
            }
            else if (restaurant.user_rating.aggregate_rating == "3.5" ||
                     restaurant.user_rating.aggregate_rating == "3.6" ||
                     restaurant.user_rating.aggregate_rating == "3.7" ||
                     restaurant.user_rating.aggregate_rating == "3.8" ||
                     restaurant.user_rating.aggregate_rating == "3.9")
            {
                Rating = "\xE1CF\xE1CF\xE1CF\xE7C6\xE1CE"; //3.5
            }
            else if (restaurant.user_rating.aggregate_rating == "4.0" ||
                restaurant.user_rating.aggregate_rating == "4.1" ||
                restaurant.user_rating.aggregate_rating == "4.2" ||
                restaurant.user_rating.aggregate_rating == "4.3")
            {
                Rating = "\xE1CF\xE1CF\xE1CF\xE1CF\xE1CE"; //4
            }
            else if (restaurant.user_rating.aggregate_rating == "4.4" ||
                     restaurant.user_rating.aggregate_rating == "4.5" ||
                     restaurant.user_rating.aggregate_rating == "4.6" ||
                     restaurant.user_rating.aggregate_rating == "4.7" ||
                     restaurant.user_rating.aggregate_rating == "4.8" ||
                     restaurant.user_rating.aggregate_rating == "4.9")
            {
                Rating = "\xE1CF\xE1CF\xE1CF\xE1CF\xE7C6"; //4.5
            }
            else
            {
                Rating = "\xE1CF\xE1CF\xE1CF\xE1CF\xE1CF"; //5
            }
            #endregion
            URL = restaurant.url;
            
        }



        public Restaurant2 restaurant { get; set; }

        public string Name { get; set; }
        public string Thumbnail { get; set; }
        public string Address { get; set; }
        public string Price { get; set; }
        public string Rating { get; set; }
        public string URL { get; set; }
    }
}
