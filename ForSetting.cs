using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace VPProject
{
    public partial class ForSetting : UserControl
    {
        public ForSetting()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            switch (comboBox1.SelectedIndex)
            {
                case 0:
                    Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("en-US");
                    Properties.Settings.Default["Lang"] = "en-US";
                    Properties.Settings.Default.Save();

                    break;
                case 1:
                    Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("ur-PK");
                    Properties.Settings.Default["Lang"] = "ur-PK";
                    Properties.Settings.Default.Save();

                    break;
                case 2:
                    Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("tr-TR");
                    Properties.Settings.Default["Lang"] = "tr-TR";
                    Properties.Settings.Default.Save();

                    break;

                default:
                    Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("en-US");
                    Properties.Settings.Default["Lang"] = "en-US";
                    Properties.Settings.Default.Save();
                    break;
            }
            this.Controls.Clear();
            InitializeComponent();
            ForSetting_Load(sender, e);

        }

        private void ForSetting_Load(object sender, EventArgs e)
        {
            //panel1.BackColor = Color.FromArgb(100, 0, 0, 0);
            comboBox1.Items.Add("English");
            comboBox1.Items.Add("اردو");
            comboBox1.Items.Add("Turkish");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Covid19Tracker newform = new Covid19Tracker();
                newform.Show();
                this.Hide();
            }
            catch (Exception )
            {
                //e.Message;
            }
           
        }
    }
}
