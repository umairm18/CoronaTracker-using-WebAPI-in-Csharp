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
    public partial class Covid19Tracker : Form
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
        public Covid19Tracker()
        {
            String selectedLang = Properties.Settings.Default.Lang;
            Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo(selectedLang);
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
            pnlNav.Height = btnDashboard.Height;
            pnlNav.Top = btnDashboard.Top;
            pnlNav.Left = btnDashboard.Left;
            btnDashboard.BackColor = Color.FromArgb(46, 51, 73);
        }
        private void Covid19Tracker_Load(object sender, EventArgs e)
        {
            pictureBox4.Visible = false;
            pictureBox1.Visible = true;
            pictureBox2.Visible = false;
            pictureBox3.Visible = false;
            lblDasshboard.Visible= true;
            lblAnalytics.Visible = false;
            lblContact.Visible = false;
            lblSettings.Visible = false;
            Dashboard.Visible = true;
            Graph.Visible = false;
            Contact.Visible = false;
            Settings.Visible = false;
            //panel1.BackColor = Color.FromArgb(100, 0, 0, 0);
            //panel2.BackColor = Color.FromArgb(100, 0, 0, 0);
            //panel3.BackColor = Color.FromArgb(100, 0, 0, 0);
            //Dashboard.BackColor = Color.FromArgb(100, 0, 0, 0);
        }
        private void btnDashboard_Click(object sender, EventArgs e)
        {
            pictureBox4.Visible = false;
            pictureBox2.Visible = false;
            pictureBox1.Visible = true;
            pictureBox3.Visible = false;
            //label1.Visible = false;
            lblDasshboard.Show();          
            lblAnalytics.Visible = false;
            lblContact.Visible = false;
            lblSettings.Visible = false;
            pnlNav.Height = btnDashboard.Height;
            pnlNav.Top = btnDashboard.Top;
            pnlNav.Left = btnDashboard.Left;
            btnDashboard.BackColor = Color.FromArgb(46, 51, 73);
            Graph.Hide();
            Dashboard.Visible = true;
            Contact.Visible = false;
            Settings.Visible = false;
        }
        private void btnGraph_Click(object sender, EventArgs e)
        {
            //DataHandling d = new DataHandling();
            //MessageBox.Show(d.getRecoveryRate().ToString());
            pictureBox4.Visible = false;
            pictureBox3.Visible = false;
            pictureBox2.Visible = true;
            pictureBox1.Visible = false;
            //label1.Visible = false;
            lblAnalytics.Show();
            lblDasshboard.Visible = false;           
            lblContact.Visible = false;
            lblSettings.Visible = false;
            Dashboard.Hide();
            Graph.Show();
            Contact.Visible = false;
            Settings.Visible = false;
        }

        private void label2_Click(object sender, EventArgs e)
        {
            //label1.Visible = false;

        }

        private void btnContact_Click(object sender, EventArgs e)
        {
            Settings.Visible = false;
            pictureBox4.Visible = false;
            pictureBox1.Visible = false;
            pictureBox2.Visible = false;
            pictureBox3.Visible = true;
            lblDasshboard.Visible = false;
            lblAnalytics.Visible = false;           
            lblSettings.Visible = false;
            lblContact.Show();
            Dashboard.Hide();
            Graph.Hide();
            pnlNav.Height = btnContact.Height;
            pnlNav.Top = btnContact.Top;
            pnlNav.Left = btnContact.Left;
            btnContact.BackColor = Color.FromArgb(46, 51, 73);
            Contact.Visible = true;
        }

        private void btnDashboard_Leave(object sender, EventArgs e)
        {
            btnDashboard.BackColor = Color.FromArgb(20, 30, 54);
        }

        private void btnContact_Leave(object sender, EventArgs e)
        {
            btnContact.BackColor = Color.FromArgb(20, 30, 54);
        }

        private void btnSettings_Leave(object sender, EventArgs e)
        {
            button3.BackColor = Color.FromArgb(20, 30, 54);
        }

        private void button1_Click(object sender, EventArgs e)
        {

            System.Windows.Forms.Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Home newform = new Home();
            this.Hide();
            newform.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Settings.Visible = true;
            Contact.Visible = false;
            pictureBox1.Visible = false;
            pictureBox2.Visible = false;
            pictureBox3.Visible = false;
            pictureBox4.Visible = true;
            lblDasshboard.Visible = false;
            lblAnalytics.Visible = false;
            lblContact.Visible = false;
            lblSettings.Show();
            Dashboard.Hide();
            Graph.Hide();
            pnlNav.Height = button3.Height;
            pnlNav.Top = button3.Top;
            pnlNav.Left = button3.Left;
            button3.BackColor = Color.FromArgb(46, 51, 73);
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            lblDasshboard.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void lblContact_Click(object sender, EventArgs e)
        {

        }

        private void Contact_Load(object sender, EventArgs e)
        {

        }

        private void Graph_Load(object sender, EventArgs e)
        {

        }

        private void Settings_Load(object sender, EventArgs e)
        {

        }
    }
}