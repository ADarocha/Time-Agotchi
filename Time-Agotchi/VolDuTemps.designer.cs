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
            this.VerifVivant = new System.Windows.Forms.Timer(this.components);
            this.pbAdversaire = new System.Windows.Forms.PictureBox();
            this.pbGifVoler = new System.Windows.Forms.PictureBox();
            this.lbTousMorts = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbAdversaire)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbGifVoler)).BeginInit();
            this.SuspendLayout();
            // 
            // cBVolDuTemps
            // 
            this.cBVolDuTemps.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.cBVolDuTemps.ForeColor = System.Drawing.Color.SpringGreen;
            this.cBVolDuTemps.FormattingEnabled = true;
            this.cBVolDuTemps.Location = new System.Drawing.Point(305, 82);
            this.cBVolDuTemps.Name = "cBVolDuTemps";
            this.cBVolDuTemps.Size = new System.Drawing.Size(121, 21);
            this.cBVolDuTemps.TabIndex = 0;
            this.cBVolDuTemps.SelectedIndexChanged += new System.EventHandler(this.cBVolDuTemps_SelectedIndexChanged);
            // 
            // lbInfoVol
            // 
            this.lbInfoVol.AutoSize = true;
            this.lbInfoVol.Font = new System.Drawing.Font("Quartz MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbInfoVol.ForeColor = System.Drawing.Color.SpringGreen;
            this.lbInfoVol.Location = new System.Drawing.Point(232, 29);
            this.lbInfoVol.Name = "lbInfoVol";
            this.lbInfoVol.Size = new System.Drawing.Size(294, 25);
            this.lbInfoVol.TabIndex = 1;
            this.lbInfoVol.Text = "Qui voulez-vous voler ?";
            // 
            // btVolDuTemps
            // 
            this.btVolDuTemps.Font = new System.Drawing.Font("Quartz MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btVolDuTemps.ForeColor = System.Drawing.Color.SpringGreen;
            this.btVolDuTemps.Location = new System.Drawing.Point(253, 209);
            this.btVolDuTemps.Name = "btVolDuTemps";
            this.btVolDuTemps.Size = new System.Drawing.Size(222, 50);
            this.btVolDuTemps.TabIndex = 2;
            this.btVolDuTemps.Text = "Voler du temps";
            this.btVolDuTemps.UseVisualStyleBackColor = true;
            this.btVolDuTemps.Click += new System.EventHandler(this.btVolDuTemps_Click);
            // 
            // btRetourMenu
            // 
            this.btRetourMenu.Font = new System.Drawing.Font("Quartz MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btRetourMenu.ForeColor = System.Drawing.Color.SpringGreen;
            this.btRetourMenu.Location = new System.Drawing.Point(270, 413);
            this.btRetourMenu.Name = "btRetourMenu";
            this.btRetourMenu.Size = new System.Drawing.Size(179, 50);
            this.btRetourMenu.TabIndex = 3;
            this.btRetourMenu.Text = "Retour au menu";
            this.btRetourMenu.UseVisualStyleBackColor = true;
            this.btRetourMenu.Click += new System.EventHandler(this.btRetourMenu_Click);
            // 
            // infoDuVol
            // 
            this.infoDuVol.AutoSize = true;
            this.infoDuVol.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.infoDuVol.ForeColor = System.Drawing.Color.SpringGreen;
            this.infoDuVol.Location = new System.Drawing.Point(265, 341);
            this.infoDuVol.Name = "infoDuVol";
            this.infoDuVol.Size = new System.Drawing.Size(202, 25);
            this.infoDuVol.TabIndex = 5;
            this.infoDuVol.Text = "REUSSI OU RATE";
            this.infoDuVol.Visible = false;
            // 
            // VerifVivant
            // 
            this.VerifVivant.Enabled = true;
            this.VerifVivant.Interval = 500;
            this.VerifVivant.Tick += new System.EventHandler(this.VerifVivant_Tick);
            // 
            // pbAdversaire
            // 
            this.pbAdversaire.Image = global::Time_Agotchi.Properties.Resources.Qui;
            this.pbAdversaire.Location = new System.Drawing.Point(29, 82);
            this.pbAdversaire.Name = "pbAdversaire";
            this.pbAdversaire.Size = new System.Drawing.Size(154, 207);
            this.pbAdversaire.TabIndex = 4;
            this.pbAdversaire.TabStop = false;
            // 
            // pbGifVoler
            // 
            this.pbGifVoler.Image = global::Time_Agotchi.Properties.Resources.GIF_Voleur;
            this.pbGifVoler.Location = new System.Drawing.Point(524, 82);
            this.pbGifVoler.Name = "pbGifVoler";
            this.pbGifVoler.Size = new System.Drawing.Size(200, 200);
            this.pbGifVoler.TabIndex = 6;
            this.pbGifVoler.TabStop = false;
            // 
            // lbTousMorts
            // 
            this.lbTousMorts.AutoSize = true;
            this.lbTousMorts.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTousMorts.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbTousMorts.Location = new System.Drawing.Point(189, 316);
            this.lbTousMorts.Name = "lbTousMorts";
            this.lbTousMorts.Size = new System.Drawing.Size(377, 75);
            this.lbTousMorts.TabIndex = 7;
            this.lbTousMorts.Text = "          En arrivant en ville,\r\n     vous vous rendez compte\r\nque vous êtes le d" +
                "ernier survivant.";
            this.lbTousMorts.Visible = false;
            // 
            // VolDuTemps
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlText;
            this.ClientSize = new System.Drawing.Size(753, 490);
            this.Controls.Add(this.lbTousMorts);
            this.Controls.Add(this.pbGifVoler);
            this.Controls.Add(this.infoDuVol);
            this.Controls.Add(this.pbAdversaire);
            this.Controls.Add(this.btRetourMenu);
            this.Controls.Add(this.btVolDuTemps);
            this.Controls.Add(this.lbInfoVol);
            this.Controls.Add(this.cBVolDuTemps);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "VolDuTemps";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Load += new System.EventHandler(this.VolDuTemps_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbAdversaire)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbGifVoler)).EndInit();
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
        private System.Windows.Forms.PictureBox pbGifVoler;
        private System.Windows.Forms.Label lbTousMorts;
    }
}