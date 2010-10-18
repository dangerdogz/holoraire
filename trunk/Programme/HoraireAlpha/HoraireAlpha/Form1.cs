using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace HoraireAlpha
{
    public partial class Horaire : Form
    {
        public Horaire()
        {
            InitializeComponent();
        }

        private void buttonHoraire_Click(object sender, EventArgs e)
        {
            panelGauche.BackColor = Color.Green;
            panelCentral.BackColor = Color.Green; 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panelGauche.BackColor = Color.Red;
            panelCentral.BackColor = Color.Red; 
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panelGauche.BackColor = Color.Blue;
            panelCentral.BackColor = Color.Blue; 
        }

        private void button3_Click(object sender, EventArgs e)
        {
            panelGauche.BackColor = Color.White;
            panelCentral.BackColor = Color.White; 
        }

        private void panelCentral_Paint(object sender, PaintEventArgs e)
        {
    
        
        }

        private void panelGauche_Paint(object sender, PaintEventArgs e)
        {

        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

        }
    }
}
