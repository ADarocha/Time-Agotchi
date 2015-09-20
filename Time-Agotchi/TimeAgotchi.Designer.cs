namespace Time_Agotchi
{
    partial class Timeagotchi
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aProposToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbNomPerso = new System.Windows.Forms.Label();
            this.gbStatus = new System.Windows.Forms.GroupBox();
            this.lbSoif = new System.Windows.Forms.Label();
            this.lbFaim = new System.Windows.Forms.Label();
            this.lbAge = new System.Windows.Forms.Label();
            this.lbNom = new System.Windows.Forms.Label();
            this.lbAgePerso = new System.Windows.Forms.Label();
            this.pbSoifPerso = new System.Windows.Forms.ProgressBar();
            this.pbFaimPerso = new System.Windows.Forms.ProgressBar();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.gbStatus.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.optionsToolStripMenuItem,
            this.aProposToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(684, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.optionsToolStripMenuItem.Text = "Options";
            // 
            // aProposToolStripMenuItem
            // 
            this.aProposToolStripMenuItem.Name = "aProposToolStripMenuItem";
            this.aProposToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.aProposToolStripMenuItem.Text = "A propos";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(247, 199);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(166, 160);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // lbNomPerso
            // 
            this.lbNomPerso.AutoSize = true;
            this.lbNomPerso.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNomPerso.Location = new System.Drawing.Point(103, 16);
            this.lbNomPerso.Name = "lbNomPerso";
            this.lbNomPerso.Size = new System.Drawing.Size(91, 13);
            this.lbNomPerso.TabIndex = 2;
            this.lbNomPerso.Text = "NOM DU PERSO";
            // 
            // gbStatus
            // 
            this.gbStatus.Controls.Add(this.lbSoif);
            this.gbStatus.Controls.Add(this.lbFaim);
            this.gbStatus.Controls.Add(this.lbAge);
            this.gbStatus.Controls.Add(this.lbNom);
            this.gbStatus.Controls.Add(this.lbAgePerso);
            this.gbStatus.Controls.Add(this.pbSoifPerso);
            this.gbStatus.Controls.Add(this.pbFaimPerso);
            this.gbStatus.Controls.Add(this.lbNomPerso);
            this.gbStatus.Location = new System.Drawing.Point(472, 38);
            this.gbStatus.Name = "gbStatus";
            this.gbStatus.Size = new System.Drawing.Size(200, 117);
            this.gbStatus.TabIndex = 3;
            this.gbStatus.TabStop = false;
            this.gbStatus.Text = "Status";
            // 
            // lbSoif
            // 
            this.lbSoif.AutoSize = true;
            this.lbSoif.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSoif.Location = new System.Drawing.Point(6, 89);
            this.lbSoif.Name = "lbSoif";
            this.lbSoif.Size = new System.Drawing.Size(34, 13);
            this.lbSoif.TabIndex = 9;
            this.lbSoif.Text = "Soif : ";
            // 
            // lbFaim
            // 
            this.lbFaim.AutoSize = true;
            this.lbFaim.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFaim.Location = new System.Drawing.Point(6, 65);
            this.lbFaim.Name = "lbFaim";
            this.lbFaim.Size = new System.Drawing.Size(35, 13);
            this.lbFaim.TabIndex = 8;
            this.lbFaim.Text = "Faim :";
            // 
            // lbAge
            // 
            this.lbAge.AutoSize = true;
            this.lbAge.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAge.Location = new System.Drawing.Point(6, 40);
            this.lbAge.Name = "lbAge";
            this.lbAge.Size = new System.Drawing.Size(32, 13);
            this.lbAge.TabIndex = 7;
            this.lbAge.Text = "Age :";
            // 
            // lbNom
            // 
            this.lbNom.AutoSize = true;
            this.lbNom.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNom.Location = new System.Drawing.Point(6, 16);
            this.lbNom.Name = "lbNom";
            this.lbNom.Size = new System.Drawing.Size(38, 13);
            this.lbNom.TabIndex = 6;
            this.lbNom.Text = "Nom : ";
            // 
            // lbAgePerso
            // 
            this.lbAgePerso.AutoSize = true;
            this.lbAgePerso.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAgePerso.Location = new System.Drawing.Point(103, 40);
            this.lbAgePerso.Name = "lbAgePerso";
            this.lbAgePerso.Size = new System.Drawing.Size(88, 13);
            this.lbAgePerso.TabIndex = 5;
            this.lbAgePerso.Text = "AGE DU PERSO";
            // 
            // pbSoifPerso
            // 
            this.pbSoifPerso.Location = new System.Drawing.Point(94, 89);
            this.pbSoifPerso.Name = "pbSoifPerso";
            this.pbSoifPerso.Size = new System.Drawing.Size(100, 13);
            this.pbSoifPerso.TabIndex = 4;
            // 
            // pbFaimPerso
            // 
            this.pbFaimPerso.Location = new System.Drawing.Point(94, 65);
            this.pbFaimPerso.Name = "pbFaimPerso";
            this.pbFaimPerso.Size = new System.Drawing.Size(100, 13);
            this.pbFaimPerso.TabIndex = 3;
            // 
            // groupBox2
            // 
            this.groupBox2.Location = new System.Drawing.Point(472, 161);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 288);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // groupBox3
            // 
            this.groupBox3.Location = new System.Drawing.Point(12, 38);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 411);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "groupBox3";
            // 
            // Timeagotchi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 461);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.gbStatus);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Timeagotchi";
            this.Text = "Time-Agotchi";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.gbStatus.ResumeLayout(false);
            this.gbStatus.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aProposToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbNomPerso;
        private System.Windows.Forms.GroupBox gbStatus;
        private System.Windows.Forms.Label lbSoif;
        private System.Windows.Forms.Label lbFaim;
        private System.Windows.Forms.Label lbAge;
        private System.Windows.Forms.Label lbNom;
        private System.Windows.Forms.Label lbAgePerso;
        private System.Windows.Forms.ProgressBar pbSoifPerso;
        private System.Windows.Forms.ProgressBar pbFaimPerso;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
    }
}

