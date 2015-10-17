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
        List<string> listeEntrees = new List<string>();
        
        
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
        private void AfficherImageReponse(PictureBox picture, bool reponse)
        {
            if (reponse == true)
            {
                picture.BackgroundImage = Properties.Resources.Correct;
            }
            else
                picture.BackgroundImage = Properties.Resources.Faux;
            
                
        }

        private void AffichagerAllReponses()
        {
            for (int i = 0; i < GestionnaireMiniJeuBrasDeFer.GetlisteReponses().Count; i++)
            {
                if (i == 0)
                    AfficherImageReponse(pbFirstReponse, GestionnaireMiniJeuBrasDeFer.GetlisteReponses()[i]);
                else if (i == 1)
                {
                    AfficherImageReponse(pbSecondReponse, GestionnaireMiniJeuBrasDeFer.GetlisteReponses()[i]);
                }
                else if (i == 2)
                {
                    AfficherImageReponse(pbThirdReponse, GestionnaireMiniJeuBrasDeFer.GetlisteReponses()[i]);
                }
                else if (i == 3)
                {
                    AfficherImageReponse(pbFourthReponse, GestionnaireMiniJeuBrasDeFer.GetlisteReponses()[i]);
                }
            }
        }
        private void AfficherAllFleches()
        {
           
            ///Méthode qui permet d'afficher les images
            ///pour l'instant des test avec des Label
            for (int i = 0; i < GestionnaireMiniJeuBrasDeFer.GetFleches().Count; i++)
            {
                if (i == 0)
                {
                    AfficherFleche(pbFirstArrow, GestionnaireMiniJeuBrasDeFer.GetFleches()[i]);
                }
                else if (i == 1)
                {
                    AfficherFleche(pbSecondArrow, GestionnaireMiniJeuBrasDeFer.GetFleches()[i]);
                }
                else if (i == 2)
                {
                    AfficherFleche(pbThridArrow, GestionnaireMiniJeuBrasDeFer.GetFleches()[i]);
                }
                else if (i == 3)
                {
                    AfficherFleche(pbFourthArrow, GestionnaireMiniJeuBrasDeFer.GetFleches()[i]);
                }
            }
           
        }

        private void AfficherFleche(PictureBox Picture, string nomfleche)
        {
            //Methode qui permet de donner aux Picture box sa bonne Fléche. Si le string est haut on affiche une fléche HAut sur le PictureBox
            if (nomfleche == "haut")
                Picture.BackgroundImage = new Bitmap(Properties.Resources.fleche_haut);
            else if (nomfleche == "bas")
                Picture.BackgroundImage = new Bitmap(Properties.Resources.fleche_bas);
            else if (nomfleche == "droite")
                Picture.BackgroundImage = new Bitmap(Properties.Resources.fleche_droite);
            else if (nomfleche == "gauche")
                Picture.BackgroundImage = new Bitmap(Properties.Resources.fleche_gauche);

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
            
            GestionnaireMiniJeuBrasDeFer.GenererListeDeFleches(4); //on génére une liste de fléches
            AfficherAllFleches(); //on affiche les fléches (images)
            GestionnaireMiniJeuBrasDeFer.GetlisteFlechesEntrees().Clear();//avant de réactiver les entrees pour le joueur on clean la listeDes entrees d'avant
            KeyPreview = true; //activation des entrees
            timer2.Interval = 2000; //on attends 2 secondes avant de desactiver
            timer2.Start(); //on desactive et vérifications (voir le tick)
            
            
            
        }
       

       ///<summary> FIN METHODE MAIN JEU</summary>
        protected override void OnKeyPress(KeyPressEventArgs e)
        {
            string entreeDuJoueur = e.KeyChar.ToString(); //la vraie valeur que le joueur entre par exemple a
            string entreeTransformeeFleche = "null"; //on transforme cette valeur en fléche si on tape z alors on transforme en "haut"
            switch (entreeDuJoueur)
            {
                case "z":
                    entreeTransformeeFleche = "haut";

                    break;
                case "s":
                    entreeTransformeeFleche = "bas";
                    break;
                case "d":
                    entreeTransformeeFleche = "droite";
                    break;
                case "q":
                    entreeTransformeeFleche = "gauche";
                    break;
            }
            GestionnaireMiniJeuBrasDeFer.GetlisteFlechesEntrees().Add(entreeTransformeeFleche);
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
            foreach (bool b in GestionnaireMiniJeuBrasDeFer.GetlisteReponses())
            {
                MessageBox.Show(b.ToString());
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            KeyPreview = false;
            timer2.Stop();//desactiver
            GestionnaireMiniJeuBrasDeFer.GetReponses(); //Recupération des réponses
            AffichagerAllReponses();

            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show(GestionnaireMiniJeuBrasDeFer.GetlisteFlechesEntrees().Count.ToString());
            
        }

        



    
    }
}
