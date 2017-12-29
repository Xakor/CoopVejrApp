using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace Coop_vejrapp_Xamarin.Model
{
    public class Butik
    {
        private Datum datum;

        public Butik(Datum datum)
        {

        }

        public class RootObject
        {
            [JsonProperty("Data")]
            public List<Datum> Data { get; set; }
        }

        /// <summary>
        /// Constructor
        /// </summary>
        public class Datum
        {
            [JsonProperty("Kardex")]
            public string Kardex { get; set; }

            [JsonProperty("RetailGroupName")]
            public string RetailGroupName { get; set; }

            [JsonProperty("Name")]
            public string Name { get; set; }

            [JsonProperty("Address")]
            public string Address { get; set; }

            [JsonProperty("Zipcode")]
            public string Zipcode { get; set; }

            [JsonProperty("Link")]
            public string Link { get; set; }

            [JsonProperty("City")]
            public string City { get; set; }

            [JsonProperty("Phonenumber")]
            public string Phonenumber { get; set; }

            [JsonProperty("Manager")]
            public string Manager { get; set; }

            [JsonProperty("Location")]
            public Locations Location { get; set; }


        }

        public class Locations
        {
            [JsonProperty("type")]
            public string Type { get; set; }

            [JsonProperty("coordinates")]
            public string[] Coordinates { get; set; }

        }
    }
}
