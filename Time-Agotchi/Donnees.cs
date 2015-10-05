using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Time_Agotchi
{
    static class Donnees
    {

        private static List<Personnage> listePersos = new List<Personnage>();
        private static string nomPerso;

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

        public static void AjouterPerso(Personnage perso)
        {
            listePersos.Add(perso);
        }
    }
}
