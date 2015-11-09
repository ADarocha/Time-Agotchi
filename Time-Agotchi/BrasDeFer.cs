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
using System.Media;

namespace Time_Agotchi
{
    public partial class BrasDeFer : Form
    {
        List<string> listeEntrees = new List<string>();//liste des entrees du joueur (saisie)
        SoundPlayer sound = new SoundPlayer(Properties.Resources.Sound_BrasDeFer); //musique de fond
        
        public BrasDeFer()
        {
           
            InitializeComponent();

        }

        private void BrasDeFer_Load(object sender, EventArgs e)
        {
            //Affichage de Données Des personnages + Affichage de ProgressBar 
            GestionnaireMiniJeuBrasDeFer.SetAdversaire(Donnees.GetAdversaires()[0]);
            AffichageNomsPersonnages();
            AffichageTempsPersonnages();
            progressBarPersoMain.Value = 50;
            progressBarAdversaire.Value = 50;
            sound.PlayLooping();
            
            

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
            //affiche les reponses qui se trouvent dans une liste pour les pictureimage
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
        private void AffichageTempsPersonnages()
        {
            lbTempsJoueur.Text = GestionnaireMiniJeuBrasDeFer.GetMainPerso().TempsPersonnageString();
            lbTempsAdversaire.Text = GestionnaireMiniJeuBrasDeFer.GetAdversaire().TempsPersonnageString();
           
        }

        private void AffichageNomsPersonnages()
        {
            lbPersoMain.Text = GestionnaireMiniJeuBrasDeFer.GetMainPerso().GetNom();
            lbNomAdversaire.Text = GestionnaireMiniJeuBrasDeFer.GetAdversaire().GetNom();
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
            timerGestionnaireJeu.Interval = 1500; //on attends 2 secondes avant de desactiver
            timerGestionnaireJeu.Start(); //on desactive et vérifications (voir le tick)
            
            
            
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



        private void btGo_Click(object sender, EventArgs e)
        {
            //lance le timer du main jeu
            timerMainJeu.Interval = 2000;
            timerMainJeu.Start();
            
        }


        private void timerMainJeu_Tick(object sender, EventArgs e)
        {
            //si un des joueurs a une vie de 0 alors on arrete le cycle de jeu//
            //si non on continue le cycle
            if (progressBarAdversaire.Value == 0 || progressBarPersoMain.Value == 0)
            {
                timerMainJeu.Stop();
                btQuitter.Visible = true;
                //fin du cycle de jeu//

            }
            //On peut faire une valeur négative pour diminuer le progressBar
            else
            {
                Main_Jeu();

            }
        }
        /// <summary>
        /// Timer Qui va s'occuper de la gestion de jeu
        /// Recupération de donnes
        /// Chargenement d'aimges
        /// Etat des Barres et labels etc
        /// Definition des gagant recalculs de leur vie
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timerGestionnaireJeu_Tick(object sender, EventArgs e)
        {
            int valeur = 25;
            KeyPreview = false;

            GestionnaireMiniJeuBrasDeFer.GenererReponses(); //Recupération des réponses
            AffichagerAllReponses();//affiche les images des bonnes et mauvaises réponses
            GestionnaireMiniJeuBrasDeFer.SetGagnantPrecedent(GestionnaireMiniJeuBrasDeFer.GetGagnant()); //changement du joueur precedent
            if (GestionnaireMiniJeuBrasDeFer.DefinirGagnant() == true)
            {
                progressBarAdversaire.Increment(-valeur);
                progressBarPersoMain.Increment(valeur);
            }
            else
            {
                progressBarAdversaire.Increment(valeur);
                progressBarPersoMain.Increment(-valeur);
            }
            GestionnaireMiniJeuBrasDeFer.CalculTemps();
            AffichageTempsPersonnages();
            timerGestionnaireJeu.Stop();
        }

        private void lbHelp_MouseHover(object sender, EventArgs e)
        {
            //Affichage des instruction du jeux
            richTbHelp.Visible = true;
        }

        private void lbHelp_MouseLeave(object sender, EventArgs e)
        {
            //On enleve les instruction
            richTbHelp.Visible = false;
        }

        private void btQuitter_Click(object sender, EventArgs e)
        {
            //quitter le jeu
            this.Close();
        }

        private void BrasDeFer_FormClosed(object sender, FormClosedEventArgs e)
        {
            //Arret de la musique
            sound.Stop();
        }
    }
}
