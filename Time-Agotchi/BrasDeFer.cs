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

        


    
    }
}
