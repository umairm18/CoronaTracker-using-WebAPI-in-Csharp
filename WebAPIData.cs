using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace VPProject
{
    
        // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse); 
        public class Confirmed
        {
            public int value { get; set; }
            public string detail { get; set; }
        }

        public class Recovered
        {
            public int value { get; set; }
            public string detail { get; set; }
        }

        public class Deaths
        {
            public int value { get; set; }
            public string detail { get; set; }
        }

        public class Root1
        {
            public Confirmed confirmed { get; set; }
            public Recovered recovered { get; set; }
            public Deaths deaths { get; set; }
            public DateTime lastUpdate { get; set; }
        }

      
       /*public static void getData(string name)
            {
                WebRequest request = HttpWebRequest.Create("https://covid19.mathdro.id/api/countries/" + name);
                WebResponse response = request.GetResponse();
                StreamReader stream = new StreamReader(response.GetResponseStream());
                string data = stream.ReadToEnd();

                Root DeserializedClass = JsonConvert.DeserializeObject<Root>(data);
                
              /*  DataHandling d = new DataHandling();
                d.setDeath(DeserializedClass.deaths.value);
                d.setRecovered(DeserializedClass.recovered.value);
                d.setConfirmed(DeserializedClass.confirmed.value);*/
}
            

