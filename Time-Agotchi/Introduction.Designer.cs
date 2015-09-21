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
            ((System.ComponentModel.ISupportInitialize)(this.pbIntro)).BeginInit();
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
            this.lbResume.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbResume.Location = new System.Drawing.Point(12, 285);
            this.lbResume.Name = "lbResume";
            this.lbResume.Size = new System.Drawing.Size(501, 65);
            this.lbResume.TabIndex = 1;
            this.lbResume.Text = resources.GetString("lbResume.Text");
            // 
            // lbVotreNom
            // 
            this.lbVotreNom.AutoSize = true;
            this.lbVotreNom.Location = new System.Drawing.Point(12, 421);
            this.lbVotreNom.Name = "lbVotreNom";
            this.lbVotreNom.Size = new System.Drawing.Size(64, 13);
            this.lbVotreNom.TabIndex = 2;
            this.lbVotreNom.Text = "Votre nom : ";
            // 
            // tbNom
            // 
            this.tbNom.Location = new System.Drawing.Point(82, 418);
            this.tbNom.MaxLength = 15;
            this.tbNom.Name = "tbNom";
            this.tbNom.Size = new System.Drawing.Size(151, 20);
            this.tbNom.TabIndex = 3;
            // 
            // btValider
            // 
            this.btValider.Location = new System.Drawing.Point(256, 418);
            this.btValider.Name = "btValider";
            this.btValider.Size = new System.Drawing.Size(75, 23);
            this.btValider.TabIndex = 4;
            this.btValider.Text = "Valider";
            this.btValider.UseVisualStyleBackColor = true;
            this.btValider.Click += new System.EventHandler(this.btValider_Click);
            // 
            // Introduction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(511, 486);
            this.Controls.Add(this.btValider);
            this.Controls.Add(this.tbNom);
            this.Controls.Add(this.lbVotreNom);
            this.Controls.Add(this.lbResume);
            this.Controls.Add(this.pbIntro);
            this.Name = "Introduction";
            this.Text = "Introduction";
            ((System.ComponentModel.ISupportInitialize)(this.pbIntro)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.PictureBox pbIntro;
        private System.Windows.Forms.Label lbResume;
        private System.Windows.Forms.Label lbVotreNom;
        private System.Windows.Forms.TextBox tbNom;
        private System.Windows.Forms.Button btValider;

    }
}