using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;

namespace Time_Agotchi
{
    public partial class Introduction : Form
    {
        public Introduction()
        {
            InitializeComponent();
        }

        private void btValider_Click(object sender, EventArgs e)
        {
            if (tbNom.Text == "")
            {
                MessageBox.Show("Vous devez entrer votre nom.");
            }
            else
            {
                Donnees.SetNom(tbNom.Text); //enregistre le nom
                this.Close(); //ferme le form
            }
        }

        private void Introduction_Load(object sender, EventArgs e)
        {

        }
        //Partie de Chargement de donnes sauvagardés//
        private void btReprendre_Click(object sender, EventArgs e)
        {
            string monFichierLecture;
            DialogResult dr = openFileDialog1.ShowDialog(); //Affichage de fenetre pour choisir emplacement
            if (dr == DialogResult.OK)
            {
                monFichierLecture = openFileDialog1.FileName; //on récuprer le nom du fichier 
                Stream streamLecture; //stream pour lecture
                BinaryFormatter bformatter = new BinaryFormatter();
                streamLecture = File.Open(monFichierLecture, FileMode.Open); //on ouvre le fichier choisie auparavant 
                Donnees.GetPersos().Clear(); //efface la liste actuelle
                Donnees.SetPersonnages((List<Personnage>)bformatter.Deserialize(streamLecture)); //ajoute la nouvelle liste désérialisé

                streamLecture.Close(); //fermeture de stream
                Donnees.SetCharge(true);
               this.Close(); //ferme le form
                
            }
        }
    }
}
