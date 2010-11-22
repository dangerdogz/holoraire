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
    public partial class ModificationBloc : Form
    {
        string hd;
        string hf;
        int commande = 0;
        public ModificationBloc(string hd, string hf)
        {
            InitializeComponent(hd, hf);
        }


        public void setHeures()
        {
            hd = textBox1.Text;
            hf = textBox2.Text;

            if (hf == "25")
                hf = "1";
            if (hd == "24")
                hd = "0";
            if (hf == "24")
                hf = "0";
        }

        public string getHd()
        {
            return hd;
        }

        public int getCommande() 
        {
            return commande;
        }

        public string getHf()
        {
            return hf;
        }

        private void modifierClick(object sender, EventArgs e)
        {
            for (int i = 0; i <= textBox1.Text.Length; i++)
            {

            }

            setHeures();
            commande = 0;
           
            this.Hide();
        }

        private void supprimerClick(object sender, EventArgs e)
        {
            for (int i = 0; i <= textBox1.Text.Length; i++)
            {

            }

            commande = 1;
            
           
            this.Hide();
        }

    }
}