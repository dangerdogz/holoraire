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
        bool valide = false;
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

        public bool isValide() { return valide; }

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

            MessageBox.Show("Heure temp "+tempHd);
            try
                {
                heureTempDebut = Int16.Parse(tempHd);
                }
            catch (Exception)
                {
                MessageBox.Show("Erreur de parse");
                throw;
                }
            
            //Trouve son index
            for (int i = 0; i < listBloc.Count; i++)
                {
                    MessageBox.Show("Heure de départ : " + listBloc[i].getDebut().Hour);
                if (listBloc[i].getDebut().Hour.Equals(heureTempDebut))
                    {
                    indexBloc = i;
                    MessageBox.Show("Index du bloc :" + indexBloc);
                    break;
                    }
                }
            MessageBox.Show("Début : " + leBloc.getDebut().Hour + " Fin : " + leBloc.getFin().Hour);

            for (int i = 0; i < listBloc.Count; i++)
            {/*
                //Sois le bloc ajouté enpiète sur la fin du bloc existant ou sur le debut du bloc existant
                if (((( leBloc.getDebut().Hour < listBloc[i].getFin().Hour && leBloc.getFin().Hour > listBloc[i].getFin().Hour)
                    || (leBloc.getFin().Hour > listBloc[i].getDebut().Hour && leBloc.getDebut().Hour < listBloc[i].getDebut().Hour)
                    || (leBloc.getDebut().Hour < listBloc[i].getDebut().Hour && leBloc.getFin().Hour > listBloc[i].getDebut().Hour))) 
                    && (indexBloc != i))//Différent de lui-même*/
                MessageBox.Show("Première condition : " + (leBloc.getDebut().Hour < listBloc[i].getFin().Hour && leBloc.getFin().Hour > listBloc[i].getDebut().Hour) + " \nDeuxième condition : " + (leBloc.getFin().Hour > listBloc[i].getDebut().Hour && leBloc.getDebut().Hour < listBloc[i].getDebut().Hour) + " \n Troisième condition : " + (leBloc.getDebut().Hour < listBloc[i].getDebut().Hour && leBloc.getFin().Hour > listBloc[i].getDebut().Hour) + " \n Index : " + (indexBloc != i));


                if (((leBloc.getDebut().Hour < listBloc[i].getFin().Hour && leBloc.getFin().Hour > listBloc[i].getDebut().Hour)
                    || (leBloc.getFin().Hour > listBloc[i].getDebut().Hour && leBloc.getDebut().Hour < listBloc[i].getDebut().Hour)
                    || (leBloc.getDebut().Hour < listBloc[i].getDebut().Hour && leBloc.getFin().Hour > listBloc[i].getDebut().Hour))
                    && (indexBloc != i))//Différent de lui-même*/
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
                {
                this.Hide();
                valide = true;
                }
        }

        private void supprimerClick(object sender, EventArgs e)
        {
            for (int i = 0; i <= textBox1.Text.Length; i++)
            {

            }

            commande = 1;
            valide = true;
           
            this.Hide();
        }

    }
}