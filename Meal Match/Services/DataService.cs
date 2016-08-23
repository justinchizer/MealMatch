using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using Newtonsoft.Json;
using Meal_Match.Models;
using Meal_Match.ViewModels;
using Template10.Mvvm;

namespace Meal_Match.Services
{
    public class DataService : BindableBase
    {
        //public string CuisineType { get; private set; }


        string _CuisineType = default(string);
        public string CuisineType { get { return _CuisineType; } set { Set(ref _CuisineType, value); } }

        public async Task<IEnumerable<Models.Restaurant>> GetReataurantsAsync()
        {

            var rootObject = ZomatoAPICall().Result;
            await Task.CompletedTask;
            return Enumerable.Range(0, 7).Select(x => new Models.Restaurant(rootObject.restaurants[x].restaurant) { Name = Guid.NewGuid().ToString() });
        }

        public async Task<RootObject> ZomatoAPICall()
        {
            
        // Create a client
        HttpClient httpClient = new HttpClient();


            string ZOMATO_API = "https://developers.zomato.com/api/v2.1/search?q=";

            string CUISINE_TYPE = CuisineType;

            string LOCATION = "&count=8&lat=37.784627&lon=-122.398458&radius=1600&sort=rating";

            string ZOMATO_URL = ZOMATO_API + CUISINE_TYPE.Replace(" ", "%20") + LOCATION;

            // Add a new Request Message
            HttpRequestMessage requestMessage = new HttpRequestMessage(HttpMethod.Put, ZOMATO_URL);
            // Add our custom headers
            requestMessage.Headers.Add("user-key", "d22a78b458553d4677780d0d8e287df9");
            requestMessage.Headers.Add("Accept", "application/json");

            // Send the request to the server
            HttpResponseMessage response = await httpClient.SendAsync(requestMessage);

            string responseAsString = null;
            responseAsString = await response.Content.ReadAsStringAsync();
            //OutputField.Text = responseAsString;

            //TODO: Add check to see if API Call recieved a response

            RootObject rootObject = null;

            rootObject = JsonConvert.DeserializeObject<RootObject>(responseAsString);

            await Task.CompletedTask;

            return rootObject;
        }

        public async Task<List<Restaurant>> listOfRestaurants()
        {
            var serchResults = ZomatoAPICall().Result;

            await Task.CompletedTask;

            return serchResults.restaurants;


        }
    }
}
