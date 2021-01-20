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
    public partial class Home : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
            (
              int nLeftRect,
              int nTopRect,
              int nRightRect,
              int nBottomRect,
              int nWidthEllipse,
              int nHeightEllipse
            );
        public Home()
        {
            Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("en-US");
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));

        }

        private void Home_Load(object sender, EventArgs e)
        {
            panel1.BackColor = Color.FromArgb(100, 0, 0, 0);
            comboBox1.Items.Add("English");
            comboBox1.Items.Add("اردو");
            comboBox1.Items.Add("Turkish");
           
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {/*
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
            }
            this.Controls.Clear();
            InitializeComponent();
            Home_Load(sender, e);*/
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
             Covid19Tracker newform = new Covid19Tracker();
             newform.Show();
             this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
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
            Home_Load(sender, e);

        }
    }
}