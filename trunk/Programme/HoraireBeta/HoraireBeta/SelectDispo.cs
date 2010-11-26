
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
            grille = new GrilleHoraire(grfx, profil, getDebutSemaine());
           // MessageBox.Show("Jewthunder");
            
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            DateTime debutSemaine = getDebutSemaine();
            grille.changeSemaineProfil(debutSemaine);
            grille.refresh();
        }

        public DateTime getDebutSemaine()
        {

            DateTime selectedDate = monthCalendar1.SelectionStart.Date;

            String dow = monthCalendar1.SelectionStart.DayOfWeek.ToString();

            switch (dow)
            {
                case "Sunday":
                    TimeSpan toSubstract = TimeSpan.FromDays(6);
                    DateTime monday = selectedDate.Subtract(toSubstract);
                    return monday;
                case "Monday":
                    monday = monthCalendar1.SelectionStart.Date;
                    return monday;
                case "Tuesday":
                    toSubstract = TimeSpan.FromDays(1);
                    monday = selectedDate.Subtract(toSubstract);
                    return monday;
                case "Wednesday":
                    toSubstract = TimeSpan.FromDays(2);
                    monday = selectedDate.Subtract(toSubstract);
                    return monday;
                case "Thursday":
                    toSubstract = TimeSpan.FromDays(3);
                    monday = selectedDate.Subtract(toSubstract);
                    return monday;
                case "Friday":
                    toSubstract = TimeSpan.FromDays(4);
                    monday = selectedDate.Subtract(toSubstract);
                    return monday;
                case "Saturday":
                    toSubstract = TimeSpan.FromDays(5);
                    monday = selectedDate.Subtract(toSubstract);
                    return monday;
            }
            return selectedDate;
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


    }
}
