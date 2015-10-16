using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Time_Agotchi
{
    class Personnage
    {


        private string nom;
        private int faim;
        private int soif;
        private int minutesPlacees;
        private int secondesPlacees;
        private Temps temps;


        public Personnage(string leNom, Temps letemps)
        {
            nom = leNom;
            faim = 10;
            soif = 10;
            minutesPlacees = 0;
            secondesPlacees = 0;
            temps = letemps;
        }


        public Temps GetTemps()
        {
            return temps;
        }

        //retourne le nom du perso
        public string GetNom()
        {
            return nom;
        }

        //modifie le nom du perso
        public void SetNom(string leNom)
        {
            nom = leNom;
        }

        //retourne le niveau de faim sur 10 du perso (0 = mort)
        public int GetFaim()
        {
            return faim;
        }

        //Modifie la faim du perso
        public void SetFaim(int laFaim)
        {
            faim = laFaim;
        }

        //retire ou ajoute 1 point de faim
        public void AjouterRetirerFaim(bool ajouter)
        {
            if (ajouter && faim < 10)
                faim++;
            else if (ajouter == false && faim > 0)
                faim--;
        }

        //retourne le niveau de soif sur 10 du perso (0=mort)
        public int GetSoif()
        {
            return soif;
        }

        //modifie le niveau de soif
        public void SetSoif(int laSoif)
        {
            soif = laSoif;
        }


        //ajoute ou retire un point de soif
        public void AjouterRetirerSoif(bool ajouter)
        {
            if (ajouter && soif < 10)
                soif++;
            else if (ajouter == false && soif > 0)
                soif--;
        }

        //retourne le nombre de minutes placées
        public int GetMinutesPlacees()
        {
            return minutesPlacees;
        }

        //permet de modifier le nombre de minutes placées
        public void SetMinutesPlacees(int minutes)
        {
            minutesPlacees = minutes;
        }

        //retourne le nombre de secondes placées
        public int GetSecondesPlacees()
        {
            return secondesPlacees;
        }

        //permet de modifier le nombre de secondes placées
        public void SetSecondesPlacees(int secondes)
        {
            secondesPlacees = secondes;
        }

        public override string ToString()
        {
            string txtHeure;
            string txtMinute;
            string txtSeconde;
            string temps;
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



            temps = txtHeure + ":" + txtMinute + ":" + txtSeconde;
            return temps;
        }
    }
}
