using Coop_vejrapp_Xamarin.Model;
using Newtonsoft.Json;
using System.Collections.ObjectModel;
using System.Net.Http;
using System.Net;
using Coop_vejrapp_Xamarin.ViewModels;

namespace Coop_vejrapp_Xamarin.Services
{
    public class CoopApi
    {
        public CoopApi()
        {
            
        }

        public async void CallApi(AllStoresViewModel viewModel)
        {

            var client = new HttpClient();
            AllStoresViewModel ViewModel = viewModel;

            /*var queryString = WebUtility.UrlDecode(string.Empty);*/
            ObservableCollection<Butik.Datum> temp = ViewModel.ButiksListe.ButiksListe;

            client.DefaultRequestHeaders.Add("Ocp-Apim-Subscription-Key", "/* REDACTED, still? */");
            client.DefaultRequestHeaders.Add("host", "api.cl.coop.dk");
            client.DefaultRequestHeaders.Add("Connection", "Keep-Alive");


            HttpRequestMessage requestApi = new HttpRequestMessage(HttpMethod.Get, "https://api.cl.coop.dk/storeapi/v1/stores?page=1&size=50"/* + queryString*/);
            
            HttpResponseMessage responseApi = await client.SendAsync(requestApi);
            
            var resultApi = JsonConvert.DeserializeObject<Butik.RootObject>(await responseApi.Content.ReadAsStringAsync());
            foreach (var i in resultApi.Data)
            {
                viewModel.ButiksListe.addButik(i);
            }
        }

        public async void CallApiFreetext(string searchText)
        {
            ObservableCollection<Butik.Datum> SearchResults = new ObservableCollection<Butik.Datum>();
            var client = new HttpClient();
            var queryString = WebUtility.UrlDecode(string.Empty);

            client.DefaultRequestHeaders.Add("Ocp-Apim-Subscription-Key", "a7a5af54dd7a45778bbae79cf9cd3080");
            client.DefaultRequestHeaders.Add("host", "api.cl.coop.dk");
            client.DefaultRequestHeaders.Add("Connection", "Keep-Alive");


            HttpRequestMessage requestApi = new HttpRequestMessage(HttpMethod.Get, "https://api.cl.coop.dk/storeapi/v1/stores/find/" + searchText + "?page=1&size=10" + queryString);
            HttpResponseMessage responseApi = await client.SendAsync(requestApi);
            string responseApiJson = await responseApi.Content.ReadAsStringAsync();

            var resultApi = JsonConvert.DeserializeObject<Butik.RootObject>(responseApiJson);
            foreach (var i in resultApi.Data)
            {
                SearchResults.Add(i);
            }
        }
        public void UpdateButiksListe()
        {

        }
    }
}
