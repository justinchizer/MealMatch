using System;
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
            Price = restaurant.price_range.ToString();
        }



        public Restaurant2 restaurant { get; set; }

        public string Name { get; set; }
        public string Thumbnail { get; set; }
        public string Address { get; set; }
        public string Price { get; set; }

    }
}
