namespace Time_Agotchi
{
    partial class Banque
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Banque));
            this.btPlacer = new System.Windows.Forms.Button();
            this.lbTempsPlace = new System.Windows.Forms.Label();
            this.timerPlacement = new System.Windows.Forms.Timer(this.components);
            this.tbSecPlacement = new System.Windows.Forms.TextBox();
            this.btRecup = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btFermer = new System.Windows.Forms.Button();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.lbTaux = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // btPlacer
            // 
            this.btPlacer.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btPlacer.ForeColor = System.Drawing.Color.SpringGreen;
            this.btPlacer.Location = new System.Drawing.Point(486, 42);
            this.btPlacer.Name = "btPlacer";
            this.btPlacer.Size = new System.Drawing.Size(99, 45);
            this.btPlacer.TabIndex = 0;
            this.btPlacer.Text = "Placer";
            this.btPlacer.UseVisualStyleBackColor = true;
            this.btPlacer.Click += new System.EventHandler(this.btPlacer_Click);
            // 
            // lbTempsPlace
            // 
            this.lbTempsPlace.AutoSize = true;
            this.lbTempsPlace.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTempsPlace.ForeColor = System.Drawing.Color.SpringGreen;
            this.lbTempsPlace.Location = new System.Drawing.Point(228, 263);
            this.lbTempsPlace.Name = "lbTempsPlace";
            this.lbTempsPlace.Size = new System.Drawing.Size(144, 29);
            this.lbTempsPlace.TabIndex = 2;
            this.lbTempsPlace.Text = "temps place";
            this.lbTempsPlace.Visible = false;
            // 
            // timerPlacement
            // 
            this.timerPlacement.Interval = 60000;
            this.timerPlacement.Tick += new System.EventHandler(this.timerPlacement_Tick);
            // 
            // tbSecPlacement
            // 
            this.tbSecPlacement.Location = new System.Drawing.Point(365, 56);
            this.tbSecPlacement.Name = "tbSecPlacement";
            this.tbSecPlacement.Size = new System.Drawing.Size(86, 20);
            this.tbSecPlacement.TabIndex = 3;
            // 
            // btRecup
            // 
            this.btRecup.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btRecup.ForeColor = System.Drawing.Color.SpringGreen;
            this.btRecup.Location = new System.Drawing.Point(12, 336);
            this.btRecup.Name = "btRecup";
            this.btRecup.Size = new System.Drawing.Size(143, 60);
            this.btRecup.TabIndex = 4;
            this.btRecup.Text = "Recuperer le temps";
            this.btRecup.UseVisualStyleBackColor = true;
            this.btRecup.Click += new System.EventHandler(this.btRecup_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.SpringGreen;
            this.label1.Location = new System.Drawing.Point(27, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(278, 24);
            this.label1.TabIndex = 5;
            this.label1.Text = "Temps a placer (en secondes) :";
            // 
            // btFermer
            // 
            this.btFermer.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btFermer.ForeColor = System.Drawing.Color.SpringGreen;
            this.btFermer.Location = new System.Drawing.Point(486, 336);
            this.btFermer.Name = "btFermer";
            this.btFermer.Size = new System.Drawing.Size(99, 54);
            this.btFermer.TabIndex = 6;
            this.btFermer.Text = "Fermer";
            this.btFermer.UseVisualStyleBackColor = true;
            this.btFermer.Click += new System.EventHandler(this.btFermer_Click);
            // 
            // pbLogo
            // 
            this.pbLogo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbLogo.BackgroundImage")));
            this.pbLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbLogo.Location = new System.Drawing.Point(249, 128);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(143, 121);
            this.pbLogo.TabIndex = 7;
            this.pbLogo.TabStop = false;
            // 
            // lbTaux
            // 
            this.lbTaux.AutoSize = true;
            this.lbTaux.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTaux.ForeColor = System.Drawing.Color.SpringGreen;
            this.lbTaux.Location = new System.Drawing.Point(12, 94);
            this.lbTaux.Name = "lbTaux";
            this.lbTaux.Size = new System.Drawing.Size(266, 48);
            this.lbTaux.TabIndex = 8;
            this.lbTaux.Text = "Taux du livret T : 10%\r\nActualisation à chaque minute.";
            // 
            // Banque
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlText;
            this.ClientSize = new System.Drawing.Size(641, 457);
            this.Controls.Add(this.lbTaux);
            this.Controls.Add(this.pbLogo);
            this.Controls.Add(this.btFermer);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btRecup);
            this.Controls.Add(this.tbSecPlacement);
            this.Controls.Add(this.lbTempsPlace);
            this.Controls.Add(this.btPlacer);
            this.Name = "Banque";
            this.Text = "Banque";
            this.Load += new System.EventHandler(this.Banque_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btPlacer;
        private System.Windows.Forms.Label lbTempsPlace;
        private System.Windows.Forms.Timer timerPlacement;
        private System.Windows.Forms.TextBox tbSecPlacement;
        private System.Windows.Forms.Button btRecup;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btFermer;
        private System.Windows.Forms.PictureBox pbLogo;
        private System.Windows.Forms.Label lbTaux;
    }
}