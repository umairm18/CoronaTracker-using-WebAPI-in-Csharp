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
    public partial class ForContact : UserControl
    {
        public ForContact()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            linkLabel1.LinkVisited = true;
            System.Diagnostics.Process.Start("mailto:01-131182-027@student.bahria.edu.pk");
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            linkLabel2.LinkVisited = true;
            System.Diagnostics.Process.Start("mailto:01-131182-003@student.bahria.edu.pk");
        }

        private void linkLabel1_Leave(object sender, EventArgs e)
        {
          //  linkLabel1.VisitedLinkColor = Color.White;
        }

        private void linkLabel2_Leave(object sender, EventArgs e)
        {
           //linkLabel2.VisitedLinkColor = Color.White;
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            linkLabel3.LinkVisited = true;
            System.Diagnostics.Process.Start("https://github.com/abdul-raouf");
        }

        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            linkLabel4.LinkVisited = true;
            System.Diagnostics.Process.Start("https://github.com/umairm18");
        }
    }
}
