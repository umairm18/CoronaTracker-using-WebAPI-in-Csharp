
namespace VPProject
{
    partial class ForDashboard
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ForDashboard));
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.lbldeaths = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lblrecovered = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblconfirmed = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.fatalityBar = new CircularProgressBar.CircularProgressBar();
            this.recoverBar = new CircularProgressBar.CircularProgressBar();
            this.panel2.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            resources.ApplyResources(this.comboBox1, "comboBox1");
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.label1.Name = "label1";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.panel3);
            resources.ApplyResources(this.panel2, "panel2");
            this.panel2.Name = "panel2";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.panel5.Controls.Add(this.lbldeaths);
            this.panel5.Controls.Add(this.label6);
            resources.ApplyResources(this.panel5, "panel5");
            this.panel5.Name = "panel5";
            this.panel5.Paint += new System.Windows.Forms.PaintEventHandler(this.panel5_Paint);
            // 
            // lbldeaths
            // 
            resources.ApplyResources(this.lbldeaths, "lbldeaths");
            this.lbldeaths.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.lbldeaths.Name = "lbldeaths";
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.label6.Name = "label6";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.panel4.Controls.Add(this.lblrecovered);
            this.panel4.Controls.Add(this.label5);
            resources.ApplyResources(this.panel4, "panel4");
            this.panel4.Name = "panel4";
            // 
            // lblrecovered
            // 
            resources.ApplyResources(this.lblrecovered, "lblrecovered");
            this.lblrecovered.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.lblrecovered.Name = "lblrecovered";
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.label5.Name = "label5";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.panel3.Controls.Add(this.lblconfirmed);
            this.panel3.Controls.Add(this.label4);
            resources.ApplyResources(this.panel3, "panel3");
            this.panel3.Name = "panel3";
            // 
            // lblconfirmed
            // 
            resources.ApplyResources(this.lblconfirmed, "lblconfirmed");
            this.lblconfirmed.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.lblconfirmed.Name = "lblconfirmed";
            this.lblconfirmed.Click += new System.EventHandler(this.lblconfirmed_Click_1);
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.label4.Name = "label4";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.fatalityBar);
            this.panel1.Controls.Add(this.recoverBar);
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.label3.Name = "label3";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.label2.Name = "label2";
            // 
            // fatalityBar
            // 
            resources.ApplyResources(this.fatalityBar, "fatalityBar");
            this.fatalityBar.AnimationFunction = ((WinFormAnimation.AnimationFunctions.Function)(resources.GetObject("fatalityBar.AnimationFunction")));
            this.fatalityBar.AnimationSpeed = 500;
            this.fatalityBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.fatalityBar.ForeColor = System.Drawing.Color.White;
            this.fatalityBar.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.fatalityBar.InnerMargin = 2;
            this.fatalityBar.InnerWidth = -1;
            this.fatalityBar.MarqueeAnimationSpeed = 2000;
            this.fatalityBar.Name = "fatalityBar";
            this.fatalityBar.OuterColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.fatalityBar.OuterMargin = -25;
            this.fatalityBar.OuterWidth = 26;
            this.fatalityBar.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.fatalityBar.ProgressWidth = 10;
            this.fatalityBar.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 36F);
            this.fatalityBar.StartAngle = 270;
            this.fatalityBar.SubscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.fatalityBar.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.fatalityBar.SubscriptText = "";
            this.fatalityBar.SuperscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.fatalityBar.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.fatalityBar.SuperscriptText = "";
            this.fatalityBar.TextMargin = new System.Windows.Forms.Padding(5, 8, 0, 0);
            this.fatalityBar.Value = 5;
            this.fatalityBar.Click += new System.EventHandler(this.fatalityBar_Click);
            // 
            // recoverBar
            // 
            resources.ApplyResources(this.recoverBar, "recoverBar");
            this.recoverBar.AnimationFunction = ((WinFormAnimation.AnimationFunctions.Function)(resources.GetObject("recoverBar.AnimationFunction")));
            this.recoverBar.AnimationSpeed = 500;
            this.recoverBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.recoverBar.ForeColor = System.Drawing.Color.White;
            this.recoverBar.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.recoverBar.InnerMargin = 2;
            this.recoverBar.InnerWidth = -1;
            this.recoverBar.MarqueeAnimationSpeed = 2000;
            this.recoverBar.Name = "recoverBar";
            this.recoverBar.OuterColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.recoverBar.OuterMargin = -25;
            this.recoverBar.OuterWidth = 26;
            this.recoverBar.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.recoverBar.ProgressWidth = 10;
            this.recoverBar.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 36F);
            this.recoverBar.StartAngle = 270;
            this.recoverBar.SubscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.recoverBar.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.recoverBar.SubscriptText = "";
            this.recoverBar.SuperscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.recoverBar.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.recoverBar.SuperscriptText = "";
            this.recoverBar.TextMargin = new System.Windows.Forms.Padding(5, 8, 0, 0);
            this.recoverBar.Value = 95;
            this.recoverBar.Click += new System.EventHandler(this.recoverBar_Click);
            // 
            // ForDashboard
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Name = "ForDashboard";
            this.Load += new System.EventHandler(this.ForDashboard_Load);
            this.panel2.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label lbldeaths;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblrecovered;
        private System.Windows.Forms.Label lblconfirmed;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private CircularProgressBar.CircularProgressBar fatalityBar;
        private CircularProgressBar.CircularProgressBar recoverBar;
    }
}
