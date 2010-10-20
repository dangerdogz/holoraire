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
      

    }
}
