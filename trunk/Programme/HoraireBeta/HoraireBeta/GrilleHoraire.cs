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
        public Bloc selectionEnCours;
        GrilleJour jourCliquer;
        Profil profil;
        public bool isPref = false;


        //Id des blocs en mémoires

        public GrilleHoraire(Graphics grfx, Loader loader, DateTime date)
        {
            gfx = grfx;
            this.loader = loader;
            //DateTime renvoyer par la fonction getweekrange()
            laDate = date;

            //DateTime et une addition de timespan
            DateTime lundi = laDate;
            DateTime mardi = laDate.Add(new TimeSpan(24, 0, 0));
            DateTime mercredi = laDate.Add(new TimeSpan(48, 0, 0));
            DateTime jeudi = laDate.Add(new TimeSpan(72, 0, 0));
            DateTime vendredi = laDate.Add(new TimeSpan(96, 0, 0));
            DateTime samedi = laDate.Add(new TimeSpan(120, 0, 0));
            DateTime dimanche = laDate.Subtract(new TimeSpan(24, 0, 0));

            //Création des jours - ajouter les blocs existants
            jours[0] = new GrilleJour("Dimanche", dimanche, 1, 40, 20, grfx, loader, this);
            jours[1] = new GrilleJour("Lundi", lundi, 2, 140, 20, grfx, loader, this);
            jours[2] = new GrilleJour("Mardi", mardi, 3, 240, 20, grfx, loader, this);
            jours[3] = new GrilleJour("Mercredi", mercredi, 4, 340, 20, grfx, loader, this);
            jours[4] = new GrilleJour("Jeudi", jeudi, 5, 440, 20, grfx, loader, this);
            jours[5] = new GrilleJour("Vendredi", vendredi, 6, 540, 20, grfx, loader, this);
            jours[6] = new GrilleJour("Samedi", samedi, 7, 640, 20, grfx, loader, this);



        }

        public GrilleHoraire(Graphics grfx, Profil profil, DateTime date)
        {
            gfx = grfx;
            this.profil = profil;
            //DateTime renvoyer par la fonction getweekrange()
            laDate = date;

            changeSemaineProfil(laDate);



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
                if (i <= 10)
                    gfx.DrawString("0" + (i - 1) + ":00", laFont, brush, 0, (20 * i) + 15);
                else
                    gfx.DrawString((i - 1) + ":00", laFont, brush, 0, (20 * i) + 15);
            }
        }

        public void refresh()
        {
            gfx.Clear(Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192))))));
            activer();
        }


        public void changeSemaine(DateTime date)
        {

            DateTime lundi = date;
            DateTime mardi = date.Add(new TimeSpan(24, 0, 0));
            DateTime mercredi = date.Add(new TimeSpan(48, 0, 0));
            DateTime jeudi = date.Add(new TimeSpan(72, 0, 0));
            DateTime vendredi = date.Add(new TimeSpan(96, 0, 0));
            DateTime samedi = date.Add(new TimeSpan(120, 0, 0));
            DateTime dimanche = date.Subtract(new TimeSpan(24, 0, 0));


            //Création des jours - ajouter les blocs existants
            jours[0] = new GrilleJour("Dimanche", dimanche, 1, 40, 20, gfx, loader, this);
            jours[1] = new GrilleJour("Lundi", lundi, 2, 140, 20, gfx, loader, this);
            jours[2] = new GrilleJour("Mardi", mardi, 3, 240, 20, gfx, loader, this);
            jours[3] = new GrilleJour("Mercredi", mercredi, 4, 340, 20, gfx, loader, this);
            jours[4] = new GrilleJour("Jeudi", jeudi, 5, 440, 20, gfx, loader, this);
            jours[5] = new GrilleJour("Vendredi", vendredi, 6, 540, 20, gfx, loader, this);
            jours[6] = new GrilleJour("Samedi", samedi, 7, 640, 20, gfx, loader, this);
            
            refresh();
        }

        public void changeSemaineProfil(DateTime date)
        {

            DateTime lundi = date;
            DateTime mardi = date.Add(new TimeSpan(24, 0, 0));
            DateTime mercredi = date.Add(new TimeSpan(48, 0, 0));
            DateTime jeudi = date.Add(new TimeSpan(72, 0, 0));
            DateTime vendredi = date.Add(new TimeSpan(96, 0, 0));
            DateTime samedi = date.Add(new TimeSpan(120, 0, 0));
            DateTime dimanche = date.Subtract(new TimeSpan(24, 0, 0));


            //Création des jours - ajouter les blocs existants
            jours[0] = new GrilleJour("Dimanche", dimanche, 1, 40, 20, gfx, profil, this);
            jours[1] = new GrilleJour("Lundi", lundi, 2, 140, 20, gfx, profil, this);
            jours[2] = new GrilleJour("Mardi", mardi, 3, 240, 20, gfx, profil, this);
            jours[3] = new GrilleJour("Mercredi", mercredi, 4, 340, 20, gfx, profil, this);
            jours[4] = new GrilleJour("Jeudi", jeudi, 5, 440, 20, gfx, profil, this);
            jours[5] = new GrilleJour("Vendredi", vendredi, 6, 540, 20, gfx, profil, this);
            jours[6] = new GrilleJour("Samedi", samedi, 7, 640, 20, gfx, profil, this);


            //7refresh();

        }

        public void passeClique(MouseEventArgs e, String mouse, Bloc preset = null)
        {
            if (mouse == "MouseDown")
            {
                if (preset != null)
                {
                    for (int i = 0; i < 7; i++)
                    {
                        //Sélection du bon jours
                        if (e.X > jours[i].getX() && e.X < jours[i].getXFin())
                        {
                            //Jour cliquer
                            jourCliquer = jours[i];

                            //DateTime 1 heure plus tard
                            DateTime tempDateFin = jourCliquer.getDate();

                            if (jourCliquer.getHeureClique(e.Y) >= 0)
                            {
                                if (jourCliquer.getHeureClique(e.Y) >= 0)
                                {
                                    //Création du bloc
                                    //  refresh();
                                    jourCliquer.addPreset(preset, jourCliquer.getX());
                                    refresh();
                                }
                            }




                        }
                    }

                }
                else
                {
                    Boolean blocUnselected = false;

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
                                blocUnselected = true;
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
                                if (blocUnselected == false)
                                {
                                    {
                                        //DateTime 1 heure plus tard
                                        DateTime tempDateFin = jourCliquer.getDate();

                                        if (jourCliquer.getHeureClique(e.Y) >= 0)
                                        {
                                            if (jourCliquer.getHeureClique(e.Y) >= 0)
                                            {
                                                //Création du bloc
                                                //  refresh();
                                                jourCliquer.createBlock(jourCliquer.getX(), jourCliquer.getHeureClique(e.Y),
                                                    jourCliquer.getDate(), tempDateFin);
                                                refresh();
                                            }
                                        }

                                    }
                                }
                            }
                        }
                    }
                }


            }//Fin du MouseUp
            if (mouse == "MouseUp")
            {
                
            }

            if (mouse == "DoubleClick")
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
                            jourCliquer.modifierBlock(selectionEnCours);
                            refresh();

                        }

                    }

                }

            }


          
        }
    }
}

