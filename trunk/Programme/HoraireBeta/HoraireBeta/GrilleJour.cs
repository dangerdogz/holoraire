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

        DateTime dateFin;
        bool mousepush = false;
        int jour;
        public String jourText;
        //Bloc[] blocs = new Bloc[10];
        List<Bloc> blocs = new List<Bloc>();
        Bloc selectionEnCours;
        int indexBlocs = 0;
        public DateTime dateDuJour;
        private int posX;
        private int posY;
        private int width;
        private int height;
        Loader loader;
        Profil profil;
        Graphics grfx;
        GrilleHoraire laGrille;
        Font laFont = new Font("Arial", 12);
        SolidBrush myBrush = new SolidBrush(Color.Black);
        SolidBrush myWhiteBrush = new SolidBrush(Color.White);
        SolidBrush myBlackBrush = new SolidBrush(Color.Black);
        SolidBrush myBlueBrush = new SolidBrush(Color.Blue);
        Pen bPen = new Pen(Color.Black);
        int nbHeures = 24;
       

        //Gestion des heures
        int heightHeure;
        int heureDebutGradation = 1;



        //Constructeur
        public GrilleJour(String jourText, DateTime laDate, int jour, int posx, int posy, Graphics grfx, Loader loader, GrilleHoraire grilleH)
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
            laGrille = grilleH;

            //Petit rectangle
            heightHeure = ((height - 20) / nbHeures);

        }

        public GrilleJour(String jourText, DateTime laDate, int jour, int posx, int posy, Graphics grfx, Profil profil, GrilleHoraire grilleH)
        {
            this.jourText = jourText;
            this.jour = jour;
            dateDuJour = laDate;
            posX = posx;
            posY = posy;
            width = 100;
            height = 500;
            this.profil = profil;
            this.grfx = grfx;
            laGrille = grilleH;

            //Petit rectangle
            heightHeure = ((height - 20) / nbHeures);

        }

        ~GrilleJour()
        { //Destructeur Décoratif! Made by Simon Brassard



        }
        //Renvois la position en Y l'heure cliquer
        public int getHeureClique(int yClique)
        {

            //Enève l'entête de 20 pixel
            yClique = yClique - 20;

            for (int i = 0; i <= nbHeures; i++)
            {
                if (yClique > (i * heightHeure) && yClique < ((i + 1) * heightHeure))
                {
                    return (i - 1);
                }
            }

            return -1;
        }

        public int getHeightHeure()
        {
            return heightHeure;
        }

        public int getX()
        { return posX; }

        public int getXFin()
        { return posX + width; }

        public DateTime getDate()
        { return dateDuJour; }

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
            if (profil == null)
                blocs = loader.getBlocFromDate(dateDuJour);
            else
                if (loader == null && laGrille.isPref)
                    blocs = profil.getBlocFromDate(dateDuJour, true);
                else
                    if (loader == null && !laGrille.isPref)
                    {
                       // MessageBox.Show("Fuckshit");
                        blocs = profil.getBlocFromDate(dateDuJour, false);
                   // MessageBox.Show("Niggercunt");
                    }

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
            dateDuJour = nouvelleDate;

        }

        public Bloc selectionneUnBloc(int lesY)
        {
            //Vérifis si le clique touche un bloc
            // blocs = loader.getBlocFromDate(dateDuJour);
            if (blocs != null)
            {
                for (int i = 0; i < blocs.Count; i++)
                {
                    //Vérifis les Y des blocs
                    if ((lesY > blocs.ElementAt(i).getY()) && (lesY < blocs.ElementAt(i).getYFin()))
                    {
                        return blocs.ElementAt(i);

                    }
                }

            }
            return null;
        }



        public void ajouterBloc(int heureDebut)
        {
            //Variables bidon
            //  DateTime date = new DateTime();
            //  blocs[indexBlocs] = new Bloc();
            //Lors de l'ajout du bloc par defaut on ajoute 1hr
            // debut +1
            
            //blocs[indexBlocs++] = new Bloc(date,date,0);




        }

        public Bloc getBloc(int i)
        {
            return blocs.ElementAt(i);
        }

        public void passeClique(MouseEventArgs e, String mouse)
        {


            if (mouse == "MouseDown")
            {
                if ((e.X >= posX) && (e.X < (posX + 100)))
                {
                    
                    //Vérifis si le clique touche un bloc
                   // blocs = loader.getBlocFromDate(dateDuJour);
                    if (blocs != null)
                    {
                        for (int i = 0; i < blocs.Count; i++)
                        {
                            //Vérifis les Y des blocs
                            if((e.Y >= blocs.ElementAt(i).getY()) && (e.Y <= blocs.ElementAt(i).getYFin()))
                                {
                                //Si je sélectionne déjàs un bloc
                                if (selectionEnCours != null)
                                    {
                                    selectionEnCours.unSelectIt();
                                    }
                                //Affectation du nouveau Bloc
                                blocs.ElementAt(i).selectIt();
                                selectionEnCours = blocs.ElementAt(i);
                                //MessageBox.Show("Block sélectionné");
                                laGrille.refresh();
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


        public void modifierBlock(Bloc leBloc)
        {
            string hDebut = leBloc.getDebut().Hour + "";
            string hFin = (leBloc.getFin().Hour + 1) + "";

            DateTime debut = leBloc.getDebut();
            DateTime fin = leBloc.getFin();

            ModificationBloc modifbloc = new ModificationBloc(hDebut, hFin,blocs);
            modifbloc.ShowDialog();

            if (modifbloc.isValide())
            {
                if (modifbloc.getCommande() == 0)
                {
                    //Modification d'un bloc
                    //Compute Nouvelle Date ** Ajouter validation ** 

                    int dateDebut = int.Parse(modifbloc.getHd());
                    int dateFin = int.Parse(modifbloc.getHf());

                    DateTime tempDebut = new DateTime(debut.Year, debut.Month, debut.Day, dateDebut, debut.Minute, debut.Second);
                    DateTime tempFin = new DateTime(fin.Year, fin.Month, fin.Day, dateFin - 1, fin.Minute, fin.Second);


                    Bloc leBloc2 = new Bloc(tempDebut, tempFin, 0, 0);
                    if (modifbloc.placementValide(leBloc2))

                    {

                        if (loader != null && loader.modifierBloc(leBloc, leBloc2))
                        { //Ajout du bloc confirmé 
                        } //
                        else
                        {
                            if (loader != null)
                                MessageBox.Show("Bloc introuvable");
                            else
                            {
                                if (profil != null && laGrille.isPref && profil.modifierBloc(leBloc, leBloc2, true))
                                { //lolnigger
                                }
                                else
                                {
                                    if (profil != null && !laGrille.isPref && profil.modifierBloc(leBloc, leBloc2, false))
                                    { //lolnigger
                                    }
                                }

                            }

                        }
                    }
                    else
                    {

                    }
                }


                else
                //Suppression d'un Bloc
                {
                    if (profil == null)
                        loader.supprimerBloc(leBloc);
                    else
                    {
                        if (loader == null && laGrille.isPref)
                            profil.getPref().Remove(leBloc);
                        else
                        {
                            if (loader == null && !laGrille.isPref)
                                profil.getDispo().Remove(leBloc);
                        }

                    }


                    laGrille.refresh();


                }

            }
            modifbloc.Dispose();
    
        }



        public void createBlock(int x, int heureDebut, DateTime debut, DateTime fin)
        {
            string hDebut = heureDebut + "";
            string hFin = (heureDebut + 1) + "";

            CreationBloc creationbloc = new CreationBloc(hDebut, hFin, blocs);
            creationbloc.ShowDialog();

            if (creationbloc.isValide())
            {

            //Compute Nouvelle Date ** Ajouter validation ** 
            int dateDebut = int.Parse(creationbloc.getHd());
            int dateFin = int.Parse(creationbloc.getHf());



            DateTime tempDebut = new DateTime(debut.Year, debut.Month, debut.Day, dateDebut, debut.Minute, debut.Second);
            DateTime tempFin = new DateTime(fin.Year, fin.Month, fin.Day, dateFin, fin.Minute, fin.Second) - new TimeSpan(0, 0, 0, 1);

            // MessageBox.Show(" Date Début : " + tempDebut + " et Date Fin : " + tempFin);


            //Affecte le bloc
            Bloc tempBloc = new Bloc(tempDebut, tempFin, 0, 0);

            

            if (creationbloc.placementValide(tempBloc))
            {
                if (profil != null)
                {
                    if (loader == null && laGrille.isPref)
                        profil.addPref(tempBloc);
                    else
                        if (loader == null && !laGrille.isPref)
                            profil.addDispo(tempBloc);
                    tempBloc.draw(width, grfx);
                }
                else
                {
                    //Ajout du block valide
                    tempBloc.draw(width, grfx);
                    loader.bloc.Add(tempBloc);
                }
            }
            else
                MessageBox.Show("Placement invalide");

            }
           


            
            creationbloc.Dispose();

        }


    }





}

