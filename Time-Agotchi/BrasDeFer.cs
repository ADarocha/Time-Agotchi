using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using System.Timers;

namespace Time_Agotchi
{
    public partial class BrasDeFer : Form
    {
        List<string> entrees = new List<string>();
        List<bool> reponses = new List<bool>();
        
        public BrasDeFer()
        {
            
            InitializeComponent();

        }

        private void BrasDeFer_Load(object sender, EventArgs e)
        {
            //Affichage de Données Des personnages + Affichage de ProgressBar 
            AffichageDonnesPersonnages();
            progressBarPersoMain.Value = 50;
            progressBarAdversaire.Value = 50;

            

            //fin



            
            
        }

        /// <summary>
        /// Methodes D'affichage images
        /// </summary>

        private void AfficherImagesFleches(List<string> listeDeFleches)
        {
            ///Méthode qui permet d'afficher les images
            ///pour l'instant des test avec des Label
            
            lbReponse1.Text = listeDeFleches[0];
            lbReponse2.Text = listeDeFleches[1];
            lbReponse3.Text = listeDeFleches[2];
            lbReponse4.Text = listeDeFleches[3];
        }
        /// <summary>
        /// Fin Methodes D'affichage images
        /// </summary>
        /// <param name="e"></param>
        

       /// <summary>
       /// Debut Methodes D'afficahges Donnes Personnages
       /// </summary>
        private void AffichageDonnesPersonnages()
        {
            lbTempsJoueur.Text = Donnees.GetPersos()[0].ToString();
            lbTempsAdversaire.Text = Donnees.GetPersos()[1].ToString();
        }

       ///<summary>
       ///Fin Methodes d'afficahge Donnes Personnages 
       ///</summary>

       ///<summary> Methode MAIN Jeu///</summary>

        private void Main_Jeu()
        {
            
            GestionnaireMiniJeuBrasDeFer.GenererListeDeFleches(4);
            AfficherImagesFleches(GestionnaireMiniJeuBrasDeFer.GetFleches());
            KeyPreview = true;
            timer2.Interval = 2000;
            timer2.Start();
            
            
 
            
         /*
            while (timer2.Enabled == false)
            {
                lbAnnonce.Text = "mes";
                
            }*/
            
            
            
        }
       

       ///<summary> FIN METHODE MAIN JEU</summary>
        protected override void OnKeyPress(KeyPressEventArgs e)
        {
            string entreeDuJoueur = e.KeyChar.ToString();
            GestionnaireMiniJeuBrasDeFer.GetlisteFlechesEntrees().Add(entreeDuJoueur);
        }



        private void btTest_Click(object sender, EventArgs e)
        {
            Main_Jeu();
            
            //bool BonneTouche = false;
            //int seconds = 1;

            //while (BonneTouche)
            //{
            //    this.KeyPreview = true;
                
                    
            //}
        }

        private void Timer_AttenteKeyPress_Tick(object sender, EventArgs e)
        {
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
           
            progressBarPersoMain.Increment(-5); //On peut faire une valeur négative pour diminuer le progressBar
            
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            KeyPreview = false;
            timer2.Stop();
            this.reponses = GestionnaireMiniJeuBrasDeFer.GetReponses();

            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show(GestionnaireMiniJeuBrasDeFer.GetlisteFlechesEntrees()[0]+":"+GestionnaireMiniJeuBrasDeFer.GetlisteFlechesEntrees().Count);
            
        }

        



    
    }
}
