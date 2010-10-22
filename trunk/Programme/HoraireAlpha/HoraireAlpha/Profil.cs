using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HoraireAlpha
{
    class Profil
    {
        private string prenom;
        private string nom;
        private string email;
        private string numTelephone;
        private int anciennete;
        private int heuresTravaillees;
        private List<Poste> poste = new List<Poste>();



        public Profil(string prenom, string nom, string email, string numTelephone, int anciennete, int heuresTravaillees)
        {

            setPrenom(prenom);
            setNom(nom);
            setEmail(email);
            setNumTelephone(numTelephone);
            setAnciennete(anciennete);
            setHeuresTravaillees(heuresTravaillees);

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

        public List<Poste> getPoste() 
        {
         return poste;
        }



    }
}
