namespace Time_Agotchi
{
    partial class APropos
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
            this.lbApropos = new System.Windows.Forms.Label();
            this.pbImgAPropos = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbImgAPropos)).BeginInit();
            this.SuspendLayout();
            // 
            // lbApropos
            // 
            this.lbApropos.AutoSize = true;
            this.lbApropos.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbApropos.ForeColor = System.Drawing.Color.BlanchedAlmond;
            this.lbApropos.Location = new System.Drawing.Point(12, 211);
            this.lbApropos.Name = "lbApropos";
            this.lbApropos.Size = new System.Drawing.Size(251, 170);
            this.lbApropos.TabIndex = 0;
            this.lbApropos.Text = "Time-Agotchi V.Pré-pré-pré-Alpha\r\n\r\nProjet inspiré par le film Time Out\r\n\r\nRéalis" +
                "é par : \r\n\r\nAnthony Da Rocha\r\nJuan Carlos Coyla\r\nAxel Evrard\r\nMeriem Djouama\r\n";
            // 
            // pbImgAPropos
            // 
            this.pbImgAPropos.Image = global::Time_Agotchi.Properties.Resources.ezgif_3077835043;
            this.pbImgAPropos.Location = new System.Drawing.Point(7, 12);
            this.pbImgAPropos.Name = "pbImgAPropos";
            this.pbImgAPropos.Size = new System.Drawing.Size(350, 175);
            this.pbImgAPropos.TabIndex = 1;
            this.pbImgAPropos.TabStop = false;
            // 
            // APropos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCoral;
            this.ClientSize = new System.Drawing.Size(360, 421);
            this.Controls.Add(this.pbImgAPropos);
            this.Controls.Add(this.lbApropos);
            this.Name = "APropos";
            this.Text = "APropos";
            ((System.ComponentModel.ISupportInitialize)(this.pbImgAPropos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbApropos;
        private System.Windows.Forms.PictureBox pbImgAPropos;
    }
}