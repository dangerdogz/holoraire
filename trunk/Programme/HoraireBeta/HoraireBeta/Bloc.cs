using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HoraireBeta
{

    public struct RessourceEntree
    {
        //struct qui sert a rentrer toutes les variables dans une liste   
        public Poste voulue;
        public int nbVoulue;
        public int nbAffectee;
    }

    public class Bloc
    {



        private DateTime debut;
        private DateTime fin;
        private int typeBloc;
        private bool erreurExiste;
        private bool estComplet;
        
        System.Globalization.CultureInfo info = new System.Globalization.CultureInfo("en-US", false);

        List<Profil> ressourcesAffectes = new List<Profil>();
        List<RessourceEntree> ressourcesVoulus = new List<RessourceEntree>();

        public Bloc(DateTime debut, DateTime fin, int type)
        {


            System.Globalization.Calendar calendar = info.Calendar;
            this.debut = debut;
            this.fin = fin;
            this.typeBloc = type;


            erreurExiste = false;
            estComplet = false;

        }

        public int getType()
        {
            return typeBloc;
        }


        public void addRessourceVoulue(int nbvoulue, Poste voulue)
        {
            //nom pas tant hot
            
            RessourceEntree ressourceToAdd;
            ressourceToAdd.voulue = voulue;
            ressourceToAdd.nbVoulue = nbvoulue;
            ressourceToAdd.nbAffectee = 0;

            ressourcesVoulus.Add(ressourceToAdd);
        }



        public void addEmployee(Profil newEmp)
        {
            

            if (ressourcesVoulus.Count!=0)
            {

                if (ressourcesAffectes.Count == 0)
                {
                    ressourcesAffectes.Add(newEmp);

                }
                else
                {
                    //trie l'employé dès son ajout
                    int coun = 0;
                    while (coun < ressourcesAffectes.Count && ressourcesAffectes[coun].getAnciennete() <= newEmp.getAnciennete())
                    {
                        coun++;
                    }
                    
                   
                    
                    ressourcesAffectes.Insert(coun, newEmp);
                    
                }
                int i=0;
                int j = 0;
                while (i < ressourcesVoulus.Count() && ressourcesVoulus[i].voulue != newEmp.getPoste(j))
                {
                    
                    j = 0;
                    while(j<newEmp.getPoste().Count && ressourcesVoulus[i].voulue != newEmp.getPoste(j++));
                    j--;
                    if(ressourcesVoulus[i].voulue != newEmp.getPoste(j))
                       i++;
                }

                if (i < ressourcesVoulus.Count())
                {
                    RessourceEntree ressourceAdded = ressourcesVoulus[i];
                    ressourceAdded.nbAffectee++;
                    ressourcesVoulus[i] = ressourceAdded;
                }
            }
            checkCompletion();



        }

        public void removeEmplNouv()
        {
            //enlève l'employé le plus noob
            int i = 0;
            int j = 0;
            while (i < ressourcesVoulus.Count() && ressourcesVoulus[i].voulue != ressourcesAffectes[0].getPoste(j))
                {
                    
                    j = 0;
                    while(j<ressourcesAffectes[0].getPoste().Count && ressourcesVoulus[i].voulue !=ressourcesAffectes[0].getPoste(j++));
                    j--;
                    if(ressourcesVoulus[i].voulue != ressourcesAffectes[0].getPoste(j))
                       i++;
                }

            RessourceEntree ressourceAdded = ressourcesVoulus[i];
            ressourceAdded.nbAffectee--;
            ressourcesVoulus[i] = ressourceAdded;

            ressourcesAffectes.RemoveAt(0);
            checkCompletion();
            
        }

        public void removeEmpl(int position)
        {
            int j = 0;
            int i = 0;
            while (i < ressourcesVoulus.Count() && ressourcesVoulus[i].voulue != ressourcesAffectes[position].getPoste(j))
            {

                j = 0;
                while (j < ressourcesAffectes[position].getPoste().Count && ressourcesVoulus[i].voulue != ressourcesAffectes[position].getPoste(j++)) ;
                j--;
                if (ressourcesVoulus[i].voulue != ressourcesAffectes[position].getPoste(j))
                    i++;
            };

            RessourceEntree ressourceAdded = ressourcesVoulus[i];
            ressourceAdded.nbAffectee--;
            ressourcesVoulus[i] = ressourceAdded;

            

            ressourcesAffectes.RemoveAt(position);
            checkCompletion();
            
        }


        public DateTime getDebut()
        {
            return debut;
        }

        public DateTime getFin()
        {
            return fin;
        }



        public RessourceEntree getRessourceVoulus(int position)
        {
            return ressourcesVoulus[position];
        }

        public Profil getRessourceAffecte(int position) 
        {
            if (position < ressourcesAffectes.Count)
            {
                return ressourcesAffectes[position];
            }
            else
                return null;
            
        }

        public void checkCompletion()
        {
            int i = -1;
            estComplet=true;
            while (++i != ressourcesVoulus.Count)
            {
                if (ressourcesVoulus[i].nbVoulue>=ressourcesVoulus[i].nbAffectee)
                {
                    estComplet = true;
                }
            }
        }

    }
}
