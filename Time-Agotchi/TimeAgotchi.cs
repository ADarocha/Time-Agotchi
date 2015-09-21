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


        int heure;
        int minute;
        int seconde;
        int age;
        string txtHeure;
        string txtMinute;
        string txtSeconde;


        // LOAD


        private void Timeagotchi_Load(object sender, EventArgs e)
        {

            Introduction intro = new Introduction();
            intro.ShowDialog();

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
            lbNomPerso.Text = Personnage.GetNom(); //affichage du nom du personnage
            heure = 0; //nombre d'heure au départ
            minute = 10; //nombre dem inutes au départ
            seconde = 0; //nombre de secondes au départ
            lbAgePerso.Text = age.ToString() + " minutes"; //affichage de l'âge du personnage au départ



            //EVENEMENTS


        }

        private void seSuiciderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            heure = 0; minute = 0; seconde = 3; //en cas de suicide, le temps restant passe à 3 secondes.
        }

        private void btManger_Click(object sender, EventArgs e)
        {
            if (minute <= 1)
                mort();
            else
            {
                minute--;
                minute--;
                Personnage.AjouterRetirerFaim(true);
            }

        }

        private void btBoire_Click(object sender, EventArgs e)
        {
            if (minute == 0)
                mort();
            else
            {
                minute--;
                Personnage.AjouterRetirerFaim(true);
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
            //Ouvre un nouveau Form avec un mini jeu où il faut spammer un bouton pour gagner
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

            if (heure < 10)
                txtHeure = "0" + heure.ToString();
            else
                txtHeure = heure.ToString();

            if (minute < 10)
                txtMinute = "0" + minute.ToString();
            else
                txtMinute = minute.ToString();

            if (seconde < 10)
                txtSeconde = "0" + seconde.ToString();
            else
                txtSeconde = seconde.ToString();



            lbTempsRestant.Text = txtHeure + ":" + txtMinute + ":" + txtSeconde; //affiche le temps restant 

            //la suite permet le décompte du temps
            if (seconde == 0)
            {
                seconde = 59;
                if (minute == 0)
                {
                    if (heure == 0)
                    {
                        mort();
                    }
                    else
                    {
                        heure--;
                        minute = 59;
                    }
                }
                else
                {
                    minute--;
                }
            }
            else
            {
                seconde--;
            }
        }



        private void timerAge_Tick(object sender, EventArgs e)
        {

            //timer qui check toutes les 1 minute
            

            age++; //ajoute 1 minute à l'age du personnage
            lbAgePerso.Text = age.ToString() + " minutes"; //rafraichît l'affichage de l'age


            Personnage.AjouterRetirerFaim(false);//retire 1 de faim
            Personnage.AjouterRetirerSoif(false);//retire 1 de soif
            pbFaimPerso.PerformStep(); //rafraichit
            pbSoifPerso.PerformStep(); //rafrachit

            if (Personnage.GetFaim() == 0 || Personnage.GetSoif() == 0) //si le personnage a trop faim ou soif, il meurt
            {
                mort();
            }
        }

        private void aProposToolStripMenuItem_Click(object sender, EventArgs e)
        {
            APropos apropos = new APropos();
            apropos.ShowDialog();
        }

    }
}
