using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HoraireBeta
{
    public class Equipe : Ressource
    {
        private List<Ressource> profils = new List<Ressource>();
        private String nom;
        private String description;

        public Equipe(int id, string nom, string description)
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


        public void setEmploye(Ressource profil)
        {
            profils.Add(profil);
        }

        public string getNom()
        {
            return nom;
        }
        public List<Ressource> getProfils() 
        {
         return profils;
        }



    }
}
