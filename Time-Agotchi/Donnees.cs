using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Time_Agotchi
{
    static class Donnees
    {

        private static List<Personnage> listePersos = new List<Personnage>();
        private static List<Personnage> listeAdversaires = new List<Personnage>(); //liste de personnages qui vont faire le mini jeu
        private static string nomPerso;
        private static bool charge;

        public static void SetNom(string leNom)
        {
            nomPerso = leNom;
        }

        public static string GetNom()
        {
            return nomPerso;
        }


        public static List<Personnage> GetPersos()
        {
            return listePersos;
        }
        public static void SetPersonnages(List<Personnage> maliste)
        {
            listePersos = maliste;
        }

        public static void AjouterPerso(Personnage perso)
        {
            listePersos.Add(perso);
        }

        public static List<Personnage> GetAdversaires()
        {
            return listeAdversaires;
        }

        public static void SetCharge(bool rep)
        {
            charge = rep;
        }

        public static bool GetCharge()
        {
            return charge;
        }
    }
}
