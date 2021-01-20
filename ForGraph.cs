using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace VPProject
{
    public partial class ForGraph : UserControl
    {
        public double x, y,z;
        public double recRate, fatRate;
        //public FrameType FrameType { get; set; }
        public ForGraph()
        {
            
            //circularProgressBar1.BackColor = Color.FromArgb(100, 0, 0, 0);
            //circularProgressBar2.BackColor = Color.FromArgb(100, 0, 0, 0);
           
            InitializeComponent();
        }
        public ForGraph(double a,double b, double c)
        {
            x = a;
            y = b;
            z = c;

        }
        public double getRecoveryRate()
        {
            this.recRate = ((x / y) * 100);
            return Math.Round(recRate);

        }

        public double getFatalityRate()
        {
            this.fatRate = ((z / y) * 100);
            return Math.Round(fatRate);

        }

        private void ForGraph_Load(object sender, EventArgs e)
        {
            /*
            recoverBar.Value = Convert.ToInt32(getRecoveryRate());
            recoverBar.Text = recRate + "%";*/
        }

        private void circularProgressBar1_Click(object sender, EventArgs e)
        {

        }
    }
}
