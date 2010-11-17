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
        Bloc selectionEnCours;
        GrilleJour jourCliquer;

        public GrilleHoraire(Graphics grfx,Loader loader,DateTime date)

        {
            gfx = grfx;
            this.loader = loader;
            //DateTime renvoyer par la fonction getweekrange()
            laDate = date;

            //DateTime et une addition de timespan
            DateTime lundi      = laDate;
            DateTime mardi      = laDate.Add(new TimeSpan(24,0,0));
            DateTime mercredi   = laDate.Add(new TimeSpan(48, 0, 0));
            DateTime jeudi      = laDate.Add(new TimeSpan(72, 0, 0));
            DateTime vendredi   = laDate.Add(new TimeSpan(96, 0, 0));
            DateTime samedi     = laDate.Add(new TimeSpan(120, 0, 0));
            DateTime dimanche   = laDate.Subtract(new TimeSpan(24,0,0));

            //Création des jours - ajouter les blocs existants
            jours[0] = new GrilleJour("Dimanche", dimanche, 1, 40, 20, grfx, loader,this);
            jours[1] = new GrilleJour("Lundi",lundi,2, 140, 20, grfx,loader,this);
            jours[2] = new GrilleJour("Mardi", mardi, 3, 240, 20, grfx, loader,this);
            jours[3] = new GrilleJour("Mercredi",mercredi, 4, 340, 20, grfx, loader,this);
            jours[4] = new GrilleJour("Jeudi", jeudi, 5, 440, 20, grfx, loader,this);
            jours[5] = new GrilleJour("Vendredi", vendredi, 6, 540, 20, grfx, loader,this);
            jours[6] = new GrilleJour("Samedi", samedi, 7, 640, 20, grfx, loader,this);
           

           
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
            
            //En-tête

            //Grade des heures
            Font laFont = new Font("Arial", 10);
            Pen pen = new Pen(Color.Black);
            SolidBrush brush = new SolidBrush(Color.Black);
            SolidBrush selectedBrush = new SolidBrush(Color.Black);

            for (int i = 1; i <= 24; i++)
                {
                if(i < 10)
                    gfx.DrawString("0"+i+":00", laFont, brush, 0, (20*i)+25);
                else
                    gfx.DrawString(i + ":00", laFont, brush, 0, (20*i)+25);
                }
        }

        public void refresh() {
            
            gfx.Clear(Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192))))));
            activer();
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
            jours[0] = new GrilleJour("Dimanche", dimanche, 1, 40, 20, gfx, loader,this);
            jours[1] = new GrilleJour("Lundi", lundi, 2, 140, 20, gfx, loader,this);
            jours[2] = new GrilleJour("Mardi", mardi, 3, 240, 20, gfx, loader,this);
            jours[3] = new GrilleJour("Mercredi", mercredi, 4, 340, 20, gfx, loader,this);
            jours[4] = new GrilleJour("Jeudi", jeudi, 5, 440, 20, gfx, loader,this);
            jours[5] = new GrilleJour("Vendredi", vendredi, 6, 540, 20, gfx, loader,this);
            jours[6] = new GrilleJour("Samedi", samedi, 7, 640, 20, gfx, loader,this);


            refresh();
        
        }

        public void passeClique(MouseEventArgs e,String mouse)
        {
            
            if(mouse == "MouseUp")
            {
               
                for (int i = 0; i < 7; i++)
                {
                    //Sélection du bon jours
                    if (e.X > jours[i].getX() && e.X < jours[i].getXFin())
                    {
                        //Jour cliquer
                        jourCliquer = jours[i];


                        //Sélection d'un bloc existant
                        if (selectionEnCours != null)
                        {
                            selectionEnCours.unSelectIt();
                        }
                        selectionEnCours = jours[i].selectionneUnBloc(e.Y);
                        if (selectionEnCours != null)
                        {
                            selectionEnCours.selectIt();
                            refresh();

                        }
                        //Si appuis dans le vide
                        else
                            {
                            //DateTime 1 heure plus tard
                            DateTime tempDateFin = jourCliquer.getDate().Add(new TimeSpan(1,0,0));

                            if(jourCliquer.getHeureClique(e.Y) >= 0)
                                {
                                //Création du bloc
                                jourCliquer.createBlock(jourCliquer.getX(), jourCliquer.getHeureClique(e.Y),
                                    jourCliquer.getDate(), tempDateFin);

                                }
                            else
                                MessageBox.Show("Té pas supposer voir ca ... ");
                           // MessageBox.Show("Vide");
                            }

                    }

                    

                }
                
                
                




                //jours[i].passeClique(e,mouse);
            }
            

           

        }





     
    }
}
