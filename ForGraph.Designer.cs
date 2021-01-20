
namespace VPProject
{
    partial class ForGraph
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ForGraph));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.fatalityBar = new CircularProgressBar.CircularProgressBar();
            this.recoverBar = new CircularProgressBar.CircularProgressBar();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.fatalityBar);
            this.panel1.Controls.Add(this.recoverBar);
            this.panel1.Location = new System.Drawing.Point(46, 43);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(732, 368);
            this.panel1.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.label3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label3.Location = new System.Drawing.Point(493, 320);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "Fatality Rate";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(118, 320);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "Recovery Rate";
            // 
            // fatalityBar
            // 
            this.fatalityBar.AnimationFunction = ((WinFormAnimation.AnimationFunctions.Function)(resources.GetObject("fatalityBar.AnimationFunction")));
            this.fatalityBar.AnimationSpeed = 500;
            this.fatalityBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.fatalityBar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 35F);
            this.fatalityBar.ForeColor = System.Drawing.Color.White;
            this.fatalityBar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.fatalityBar.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.fatalityBar.InnerMargin = 2;
            this.fatalityBar.InnerWidth = -1;
            this.fatalityBar.Location = new System.Drawing.Point(405, 26);
            this.fatalityBar.MarqueeAnimationSpeed = 2000;
            this.fatalityBar.Name = "fatalityBar";
            this.fatalityBar.OuterColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.fatalityBar.OuterMargin = -25;
            this.fatalityBar.OuterWidth = 26;
            this.fatalityBar.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.fatalityBar.ProgressWidth = 10;
            this.fatalityBar.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 36F);
            this.fatalityBar.Size = new System.Drawing.Size(290, 277);
            this.fatalityBar.StartAngle = 270;
            this.fatalityBar.SubscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.fatalityBar.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.fatalityBar.SubscriptText = "";
            this.fatalityBar.SuperscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.fatalityBar.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.fatalityBar.SuperscriptText = "";
            this.fatalityBar.TabIndex = 8;
            this.fatalityBar.Text = "5%";
            this.fatalityBar.TextMargin = new System.Windows.Forms.Padding(5, 8, 0, 0);
            this.fatalityBar.Value = 5;
            // 
            // recoverBar
            // 
            this.recoverBar.AnimationFunction = ((WinFormAnimation.AnimationFunctions.Function)(resources.GetObject("recoverBar.AnimationFunction")));
            this.recoverBar.AnimationSpeed = 500;
            this.recoverBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.recoverBar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 35F);
            this.recoverBar.ForeColor = System.Drawing.Color.White;
            this.recoverBar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.recoverBar.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.recoverBar.InnerMargin = 2;
            this.recoverBar.InnerWidth = -1;
            this.recoverBar.Location = new System.Drawing.Point(36, 24);
            this.recoverBar.MarqueeAnimationSpeed = 2000;
            this.recoverBar.Name = "recoverBar";
            this.recoverBar.OuterColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.recoverBar.OuterMargin = -25;
            this.recoverBar.OuterWidth = 26;
            this.recoverBar.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.recoverBar.ProgressWidth = 10;
            this.recoverBar.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 36F);
            this.recoverBar.Size = new System.Drawing.Size(290, 279);
            this.recoverBar.StartAngle = 270;
            this.recoverBar.SubscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.recoverBar.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.recoverBar.SubscriptText = "";
            this.recoverBar.SuperscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.recoverBar.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.recoverBar.SuperscriptText = "";
            this.recoverBar.TabIndex = 8;
            this.recoverBar.Text = "95%";
            this.recoverBar.TextMargin = new System.Windows.Forms.Padding(5, 8, 0, 0);
            this.recoverBar.Value = 50;
            this.recoverBar.Click += new System.EventHandler(this.circularProgressBar1_Click);
            // 
            // ForGraph
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.Controls.Add(this.panel1);
            this.Name = "ForGraph";
            this.Size = new System.Drawing.Size(841, 450);
            this.Load += new System.EventHandler(this.ForGraph_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private CircularProgressBar.CircularProgressBar fatalityBar;
        private CircularProgressBar.CircularProgressBar recoverBar;
    }
}
