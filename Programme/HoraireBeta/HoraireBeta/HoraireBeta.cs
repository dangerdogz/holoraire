using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace HoraireBeta
{
    public partial class HoraireBeta : Form
    {
       
        public HoraireBeta()
        {
            InitializeComponent();
        }

        private void horaire_Click(object sender, EventArgs e)
        {
           

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {
          
        }

        private void employe_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
        
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pGauche_Employe_OnMouseEvent(object sender, MouseEventArgs e)
        {
          
           switch(e.Button)
                {
                case MouseButtons.Left:
                    MessageBox.Show(this, "PanelGauche Employé: Vous avez appuyez sur gauche en : " + e.X + " , " + e.Y);
                    
                    break;
                }
        }

        private void pCentral_Employe_OnMouseEvent(object sender, MouseEventArgs e)
        {

            switch (e.Button)
            {
                case MouseButtons.Left:
                    MessageBox.Show(this, "PanelCentral Employé: Vous avez appuyez sur gauche en : " + e.X + " , " + e.Y);

                    break;
            }
        }

        private void pGauche_Horaire_OnMouseEvent(object sender, MouseEventArgs e)
        {

            switch (e.Button)
            {
                case MouseButtons.Left:
                    MessageBox.Show(this, "PanelGauche Horaire: Vous avez appuyez sur gauche en : " + e.X + " , " + e.Y);

                    break;
            }
        }

        private void pCentral_Horaire_OnMouseEvent(object sender, MouseEventArgs e)
        {

            switch (e.Button)
            {
                case MouseButtons.Left:
                    MessageBox.Show(this, "PanelCentral Horaire: Vous avez appuyez sur gauche en : " + e.X + " , " + e.Y);

                    break;
            }
        }


        private void pGauche_Parametre_OnMouseEvent(object sender, MouseEventArgs e)
        {

            switch (e.Button)
            {
                case MouseButtons.Left:
                    MessageBox.Show(this, "PanelGauche Parametre: Vous avez appuyez sur gauche en : " + e.X + " , " + e.Y);

                    break;
            }
        }

        private void pCentral_Parametre_OnMouseEvent(object sender, MouseEventArgs e)
        {

            switch (e.Button)
            {
                case MouseButtons.Left:
                    MessageBox.Show(this, "PanelCentral Parametre: Vous avez appuyez sur gauche en : " + e.X + " , " + e.Y);

                    break;
            }
        }
    }
}
