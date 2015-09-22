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
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.seSuiciderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aProposToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lbNomPerso = new System.Windows.Forms.Label();
            this.gbStatus = new System.Windows.Forms.GroupBox();
            this.lbSoif = new System.Windows.Forms.Label();
            this.lbFaim = new System.Windows.Forms.Label();
            this.lbAge = new System.Windows.Forms.Label();
            this.lbNom = new System.Windows.Forms.Label();
            this.lbAgePerso = new System.Windows.Forms.Label();
            this.pbSoifPerso = new System.Windows.Forms.ProgressBar();
            this.pbFaimPerso = new System.Windows.Forms.ProgressBar();
            this.gbActions = new System.Windows.Forms.GroupBox();
            this.btMachineASous = new System.Windows.Forms.Button();
            this.btJouerBrasFer = new System.Windows.Forms.Button();
            this.btJouerPoker = new System.Windows.Forms.Button();
            this.btVolerTemps = new System.Windows.Forms.Button();
            this.btBoire = new System.Windows.Forms.Button();
            this.btManger = new System.Windows.Forms.Button();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.lbTempsRestant = new System.Windows.Forms.Label();
            this.timerAge = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.gbStatus.SuspendLayout();
            this.gbActions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
            this.optionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.seSuiciderToolStripMenuItem});
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.optionsToolStripMenuItem.Text = "Options";
            // 
            // seSuiciderToolStripMenuItem
            // 
            this.seSuiciderToolStripMenuItem.Name = "seSuiciderToolStripMenuItem";
            this.seSuiciderToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.seSuiciderToolStripMenuItem.Text = "Se suicider";
            this.seSuiciderToolStripMenuItem.Click += new System.EventHandler(this.seSuiciderToolStripMenuItem_Click);
            // 
            // aProposToolStripMenuItem
            // 
            this.aProposToolStripMenuItem.Name = "aProposToolStripMenuItem";
            this.aProposToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.aProposToolStripMenuItem.Text = "A propos";
            this.aProposToolStripMenuItem.Click += new System.EventHandler(this.aProposToolStripMenuItem_Click);
            // 
            // lbNomPerso
            // 
            this.lbNomPerso.AutoSize = true;
            this.lbNomPerso.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNomPerso.Location = new System.Drawing.Point(91, 16);
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
            this.lbNom.Location = new System.Drawing.Point(6, 17);
            this.lbNom.Name = "lbNom";
            this.lbNom.Size = new System.Drawing.Size(38, 13);
            this.lbNom.TabIndex = 6;
            this.lbNom.Text = "Nom : ";
            // 
            // lbAgePerso
            // 
            this.lbAgePerso.AutoSize = true;
            this.lbAgePerso.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAgePerso.Location = new System.Drawing.Point(94, 40);
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
            // gbActions
            // 
            this.gbActions.Controls.Add(this.button1);
            this.gbActions.Controls.Add(this.btMachineASous);
            this.gbActions.Controls.Add(this.btJouerBrasFer);
            this.gbActions.Controls.Add(this.btJouerPoker);
            this.gbActions.Controls.Add(this.btVolerTemps);
            this.gbActions.Controls.Add(this.btBoire);
            this.gbActions.Controls.Add(this.btManger);
            this.gbActions.Location = new System.Drawing.Point(12, 38);
            this.gbActions.Name = "gbActions";
            this.gbActions.Size = new System.Drawing.Size(200, 288);
            this.gbActions.TabIndex = 4;
            this.gbActions.TabStop = false;
            this.gbActions.Text = "Actions";
            // 
            // btMachineASous
            // 
            this.btMachineASous.Location = new System.Drawing.Point(9, 174);
            this.btMachineASous.Name = "btMachineASous";
            this.btMachineASous.Size = new System.Drawing.Size(182, 23);
            this.btMachineASous.TabIndex = 11;
            this.btMachineASous.Text = "Machine à sous - Prix :  1min";
            this.btMachineASous.UseVisualStyleBackColor = true;
            this.btMachineASous.Click += new System.EventHandler(this.btMachineASous_Click);
            // 
            // btJouerBrasFer
            // 
            this.btJouerBrasFer.Location = new System.Drawing.Point(9, 145);
            this.btJouerBrasFer.Name = "btJouerBrasFer";
            this.btJouerBrasFer.Size = new System.Drawing.Size(182, 23);
            this.btJouerBrasFer.TabIndex = 10;
            this.btJouerBrasFer.Text = "Jouer au bras de fer - Prix : 10min";
            this.btJouerBrasFer.UseVisualStyleBackColor = true;
            this.btJouerBrasFer.Click += new System.EventHandler(this.btJouerBrasFer_Click);
            // 
            // btJouerPoker
            // 
            this.btJouerPoker.Location = new System.Drawing.Point(9, 116);
            this.btJouerPoker.Name = "btJouerPoker";
            this.btJouerPoker.Size = new System.Drawing.Size(182, 23);
            this.btJouerPoker.TabIndex = 9;
            this.btJouerPoker.Text = "Jouer au poker - Mise : 10min";
            this.btJouerPoker.UseVisualStyleBackColor = true;
            this.btJouerPoker.Click += new System.EventHandler(this.btJouerPoker_Click);
            // 
            // btVolerTemps
            // 
            this.btVolerTemps.Location = new System.Drawing.Point(9, 87);
            this.btVolerTemps.Name = "btVolerTemps";
            this.btVolerTemps.Size = new System.Drawing.Size(182, 23);
            this.btVolerTemps.TabIndex = 8;
            this.btVolerTemps.Text = "Tenter de voler du temps";
            this.btVolerTemps.UseVisualStyleBackColor = true;
            this.btVolerTemps.Click += new System.EventHandler(this.btVolerTemps_Click);
            // 
            // btBoire
            // 
            this.btBoire.Location = new System.Drawing.Point(9, 58);
            this.btBoire.Name = "btBoire";
            this.btBoire.Size = new System.Drawing.Size(182, 23);
            this.btBoire.TabIndex = 7;
            this.btBoire.Text = "Acheter à boire - Prix : 1min";
            this.btBoire.UseVisualStyleBackColor = true;
            this.btBoire.Click += new System.EventHandler(this.btBoire_Click);
            // 
            // btManger
            // 
            this.btManger.Location = new System.Drawing.Point(9, 29);
            this.btManger.Name = "btManger";
            this.btManger.Size = new System.Drawing.Size(182, 23);
            this.btManger.TabIndex = 6;
            this.btManger.Text = "Acheter à manger - Prix : 2min";
            this.btManger.UseVisualStyleBackColor = true;
            this.btManger.Click += new System.EventHandler(this.btManger_Click);
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // lbTempsRestant
            // 
            this.lbTempsRestant.AutoSize = true;
            this.lbTempsRestant.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTempsRestant.Location = new System.Drawing.Point(265, 60);
            this.lbTempsRestant.Name = "lbTempsRestant";
            this.lbTempsRestant.Size = new System.Drawing.Size(149, 37);
            this.lbTempsRestant.TabIndex = 6;
            this.lbTempsRestant.Text = "00:10:00";
            // 
            // timerAge
            // 
            this.timerAge.Interval = 60000;
            this.timerAge.Tick += new System.EventHandler(this.timerAge_Tick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(234, 125);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(200, 200);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(9, 203);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(182, 23);
            this.button1.TabIndex = 12;
            this.button1.Text = "Placer du temps";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Timeagotchi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 361);
            this.Controls.Add(this.lbTempsRestant);
            this.Controls.Add(this.gbActions);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.gbStatus);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Timeagotchi";
            this.Text = "Time-Agotchi";
            this.Load += new System.EventHandler(this.Timeagotchi_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.gbStatus.ResumeLayout(false);
            this.gbStatus.PerformLayout();
            this.gbActions.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private System.Windows.Forms.GroupBox gbActions;
        private System.Windows.Forms.ToolStripMenuItem seSuiciderToolStripMenuItem;
        private System.Windows.Forms.Button btJouerBrasFer;
        private System.Windows.Forms.Button btJouerPoker;
        private System.Windows.Forms.Button btVolerTemps;
        private System.Windows.Forms.Button btBoire;
        private System.Windows.Forms.Button btManger;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Label lbTempsRestant;
        private System.Windows.Forms.Timer timerAge;
        private System.Windows.Forms.Button btMachineASous;
        private System.Windows.Forms.Button button1;
    }
}

