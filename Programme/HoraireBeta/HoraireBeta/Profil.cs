using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace HoraireBeta
{
    public class Profil : Ressource
    {
        private string prenom;
        private string nom;
        private string email;
        private string numTelephone;
        private int anciennete;
        private int heuresTravaillees;
        private int heuresMax;
        private List<Poste> poste = new List<Poste>();
        private List<Bloc> preference = new List<Bloc>();
        private List<Bloc> disponibilite = new List<Bloc>();


        public Profil(Poste poste, string prenom, string nom, string email, int heureMax, string numTelephone, int anciennete)
        {

            setPrenom(prenom);
            setNom(nom);
            setEmail(email);
            setNumTelephone(numTelephone);
            setAnciennete(anciennete);
            setHeuresMax(heureMax);
            this.poste.Add(poste);

        }

        public Profil(string prenom, string nom, string email, string numTelephone, int anciennete, int heureMax)
        {
            setPrenom(prenom);
            setNom(nom);
            setEmail(email);
            setNumTelephone(numTelephone);
            setAnciennete(anciennete);
            setHeuresMax(heureMax);

        }


        public Profil(string prenom, string nom, string email, string numTelephone, int anciennete)
        {
            setPrenom(prenom);
            setNom(nom);
            setEmail(email);
            setNumTelephone(numTelephone);
            setAnciennete(anciennete);

        }

        public Profil(int id, string prenom, string nom, string email, string numTelephone, int anciennete)
        {
            setId(id);
            setPrenom(prenom);
            setNom(nom);
            setEmail(email);
            setNumTelephone(numTelephone);
            setAnciennete(anciennete);

        }

        public void setPrenom(string prenom)
        {
            this.prenom = prenom;
        }

        public void setNom(string nom)
        {
            this.nom = nom;
        }

        public void setEmail(string email)
        {
            this.email = email;
        }

        public void setNumTelephone(string numTelephone)
        {
            this.numTelephone = numTelephone;
        }

        public void setAnciennete(int anciennete)
        {
            this.anciennete = anciennete;
        }

        public void setHeuresTravaillees(int heuresTravaillees)
        {
            this.heuresTravaillees = heuresTravaillees;
        }

        

        public int getHeuresMax()
        {

            return (heuresMax);
        }

        public void setHeuresMax(int heuresMax) {
            this.heuresMax = heuresMax;
        }
        public void setPoste(Poste poste)
        {
          this.poste.Add(poste);
        }

        public String getPrenom()
        {
            return prenom;
        }

        public String getNom()
        {
            return nom;
        }

        public String getEmail()
        {
            return email;
        }

        public String getNumTelephone()
        {
            return numTelephone;
        }

        public int getAnciennete()
        {
            return anciennete;
        }

        public int getHeuresTravaillees()
        {
            return heuresTravaillees;
        }

        public Poste getPoste(int num) 
        {
         return (poste[num]);
        }

        public List<Poste> getPoste()
        {
            return poste;
        }

        public void addDispo(Bloc dispo)
        {
            disponibilite.Add(dispo);
        }

        public void addPref(Bloc pref)
        {
            preference.Add(pref);
        }

        public List<Bloc> getPref(){
            return (preference);
        }

        public List<Bloc> getDispo()
        {
            return (disponibilite);
        }

        public void draw(Bloc bloc,int i, Graphics gfx)
        {
            Font laFont = new Font("Arial", 16);
            SolidBrush brush = new SolidBrush(Color.Red);


            int x = bloc.getX();
            int y = bloc.getY() + (i * 20) + 20;

            Point coin = new Point(x, y);
            MessageBox.Show("Sup, jme dessine");
            gfx.DrawString(nom + " " + prenom, laFont, brush, coin);
            
        }



    }
}
