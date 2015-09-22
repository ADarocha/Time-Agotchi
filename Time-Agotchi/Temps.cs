using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Time_Agotchi
{
    class Temps
    {

        private static int heure;
        private static int minute;
        private static int seconde;


        //accesseurs 

        public static int GetHeure()
        {
            return heure;
        }
        public static int GetMinute()
        {
            return minute;
        }
        public static int GetSeconde()
        {
            return seconde;
        }

        //mutateurs

        public static void SetHeure(int h)
        {
            heure = h;
        }
        public static void SetMinute(int m)
        {
            minute = m;
        }
        public static void SetSeconde(int s)
        {
            seconde = s;
        }


        // ces méthodes permettent d'ajouter 1 unité 

        public static void ajouterHeure()
        {
            heure++;
        }
        public static void ajouterMinute()
        {
            minute++;
        }

        public static void ajouterSeconde()
        {
            seconde++;
        }

        //surchargent qui permettent de rajouter un nombre défini

        public static void ajouterHeure(int h)
        {
            heure = heure + h;
        }
        public static void ajouterMinute(int m)
        {
            minute = minute + m;
        }

        public static void ajouterSeconde(int s)
        {
            seconde = seconde + s;
        }



        // ces trois méthodes retirent 1 unité 

        public static void retirerHeure()
        {
            heure--;
        }

        public static void retirerMinute()
        {
            minute--;
        }

        public static void retirerSeconde()
        {
            seconde--;
        }


        //surcharges qui permettent de retirer un nombre défini

        public static void retirerHeure(int h)
        {
            heure = heure - h;
        }

        public static void retirerMinute(int m)
        {
            minute = minute - m;
        }

        public static void retirerSeconde(int s)
        {
            seconde = seconde - s;
        }



    }
}
