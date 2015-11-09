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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Timeagotchi));
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
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.lbTempsRestant = new System.Windows.Forms.Label();
            this.timerAge = new System.Windows.Forms.Timer(this.components);
            this.btPersonnages = new System.Windows.Forms.Button();
            this.listeBoxInfosPersonnages = new System.Windows.Forms.ListBox();
            this.timerAffichageGif = new System.Windows.Forms.Timer(this.components);
            this.gbActions = new System.Windows.Forms.GroupBox();
            this.btPlacerTemps = new System.Windows.Forms.Button();
            this.btMachineASous = new System.Windows.Forms.Button();
            this.btJouerBrasFer = new System.Windows.Forms.Button();
            this.btVolerTemps = new System.Windows.Forms.Button();
            this.btBoire = new System.Windows.Forms.Button();
            this.btManger = new System.Windows.Forms.Button();
            this.pbPersonnage = new System.Windows.Forms.PictureBox();
            this.TimerAffichageManger = new System.Windows.Forms.Timer(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.gbStatus.SuspendLayout();
            this.gbActions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPersonnage)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.optionsToolStripMenuItem,
            this.aProposToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1053, 24);
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
            this.lbNomPerso.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lbNomPerso.Location = new System.Drawing.Point(91, 16);
            this.lbNomPerso.Name = "lbNomPerso";
            this.lbNomPerso.Size = new System.Drawing.Size(156, 24);
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
            this.gbStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbStatus.ForeColor = System.Drawing.Color.SpringGreen;
            this.gbStatus.Location = new System.Drawing.Point(792, 38);
            this.gbStatus.Name = "gbStatus";
            this.gbStatus.Size = new System.Drawing.Size(249, 187);
            this.gbStatus.TabIndex = 3;
            this.gbStatus.TabStop = false;
            this.gbStatus.Text = "Status";
            // 
            // lbSoif
            // 
            this.lbSoif.AutoSize = true;
            this.lbSoif.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSoif.Location = new System.Drawing.Point(6, 89);
            this.lbSoif.Name = "lbSoif";
            this.lbSoif.Size = new System.Drawing.Size(56, 24);
            this.lbSoif.TabIndex = 9;
            this.lbSoif.Text = "Soif : ";
            // 
            // lbFaim
            // 
            this.lbFaim.AutoSize = true;
            this.lbFaim.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFaim.Location = new System.Drawing.Point(6, 65);
            this.lbFaim.Name = "lbFaim";
            this.lbFaim.Size = new System.Drawing.Size(62, 24);
            this.lbFaim.TabIndex = 8;
            this.lbFaim.Text = "Faim :";
            // 
            // lbAge
            // 
            this.lbAge.AutoSize = true;
            this.lbAge.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAge.Location = new System.Drawing.Point(6, 40);
            this.lbAge.Name = "lbAge";
            this.lbAge.Size = new System.Drawing.Size(55, 24);
            this.lbAge.TabIndex = 7;
            this.lbAge.Text = "Age :";
            // 
            // lbNom
            // 
            this.lbNom.AutoSize = true;
            this.lbNom.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNom.Location = new System.Drawing.Point(6, 17);
            this.lbNom.Name = "lbNom";
            this.lbNom.Size = new System.Drawing.Size(66, 24);
            this.lbNom.TabIndex = 6;
            this.lbNom.Text = "Nom : ";
            // 
            // lbAgePerso
            // 
            this.lbAgePerso.AutoSize = true;
            this.lbAgePerso.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lbAgePerso.Location = new System.Drawing.Point(94, 40);
            this.lbAgePerso.Name = "lbAgePerso";
            this.lbAgePerso.Size = new System.Drawing.Size(151, 24);
            this.lbAgePerso.TabIndex = 5;
            this.lbAgePerso.Text = "AGE DU PERSO";
            // 
            // pbSoifPerso
            // 
            this.pbSoifPerso.Location = new System.Drawing.Point(98, 99);
            this.pbSoifPerso.Name = "pbSoifPerso";
            this.pbSoifPerso.Size = new System.Drawing.Size(100, 13);
            this.pbSoifPerso.TabIndex = 4;
            // 
            // pbFaimPerso
            // 
            this.pbFaimPerso.Location = new System.Drawing.Point(98, 75);
            this.pbFaimPerso.Name = "pbFaimPerso";
            this.pbFaimPerso.Size = new System.Drawing.Size(100, 13);
            this.pbFaimPerso.TabIndex = 3;
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // lbTempsRestant
            // 
            this.lbTempsRestant.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTempsRestant.ForeColor = System.Drawing.Color.SpringGreen;
            this.lbTempsRestant.Location = new System.Drawing.Point(564, 293);
            this.lbTempsRestant.Name = "lbTempsRestant";
            this.lbTempsRestant.Size = new System.Drawing.Size(239, 68);
            this.lbTempsRestant.TabIndex = 6;
            this.lbTempsRestant.Text = "00:10:00";
            // 
            // timerAge
            // 
            this.timerAge.Interval = 60000;
            this.timerAge.Tick += new System.EventHandler(this.timerAge_Tick);
            // 
            // btPersonnages
            // 
            this.btPersonnages.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btPersonnages.ForeColor = System.Drawing.Color.SpringGreen;
            this.btPersonnages.Location = new System.Drawing.Point(852, 467);
            this.btPersonnages.Name = "btPersonnages";
            this.btPersonnages.Size = new System.Drawing.Size(177, 79);
            this.btPersonnages.TabIndex = 13;
            this.btPersonnages.Text = "Voir personnages";
            this.btPersonnages.UseVisualStyleBackColor = true;
            this.btPersonnages.Click += new System.EventHandler(this.btPersonnages_Click);
            // 
            // listeBoxInfosPersonnages
            // 
            this.listeBoxInfosPersonnages.BackColor = System.Drawing.SystemColors.InfoText;
            this.listeBoxInfosPersonnages.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listeBoxInfosPersonnages.ForeColor = System.Drawing.Color.SpringGreen;
            this.listeBoxInfosPersonnages.FormattingEnabled = true;
            this.listeBoxInfosPersonnages.ItemHeight = 18;
            this.listeBoxInfosPersonnages.Location = new System.Drawing.Point(574, 398);
            this.listeBoxInfosPersonnages.Name = "listeBoxInfosPersonnages";
            this.listeBoxInfosPersonnages.Size = new System.Drawing.Size(227, 148);
            this.listeBoxInfosPersonnages.TabIndex = 14;
            this.listeBoxInfosPersonnages.Visible = false;
            this.listeBoxInfosPersonnages.VisibleChanged += new System.EventHandler(this.listeBoxInfosPersonnages_VisibleChanged);
            this.listeBoxInfosPersonnages.MouseHover += new System.EventHandler(this.listeBoxInfosPersonnages_MouseHover);
            // 
            // timerAffichageGif
            // 
            this.timerAffichageGif.Tick += new System.EventHandler(this.timerAffichageGif_Tick);
            // 
            // gbActions
            // 
            this.gbActions.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("gbActions.BackgroundImage")));
            this.gbActions.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.gbActions.Controls.Add(this.btPlacerTemps);
            this.gbActions.Controls.Add(this.btMachineASous);
            this.gbActions.Controls.Add(this.btJouerBrasFer);
            this.gbActions.Controls.Add(this.btVolerTemps);
            this.gbActions.Controls.Add(this.btBoire);
            this.gbActions.Controls.Add(this.btManger);
            this.gbActions.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.gbActions.ForeColor = System.Drawing.Color.SpringGreen;
            this.gbActions.Location = new System.Drawing.Point(12, 38);
            this.gbActions.Name = "gbActions";
            this.gbActions.Size = new System.Drawing.Size(530, 548);
            this.gbActions.TabIndex = 4;
            this.gbActions.TabStop = false;
            this.gbActions.Text = "Map";
            // 
            // btPlacerTemps
            // 
            this.btPlacerTemps.BackColor = System.Drawing.Color.Black;
            this.btPlacerTemps.FlatAppearance.BorderSize = 0;
            this.btPlacerTemps.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btPlacerTemps.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btPlacerTemps.ForeColor = System.Drawing.Color.SpringGreen;
            this.btPlacerTemps.Location = new System.Drawing.Point(41, 360);
            this.btPlacerTemps.Name = "btPlacerTemps";
            this.btPlacerTemps.Size = new System.Drawing.Size(130, 68);
            this.btPlacerTemps.TabIndex = 12;
            this.btPlacerTemps.Text = "Placer du temps";
            this.btPlacerTemps.UseVisualStyleBackColor = false;
            this.btPlacerTemps.Click += new System.EventHandler(this.btPlacerTemps_Click);
            // 
            // btMachineASous
            // 
            this.btMachineASous.BackColor = System.Drawing.Color.Black;
            this.btMachineASous.FlatAppearance.BorderSize = 0;
            this.btMachineASous.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btMachineASous.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btMachineASous.ForeColor = System.Drawing.Color.SpringGreen;
            this.btMachineASous.Location = new System.Drawing.Point(29, 262);
            this.btMachineASous.Name = "btMachineASous";
            this.btMachineASous.Size = new System.Drawing.Size(95, 77);
            this.btMachineASous.TabIndex = 11;
            this.btMachineASous.Text = "Machine à sous";
            this.btMachineASous.UseVisualStyleBackColor = false;
            this.btMachineASous.Click += new System.EventHandler(this.btMachineASous_Click);
            // 
            // btJouerBrasFer
            // 
            this.btJouerBrasFer.BackColor = System.Drawing.Color.Black;
            this.btJouerBrasFer.FlatAppearance.BorderSize = 0;
            this.btJouerBrasFer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btJouerBrasFer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btJouerBrasFer.ForeColor = System.Drawing.Color.SpringGreen;
            this.btJouerBrasFer.Location = new System.Drawing.Point(179, 208);
            this.btJouerBrasFer.Name = "btJouerBrasFer";
            this.btJouerBrasFer.Size = new System.Drawing.Size(73, 87);
            this.btJouerBrasFer.TabIndex = 10;
            this.btJouerBrasFer.Text = "Jouer au bras de fer";
            this.btJouerBrasFer.UseVisualStyleBackColor = false;
            this.btJouerBrasFer.Click += new System.EventHandler(this.btJouerBrasFer_Click);
            // 
            // btVolerTemps
            // 
            this.btVolerTemps.BackColor = System.Drawing.Color.Black;
            this.btVolerTemps.FlatAppearance.BorderSize = 0;
            this.btVolerTemps.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btVolerTemps.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btVolerTemps.ForeColor = System.Drawing.Color.SpringGreen;
            this.btVolerTemps.Location = new System.Drawing.Point(355, 174);
            this.btVolerTemps.Name = "btVolerTemps";
            this.btVolerTemps.Size = new System.Drawing.Size(70, 140);
            this.btVolerTemps.TabIndex = 8;
            this.btVolerTemps.Text = "Tenter de voler du temps";
            this.btVolerTemps.UseVisualStyleBackColor = false;
            this.btVolerTemps.Click += new System.EventHandler(this.btVolerTemps_Click);
            // 
            // btBoire
            // 
            this.btBoire.BackColor = System.Drawing.Color.Black;
            this.btBoire.FlatAppearance.BorderSize = 0;
            this.btBoire.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btBoire.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btBoire.ForeColor = System.Drawing.Color.SpringGreen;
            this.btBoire.Location = new System.Drawing.Point(110, 47);
            this.btBoire.Name = "btBoire";
            this.btBoire.Size = new System.Drawing.Size(121, 106);
            this.btBoire.TabIndex = 7;
            this.btBoire.Text = "Acheter à boire - Prix : 1min";
            this.btBoire.UseVisualStyleBackColor = false;
            this.btBoire.Click += new System.EventHandler(this.btBoire_Click);
            // 
            // btManger
            // 
            this.btManger.BackColor = System.Drawing.Color.Black;
            this.btManger.FlatAppearance.BorderSize = 0;
            this.btManger.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btManger.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btManger.ForeColor = System.Drawing.Color.SpringGreen;
            this.btManger.Location = new System.Drawing.Point(377, 40);
            this.btManger.Name = "btManger";
            this.btManger.Size = new System.Drawing.Size(117, 113);
            this.btManger.TabIndex = 6;
            this.btManger.Text = "Acheter à manger - Prix : 2min";
            this.btManger.UseVisualStyleBackColor = false;
            this.btManger.Click += new System.EventHandler(this.btManger_Click);
            // 
            // pbPersonnage
            // 
            this.pbPersonnage.BackColor = System.Drawing.Color.White;
            this.pbPersonnage.Image = global::Time_Agotchi.Properties.Resources.personnage;
            this.pbPersonnage.Location = new System.Drawing.Point(574, 38);
            this.pbPersonnage.Name = "pbPersonnage";
            this.pbPersonnage.Size = new System.Drawing.Size(200, 200);
            this.pbPersonnage.TabIndex = 1;
            this.pbPersonnage.TabStop = false;
            this.pbPersonnage.Click += new System.EventHandler(this.pbPersonnage_Click);
            // 
            // TimerAffichageManger
            // 
            this.TimerAffichageManger.Tick += new System.EventHandler(this.TimerAffichageManger_Tick);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.SpringGreen;
            this.button1.Location = new System.Drawing.Point(792, 282);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(177, 79);
            this.button1.TabIndex = 15;
            this.button1.Text = "Voir personnages";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Timeagotchi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1053, 598);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listeBoxInfosPersonnages);
            this.Controls.Add(this.btPersonnages);
            this.Controls.Add(this.lbTempsRestant);
            this.Controls.Add(this.gbActions);
            this.Controls.Add(this.pbPersonnage);
            this.Controls.Add(this.gbStatus);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Timeagotchi";
            this.Text = " ";
            this.Load += new System.EventHandler(this.Timeagotchi_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.gbStatus.ResumeLayout(false);
            this.gbStatus.PerformLayout();
            this.gbActions.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbPersonnage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aProposToolStripMenuItem;
        private System.Windows.Forms.PictureBox pbPersonnage;
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
        private System.Windows.Forms.Button btVolerTemps;
        private System.Windows.Forms.Button btBoire;
        private System.Windows.Forms.Button btManger;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Label lbTempsRestant;
        private System.Windows.Forms.Timer timerAge;
        private System.Windows.Forms.Button btMachineASous;
        private System.Windows.Forms.Button btPlacerTemps;
        private System.Windows.Forms.Button btPersonnages;
        private System.Windows.Forms.ListBox listeBoxInfosPersonnages;
        private System.Windows.Forms.Timer timerAffichageGif;
        private System.Windows.Forms.Timer TimerAffichageManger;
        private System.Windows.Forms.Button button1;
    }
}

