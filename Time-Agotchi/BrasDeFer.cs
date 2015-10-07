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
    public partial class BrasDeFer : Form
    {
        public BrasDeFer()
        {
            InitializeComponent();
        }

        private void BrasDeFer_Load(object sender, EventArgs e)
        {
            GestionnaireMiniJeuBrasDeFer.GenererListeDeFleches(4);
            AfficherImagesFleches(GestionnaireMiniJeuBrasDeFer.GetFleches());
            
        }

        /// <summary>
        /// Methodes D'affichage images
        /// </summary>

        private void AfficherImagesFleches(List<string> listeDeFleches)
        {
            ///Méthode qui permet d'afficher les images
            ///pour l'instant des test avec des Label
            
            lbReponse1.Text = listeDeFleches[0];
            lbReponse2.Text = listeDeFleches[1];
            lbReponse3.Text = listeDeFleches[2];
            lbReponse4.Text = listeDeFleches[3];
        }
        

        

        protected override void OnKeyPress(KeyPressEventArgs e)
        {
            MessageBox.Show(e.KeyChar.ToString());
        }

        private void BrasDeFer_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                MessageBox.Show("lol");
            }
        }


        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Left)
            {
                MessageBox.Show("You pressed Left arrow key");
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void btTest_Click(object sender, EventArgs e)
        {
            //bool BonneTouche = false;
            //int seconds = 1;

            //while (BonneTouche)
            //{
            //    this.KeyPreview = true;
                
                    
            //}
        }

        private void Timer_AttenteKeyPress_Tick(object sender, EventArgs e)
        {
            
        }




    
    }
}
