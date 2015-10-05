using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Time_Agotchi
{
    public partial class Timeagotchi : Form
    {
        public Timeagotchi()
        {
            InitializeComponent();
        }

        // VARIABLES

        int age;
        string txtHeure;
        string txtMinute;
        string txtSeconde;

        bool instancie;

        Banque banque;

        Personnage joueur;
        Personnage tama;
        Personnage got;
        Personnage chi;
        Personnage axel;

        

        // LOAD


        private void Timeagotchi_Load(object sender, EventArgs e)
        {

            Introduction intro = new Introduction();
            
            intro.ShowDialog();


            //Création des personnages
            Temps tempsJoueur = new Temps(0,10,0);
            joueur = new Personnage(Donnees.GetNom(), tempsJoueur);
            Donnees.AjouterPerso(joueur);

            Temps tempsTama = new Temps(0,10,0);
            tama = new Personnage("tama", tempsTama);
            Donnees.AjouterPerso(tama);

            Temps tempsGot = new Temps(0, 10, 0);
            got = new Personnage("got", tempsGot);
            Donnees.AjouterPerso(got);

            Temps tempsChi = new Temps(0, 10, 0);
            chi = new Personnage("chi", tempsChi);
            Donnees.AjouterPerso(tama);

            Temps tempsAxel = new Temps(0, 10, 0);
            axel = new Personnage("axel", tempsAxel);
            Donnees.AjouterPerso(axel);



            Donnees.GetPersos()[0].SetFaim(10);
            Donnees.GetPersos()[0].SetSoif(10);
            timer.Enabled = true;
            timerAge.Enabled = true;
            pbFaimPerso.Maximum = 10; //maximum de la barre
            pbFaimPerso.Minimum = 0;// minimum de la barre
            pbFaimPerso.Step = 10; //status de la barre
            pbFaimPerso.PerformStep(); //actualise la barre
            pbSoifPerso.Maximum = 10;
            pbSoifPerso.Minimum = 0;
            pbSoifPerso.Step = 10;
            pbSoifPerso.PerformStep();

            age = 0; //age du personnage en minute
            lbNomPerso.Text =  Donnees.GetPersos()[0].GetNom(); //affichage du nom du personnage
            Donnees.GetPersos()[0].GetTemps().SetHeure(0); //nombre d'heure au départ
            Donnees.GetPersos()[0].GetTemps().SetMinute(10); //nombre dem inutes au départ
            Donnees.GetPersos()[0].GetTemps().SetSeconde(0); //nombre de secondes au départ
            lbAgePerso.Text = age.ToString() + " minutes"; //affichage de l'âge du personnage au départ



            //EVENEMENTS


        }

        private void seSuiciderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Donnees.GetPersos()[0].GetTemps().SetHeure(0); Donnees.GetPersos()[0].GetTemps().SetMinute(0); Donnees.GetPersos()[0].GetTemps().SetSeconde(3); //en cas de suicide, le temps restant passe à 3 secondes.
        }

        private void btManger_Click(object sender, EventArgs e)
        {
            if (Donnees.GetPersos()[0].GetTemps().GetMinute() <= 1)
                mort();
            else
            {
                Donnees.GetPersos()[0].GetTemps().retirerMinute();
                Donnees.GetPersos()[0].GetTemps().retirerMinute();
                 Donnees.GetPersos()[0].AjouterRetirerFaim(true);
            }

        }

        private void btBoire_Click(object sender, EventArgs e)
        {
            if (Donnees.GetPersos()[0].GetTemps().GetMinute() == 0)
                mort();
            else
            {
                Donnees.GetPersos()[0].GetTemps().retirerMinute();
                Donnees.GetPersos()[0].AjouterRetirerFaim(true);
            }
        }

        private void btVolerTemps_Click(object sender, EventArgs e)
        {
            //Ouvre un nouveau Form avec un mini jeu où on tente de voler du temps (la réussite ainsi que le nombre de temps voler se décidera au hasard)
        }

        private void btJouerPoker_Click(object sender, EventArgs e)
        {
            //Ouvre un form pour faire un mini jeu de poker (déroulement à déterminer).
        }

        private void btJouerBrasFer_Click(object sender, EventArgs e)
        {
            BrasDeFer brasDeFer = new BrasDeFer();
            brasDeFer.ShowDialog();
            //Ouvre un nouveau Form avec un mini jeu où il faut spammer un bouton pour gagner
        }

        private void btMachineASous_Click(object sender, EventArgs e)
        {
            //jeu de machine à sous
        }

        private void btPlacerTemps_Click(object sender, EventArgs e)
        {
            
           //placer du temps
            if (instancie != true)
            {
                banque = new Banque();
                instancie = true;
                banque.Show();
            }
            else if (instancie == true)
            {
                banque.Show();
            }
        }

        private void aProposToolStripMenuItem_Click(object sender, EventArgs e)
        {
            APropos apropos = new APropos();
            apropos.ShowDialog();
        }


        // METHODES


        private void mort()
        {
            //ouvre un Form pour informer le joueur de sa mort. (prévoir une image et un texte, création, instanciation et ouverture d'un Form, puis fermeture du programme après validation)
            MessageBox.Show("Vous êtes mort");
        }






        // LES TIMERS (THREADS, SE LANCE UNE FOIS TOUS LES X MILISECONDES)


        private void timer_Tick(object sender, EventArgs e)
        {

            //Timer qui check à chaque seconde

            if (Donnees.GetPersos()[0].GetTemps().GetHeure() < 10)
                txtHeure = "0" + Donnees.GetPersos()[0].GetTemps().GetHeure().ToString();
            else
                txtHeure = Donnees.GetPersos()[0].GetTemps().GetHeure().ToString();

            if (Donnees.GetPersos()[0].GetTemps().GetMinute() < 10)
                txtMinute = "0" + Donnees.GetPersos()[0].GetTemps().GetMinute().ToString();
            else
                txtMinute = Donnees.GetPersos()[0].GetTemps().GetMinute().ToString();

            if (Donnees.GetPersos()[0].GetTemps().GetSeconde() < 10)
                txtSeconde = "0" + Donnees.GetPersos()[0].GetTemps().GetSeconde().ToString();
            else
                txtSeconde = Donnees.GetPersos()[0].GetTemps().GetSeconde().ToString();



            lbTempsRestant.Text = txtHeure + ":" + txtMinute + ":" + txtSeconde; //affiche le temps restant 

            //la suite permet le décompte du temps
            if (Donnees.GetPersos()[0].GetTemps().GetSeconde() == 0)
            {
                Donnees.GetPersos()[0].GetTemps().SetSeconde(59);
                if (Donnees.GetPersos()[0].GetTemps().GetMinute() <= 0)
                {
                    if (Donnees.GetPersos()[0].GetTemps().GetSeconde() <= 0)
                    {
                        mort();
                    }
                    else
                    {
                        Donnees.GetPersos()[0].GetTemps().retirerHeure();
                        Donnees.GetPersos()[0].GetTemps().SetMinute(59);
                    }
                }
                else
                {
                    Donnees.GetPersos()[0].GetTemps().retirerMinute();
                }
            }
            else
            {
                Donnees.GetPersos()[0].GetTemps().retirerSeconde();
            }
        }



        private void timerAge_Tick(object sender, EventArgs e)
        {

            //timer qui check toutes les 1 minute
            

            age++; //ajoute 1 minute à l'age du personnage
            lbAgePerso.Text = age.ToString() + " minutes"; //rafraichît l'affichage de l'age


             Donnees.GetPersos()[0].AjouterRetirerFaim(false);//retire 1 de faim
             Donnees.GetPersos()[0].AjouterRetirerSoif(false);//retire 1 de soif
             pbFaimPerso.Step = Donnees.GetPersos()[0].GetFaim();
             pbSoifPerso.Step = Donnees.GetPersos()[0].GetSoif();
            pbFaimPerso.PerformStep(); //rafraichit
            pbSoifPerso.PerformStep(); //rafrachit

            if (Donnees.GetPersos()[0].GetFaim() == 0 || Donnees.GetPersos()[0].GetSoif() == 0) //si le personnage a trop faim ou soif, il meurt
            {
                mort();
            }
        }
    }
}
