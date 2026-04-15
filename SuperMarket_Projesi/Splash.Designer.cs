
namespace SuperMarket_Projesi
{
    partial class Splash
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Splash));
            this.label3 = new System.Windows.Forms.Label();
            this.Myprogress = new Bunifu.Framework.UI.BunifuProgressBar();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.DarkOrange;
            resources.ApplyResources(this.label3, "label3");
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Name = "label3";
            // 
            // Myprogress
            // 
            this.Myprogress.BackColor = System.Drawing.Color.DarkOrange;
            this.Myprogress.BorderRadius = 5;
            this.Myprogress.ForeColor = System.Drawing.SystemColors.ControlText;
            resources.ApplyResources(this.Myprogress, "Myprogress");
            this.Myprogress.MaximumValue = 100;
            this.Myprogress.Name = "Myprogress";
            this.Myprogress.ProgressColor = System.Drawing.Color.White;
            this.Myprogress.Value = 0;
            this.Myprogress.progressChanged += new System.EventHandler(this.Myprogress_progressChanged);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.DarkOrange;
            resources.ApplyResources(this.label1, "label1");
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Name = "label1";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SuperMarket_Projesi.Properties.Resources._1638132876554;
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Splash
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkOrange;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Myprogress);
            this.Controls.Add(this.label3);
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Name = "Splash";
            this.Load += new System.EventHandler(this.Splash_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private Bunifu.Framework.UI.BunifuProgressBar Myprogress;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}