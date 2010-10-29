using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HoraireBeta
{
    class GrilleJour
    {
        //Variables locales
        String jour="null";
        Bloc[] blocs = new Bloc[10];
        int indexBlocs=0;
        DateTime dateDuJour;

        //Constructeur
        public GrilleJour(String jour)
            {   
            this.jour = jour;
            dateDuJour = new DateTime();
            
            }

        public void ajouterBloc(int heureDebut) 
            {
                //Variables bidon
                DateTime date = new DateTime();

                //Lors de l'ajout du bloc par defaut on ajoute 1hr
                // debut +1
            
                blocs[indexBlocs++] = new Bloc(date,date,0);
                
            }

        public Bloc


        


    }
}
