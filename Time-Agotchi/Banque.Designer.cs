﻿namespace Time_Agotchi
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
            this.btPlacer = new System.Windows.Forms.Button();
            this.lbTempsPlace = new System.Windows.Forms.Label();
            this.timerPlacement = new System.Windows.Forms.Timer(this.components);
            this.tbSecPlacement = new System.Windows.Forms.TextBox();
            this.btRecup = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btFermer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btPlacer
            // 
            this.btPlacer.Location = new System.Drawing.Point(276, 121);
            this.btPlacer.Name = "btPlacer";
            this.btPlacer.Size = new System.Drawing.Size(75, 23);
            this.btPlacer.TabIndex = 0;
            this.btPlacer.Text = "Placer";
            this.btPlacer.UseVisualStyleBackColor = true;
            this.btPlacer.Click += new System.EventHandler(this.btPlacer_Click);
            // 
            // lbTempsPlace
            // 
            this.lbTempsPlace.AutoSize = true;
            this.lbTempsPlace.Location = new System.Drawing.Point(65, 50);
            this.lbTempsPlace.Name = "lbTempsPlace";
            this.lbTempsPlace.Size = new System.Drawing.Size(64, 13);
            this.lbTempsPlace.TabIndex = 2;
            this.lbTempsPlace.Text = "temps placé";
            this.lbTempsPlace.Visible = false;
            // 
            // timerPlacement
            // 
            this.timerPlacement.Interval = 60000;
            this.timerPlacement.Tick += new System.EventHandler(this.timerPlacement_Tick);
            // 
            // tbSecPlacement
            // 
            this.tbSecPlacement.Location = new System.Drawing.Point(196, 123);
            this.tbSecPlacement.Name = "tbSecPlacement";
            this.tbSecPlacement.Size = new System.Drawing.Size(62, 20);
            this.tbSecPlacement.TabIndex = 3;
            // 
            // btRecup
            // 
            this.btRecup.Location = new System.Drawing.Point(24, 345);
            this.btRecup.Name = "btRecup";
            this.btRecup.Size = new System.Drawing.Size(143, 43);
            this.btRecup.TabIndex = 4;
            this.btRecup.Text = "Récuperer le temps";
            this.btRecup.UseVisualStyleBackColor = true;
            this.btRecup.Click += new System.EventHandler(this.btRecup_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 126);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Temps à placer (en secondes) :";
            this.label1.Visible = false;
            // 
            // btFermer
            // 
            this.btFermer.Location = new System.Drawing.Point(603, 363);
            this.btFermer.Name = "btFermer";
            this.btFermer.Size = new System.Drawing.Size(71, 25);
            this.btFermer.TabIndex = 6;
            this.btFermer.Text = "Fermer";
            this.btFermer.UseVisualStyleBackColor = true;
            this.btFermer.Click += new System.EventHandler(this.btFermer_Click);
            // 
            // Banque
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(686, 400);
            this.Controls.Add(this.btFermer);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btRecup);
            this.Controls.Add(this.tbSecPlacement);
            this.Controls.Add(this.lbTempsPlace);
            this.Controls.Add(this.btPlacer);
            this.Name = "Banque";
            this.Text = "Banque";
            this.Load += new System.EventHandler(this.Banque_Load);
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
    }
}