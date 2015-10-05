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
    public partial class Banque : Form
    {
        public Banque()
        {
            InitializeComponent();
        }

        int minutes = 0; //minute pour l'affichage
        int secondes = 0; //secondes pour l'affichage
        int secondesgagnees = 0; //nombre de secondes gagnées grâce au placement

        private void Banque_Load(object sender, EventArgs e)
        {
        }

        private void btPlacer_Click(object sender, EventArgs e)
        {
            timerPlacement.Enabled = true;

            Donnees.GetPersos()[0].SetSecondesPlacees(Convert.ToInt32(tbSecPlacement.Text)); //on place le temps

            minutes = Donnees.GetPersos()[0].GetSecondesPlacees() / 60; //on converti en minutes et en secondes
            secondes = Donnees.GetPersos()[0].GetSecondesPlacees() % 60;

            Donnees.GetPersos()[0].GetTemps().retirerSeconde(secondes); //on retire le temps placé au temps du joueur
            Donnees.GetPersos()[0].GetTemps().retirerMinute(minutes);

            lbTempsPlace.Visible = true; //on fait apparaitre l'affichage du temps placé
            lbTempsPlace.Text = minutes + " minutes et " + secondes + " secondes."; //actualisation de l'affichage
            btPlacer.Enabled = false;
            btRecup.Enabled = true;

        }

        private void timerPlacement_Tick(object sender, EventArgs e)
        {
            secondesgagnees = Donnees.GetPersos()[0].GetSecondesPlacees() / 10 ; //10% du temps placé est gagné
            Donnees.GetPersos()[0].SetSecondesPlacees( Donnees.GetPersos()[0].GetSecondesPlacees() + secondesgagnees); //on ajoute ce temps au temps placé
            secondesgagnees = 0; //reinitialisation
            minutes = Donnees.GetPersos()[0].GetSecondesPlacees() / 60; //on converti en minutes et en secondes
            secondes = Donnees.GetPersos()[0].GetSecondesPlacees() % 60;
            lbTempsPlace.Text = minutes + " minutes et " + secondes + " secondes."; //actualisation de l'affichage
        }

        private void btRecup_Click(object sender, EventArgs e)
        {
            Donnees.GetPersos()[0].GetTemps().ajouterSeconde(Donnees.GetPersos()[0].GetSecondesPlacees()); //on récupere le temps
            Donnees.GetPersos()[0].SetSecondesPlacees(0); // on le supprime du placement
            secondesgagnees = 0; //reinitialisation
            lbTempsPlace.Visible = false;
            timerPlacement.Enabled = false;
            btPlacer.Enabled = true;
            btRecup.Enabled = false;
        }

        private void btFermer_Click(object sender, EventArgs e)
        {
            this.Hide();
        }


    }
}
