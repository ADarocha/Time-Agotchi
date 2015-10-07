using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Time_Agotchi
{
    class Temps
    {

        private int heure;
        private int minute;
        private int seconde;

        


        public Temps(int uneHeure, int uneMinute, int uneSeconde)
        {
            heure = uneHeure;
            minute = uneMinute;
            seconde = uneSeconde;
        }

        //accesseurs 

        public int GetHeure()
        {
            return heure;
        }
        public int GetMinute()
        {
            return minute;
        }
        public int GetSeconde()
        {
            return seconde;
        }


        //mutateurs

        public void SetHeure(int h)
        {
            heure = h;
        }
        public void SetMinute(int m)
        {
            minute = m;
        }
        public void SetSeconde(int s)
        {
            seconde = s;
        }


        // ces méthodes permettent d'ajouter 1 unité 

        public void ajouterHeure()
        {
            heure++;
        }
        public void ajouterMinute()
        {
            minute++;
        }

        public void ajouterSeconde()
        {
            seconde++;
        }

        //surchargent qui permettent de rajouter un nombre défini
        public void ajouterHeure(int h)
        {
            heure = heure + h;
        }
        public void ajouterMinute(int m)
        {
            minute = minute + m;
            int ajoutheure = minute / 60;
            minute = minute % 60;
            heure = heure + ajoutheure;
        }


        public void ajouterSeconde(int s)
        {
            seconde = seconde + s;
            int ajoutminute = seconde / 60;
            seconde = seconde % 60;
            minute = minute + ajoutminute;
        }



        // ces trois méthodes retirent 1 unité 
        public void retirerHeure()
        {
            heure--;
        }

        public void retirerMinute()
        {
            minute--;
        }

        public void retirerSeconde()
        {
            seconde--;
        }


        //surcharges qui permettent de retirer un nombre défini
        public void retirerHeure(int h)
        {
            heure = heure - h;
        }

        public void retirerMinute(int m)
        {
            int heure = m / 60;
            if (heure > 0)
                retirerHeure(heure);
            minute = minute - (m%60);
            
        }

        public void retirerSeconde(int s)
        {
            int min = s / 60;
            if(min > 0)
                retirerMinute(min);
            seconde = seconde - (s % 60);
        }



    }
}
