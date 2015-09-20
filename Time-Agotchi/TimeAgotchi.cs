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
    public partial class Timeagotchi : Form
    {
        public Timeagotchi()
        {
            InitializeComponent();
            pbFaimPerso.Maximum = 10; //maximum de la barre
            pbFaimPerso.Minimum = 0;// minimum de la barre
            pbFaimPerso.Step = 10; //status de la barre
            //pbFaimPerso.PerformStep(); pour actualiser
            pbSoifPerso.Maximum = 10;
            pbSoifPerso.Minimum = 0;
            pbSoifPerso.Step = 10;
            //pbSoifPerso.PerformStep();

        }

    }
}
