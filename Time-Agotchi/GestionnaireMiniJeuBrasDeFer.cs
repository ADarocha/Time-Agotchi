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
        private static List<bool> listeReponses = new List<bool>(); //bonne ou mauvais réponses du joueur 
        private static Personnage personnageMain = Donnees.GetPersos()[0]; //recuprer le personnage principal
        private static Personnage adversaire; //prends l'adversaire dans la liste de la classe donnes
        private static Personnage gagnant;
        private static Personnage perdant;
        private static Personnage gagnatPrecedant; //pour faire le systeme du "MemeGagnant?"
        private static int points; //points perdu du joueur perdant de la manche precédente
        
        
        
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
            return listeReponses;
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
        /// <summary>
        /// Debut Sets et Gets
        /// </summary>
        /// <param name="unPerso"></param>
        public static void SetAdversaire(Personnage unPerso)
        {
            adversaire = unPerso;
        }

        public static Personnage GetAdversaire()
        {
            return adversaire;
        }
        public static Personnage GetMainPerso()
        {
            return personnageMain;
        }
        public static void SetMainPerso(Personnage unPerso)
        {
            personnageMain = unPerso;
        }

        public static Personnage GetPerdant()
        {
            return perdant;
        }
        public static Personnage GetGagnant()
        {
            return gagnant;
        }
        public static Personnage GetGagantPrecedent()
        {
            return gagnatPrecedant;
        }
        public static void SetGagnantPrecedent(Personnage unPerso)
        {
            gagnatPrecedant = unPerso;
        }
        /// <summary>
        /// FIN SET ET GET
        /// </summary>
        /// <returns></returns>
        private static bool VerificationDesEntreesVides()
        {
            bool verification_valide;
            //methode qui renvoie faut se ile jouer n'a rien entrée ou si taille des entres ne correspond pas a la taille demandé (4) fleches
            if (listeFlechesEntrees.Count == 0)
            {
                verification_valide = true;
            }
            
            else
                verification_valide = false;
            return verification_valide;

        }

        public static void GenererReponses()
        {
            //Retourne une liste de booleen true correspond a une bonne reponses false a une mauvaise
            //On procéde par vérifications
            //premiere verification si la liste d'entrees est vide on met false a tout la liste de retour
            listeReponses.Clear();
            
            if (VerificationDesEntreesVides()==true)    
            {
                for (int i = 0; i < 4; i++)
                {
                    listeReponses.Add(false);
                }
            }
            //deuxieme verification si la liste d'entres a moins d'entrees que la liste affiche (4)
            //on recupere les reponses mauvaises et bonnes et pour le reste d'entrees non sésies on met false
            else if (listeFlechesEntrees.Count < 4)
            {
                int nbMauvesReponses;
                for (int i = 0; i < listeFlechesEntrees.Count; i++)
                {
                    if (listeFlechesEntrees[i] != listeFleches[i])
                    {
                        listeReponses.Add(false);
                    }
                    else
                        listeReponses.Add(true);
                }
                nbMauvesReponses = listeFleches.Count - listeFlechesEntrees.Count;
                for(int i = 0; i<nbMauvesReponses; i++)
                {
                    listeReponses.Add(false);
                }
            }

            //si le nombre d'entrees dépasse la liste demandé on compte juste les 4 premieres réponses
                //pour ça la boucle for prends en paramètre le nombre de la listeFleches = 4
            else if (listeFlechesEntrees.Count > 4)
            {
                
                for (int i = 0; i <  listeFleches.Count; i++)
                {
                    if (listeFlechesEntrees[i] != listeFleches[i])
                    {
                        listeReponses.Add(false);
                    }
                    else
                        listeReponses.Add(true);
                }
               
            }
            //si le nombre d'entress est correcte on compare toutes les reponses
            else if (listeFlechesEntrees.Count == 4)
            {
                for (int i = 0; i < listeFlechesEntrees.Count; i++)
                {
                    if (listeFlechesEntrees[i] != listeFleches[i])
                    {
                        listeReponses.Add(false);
                    }
                    else
                        listeReponses.Add(true);
                }
            }

           

        }

        public static bool DefinirGagnant()
        {
            //on définit le gagnant de chaque série.
            //si le joueur main a une mauvaise réponses alors il est pendant et l'adversaire gagnant
            //si non le contraire
            bool estGagnat = false;
            foreach (bool b in listeReponses)
            {
                if (b == false)
                {
                    estGagnat = false;
                    perdant = personnageMain;
                    gagnant = adversaire;
                    break;
                }
                else
                {
                    estGagnat = true;
                    perdant = adversaire;
                    gagnant = personnageMain;
                   
                }
            }
            return estGagnat;
        }

        public static bool VerificationMemeGagnant()
        {
            //methode qui retourne vrai si on a eu le meme gagnant de suite
            //false si le gagnant a changé
            //si il y a pas de gagant precedent on retourne false
            if (gagnatPrecedant == null)
            {
                return false;
            }
            else if (gagnant.GetNom() == gagnatPrecedant.GetNom())
                return true;
            else
                return false;
        }
        /// <summary>
        /// Methode CalculTemps
        /// Recalcul les temps des adversaires après manche (après les entrées des flèches)
        /// Il va calculer combien de temps il faut attribuer à chaque joueur
        /// </summary>
        public static void CalculTemps()
        {
            //si on a le meme gagnant que la manche prescedente on prends le meme temps qu'on avait pris
            //à l'adversaire et on l'ajoute au temps des gagnant
            
            int pointsCalcul;
            if (VerificationMemeGagnant() == true)
            {

                pointsCalcul = points;
            }
            //si le gagant à changé alors on prends la motié du nouveau perdant
            //et on la met dans la varaible points pour l'avoir à la prochaine manche.
            else
            {
                pointsCalcul = (perdant.GetTemps().GetTimeEnSecondes()) / 2;
                points = pointsCalcul;

            }
            //ensuite on ajoute et on diminue les temps de joueurs selon s'ils ont perdu ou gagné
            gagnant.GetTemps().ajouterSeconde(pointsCalcul);
            perdant.GetTemps().retirerSeconde(pointsCalcul);
            //pour ne pas avoir de bug
            //au niveaux de calcul: ils ne tombent pas juste parfois parcequ'on divise par deux
            //on on a des entiers
            //donc il reste des 1 min ou 1 seconde pour les enlever on mes à 0 quand on ces valeurs.
            //if (gagnant.gettemps().getseconde() == 1)
            //{
            //    gagnant.gettemps().setseconde(0);
            //}
            if (perdant.GetTemps().GetSeconde() == 1)
            {
                perdant.GetTemps().SetSeconde(0);
            }
            //if (gagnant.GetTemps().GetMinute() == 1)
            //{
            //    gagnant.GetTemps().SetMinute(0);
            //}
            if (perdant.GetTemps().GetMinute() == 1)
            {
                perdant.GetTemps().SetMinute(0);
            }
        }
    }
}
