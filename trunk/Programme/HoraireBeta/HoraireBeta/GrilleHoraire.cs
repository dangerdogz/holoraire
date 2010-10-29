using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HoraireBeta
{
    class GrilleHoraire
    {
        //Variables Locales
        GrilleJour[] jours = new GrilleJour[7];

        public GrilleHoraire() {
            //Création des jours - ajouter les blocs existants
            jours[0] = new GrilleJour("Lundi");
            jours[1] = new GrilleJour("Mardi");
            jours[2] = new GrilleJour("Mercredi");
            jours[3] = new GrilleJour("Jeudi");
            jours[4] = new GrilleJour("Vendredi");
            jours[5] = new GrilleJour("Samedi");
            jours[6] = new GrilleJour("Dimanche");
        
        }
    }
}
