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
        public GrilleJour[] jours = new GrilleJour[7];
       


        public GrilleHoraire(Graphics grfx,Loader loader)

        {
            //DateTime renvoyer par la fonction getweekrange()
            DateTime laDate = new DateTime(2010, 10, 12, 9, 0,0);

            //DateTime et une addition de timespan
            DateTime lundi      = new DateTime(2010, 11, 8);
            DateTime mardi      = new DateTime(2010, 11, 9);
            DateTime mercredi   = new DateTime(2010, 11, 10);
            DateTime jeudi      = new DateTime(2010, 11, 11);
            DateTime vendredi   = new DateTime(2010, 11, 12);
            DateTime samedi     = new DateTime(2010, 11, 13);
            DateTime dimanche   = new DateTime(2010, 11, 14);

            //Création des jours - ajouter les blocs existants
            jours[0] = new GrilleJour("Lundi",lundi,1, 40, 20, grfx,loader);
            jours[1] = new GrilleJour("Mardi", mardi, 2, 140, 20, grfx, loader);
            jours[2] = new GrilleJour("Mercredi",mercredi, 3, 240, 20, grfx, loader);
            jours[3] = new GrilleJour("Jeudi", jeudi, 4, 340, 20, grfx, loader);
            jours[4] = new GrilleJour("Vendredi", vendredi, 5, 440, 20, grfx, loader);
            jours[5] = new GrilleJour("Samedi", samedi, 6, 540, 20, grfx, loader);
            jours[6] = new GrilleJour("Dimanche", dimanche, 7, 640, 20, grfx, loader);

           
        }

        public void activer()
        {
            jours[0].activer();
            jours[1].activer();
            jours[2].activer();
            jours[3].activer();
            jours[4].activer();
            jours[5].activer();
            jours[6].activer();

        }


        


        public void passeClique(MouseEventArgs e,String mouse)
        {
            for (int i = 0; i < 7; i++)
            {
                jours[i].passeClique(e,mouse);
            }

        }





     
    }
}
