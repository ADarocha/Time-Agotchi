namespace Time_Agotchi
{
    partial class Introduction
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Introduction));
            this.pbIntro = new System.Windows.Forms.PictureBox();
            this.lbResume = new System.Windows.Forms.Label();
            this.lbVotreNom = new System.Windows.Forms.Label();
            this.tbNom = new System.Windows.Forms.TextBox();
            this.btValider = new System.Windows.Forms.Button();
            this.gbResume = new System.Windows.Forms.GroupBox();
            this.gbRegles = new System.Windows.Forms.GroupBox();
            this.lbRegles = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbIntro)).BeginInit();
            this.gbResume.SuspendLayout();
            this.gbRegles.SuspendLayout();
            this.SuspendLayout();
            // 
            // pbIntro
            // 
            this.pbIntro.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pbIntro.Image = global::Time_Agotchi.Properties.Resources.Time_Out;
            this.pbIntro.Location = new System.Drawing.Point(12, 12);
            this.pbIntro.Name = "pbIntro";
            this.pbIntro.Size = new System.Drawing.Size(487, 258);
            this.pbIntro.TabIndex = 0;
            this.pbIntro.TabStop = false;
            // 
            // lbResume
            // 
            this.lbResume.AutoSize = true;
            this.lbResume.Font = new System.Drawing.Font("Miramonte", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbResume.ForeColor = System.Drawing.Color.SpringGreen;
            this.lbResume.Location = new System.Drawing.Point(6, 16);
            this.lbResume.Name = "lbResume";
            this.lbResume.Size = new System.Drawing.Size(448, 105);
            this.lbResume.TabIndex = 1;
            this.lbResume.Text = resources.GetString("lbResume.Text");
            // 
            // lbVotreNom
            // 
            this.lbVotreNom.AutoSize = true;
            this.lbVotreNom.Font = new System.Drawing.Font("Quartz MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbVotreNom.ForeColor = System.Drawing.Color.SpringGreen;
            this.lbVotreNom.Location = new System.Drawing.Point(43, 585);
            this.lbVotreNom.Name = "lbVotreNom";
            this.lbVotreNom.Size = new System.Drawing.Size(115, 18);
            this.lbVotreNom.TabIndex = 2;
            this.lbVotreNom.Text = "Votre nom : ";
            // 
            // tbNom
            // 
            this.tbNom.Location = new System.Drawing.Point(164, 585);
            this.tbNom.MaxLength = 15;
            this.tbNom.Name = "tbNom";
            this.tbNom.Size = new System.Drawing.Size(151, 20);
            this.tbNom.TabIndex = 3;
            // 
            // btValider
            // 
            this.btValider.Font = new System.Drawing.Font("Quartz MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btValider.ForeColor = System.Drawing.Color.SpringGreen;
            this.btValider.Location = new System.Drawing.Point(337, 575);
            this.btValider.Name = "btValider";
            this.btValider.Size = new System.Drawing.Size(104, 39);
            this.btValider.TabIndex = 4;
            this.btValider.Text = "Commencer";
            this.btValider.UseVisualStyleBackColor = true;
            this.btValider.Click += new System.EventHandler(this.btValider_Click);
            // 
            // gbResume
            // 
            this.gbResume.Controls.Add(this.lbResume);
            this.gbResume.Location = new System.Drawing.Point(31, 285);
            this.gbResume.Name = "gbResume";
            this.gbResume.Size = new System.Drawing.Size(441, 129);
            this.gbResume.TabIndex = 5;
            this.gbResume.TabStop = false;
            this.gbResume.Text = "Résumé";
            // 
            // gbRegles
            // 
            this.gbRegles.Controls.Add(this.lbRegles);
            this.gbRegles.Location = new System.Drawing.Point(31, 420);
            this.gbRegles.Name = "gbRegles";
            this.gbRegles.Size = new System.Drawing.Size(441, 138);
            this.gbRegles.TabIndex = 6;
            this.gbRegles.TabStop = false;
            this.gbRegles.Text = "Régles du jeu";
            // 
            // lbRegles
            // 
            this.lbRegles.AutoSize = true;
            this.lbRegles.Font = new System.Drawing.Font("Miramonte", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRegles.ForeColor = System.Drawing.Color.SpringGreen;
            this.lbRegles.Location = new System.Drawing.Point(6, 16);
            this.lbRegles.Name = "lbRegles";
            this.lbRegles.Size = new System.Drawing.Size(456, 120);
            this.lbRegles.TabIndex = 1;
            this.lbRegles.Text = resources.GetString("lbRegles.Text");
            // 
            // Introduction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlText;
            this.ClientSize = new System.Drawing.Size(520, 661);
            this.Controls.Add(this.gbRegles);
            this.Controls.Add(this.gbResume);
            this.Controls.Add(this.btValider);
            this.Controls.Add(this.tbNom);
            this.Controls.Add(this.lbVotreNom);
            this.Controls.Add(this.pbIntro);
            this.Name = "Introduction";
            this.Text = "Introduction";
            ((System.ComponentModel.ISupportInitialize)(this.pbIntro)).EndInit();
            this.gbResume.ResumeLayout(false);
            this.gbResume.PerformLayout();
            this.gbRegles.ResumeLayout(false);
            this.gbRegles.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.PictureBox pbIntro;
        private System.Windows.Forms.Label lbResume;
        private System.Windows.Forms.Label lbVotreNom;
        private System.Windows.Forms.TextBox tbNom;
        private System.Windows.Forms.Button btValider;
        private System.Windows.Forms.GroupBox gbResume;
        private System.Windows.Forms.GroupBox gbRegles;
        private System.Windows.Forms.Label lbRegles;

    }
}