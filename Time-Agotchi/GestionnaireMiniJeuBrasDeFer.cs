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

        public static List<string> GetlisteFlechesEntrees()
        {
            return listeFlechesEntrees;
        }

        public static List<bool> GetlisteReponses()
        {
            return reponses;
        }

        public static void GenererListeDeFleches(int nombreDeFleches)
        {
            ///methode qui génére un certain nombre de fléches et qui les met dans la listeFleches
            ///On clean les fleches parcqu'on va utiliser plusieurs fois cette methode.
            listeFleches.Clear();
            Random rd = new Random();
            for (int i = 0; i < nombreDeFleches; i++)
            {
                
                int numeroRandom = rd.Next(3);


                listeFleches.Add(nomDeFleches[numeroRandom]);
            }
        }

        private static bool VerificationDesEntreesVides(List<string> listeEntrees)
        {
            bool verification_valide;
            //methode qui renvoie faut se ile jouer n'a rien entrée ou si taille des entres ne correspond pas a la taille demandé (4) fleches
            if (listeEntrees.Count == 0)
            {
                verification_valide = true;
            }
            
            else
                verification_valide = false;
            return verification_valide;

        }

        public static List<bool> GetReponses()
        {
            //Retourne une liste de booleen true correspond a une bonne reponses false a une mauvaise
            //On procéde par vérifications
            //premiere verification si la liste d'entrees est vide on met false a tout la liste de retour
            if (VerificationDesEntreesVides(listeFlechesEntrees)==true)    
            {
                for (int i = 0; i < 4; i++)
                {
                    reponses.Add(false);
                }
            }
            //deuxieme verification si la liste d'entres a moins d'entrees que la liste affiche (4)
            //on recupere les reponses mauvaises et bonnes et pour le reste d'entrees non sésies on met false
            else if (listeFlechesEntrees.Count != 4)
            {
                int nbMauvesReponses;
                for (int i = 0; i < listeFlechesEntrees.Count; i++)
                {
                    if (listeFlechesEntrees[i] != listeFleches[i])
                    {
                        reponses.Add(false);
                    }
                    else
                        reponses.Add(true);
                }
                nbMauvesReponses = listeFleches.Count - listeFlechesEntrees.Count;
                for(int i = 0; i<nbMauvesReponses; i++)
                {
                    reponses.Add(false);
                }
            }
            //si le nombre d'entress est correcte on compara tout les reponses
            else if (listeFlechesEntrees.Count == 4)
            {
                for (int i = 0; i < listeFlechesEntrees.Count; i++)
                {
                    if (listeFlechesEntrees[i] != listeFleches[i])
                    {
                        reponses.Add(false);
                    }
                    else
                        reponses.Add(true);
                }
            }

            return reponses;

        }

    }
}
