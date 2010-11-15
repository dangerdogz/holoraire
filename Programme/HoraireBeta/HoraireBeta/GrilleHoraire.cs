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
        Graphics gfx;
        Loader loader;
        DateTime laDate; 


        public GrilleHoraire(Graphics grfx,Loader loader)

        {
            gfx = grfx;
            this.loader = loader;
            //DateTime renvoyer par la fonction getweekrange()
            laDate = new DateTime(2010, 11, 8);

            //DateTime et une addition de timespan
            DateTime lundi      = laDate;
            DateTime mardi      = laDate.Add(new TimeSpan(24,0,0));
            DateTime mercredi   = laDate.Add(new TimeSpan(48, 0, 0));
            DateTime jeudi      = laDate.Add(new TimeSpan(72, 0, 0));
            DateTime vendredi   = laDate.Add(new TimeSpan(96, 0, 0));
            DateTime samedi     = laDate.Add(new TimeSpan(120, 0, 0));
            DateTime dimanche   = laDate.Subtract(new TimeSpan(24,0,0));

            //Création des jours - ajouter les blocs existants
            jours[6] = new GrilleJour("Dimanche", dimanche, 1, 40, 20, grfx, loader);
            jours[0] = new GrilleJour("Lundi",lundi,2, 140, 20, grfx,loader);
            jours[1] = new GrilleJour("Mardi", mardi, 3, 240, 20, grfx, loader);
            jours[2] = new GrilleJour("Mercredi",mercredi, 4, 340, 20, grfx, loader);
            jours[3] = new GrilleJour("Jeudi", jeudi, 5, 440, 20, grfx, loader);
            jours[4] = new GrilleJour("Vendredi", vendredi, 6, 540, 20, grfx, loader);
            jours[5] = new GrilleJour("Samedi", samedi, 7, 640, 20, grfx, loader);
           

           
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

        public void refresh() {
            
            gfx.Clear(Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192))))));
            jours[0].activer();
            jours[1].activer();
            jours[2].activer();
            jours[3].activer();
            jours[4].activer();
            jours[5].activer();
            jours[6].activer();
        }




        public void changeSemaine(DateTime date) {
       
            DateTime lundi = date;
            DateTime mardi = date.Add(new TimeSpan(24, 0, 0));
            DateTime mercredi = date.Add(new TimeSpan(48, 0, 0));
            DateTime jeudi = date.Add(new TimeSpan(72, 0, 0));
            DateTime vendredi = date.Add(new TimeSpan(96, 0, 0));
            DateTime samedi = date.Add(new TimeSpan(120, 0, 0));
            DateTime dimanche = date.Subtract(new TimeSpan(24, 0, 0));

            
            //Création des jours - ajouter les blocs existants
            jours[6] = new GrilleJour("Dimanche", dimanche, 1, 40, 20, gfx, loader);
            jours[0] = new GrilleJour("Lundi", lundi, 2, 140, 20, gfx, loader);
            jours[1] = new GrilleJour("Mardi", mardi, 3, 240, 20, gfx, loader);
            jours[2] = new GrilleJour("Mercredi", mercredi, 4, 340, 20, gfx, loader);
            jours[3] = new GrilleJour("Jeudi", jeudi, 5, 440, 20, gfx, loader);
            jours[4] = new GrilleJour("Vendredi", vendredi, 6, 540, 20, gfx, loader);
            jours[5] = new GrilleJour("Samedi", samedi, 7, 640, 20, gfx, loader);


            refresh();
        
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
