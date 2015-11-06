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
            this.SuspendLayout();
            // 
            // lbMort
            // 
            this.lbMort.AutoSize = true;
            this.lbMort.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMort.ForeColor = System.Drawing.Color.Red;
            this.lbMort.Location = new System.Drawing.Point(12, 9);
            this.lbMort.Name = "lbMort";
            this.lbMort.Size = new System.Drawing.Size(163, 60);
            this.lbMort.TabIndex = 0;
            this.lbMort.Text = "         Perdu !\r\n\r\nVous êtes mort(e) !";
            // 
            // btFermer
            // 
            this.btFermer.Location = new System.Drawing.Point(37, 95);
            this.btFermer.Name = "btFermer";
            this.btFermer.Size = new System.Drawing.Size(115, 42);
            this.btFermer.TabIndex = 1;
            this.btFermer.Text = "Fermer le jeu";
            this.btFermer.UseVisualStyleBackColor = true;
            this.btFermer.Click += new System.EventHandler(this.btFermer_Click);
            // 
            // Mort
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(197, 163);
            this.Controls.Add(this.btFermer);
            this.Controls.Add(this.lbMort);
            this.Name = "Mort";
            this.Text = "Mort";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbMort;
        private System.Windows.Forms.Button btFermer;
    }
}