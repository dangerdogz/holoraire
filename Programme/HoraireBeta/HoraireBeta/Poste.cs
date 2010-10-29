using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HoraireBeta
{
   public class Poste : Ressource
    {

        private string nom;
        private Profil profil;
        private string description;

        public Poste (string nom, string description)
        {

            setNom(nom);
            setDescription(description);
            
        }

        public Poste(int id, string nom, string description)
        {
            setId(id);
            setNom(nom);
            setDescription(description);

        }

        public void setNom(string nom)
        {
            this.nom = nom;
        }

        public void setDescription(string description)
        {
            this.description = description;
        }

        public void setProfil(Profil profil)
        {
            this.profil = profil;
        }

        public string getNom()
        {
            return nom;
        }

        public Profil getProfil()
        {
            return profil;
        }


    }
}
