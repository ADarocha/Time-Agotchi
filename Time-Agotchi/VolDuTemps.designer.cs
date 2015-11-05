namespace Time_Agotchi
{
    partial class VolDuTemps
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
            this.cBVolDuTemps = new System.Windows.Forms.ComboBox();
            this.lbInfoVol = new System.Windows.Forms.Label();
            this.btVolDuTemps = new System.Windows.Forms.Button();
            this.btRetourMenu = new System.Windows.Forms.Button();
            this.infoDuVol = new System.Windows.Forms.Label();
            this.pbAdversaire = new System.Windows.Forms.PictureBox();
            this.VerifVivant = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pbAdversaire)).BeginInit();
            this.SuspendLayout();
            // 
            // cBVolDuTemps
            // 
            this.cBVolDuTemps.FormattingEnabled = true;
            this.cBVolDuTemps.Items.AddRange(new object[] {
            "Tama",
            "Got",
            "Chi"});
            this.cBVolDuTemps.Location = new System.Drawing.Point(277, 82);
            this.cBVolDuTemps.Name = "cBVolDuTemps";
            this.cBVolDuTemps.Size = new System.Drawing.Size(121, 21);
            this.cBVolDuTemps.TabIndex = 0;
            this.cBVolDuTemps.SelectedIndexChanged += new System.EventHandler(this.cBVolDuTemps_SelectedIndexChanged);
            // 
            // lbInfoVol
            // 
            this.lbInfoVol.AutoSize = true;
            this.lbInfoVol.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbInfoVol.Location = new System.Drawing.Point(137, 29);
            this.lbInfoVol.Name = "lbInfoVol";
            this.lbInfoVol.Size = new System.Drawing.Size(261, 25);
            this.lbInfoVol.TabIndex = 1;
            this.lbInfoVol.Text = "Qui voulez-vous voler ?";
            // 
            // btVolDuTemps
            // 
            this.btVolDuTemps.Location = new System.Drawing.Point(278, 232);
            this.btVolDuTemps.Name = "btVolDuTemps";
            this.btVolDuTemps.Size = new System.Drawing.Size(120, 50);
            this.btVolDuTemps.TabIndex = 2;
            this.btVolDuTemps.Text = "Voler du temps";
            this.btVolDuTemps.UseVisualStyleBackColor = true;
            this.btVolDuTemps.Click += new System.EventHandler(this.btVolDuTemps_Click);
            // 
            // btRetourMenu
            // 
            this.btRetourMenu.Location = new System.Drawing.Point(352, 399);
            this.btRetourMenu.Name = "btRetourMenu";
            this.btRetourMenu.Size = new System.Drawing.Size(120, 50);
            this.btRetourMenu.TabIndex = 3;
            this.btRetourMenu.Text = "Retour au menu";
            this.btRetourMenu.UseVisualStyleBackColor = true;
            this.btRetourMenu.Click += new System.EventHandler(this.btRetourMenu_Click);
            // 
            // infoDuVol
            // 
            this.infoDuVol.AutoSize = true;
            this.infoDuVol.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.infoDuVol.Location = new System.Drawing.Point(49, 337);
            this.infoDuVol.Name = "infoDuVol";
            this.infoDuVol.Size = new System.Drawing.Size(391, 25);
            this.infoDuVol.TabIndex = 5;
            this.infoDuVol.Text = "Ici on verra si le vol a réussi ou raté";
            this.infoDuVol.Visible = false;
            // 
            // pbAdversaire
            // 
            this.pbAdversaire.Location = new System.Drawing.Point(54, 82);
            this.pbAdversaire.Name = "pbAdversaire";
            this.pbAdversaire.Size = new System.Drawing.Size(150, 200);
            this.pbAdversaire.TabIndex = 4;
            this.pbAdversaire.TabStop = false;
            // 
            // VerifVivant
            // 
            this.VerifVivant.Interval = 5000;
            this.VerifVivant.Tick += new System.EventHandler(this.VerifVivant_Tick);
            // 
            // VolDuTemps
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 461);
            this.Controls.Add(this.infoDuVol);
            this.Controls.Add(this.pbAdversaire);
            this.Controls.Add(this.btRetourMenu);
            this.Controls.Add(this.btVolDuTemps);
            this.Controls.Add(this.lbInfoVol);
            this.Controls.Add(this.cBVolDuTemps);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "VolDuTemps";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.VolDuTemps_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbAdversaire)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cBVolDuTemps;
        private System.Windows.Forms.Label lbInfoVol;
        private System.Windows.Forms.Button btVolDuTemps;
        private System.Windows.Forms.Button btRetourMenu;
        private System.Windows.Forms.PictureBox pbAdversaire;
        private System.Windows.Forms.Label infoDuVol;
        private System.Windows.Forms.Timer VerifVivant;
    }
}