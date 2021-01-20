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
    class DataHandling
    {
        
        double cnfrmd;
        double recvrd;
        double deaths;
        int rateRC;
        int rateDT;

        /*public DataHandling(int x, int y, int z)
        {
            this.cnfrmd = x;
            this.recvrd = y;
            this.deaths = z;
        }*/

        public void setConfirmed(int apicnfrm)
        {
            this.cnfrmd = apicnfrm;
        }
        public void setRecovered(int apirecvrd)
        {
            this.recvrd = apirecvrd;
        }

        public void setDeath(int apideath)
        {
            this.deaths = apideath;
        }

        public double getConfirmed()
        {
            return cnfrmd;
        }

        public double getRecovered()
        {
            return recvrd;
        }

        public double getDeaths()
        {
            return deaths;
        }
        
        public int getRecoveryRate()
        {
            try
            {
                rateRC = Convert.ToInt32((recvrd / cnfrmd) * 100);
                return rateRC;
            }
            catch (DivideByZeroException e)
            {
                
                throw;
            }
            
        }

        public int getFatalityRate()
        {
            try
            {
                rateDT = Convert.ToInt32((deaths / cnfrmd) * 100);
                return rateDT;
            }
            catch (DivideByZeroException e)
            {

                throw;
            }
            
        }

        public void setData(string name)
        {
            try
            {
                WebRequest request = HttpWebRequest.Create("https://covid19.mathdro.id/api/countries/" + name);
                WebResponse response = request.GetResponse();
                StreamReader stream = new StreamReader(response.GetResponseStream());
                string data = stream.ReadToEnd();

                Root1 DeserializedClass = JsonConvert.DeserializeObject<Root1>(data);
                cnfrmd = DeserializedClass.confirmed.value;
                recvrd = DeserializedClass.recovered.value;
                deaths = DeserializedClass.deaths.value;
            }
            catch (WebException ex)
            {

                throw;
            }
            


            //ForGraph f = new ForGraph(cnfrmd,recvrd,deaths);
        }
       
    }
}