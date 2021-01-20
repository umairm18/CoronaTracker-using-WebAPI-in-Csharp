using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.IO;
using System.Net;

namespace VPProject
{
    public partial class ForDashboard : UserControl
    {
        public ForDashboard()
        {
            InitializeComponent();
        }

        private void lblconfirmed_Click(object sender, EventArgs e)
        {
           
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataHandling d= new DataHandling();
            d.setData(comboBox1.SelectedItem.ToString());

            lblconfirmed.Text = d.getConfirmed().ToString();
            lbldeaths.Text = d.getDeaths().ToString();
            lblrecovered.Text = d.getRecovered().ToString();

            recoverBar.Value = d.getRecoveryRate();
            recoverBar.Text = d.getRecoveryRate().ToString() + "%";

            fatalityBar.Value = d.getFatalityRate();
            fatalityBar.Text = d.getFatalityRate().ToString() + "%";

        


            // MessageBox.Show( d.getRecoveryRate().ToString());
            // d.getFatalityRate();
            //ForGraph f = new ForGraph(Convert.ToInt32(d.getRecoveryRate()), Convert.ToInt32(d.getRecoveryRate()));
            //MessageBox.Show(Convert.ToInt32 d.getRecoveryRate());

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ForDashboard_Load(object sender, EventArgs e)
        {
            try
            {
                // var bindingSource1 = new BindingSource();
                WebRequest request = HttpWebRequest.Create("https://covid19.mathdro.id/api/countries/");
                WebResponse response = request.GetResponse();
                StreamReader stream = new StreamReader(response.GetResponseStream());
                string data = stream.ReadToEnd();
                //string countryNames="";

                Root DeserializedClass = JsonConvert.DeserializeObject<Root>(data);
                foreach (var country in DeserializedClass.countries)
                {
                    comboBox1.Items.Add(country.name);
                }



            }
            catch (WebException ex)
            {
                MessageBox.Show(ex.Message);
            }


            try
            {

                // var bindingSource = new BindingSource();
                WebRequest request1 = HttpWebRequest.Create("https://covid19.mathdro.id/api/");
                WebResponse response1 = request1.GetResponse();
                StreamReader stream1 = new StreamReader(response1.GetResponseStream());
                string data1 = stream1.ReadToEnd();
                Root1 DeserializedClass1 = JsonConvert.DeserializeObject<Root1>(data1);

                if (comboBox1.SelectedIndex == -1)
                {
                    lblconfirmed.Text = DeserializedClass1.confirmed.value.ToString();
                    lblrecovered.Text = DeserializedClass1.recovered.value.ToString();
                    lbldeaths.Text = DeserializedClass1.deaths.value.ToString();

                    DataHandling d = new DataHandling();

                    d.setConfirmed(DeserializedClass1.confirmed.value);
                    d.setRecovered(DeserializedClass1.recovered.value);
                    d.setDeath(DeserializedClass1.deaths.value);

                    recoverBar.Value = d.getRecoveryRate();
                    recoverBar.Text = d.getRecoveryRate().ToString() + "%";

                    fatalityBar.Value = d.getFatalityRate();
                    fatalityBar.Text = d.getFatalityRate().ToString() + "%";
                }
            }
            catch (WebException ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void lblrecovered_Click(object sender, EventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblconfirmed_Click_1(object sender, EventArgs e)
        {

        }

        private void recoverBar_Click(object sender, EventArgs e)
        {

        }

        private void fatalityBar_Click(object sender, EventArgs e)
        {

        }
    }
}