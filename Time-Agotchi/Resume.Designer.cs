namespace Time_Agotchi
{
    partial class Resume
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
            this.lbTama = new System.Windows.Forms.Label();
            this.lbGot = new System.Windows.Forms.Label();
            this.lbChi = new System.Windows.Forms.Label();
            this.lbAxel = new System.Windows.Forms.Label();
            this.lbTempsTama = new System.Windows.Forms.Label();
            this.lbTempsGot = new System.Windows.Forms.Label();
            this.lbTempsChi = new System.Windows.Forms.Label();
            this.lbTempsAxel = new System.Windows.Forms.Label();
            this.timerAffichage = new System.Windows.Forms.Timer(this.components);
            this.lbResume = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbTama
            // 
            this.lbTama.AutoSize = true;
            this.lbTama.Location = new System.Drawing.Point(72, 56);
            this.lbTama.Name = "lbTama";
            this.lbTama.Size = new System.Drawing.Size(34, 13);
            this.lbTama.TabIndex = 0;
            this.lbTama.Text = "Tama";
            // 
            // lbGot
            // 
            this.lbGot.AutoSize = true;
            this.lbGot.Location = new System.Drawing.Point(72, 93);
            this.lbGot.Name = "lbGot";
            this.lbGot.Size = new System.Drawing.Size(24, 13);
            this.lbGot.TabIndex = 1;
            this.lbGot.Text = "Got";
            // 
            // lbChi
            // 
            this.lbChi.AutoSize = true;
            this.lbChi.Location = new System.Drawing.Point(72, 131);
            this.lbChi.Name = "lbChi";
            this.lbChi.Size = new System.Drawing.Size(22, 13);
            this.lbChi.TabIndex = 2;
            this.lbChi.Text = "Chi";
            // 
            // lbAxel
            // 
            this.lbAxel.AutoSize = true;
            this.lbAxel.Location = new System.Drawing.Point(72, 170);
            this.lbAxel.Name = "lbAxel";
            this.lbAxel.Size = new System.Drawing.Size(27, 13);
            this.lbAxel.TabIndex = 3;
            this.lbAxel.Text = "Axel";
            // 
            // lbTempsTama
            // 
            this.lbTempsTama.AutoSize = true;
            this.lbTempsTama.Location = new System.Drawing.Point(134, 56);
            this.lbTempsTama.Name = "lbTempsTama";
            this.lbTempsTama.Size = new System.Drawing.Size(39, 13);
            this.lbTempsTama.TabIndex = 4;
            this.lbTempsTama.Text = "Temps";
            // 
            // lbTempsGot
            // 
            this.lbTempsGot.AutoSize = true;
            this.lbTempsGot.Location = new System.Drawing.Point(134, 93);
            this.lbTempsGot.Name = "lbTempsGot";
            this.lbTempsGot.Size = new System.Drawing.Size(39, 13);
            this.lbTempsGot.TabIndex = 5;
            this.lbTempsGot.Text = "Temps";
            // 
            // lbTempsChi
            // 
            this.lbTempsChi.AutoSize = true;
            this.lbTempsChi.Location = new System.Drawing.Point(134, 131);
            this.lbTempsChi.Name = "lbTempsChi";
            this.lbTempsChi.Size = new System.Drawing.Size(39, 13);
            this.lbTempsChi.TabIndex = 6;
            this.lbTempsChi.Text = "Temps";
            // 
            // lbTempsAxel
            // 
            this.lbTempsAxel.AutoSize = true;
            this.lbTempsAxel.Location = new System.Drawing.Point(134, 170);
            this.lbTempsAxel.Name = "lbTempsAxel";
            this.lbTempsAxel.Size = new System.Drawing.Size(39, 13);
            this.lbTempsAxel.TabIndex = 7;
            this.lbTempsAxel.Text = "Temps";
            // 
            // timerAffichage
            // 
            this.timerAffichage.Enabled = true;
            this.timerAffichage.Interval = 1000;
            this.timerAffichage.Tick += new System.EventHandler(this.timerAffichage_Tick);
            // 
            // lbResume
            // 
            this.lbResume.AutoSize = true;
            this.lbResume.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbResume.Location = new System.Drawing.Point(12, 21);
            this.lbResume.Name = "lbResume";
            this.lbResume.Size = new System.Drawing.Size(240, 16);
            this.lbResume.TabIndex = 8;
            this.lbResume.Text = "Temps restant des personnages :";
            // 
            // Resume
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(270, 216);
            this.Controls.Add(this.lbResume);
            this.Controls.Add(this.lbTempsAxel);
            this.Controls.Add(this.lbTempsChi);
            this.Controls.Add(this.lbTempsGot);
            this.Controls.Add(this.lbTempsTama);
            this.Controls.Add(this.lbAxel);
            this.Controls.Add(this.lbChi);
            this.Controls.Add(this.lbGot);
            this.Controls.Add(this.lbTama);
            this.Name = "Resume";
            this.Text = "Resume";
            this.Load += new System.EventHandler(this.Resume_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbTama;
        private System.Windows.Forms.Label lbGot;
        private System.Windows.Forms.Label lbChi;
        private System.Windows.Forms.Label lbAxel;
        private System.Windows.Forms.Label lbTempsTama;
        private System.Windows.Forms.Label lbTempsGot;
        private System.Windows.Forms.Label lbTempsChi;
        private System.Windows.Forms.Label lbTempsAxel;
        private System.Windows.Forms.Timer timerAffichage;
        private System.Windows.Forms.Label lbResume;
    }
}