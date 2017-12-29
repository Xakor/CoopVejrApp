using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Coop_vejrapp_Xamarin.Model
{
    public class VejrData
    {
        private Datum datum;

        public VejrData(Datum datum)
        {

        }

        public class RootObject
        {
            [JsonProperty("data")]
            public List<Datum> data { get; set; }
        }
        public class Datum
        {
            [JsonProperty("date")]
            public string date { get; set; }

            [JsonProperty("p")] //Vores umidelbare gæt er at P står for "Point"
            public List<P> p { get; set; }
        }

        public class P
        {
            [JsonProperty("lon")]
            public string lon { get; set; }

            [JsonProperty("lat")]
            public string lat { get; set; }

            [JsonProperty("temperature")]
            public string temperature { get; set; }
        }

    }
}
