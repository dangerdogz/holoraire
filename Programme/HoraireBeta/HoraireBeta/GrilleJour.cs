using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;



namespace HoraireBeta
{
    class GrilleJour
    {
        //Variables locales
        DateTime laDate;
        DateTime dateFin;
        bool mousepush=false;
        int jour;
        String jourText;
        //Bloc[] blocs = new Bloc[10];
        List<Bloc> blocs = new List<Bloc>();
        Bloc selectionEnCours;
        int indexBlocs = 0;
        DateTime dateDuJour;
        private int posX;
        private int posY;
        private int width;
        private int height;
        Loader loader;
        Graphics grfx;
        Font laFont = new Font("Arial", 12);
        SolidBrush myBrush = new SolidBrush(Color.Black);
        SolidBrush myWhiteBrush = new SolidBrush(Color.White);
        SolidBrush myBlackBrush = new SolidBrush(Color.Black);
        SolidBrush myBlueBrush = new SolidBrush(Color.Blue);
        Pen bPen = new Pen(Color.Black);

        //Petit rectangle
        int heightHeure = (500 / 24);



        //Constructeur
        public GrilleJour(String jourText,DateTime laDate, int jour, int posx, int posy, Graphics grfx, Loader loader,GrilleHoraire grilleH)
        {
            this.jourText = jourText;
            this.jour = jour;
            dateDuJour = laDate;
            posX = posx;
            posY = posy;
            width = 100;
            height = 500;
            this.loader = loader;
            this.grfx = grfx;
            
            
        }

        ~GrilleJour() { 
           

            
        }

        public void activer()
        {
            //Tracé du jour
            grfx.DrawRectangle(bPen, posX, posY, width, height);

            //En-tête du jour
            grfx.DrawRectangle(bPen, posX, posY, width, 20);
            grfx.DrawString(jourText, laFont, myBrush, posX + 8, posY);

            //BG des jours
            grfx.FillRectangle(myBlackBrush, posX + 1, posY + 20, width - 1, height - 20);

            //Gradation rectangulaire
            for (int i = 0; i < 24; i++)
            {
                grfx.FillRectangle(myWhiteBrush, posX + 1, posY + (heightHeure * i) + 20, width - 1, heightHeure - 1);

            }

            //Charge les blocs du jours
            blocs = loader.getBlocFromDate(dateDuJour);
            if (blocs != null)
                {
                for (int i = 0; i < blocs.Count; i++)
                    {
                    blocs.ElementAt(i).draw(width, grfx);

                    }
                    
                }
        }

        public void changeDate(DateTime nouvelleDate)
            {
                laDate = nouvelleDate;
        
            }



        public void ajouterBloc(int heureDebut)
        {
            //Variables bidon
            DateTime date = new DateTime();
            //  blocs[indexBlocs] = new Bloc();
            //Lors de l'ajout du bloc par defaut on ajoute 1hr
            // debut +1


            //blocs[indexBlocs++] = new Bloc(date,date,0);




        }

        public void passeClique(MouseEventArgs e,String mouse)
        {
            
            
            if (mouse == "MouseDown")
            {
                if ((e.X >= posX) && (e.X < posX + 100))
                {

                    //Vérifis si le clique touche un bloc
                   // blocs = loader.getBlocFromDate(dateDuJour);
                    if (blocs != null)
                    {
                        for (int i = 0; i < blocs.Count; i++)
                        {
                            //Vérifis les Y des blocs
                            if(e.Y >blocs.ElementAt(i).getY() && e.Y < blocs.ElementAt(i).getYFin())
                                {
                                //Si je sélectionne déjàs un bloc
                                if (selectionEnCours != null)
                                    {
                                    selectionEnCours.unSelectIt();
                                    }
                                //Affectation du nouveau Bloc
                                blocs.ElementAt(i).selectIt();
                                selectionEnCours = blocs.ElementAt(i);
                                MessageBox.Show("Block sélectionné");
                               
                                }
                        }

                    }
                    
                    //Détecteur de bloc
                    if ((e.Y > 40) && (e.Y < 60))
                    {
                    // grfx.FillRectangle(myBlueBrush, posX + 1, e.Y, width - 1, heightHeure);

                    dateDuJour = new DateTime(dateDuJour.Year, dateDuJour.Month, dateDuJour.Day, 1, 0, 0);
                    dateFin = new DateTime(dateDuJour.Year, dateDuJour.Month, dateDuJour.Day, 2, 0, 0);
                    createBlock(posX, 40,dateDuJour,dateFin);
                    }

                }



            }

            if (mouse == "MouseUp")
                {
                if (mousepush)
                    { 
                    
                
                    }
            
                }

        }

        
        

        private void createBlock(int x, int y,DateTime debut,DateTime fin)
        {
           
                CreationBloc creationbloc = new CreationBloc();
                creationbloc.ShowDialog();
                //loader.bloc.Add(new Bloc(new DateTime(2010, 11, 03, Convert.ToInt32(creationbloc.getHd()), 0, 0), new DateTime(2010, 11, 03, Convert.ToInt32(creationbloc.getHf()), 0, 0), 0, 0));
                // loader.bloc.Add(new Bloc(jourText, x, y, y + 16, jour, 0, 0));
                Bloc tempBloc = new Bloc(debut, fin,x, 0, 0);
                tempBloc.draw(width,grfx);
                loader.bloc.Add(tempBloc);
                
                creationbloc.Dispose();
                //Application.Run(creationbloc);
          }
       
    
    }

    



   }

