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
        String jour = "null";
        Bloc[] blocs = new Bloc[10];
        int indexBlocs = 0;
        DateTime dateDuJour;
        private int posX;
        private int posY;
        private int width;
        private int height;
        Graphics grfx;
        Font laFont = new Font("Arial", 12);
        SolidBrush myBrush = new SolidBrush(Color.Black);
        SolidBrush myWhiteBrush = new SolidBrush(Color.White);
        SolidBrush myBlackBrush = new SolidBrush(Color.Black);
        Pen bPen = new Pen(Color.Black);

        //Petit rectangle
        int heightHeure = (500 / 24);



        //Constructeur
        public GrilleJour(String jour, int posx, int posy, Graphics grfx)
        {
            this.jour = jour;
            dateDuJour = new DateTime();
            posX = posx;
            posY = posy;
            width = 100;
            height = 500;

            this.grfx = grfx;

          //  blocs[0] = new Bloc(posY, posY + 30, "mon", 1, 1);
         //   blocs[0].draw(grfx);
        }

        public void activer()
        {
            //Tracé du jour
            grfx.DrawRectangle(bPen, posX, posY, width, height);

            //En-tête du jour
            grfx.DrawRectangle(bPen, posX, posY, width, 20);
            grfx.DrawString(jour, laFont, myBrush, posX + 8, posY);

            //BG des jours
            grfx.FillRectangle(myBlackBrush, posX + 1, posY + 20, width - 1, height - 20);

            //Gradation rectangulaire
            for (int i = 0; i < 24; i++)
            {
                grfx.FillRectangle(myWhiteBrush, posX + 1, posY + (heightHeure * i) + 20, width - 1, heightHeure - 1);

            }


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

        public void passeClique(MouseEventArgs e)
        {
            if (e.Clicks == 1)
            {
                if ((e.X >= posX) && (e.X < posX + 100))
                {
                    //Détecteur de bloc
                    if ((e.Y > 20) && (e.Y < 40))
                    {
                        grfx.FillRectangle(myBlackBrush, e.X + 1, e.Y, width - 1, heightHeure);
                        // MessageBox.Show("Créer un bloc");


                    }

                }



            }
        }

        public void passeClique(int x, int y)
        {
            if ((x >= posX) && (x < posX + 100))
            {
                //Détecteur de bloc
                if ((y > 20) && (y < 40))



                    // MessageBox.Show("Jour " + jour + " en position (" + x + "," + y+")");

                    grfx.DrawLine(bPen, posX, posY, x, y);

                // grfx.DrawRectangle(bPen, this.posX, this.posY, this.posX + 99, this.posY + 99);
                //grfx.dispose();
                //grfx.Clear(Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192))))));
                //activer();

            }
        }

        public void MouseEvent(MouseEventArgs e)
            {
            MessageBox.Show("Click Jour");
            }

    



    }
}
