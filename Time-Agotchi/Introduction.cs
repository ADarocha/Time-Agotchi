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
    }
}
