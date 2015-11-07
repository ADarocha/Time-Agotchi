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
    public partial class VolDuTemps : Form
    {
        public VolDuTemps()
        {
            InitializeComponent();
        }

        private void btRetourMenu_Click(object sender, EventArgs e)
        {
            this.Close();
            //On ferme la page VolDuTemps.cs
        }

        private void cBVolDuTemps_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch(cBVolDuTemps.SelectedItem.ToString()){
                case "Tama":
                    pbAdversaire.Image = Properties.Resources.Fille1;
                    break;
                case "Got":
                    pbAdversaire.Image = Properties.Resources.Méchant1;
                    break;
                case "Chi":
                    pbAdversaire.Image = Properties.Resources.Méchant2;
                    break;
            }
            //Selon le nom de la personne selectionnée dans la comboBox, on change l'image de l'adversaire
        }

        private void btVolDuTemps_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int chanceReussite;
            infoDuVol.Visible = true;
            switch (cBVolDuTemps.SelectedItem.ToString())
            {
                // Pour Tama, La chance est de 1/2, On peut gagner 1minute ou perdre 2minutes.
                case "Tama":
                    chanceReussite = Convert.ToInt32(rnd.Next(1, 100));
                    if (chanceReussite >= 50)
                    {
                        Donnees.GetPersos()[0].GetTemps().ajouterMinute(1);
                        Donnees.GetPersos()[1].GetTemps().retirerMinute(1);
                        infoDuVol.Text = "Vous avez gagné 1 minute";
                    }
                    else
                    {
                        
                            Donnees.GetPersos()[1].GetTemps().ajouterMinute(2);
                            Donnees.GetPersos()[0].GetTemps().retirerMinute(2);
                            infoDuVol.Text = "Vous avez perdu 2 minutes";
                        
                    }
                    break;

                // Pour Got, La chance est de 10%, On peut gagner 10 minutes ou perdre 1 minute.
                case "Got":
                    chanceReussite = Convert.ToInt32(rnd.Next(1, 100));
                    if (chanceReussite >= 90)
                    {
                        Donnees.GetPersos()[0].GetTemps().ajouterMinute(10);
                        Donnees.GetPersos()[2].GetTemps().retirerMinute(10);
                        infoDuVol.Text = "Vous avez gagné 10 minutes";
                    }
                    else
                    {
                        
                            Donnees.GetPersos()[2].GetTemps().ajouterMinute(1);
                            Donnees.GetPersos()[0].GetTemps().retirerMinute(1);
                            infoDuVol.Text = "Vous avez perdu 1 minute";
                        
                    }
                    break;
                
                // Pour Chi, La chance est de 30%, On peut gagner 3 minutes ou perdre 1 minutes.
                case "Chi":
                    chanceReussite = Convert.ToInt32(rnd.Next(1, 100));
                    if (chanceReussite >= 30)
                    {
                        Donnees.GetPersos()[0].GetTemps().ajouterMinute(3);
                        Donnees.GetPersos()[3].GetTemps().retirerMinute(3);
                        infoDuVol.Text = "Vous avez gagné 3 minutes";
                    }
                    else
                    {
                            Donnees.GetPersos()[3].GetTemps().ajouterMinute(1);
                            Donnees.GetPersos()[0].GetTemps().retirerMinute(1);
                            infoDuVol.Text = "Vous avez perdu 1 minute";
                    }
                    break;
            }
        }

        private void VerifVivant_Tick(object sender, EventArgs e)
        {
            if (Donnees.GetPersos()[1].GetTemps().GetHeure() == 0 && Donnees.GetPersos()[1].GetTemps().GetMinute() == 0 && Donnees.GetPersos()[1].GetTemps().GetSeconde() == 0)
            {
                cBVolDuTemps.Items.Remove("Tama");
            }
            if (Donnees.GetPersos()[2].GetTemps().GetHeure() == 0 && Donnees.GetPersos()[2].GetTemps().GetMinute() == 0 && Donnees.GetPersos()[2].GetTemps().GetSeconde() == 0)
            {
                cBVolDuTemps.Items.Remove("Got");
            }
            if (Donnees.GetPersos()[3].GetTemps().GetHeure() == 0 && Donnees.GetPersos()[3].GetTemps().GetMinute() == 0 && Donnees.GetPersos()[3].GetTemps().GetSeconde() == 0)
            {
                cBVolDuTemps.Items.Remove("Chi");
            }
        
        }

        private void VolDuTemps_Load(object sender, EventArgs e)
        {

        }

    }
}
