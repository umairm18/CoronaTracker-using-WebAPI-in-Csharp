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
    public class Country
    {
        public string name { get; set; }
        public string iso2 { get; set; }
        public string iso3 { get; set; }
    }

    public class Root
    {

        public List<Country> countries { get; set; }
    }

}