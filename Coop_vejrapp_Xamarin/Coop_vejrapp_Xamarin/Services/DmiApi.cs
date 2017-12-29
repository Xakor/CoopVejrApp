using Coop_vejrapp_Xamarin.Model;
using Coop_vejrapp_Xamarin.ViewModels;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Coop_vejrapp_Xamarin.Services
{
    public class DmiApi
    {
        static HttpClient client = new HttpClient();
        public string DMIKey = "/* REDACTED */";
        public string Param = "temperature";
        public string Longtitude { get; set; }
        public string Latitude { get; set; }
        public string Choose = "best-spatial-res";

        public async void DMICallPointModel(AllStoresViewModel Viewmodel, string longtitude, string latitude)
        {

            //string datetimenow = DateTime.Now.ToString("yyyy MM dd HH"); //Debug
            string model = "&model=hir-s03";
            string Mindate = DateTime.Now.AddHours(1).ToString("yyyyMMddHH");
            string Maxdate = DateTime.Now.AddHours(1).ToString("yyyyMMddHH");
            string PointModelUri = "https://secure.dmi.dk/GWS/model/points";
            string QueryPath = PointModelUri + "?cookie=" + DMIKey + model + "&param=" + Param + "&lon=" + longtitude + "&lat=" + latitude + "&mindate=" + Mindate + "&maxdate=" + Maxdate + "&choose=" + Choose;
            string result = string.Empty;


            HttpResponseMessage response = await client.GetAsync(QueryPath);

            //result = await response.Content.ReadAsStringAsync();
            var DeserializedJson = JsonConvert.DeserializeObject<VejrData.RootObject>(await response.Content.ReadAsStringAsync());
            Viewmodel.SelectedStoreWeather = DeserializedJson.data[0];


        }
        public async void DMICallPrognosis(AllStoresViewModel ViewModel, string longtitude, string latitude)
        {

        }
    }
}