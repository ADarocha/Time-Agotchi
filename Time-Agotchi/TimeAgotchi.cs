using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

namespace Time_Agotchi
{
    public partial class Timeagotchi : Form
    {
        public Timeagotchi()
        {
            InitializeComponent();
        }

        // VARIABLES

        int age;
        string txtHeure;
        string txtMinute;
        string txtSeconde;

        bool instancie;

        Banque banque;

        Personnage joueur;
        Personnage tama;
        Personnage got;
        Personnage chi;
        Personnage axel;

        Temps tempsPerso;
        Temps tempsDeTama;
        Temps tempsDeGot;
        Temps tempsDeChi;
        Temps tempsDeAxel;
        Personnage leJoueur;


        // LOAD


        private void Timeagotchi_Load(object sender, EventArgs e)
        {
           
            //ouverture du form d'introduction
            Introduction intro = new Introduction();
           
            intro.ShowDialog();

            if (Donnees.GetCharge() == false)
            {
                Temps tempsJoueur = new Temps(0, 10, 0);
                joueur = new Personnage(Donnees.GetNom(), tempsJoueur);
                Donnees.AjouterPerso(joueur);

                Temps tempsTama = new Temps(0, 10, 0);
                tama = new Personnage("tama", tempsTama);
                Donnees.AjouterPerso(tama);

                Temps tempsGot = new Temps(0, 10, 0);
                got = new Personnage("got", tempsGot);
                Donnees.AjouterPerso(got);

                Temps tempsChi = new Temps(0, 10, 0);
                chi = new Personnage("chi", tempsChi);
                Donnees.AjouterPerso(chi);

                Temps tempsAxel = new Temps(0, 10, 0);
                axel = new Personnage("axel", tempsAxel);
                Donnees.AjouterPerso(axel);


                



                //Création des personnages

                // création du joueur 
            }

            //references
            tempsPerso = Donnees.GetPersos()[0].GetTemps();
            tempsDeTama = Donnees.GetPersos()[1].GetTemps();
            tempsDeGot = Donnees.GetPersos()[2].GetTemps();
            tempsDeChi = Donnees.GetPersos()[3].GetTemps();
            tempsDeAxel = Donnees.GetPersos()[4].GetTemps();
            leJoueur = Donnees.GetPersos()[0];


            //configuration du personnage principal

            if (Donnees.GetCharge() == false)
            {
                leJoueur.SetFaim(10);
                leJoueur.SetSoif(10);
                pbFaimPerso.Maximum = 10; //maximum de la barre
                pbFaimPerso.Minimum = 0;// minimum de la barre
                pbFaimPerso.Step = 1; //status de la barre
                pbFaimPerso.Value = 10;
                pbSoifPerso.Maximum = 10;
                pbSoifPerso.Minimum = 0;
                pbSoifPerso.Step = 1;
                pbSoifPerso.Value = 10;
                tempsPerso.SetHeure(0); //nombre d'heure au départ
                tempsPerso.SetMinute(10); //nombre dem inutes au départ
                tempsPerso.SetSeconde(0); //nombre de secondes au départ


                age = 0; //age du personnage en minute
            }
            else
            {
                pbFaimPerso.Maximum = 10; //maximum de la barre
                pbFaimPerso.Minimum = 0;// minimum de la barre
                pbFaimPerso.Step = 1; //status de la barre
                pbFaimPerso.Value = leJoueur.GetFaim();
                pbSoifPerso.Maximum = 10;
                pbSoifPerso.Minimum = 0;
                pbSoifPerso.Step = 1;
                pbSoifPerso.Value = leJoueur.GetSoif();
            }

            timer.Enabled = true;
            timerAge.Enabled = true;
            lbNomPerso.Text = leJoueur.GetNom(); //affichage du nom du personnage
            lbAgePerso.Text = age.ToString() + " minutes"; //affichage de l'âge du personnage au départ



            //EVENEMENTS


        }

        private void seSuiciderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tempsPerso.SetHeure(0); tempsPerso.SetMinute(0); tempsPerso.SetSeconde(3); //en cas de suicide, le temps restant passe à 3 secondes.
        }

        private void btManger_Click(object sender, EventArgs e)
        {
            //permet au joueur d'acheter à manger. Cela remonte sa barre de faim et lui fais perdre du temps.

            if (tempsPerso.GetMinute() <= 1)
                mort();
            else
            {
                TimerAffichageManger.Interval = 3000;
                TimerAffichageManger.Start();
                pbPersonnage.Image = Properties.Resources.GIF_manger;//stop remettre image personnage
                tempsPerso.retirerMinute(2);
                leJoueur.AjouterRetirerFaim(true);
                if(leJoueur.GetFaim() < 10)
                    pbFaimPerso.Value = leJoueur.GetFaim(); //status de la barre
            }

        }

