namespace Time_Agotchi
{
    partial class Mort
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
            this.lbMort = new System.Windows.Forms.Label();
            this.btFermer = new System.Windows.Forms.Button();
            this.pbMort = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbMort)).BeginInit();
            this.SuspendLayout();
            // 
            // lbMort
            // 
            this.lbMort.AutoSize = true;
            this.lbMort.BackColor = System.Drawing.SystemColors.ControlText;
            this.lbMort.Font = new System.Drawing.Font("Quartz MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMort.ForeColor = System.Drawing.Color.SpringGreen;
            this.lbMort.Location = new System.Drawing.Point(141, 9);
            this.lbMort.Name = "lbMort";
            this.lbMort.Size = new System.Drawing.Size(191, 57);
            this.lbMort.TabIndex = 0;
            this.lbMort.Text = "         Perdu !\r\n\r\nVous etes mort(e) !";
            // 
            // btFermer
            // 
            this.btFermer.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btFermer.Font = new System.Drawing.Font("Quartz MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btFermer.ForeColor = System.Drawing.Color.SpringGreen;
            this.btFermer.Location = new System.Drawing.Point(171, 278);
            this.btFermer.Name = "btFermer";
            this.btFermer.Size = new System.Drawing.Size(115, 61);
            this.btFermer.TabIndex = 1;
            this.btFermer.Text = "Fermer le jeu";
            this.btFermer.UseVisualStyleBackColor = false;
            this.btFermer.Click += new System.EventHandler(this.btFermer_Click);
            // 
            // pbMort
            // 
            this.pbMort.BackgroundImage = global::Time_Agotchi.Properties.Resources.Img_Mort;
            this.pbMort.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbMort.Location = new System.Drawing.Point(132, 86);
            this.pbMort.Name = "pbMort";
            this.pbMort.Size = new System.Drawing.Size(211, 166);
            this.pbMort.TabIndex = 2;
            this.pbMort.TabStop = false;
            // 
            // Mort
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlText;
            this.ClientSize = new System.Drawing.Size(475, 371);
            this.Controls.Add(this.pbMort);
            this.Controls.Add(this.btFermer);
            this.Controls.Add(this.lbMort);
            this.Name = "Mort";
            this.Text = "Mort";
            ((System.ComponentModel.ISupportInitialize)(this.pbMort)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbMort;
        private System.Windows.Forms.Button btFermer;
        private System.Windows.Forms.PictureBox pbMort;
    }
}