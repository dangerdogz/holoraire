
﻿
﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace HoraireBeta
{
    public partial class SelectDispo : Form
    {

        private GrilleHoraire grille;

        public SelectDispo(Profil profil)
        {
            InitializeComponent();
            Graphics grfx = this.panel1.CreateGraphics();
            grille = new GrilleHoraire(grfx, profil, new DateTime(2010, 11, 29));
           // MessageBox.Show("Jewthunder");
            label1.Text = ("Disponibilités de l'employé");
            
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            DateTime debutSemaine = new DateTime(2010, 29, 11);
            grille.changeSemaineProfil(debutSemaine);
          
        }

       

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }


        private void button1_Click(object sender, EventArgs e)
        {
            grille.isPref = false;

            label1.Text = ("Disponibilités de l'employé");
            grille.refresh();
        }


        private void button2_Click_1(object sender, EventArgs e)
        {
            grille.isPref = true;
            label1.Text = ("Préférences de l'employé");
            grille.refresh();

        }

        private void panel_CentralMouseDown(object sender, MouseEventArgs e)
        {
            grille.passeClique(e, "MouseDown");
        }

        private void panel_CentralDoubleClick(object sender, EventArgs me)
        {
            MouseEventArgs e = me as MouseEventArgs;
            grille.passeClique(e, "DoubleClick");
        }

        private void SelectDispo_Load(object sender, EventArgs e)
        {

        }


    }
}
