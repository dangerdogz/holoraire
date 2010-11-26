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
        string tempHd;
        int commande = 0;
        List<Bloc> listBloc;
        public ModificationBloc(string hd, string hf, List<Bloc> listBloc)
        {
            InitializeComponent(hd, hf);
            this.listBloc = listBloc;
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

        public bool valideHeures()
        {

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

        //Retourne vrai si le placement est valide
        public bool placementValide(Bloc leBloc)
        {
            //Variables
            //Retirer lui-même du tableau
            int indexBloc = -1;
            int heureTempDebut;
            try
                {
                heureTempDebut = Int16.Parse(tempHd);
                }
            catch (Exception)
                {
                
                throw;
                }
            
            
            for (int i = 0; i < listBloc.Count; i++)
                {
                if (listBloc[i].getDebut().Hour.ToString() == tempHd)
                    {
                    indexBloc = i; 
                    break;
                    }
                }


            for (int i = 0; i < listBloc.Count; i++)
            {
                //Sois le bloc ajouté enpiète sur la fin du bloc existant ou sur le debut du bloc existant
                if (((( heureTempDebut < listBloc[i].getFin().Hour && leBloc.getFin().Hour > listBloc[i].getFin().Hour)
                    || (leBloc.getFin().Hour > listBloc[i].getDebut().Hour && heureTempDebut < listBloc[i].getDebut().Hour)
                    || (heureTempDebut > listBloc[i].getDebut().Hour && leBloc.getFin().Hour < listBloc[i].getFin().Hour))) 
                    && (indexBloc != i))//Différent de lui-même
                    {
                    return false; //Bloc existant                 
                    }

            }
            return true; //Aucun accros
        }

        private void modifierClick(object sender, EventArgs e)
        {
            for (int i = 0; i <= textBox1.Text.Length; i++)
            {

            }

            setHeures();
            commande = 0;

            if (valideHeures())
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