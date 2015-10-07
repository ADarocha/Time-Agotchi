using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Time_Agotchi
{
    static class GestionnaireMiniJeuBrasDeFer
    {
        private static List<string> nomDeFleches = new List<string> { "haut", "bas", "gauche", "droite" };
        private static List<string> listeFleches = new List<string>(); //liste de fléches généres par l'ordinateur
        private static List<string> listeFlechesEntrees = new List<string>(); //les fléches entrées par le joueur
        private static List<bool> reponses = new List<bool>(); //bonne ou mauvais réponses du joueur 

  
        
        public static List<string> GetFleches()
        {
            return listeFleches;
        }

        public static void GenererFleche()
        {
            
        }

        public static void GenererListeDeFleches(int nombreDeFleches)
        {
            ///methode qui génére un certain nombre de fléches et qui les met dans la listeFleches
            Random rd = new Random();
            for (int i = 0; i < nombreDeFleches; i++)
            {
                
                int numeroRandom = rd.Next(3);


                listeFleches.Add(nomDeFleches[numeroRandom]);
            }
        }

    }
}
