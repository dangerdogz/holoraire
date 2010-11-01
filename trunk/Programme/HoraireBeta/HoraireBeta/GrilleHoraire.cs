using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace HoraireBeta
{
    class GrilleHoraire
    {
        //Variables Locales
        GrilleJour[] jours = new GrilleJour[7];
        

        public GrilleHoraire(Graphics grfx, Pen bPen)
        {
            //Création des jours - ajouter les blocs existants
            jours[0] = new GrilleJour("Lundi", 40, 20, grfx, bPen);
            jours[1] = new GrilleJour("Mardi", 140, 20, grfx, bPen);
            jours[2] = new GrilleJour("Mercredi", 240, 20, grfx, bPen);
            jours[3] = new GrilleJour("Jeudi", 340, 20, grfx, bPen);
            jours[4] = new GrilleJour("Vendredi", 440, 20, grfx, bPen);
            jours[5] = new GrilleJour("Samedi", 540, 20, grfx, bPen);
            jours[6] = new GrilleJour("Dimanche", 640, 20, grfx, bPen);

           
        
        }

        public void activer() {
            jours[0].activer();
            jours[1].activer();
            jours[2].activer();
            jours[3].activer();
            jours[4].activer();
            jours[5].activer();
            jours[6].activer();

        }

        public void passeClique(int x,int y) {
            for (int i = 0; i < 7; i++)
                {
                    jours[i].passeClique(x, y);
                }
        
        }
    }
}
