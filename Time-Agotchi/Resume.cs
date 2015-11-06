using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Time_Agotchi
{
    public partial class Resume : Form
    {
        public Resume()
        {
            InitializeComponent();
        }

        Temps tempsTama;
        Temps tempsGot;
        Temps tempsChi;
        Temps tempsAxel;

        string txtHeure;
        string txtMinute;
        string txtSeconde;
        

        private void Resume_Load(object sender, EventArgs e)
        {
           
        }



        private void timerAffichage_Tick(object sender, EventArgs e)
        {


            tempsTama = Donnees.GetPersos()[1].GetTemps();
            tempsGot = Donnees.GetPersos()[2].GetTemps();
            tempsChi = Donnees.GetPersos()[3].GetTemps();
            tempsAxel = Donnees.GetPersos()[4].GetTemps();

            if (tempsTama.GetHeure() == 0 && tempsTama.GetMinute() == 0 && tempsTama.GetSeconde() == 0)
                lbTempsTama.Text = "Mort(e)";
            if (tempsGot.GetHeure() == 0 && tempsGot.GetMinute() == 0 && tempsGot.GetSeconde() == 0)
                lbTempsGot.Text = "Mort(e)";
            if (tempsChi.GetHeure() == 0 && tempsChi.GetMinute() == 0 && tempsChi.GetSeconde() == 0)
                lbTempsChi.Text = "Mort(e)";
            if (tempsAxel.GetHeure() == 0 && tempsAxel.GetMinute() == 0 && tempsAxel.GetSeconde() == 0)
                lbTempsAxel.Text = "Mort(e)";

            //temps Tama

            if (tempsTama.GetHeure() < 10)
                txtHeure = "0" + tempsTama.GetHeure().ToString();
            else
                txtHeure = tempsTama.GetHeure().ToString();

            if (tempsTama.GetMinute() < 10)
                txtMinute = "0" + tempsTama.GetMinute().ToString();
            else
                txtMinute = tempsTama.GetMinute().ToString();

            if (tempsTama.GetSeconde() < 10)
                txtSeconde = "0" + tempsTama.GetSeconde().ToString();
            else
                txtSeconde = tempsTama.GetSeconde().ToString();
            lbTempsTama.Text = txtHeure + ":" + txtMinute + ":" + txtSeconde;


            //temps Got

            if (tempsGot.GetHeure() < 10)
                txtHeure = "0" + tempsGot.GetHeure().ToString();
            else
                txtHeure = tempsGot.GetHeure().ToString();

            if (tempsGot.GetMinute() < 10)
                txtMinute = "0" + tempsGot.GetMinute().ToString();
            else
                txtMinute = tempsGot.GetMinute().ToString();

            if (tempsGot.GetSeconde() < 10)
                txtSeconde = "0" + tempsGot.GetSeconde().ToString();
            else
                txtSeconde = tempsGot.GetSeconde().ToString();
            lbTempsGot.Text = txtHeure + ":" + txtMinute + ":" + txtSeconde;

            //temps Chi

            if (tempsChi.GetHeure() < 10)
                txtHeure = "0" + tempsChi.GetHeure().ToString();
            else
                txtHeure = tempsChi.GetHeure().ToString();

            if (tempsChi.GetMinute() < 10)
                txtMinute = "0" + tempsChi.GetMinute().ToString();
            else
                txtMinute = tempsChi.GetMinute().ToString();

            if (tempsChi.GetSeconde() < 10)
                txtSeconde = "0" + tempsChi.GetSeconde().ToString();
            else
                txtSeconde = tempsChi.GetSeconde().ToString();
            lbTempsChi.Text = txtHeure + ":" + txtMinute + ":" + txtSeconde;

            //temps Axel

            if (tempsAxel.GetHeure() < 10)
                txtHeure = "0" + tempsAxel.GetHeure().ToString();
            else
                txtHeure = tempsAxel.GetHeure().ToString();

            if (tempsAxel.GetMinute() < 10)
                txtMinute = "0" + tempsAxel.GetMinute().ToString();
            else
                txtMinute = tempsAxel.GetMinute().ToString();

            if (tempsAxel.GetSeconde() < 10)
                txtSeconde = "0" + tempsAxel.GetSeconde().ToString();
            else
                txtSeconde = tempsAxel.GetSeconde().ToString();
            lbTempsAxel.Text = txtHeure + ":" + txtMinute + ":" + txtSeconde;



        }
    }
}
