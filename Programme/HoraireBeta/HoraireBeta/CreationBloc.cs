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
    public partial class CreationBloc : Form
    {
        string hd;
        string hf;
        bool valide = false;
        bool preset = false;

        public CreationBloc(string hd, string hf)
        {
            InitializeComponent(hd,hf);
        }

        public bool isValide() { return valide; }

        public void setHeures()
        {
            hd = textBox_hrdebut.Text;
            hf = textBox_hrfin.Text;

            if (hf == "25")
                hf = "1";
            if (hd == "24")
                hd = "0";
            if (hf == "24")
                hf = "0";
           
        }

        public bool valideHeures() {

            try
                {
                //Si contient juste des chiffres
                int.Parse(hd);
                int.Parse(hf);
                return true;
                }
            catch (Exception)
                {
                MessageBox.Show("Erreur lors de l'entrée des heures");
                
                return false;
                }

            
        }

        public string getHd()
        {
            return hd;
        }

        public string getHf()
        {
            return hf;
        }

        public bool getPreset()
        {
            return preset;
        }

        //Retourne vrai si le placement est valide

        private void button_blocconfirm_Click(object sender, EventArgs e)
        {
            setHeures();

            if (checkBox_Preset.Checked) {
                preset = true;

            }
            else
            {
                if (!checkBox_Preset.Checked)
                    preset = false;
            }

            if (valideHeures())
                {
                this.Hide();
                valide = true;
                }
        }
    }
}
