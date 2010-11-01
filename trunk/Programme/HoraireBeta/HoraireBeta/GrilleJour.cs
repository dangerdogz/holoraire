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
        String jour="null";
        Bloc[] blocs = new Bloc[10];
        int indexBlocs=0;
        DateTime dateDuJour;
        private int posX;
        private int posY;
        private int width;
        private int height;
        Graphics grfx;
        Pen bPen;
        Font laFont = new Font("Arial", 12);
        SolidBrush myBrush = new SolidBrush(Color.Black);
        SolidBrush myWhiteBrush = new SolidBrush(Color.White);
       

        //Constructeur
        public GrilleJour(String jour, int posx, int posy, Graphics grfx, Pen bPen)
            {   
            this.jour = jour;
            dateDuJour = new DateTime();
            posX = posx;
            posY = posy;
            width = 100;
            height = 400;
            this.bPen = bPen;
            this.grfx = grfx;
            
            
            }

        public void activer() {
            //Tracé du jour
            grfx.DrawRectangle(bPen, posX, posY, width, height);

            //En-tête du jour
            grfx.DrawRectangle(bPen, posX, posY, width, 20);
            grfx.DrawString(jour, laFont, myBrush, posX+8, posY);
           
            //Gradation rectangulaire
            for (int i = 0; i < 24; i++)
                { 
                grfx.FillRectangle(myWhiteBrush,posX+1,posY+((400/24)*i)+20,width-1,16-1);
            
                }

           
        }

       


        public void ajouterBloc(int heureDebut) 
            {
                //Variables bidon
                DateTime date = new DateTime();

                //Lors de l'ajout du bloc par defaut on ajoute 1hr
                // debut +1
            

                //blocs[indexBlocs++] = new Bloc(date,date,0);

              

                
            }


        public void passeClique(int x,int y) 
            {
                if ((x >= posX) && (x < posX+100))
                    {
                   // MessageBox.Show("Jour " + jour + " en position (" + x + "," + y+")");
                   
                   grfx.DrawLine(bPen, posX, posY, x, y);

                   // grfx.DrawRectangle(bPen, this.posX, this.posY, this.posX + 99, this.posY + 99);
                    //grfx.dispose();
                    //grfx.Clear(Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192))))));
                    //activer();

                    }
            }
       
        

    }
}
