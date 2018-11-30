using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Xamarin.Forms;
using System.Net.Http;
using System.Runtime.Serialization.Json;
using Newtonsoft.Json;

namespace toshiapp
{
    public class RandomAPI
    {
        public List<results> results;

        
        public string API_URL = "https://randomuser.me/api/";

        
        public async Task<List<results>> AsyncGetWebAPIData()
        {
            
            results = new List<results>();
            
            HttpClient httpClient = new HttpClient();
            
            Task<string> stringAsync = httpClient.GetStringAsync(API_URL);
            string result = await stringAsync;
            
            results = JsonConvert.DeserializeObject<List<results>>(result);

            
            return results;
        }
    }

    

    public class results
    {
        public name name { get; set; }
       
    }

    public class name
    {
        public string title { get; set; }
        public string first { get; set; }
        public string last { get; set; }
    }
}
