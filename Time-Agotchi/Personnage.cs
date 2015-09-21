using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Time_Agotchi
{
    static class Personnage
    {
        private static string nom;
        private static int faim;
        private static int soif;

        //retourne le nom du perso
        public static string GetNom()
        {
            return nom;
        }

        //modifie le nom du perso
        public static void SetNom(string leNom)
        {
            nom = leNom;
        }

        //retourne le niveau de faim sur 10 du perso (0 = mort)
        public static int GetFaim()
        {
            return faim;
        }

        //Modifie la faim du perso
        public static void SetFaim(int laFaim)
        {
            faim = laFaim;
        }

        //retire ou ajoute 1 point de faim
        public static void AjouterRetirerFaim(bool ajouter)
        {
            if (ajouter && faim < 10)
                faim++;
            else if (ajouter == false && faim > 0)
                faim--;
        }

        //retourne le niveau de soif sur 10 du perso (0=mort)
        public static int GetSoif()
        {
            return soif;
        }

        //modifie le niveau de soif
        public static void SetSoif(int laSoif)
        {
            soif = laSoif;
        }


        //ajoute ou retire un point de soif
        public static void AjouterRetirerSoif(bool ajouter)
        {
            if (ajouter && soif < 10)
                soif++;
            else if (ajouter == false && soif > 0)
                soif--;
        }
    }
}
