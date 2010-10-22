using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HoraireAlpha
{
    class Equipe : Ressource
    {
        private List<Profil> profils = new List<Profil>();
        private String nom;

        Equipe(string nom)
        {
            setNom(nom);
        }
        
        public void setNom(string nom)
        {
            this.nom = nom;
        }

        public void setEmploye(Profil profil)
        {
            profils.Add(profil);
        }

        public string getNom()
        {
            return nom;
        }
        public List<Profil> getProfils() 
        {
         return profils;
        }



    }
}
