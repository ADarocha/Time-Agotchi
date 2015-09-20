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


        public static string GetNom()
        {
            return nom;
        }

        public static void SetNom(string leNom)
        {
            nom = leNom;
        }

        public static int GetFaim()
        {
            return faim;
        }

        public static void SetFaim(int laFaim)
        {
            faim = laFaim;
        }

        public static void AjouterRetirerFaim(bool ajouter)
        {
            if (ajouter)
                faim++;
            else if (ajouter == false)
                faim--;
        }

        public static int GetSoif()
        {
            return soif;
        }

        public static void SetSoif(int laSoif)
        {
            soif = laSoif;
        }

        public static void AjouterRetirerSoif(bool ajouter)
        {
            if (ajouter)
                soif++;
            else if (ajouter == false)
                soif--;
        }
    }
}