        private void btBoire_Click(object sender, EventArgs e)
        {
            //comme pour manger.

            if (tempsPerso.GetMinute() == 0)
                mort();
            else
            {
                //on veut afficher l'image boire gif pendant 3 secondes puis ont arrete dans le timerGif
                timerAffichageGif.Interval = 3000;
                timerAffichageGif.Start();
                pbPersonnage.Image = Properties.Resources.GIF_Boire;//stop remettre image personnage
                tempsPerso.retirerMinute(1);
                leJoueur.AjouterRetirerSoif(true);
                if (leJoueur.GetSoif() < 10)
                    pbSoifPerso.Value = leJoueur.GetSoif(); //status de la barre
            }
        }

        private void btVolerTemps_Click(object sender, EventArgs e)
        {
            //Ouvre un nouveau Form avec un mini jeu où on tente de voler du temps.
            VolDuTemps vol = new VolDuTemps();
            vol.Show();
            
        }

        private void btJouerPoker_Click(object sender, EventArgs e)
        {
            //Ouvre un form pour faire un mini jeu de poker (déroulement à déterminer).
        }

        private void btJouerBrasFer_Click(object sender, EventArgs e)
        {
            if (listeBoxInfosPersonnages.Visible ==false)
            {
                
                    MessageBox.Show("Veuillez selectionner un adversaire");
                    listeBoxInfosPersonnages.Visible = true;
                
            }
            else
            {
                //MessageBox.Show(Donnees.GetAdversaires().Count.ToString());
                Personnage adversaire = (Personnage)listeBoxInfosPersonnages.SelectedItem;
                if (adversaire.GetNom() == Donnees.GetPersos()[0].GetNom())
                    MessageBox.Show("Prends un autre adversaire");
                else
                {
                    Donnees.GetAdversaires().Add(adversaire);
                    //MessageBox.Show(Donnees.GetAdversaires().Count.ToString()+" "+ Donnees.GetAdversaires()[0].GetNom());
                    timer.Stop();
                    BrasDeFer brasDeFer = new BrasDeFer();
                    brasDeFer.ShowDialog();
                    //Après fermeture du mini jeu (comeback fenetre principal)
                    timer.Start();
                    Donnees.GetAdversaires().Clear();
                    //MessageBox.Show(Donnees.GetAdversaires().Count.ToString());
                    listeBoxInfosPersonnages.Visible = false;
                }
                
            }
            //Ouvre un nouveau Form avec un mini jeu où il faut spammer un bouton pour gagner
        }

        private void btMachineASous_Click(object sender, EventArgs e)
        {
            //jeu de machine à sous
            MessageBox.Show("Partie non faite.");
        }

        private void btPlacerTemps_Click(object sender, EventArgs e)
        {

            //placer du temps
            if (instancie != true)
            {
                banque = new Banque();
                instancie = true;
                banque.Show();
            }
            else if (instancie == true)
            {
                banque.Show();
            }
        }

        private void aProposToolStripMenuItem_Click(object sender, EventArgs e)
        {
            APropos apropos = new APropos();
            apropos.ShowDialog();
        }


        // METHODES

        //mort du personnage.
        private void mort()
        {
            tempsPerso.SetHeure(0);
            tempsPerso.SetMinute(0);
            tempsPerso.SetSeconde(0);
            timer.Enabled = false;
            lbTempsRestant.Text = "00:00:00";
            Mort mort = new Mort();
            mort.ShowDialog();
            //ensuite, ajouter l'ouverte d'un Form pour informer le joueur de sa mort. (prévoir une image et un texte, création, instanciation et ouverture d'un Form, puis fermeture du programme après validation)

        }



        //découlement du temps.
        private void decouleTemps(Temps leTemps)
        {
            if (leTemps.GetSeconde() == 0)
            {
                leTemps.SetSeconde(59);
                if (leTemps.GetMinute() <= 0)
                {
                    if (leTemps.GetSeconde() <= 0)
                    {
                        mort();
                    }
                    else
                    {
                        leTemps.retirerHeure();
                        leTemps.SetMinute(59);
                    }
                }
                else
                {
                    leTemps.retirerMinute();
                }
            }
            else
            {
                leTemps.retirerSeconde();
            }
        }





        // LES TIMERS (THREADS, SE LANCE UNE FOIS TOUS LES X MILISECONDES)


