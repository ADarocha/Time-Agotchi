using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Media;

namespace Time_Agotchi
{
    public partial class Mort : Form
    {
        public Mort()
        {
            InitializeComponent();
        }

        private void btFermer_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Mort_Load(object sender, EventArgs e)
        {
            SoundPlayer son = new SoundPlayer(Properties.Resources.Sound_GameOver);
            son.Play();
        }
    }
}
