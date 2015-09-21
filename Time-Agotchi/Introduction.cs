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
    public partial class Introduction : Form
    {
        public Introduction()
        {
            InitializeComponent();
        }

        private void btValider_Click(object sender, EventArgs e)
        {
            Personnage.SetNom(tbNom.Text); //enregistre le nom
            Personnage.SetFaim(10); //initialise la barre de faim à 10 (le max)
            Personnage.SetSoif(10); //initialise la barre de soif à 10 (le max)
            this.Close(); //ferme le form
        }
    }
}
