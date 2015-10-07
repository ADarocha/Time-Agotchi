namespace Time_Agotchi
{
    partial class BrasDeFer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BrasDeFer));
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.progressBar2 = new System.Windows.Forms.ProgressBar();
            this.lbTempsJoueur = new System.Windows.Forms.Label();
            this.lbTempsAdversaire = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.btTest = new System.Windows.Forms.Button();
            this.Timer_AttenteKeyPress = new System.Windows.Forms.Timer(this.components);
            this.lbReponse1 = new System.Windows.Forms.Label();
            this.lbReponse2 = new System.Windows.Forms.Label();
            this.lbReponse3 = new System.Windows.Forms.Label();
            this.lbReponse4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.SuspendLayout();
            // 
            // progressBar1
            // 
            resources.ApplyResources(this.progressBar1, "progressBar1");
            this.progressBar1.Name = "progressBar1";
            // 
            // progressBar2
            // 
            resources.ApplyResources(this.progressBar2, "progressBar2");
            this.progressBar2.Name = "progressBar2";
            // 
            // lbTempsJoueur
            // 
            resources.ApplyResources(this.lbTempsJoueur, "lbTempsJoueur");
            this.lbTempsJoueur.Name = "lbTempsJoueur";
            // 
            // lbTempsAdversaire
            // 
            resources.ApplyResources(this.lbTempsAdversaire, "lbTempsAdversaire");
            this.lbTempsAdversaire.Name = "lbTempsAdversaire";
            // 
            // pictureBox1
            // 
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // pictureBox2
            // 
            resources.ApplyResources(this.pictureBox2, "pictureBox2");
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            resources.ApplyResources(this.pictureBox3, "pictureBox3");
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            resources.ApplyResources(this.pictureBox4, "pictureBox4");
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            resources.ApplyResources(this.pictureBox5, "pictureBox5");
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.TabStop = false;
            // 
            // btTest
            // 
            resources.ApplyResources(this.btTest, "btTest");
            this.btTest.Name = "btTest";
            this.btTest.UseVisualStyleBackColor = true;
            this.btTest.Click += new System.EventHandler(this.btTest_Click);
            // 
            // Timer_AttenteKeyPress
            // 
            this.Timer_AttenteKeyPress.Tick += new System.EventHandler(this.Timer_AttenteKeyPress_Tick);
            // 
            // lbReponse1
            // 
            resources.ApplyResources(this.lbReponse1, "lbReponse1");
            this.lbReponse1.Name = "lbReponse1";
            // 
            // lbReponse2
            // 
            resources.ApplyResources(this.lbReponse2, "lbReponse2");
            this.lbReponse2.Name = "lbReponse2";
            // 
            // lbReponse3
            // 
            resources.ApplyResources(this.lbReponse3, "lbReponse3");
            this.lbReponse3.Name = "lbReponse3";
            // 
            // lbReponse4
            // 
            resources.ApplyResources(this.lbReponse4, "lbReponse4");
            this.lbReponse4.Name = "lbReponse4";
            // 
            // BrasDeFer
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lbReponse4);
            this.Controls.Add(this.lbReponse3);
            this.Controls.Add(this.lbReponse2);
            this.Controls.Add(this.lbReponse1);
            this.Controls.Add(this.btTest);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lbTempsAdversaire);
            this.Controls.Add(this.lbTempsJoueur);
            this.Controls.Add(this.progressBar2);
            this.Controls.Add(this.progressBar1);
            this.KeyPreview = true;
            this.Name = "BrasDeFer";
            this.Load += new System.EventHandler(this.BrasDeFer_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.BrasDeFer_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.ProgressBar progressBar2;
        private System.Windows.Forms.Label lbTempsJoueur;
        private System.Windows.Forms.Label lbTempsAdversaire;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Button btTest;
        private System.Windows.Forms.Timer Timer_AttenteKeyPress;
        private System.Windows.Forms.Label lbReponse1;
        private System.Windows.Forms.Label lbReponse2;
        private System.Windows.Forms.Label lbReponse3;
        private System.Windows.Forms.Label lbReponse4;
    }
}