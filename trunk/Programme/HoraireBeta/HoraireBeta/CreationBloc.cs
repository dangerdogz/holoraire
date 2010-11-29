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
    public partial class CreationBloc : Form
    {
        string hd;
        string hf;
        List<Bloc> listBloc;
        bool valide = false;

        public CreationBloc(string hd, string hf, List<Bloc> listBloc)
        {
            InitializeComponent(hd,hf);
            this.listBloc = listBloc;
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

        //Retourne vrai si le placement est valide
        public bool placementValide(Bloc leBloc) {

            //Variables
            for (int i = 0; i < listBloc.Count; i++)
                {
                //Sois le bloc ajouté enpiète sur la fin du bloc existant ou sur le debut du bloc existant
                if ( (leBloc.getDebut() < listBloc[i].getFin() && leBloc.getFin() > listBloc[i].getFin()) 
                    || (leBloc.getFin() > listBloc[i].getDebut() && leBloc.getDebut() < listBloc[i].getDebut()))
                    {
                    return false; //Bloc existant                 
                    }
            
                }
            return true; //Aucun accros
        }

        private void button_blocconfirm_Click(object sender, EventArgs e)
        {
            setHeures();

            if (valideHeures())
                {
                this.Hide();
                valide = true;
                }
        }
    }
}