        private void timer_Tick(object sender, EventArgs e)
        {
            if (tempsPerso.GetHeure() > 0 || tempsPerso.GetMinute() > 0 || tempsPerso.GetSeconde() > 0)
            {
                decouleTemps(tempsPerso); //permet le décompte du temps
            }
            else
            {
                if (tempsPerso.GetHeure() == 0 || tempsPerso.GetMinute() == 0 || tempsPerso.GetSeconde() == 0)
                {
                    mort();
                }
            }
            if (tempsDeTama.GetHeure() > 0 || tempsDeTama.GetMinute() > 0 || tempsDeTama.GetSeconde() > 0)
                decouleTemps(tempsDeTama);
            if (tempsDeGot.GetHeure() > 0 || tempsDeGot.GetMinute() > 0 || tempsDeGot.GetSeconde() > 0)
                decouleTemps(tempsDeGot);
            if (tempsDeChi.GetHeure() > 0 || tempsDeChi.GetMinute() > 0 || tempsDeChi.GetSeconde() > 0)
                decouleTemps(tempsDeChi);
            if (tempsDeAxel.GetHeure() > 0 || tempsDeAxel.GetMinute() > 0 || tempsDeAxel.GetSeconde() > 0)
                decouleTemps(tempsDeAxel);


            //Timer qui check à chaque seconde
            if (tempsPerso.GetHeure() < 10)
                txtHeure = "0" + tempsPerso.GetHeure().ToString();
            else
                txtHeure = tempsPerso.GetHeure().ToString();

            if (tempsPerso.GetMinute() < 10)
                txtMinute = "0" + tempsPerso.GetMinute().ToString();
            else
                txtMinute = tempsPerso.GetMinute().ToString();

            if (tempsPerso.GetSeconde() < 10)
                txtSeconde = "0" + tempsPerso.GetSeconde().ToString();
            else
                txtSeconde = tempsPerso.GetSeconde().ToString();


            lbTempsRestant.Text = txtHeure + ":" + txtMinute + ":" + txtSeconde; //affiche le temps restant 

        }




        private void timerAge_Tick(object sender, EventArgs e)
        {

            //timer qui check toutes les 1 minute


            age++; //ajoute 1 minute à l'age du personnage
            lbAgePerso.Text = age.ToString() + " minutes"; //rafraichît l'affichage de l'age


            leJoueur.AjouterRetirerFaim(false);//retire 1 de faim
            leJoueur.AjouterRetirerSoif(false);//retire 1 de soif
            pbFaimPerso.Value = leJoueur.GetFaim();
            pbSoifPerso.Value = leJoueur.GetSoif();

            if (leJoueur.GetFaim() == 0 || leJoueur.GetSoif() == 0) //si le personnage a trop faim ou soif, il meurt
            {
                mort();
            }
        }

        private void btPersonnages_Click(object sender, EventArgs e)
        {
            Resume resume = new Resume();
            resume.Show();
        }

        private void rafraichirListeBox()
        {
            listeBoxInfosPersonnages.DataSource = null;
            listeBoxInfosPersonnages.DataSource = Donnees.GetPersos();
        }

        private void listeBoxInfosPersonnages_MouseHover(object sender, EventArgs e)
        {
            
            
                
            
        }

        private void listeBoxInfosPersonnages_VisibleChanged(object sender, EventArgs e)
        {
            rafraichirListeBox();
        }

    

        private void pbPersonnage_Click(object sender, EventArgs e)
        {

        }

        private void timerAffichageGif_Tick(object sender, EventArgs e)
        {
            timerAffichageGif.Stop();
            pbPersonnage.Image = Properties.Resources.personnage;
        }

        private void TimerAffichageManger_Tick(object sender, EventArgs e)
        {
            TimerAffichageManger.Stop();
            pbPersonnage.Image = Properties.Resources.personnage;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tama.GetTemps().SetMinute(0);
            tama.GetTemps().SetSeconde(2);
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            String nomFichEnr;
            saveFileDialog1.InitialDirectory = Environment.CurrentDirectory;
            saveFileDialog1.Filter = "bin files (*.bin)|*.bin";
            DialogResult dr = saveFileDialog1.ShowDialog();
            if (dr == DialogResult.OK)
            {  // un répertoire et un nom de fichier d'enregistrement a été choisi
                nomFichEnr = saveFileDialog1.FileName;
                Stream streamEcriture;
                BinaryFormatter bformatter = new BinaryFormatter();
                streamEcriture = File.Open(nomFichEnr, FileMode.OpenOrCreate);
                bformatter.Serialize(streamEcriture, Donnees.GetPersos());
                streamEcriture.Close();
                MessageBox.Show("Sauvegarde réussie");

            }

        }

      
    }
}
