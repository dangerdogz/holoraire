using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HoraireBeta
{

    public struct RessourceEntree
    {
        //struct qui sert a rentrer toutes les variables dans une liste   
        public Ressource voulue;
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
        private int id;
        
        System.Globalization.CultureInfo info = new System.Globalization.CultureInfo("en-US", false);

        List<Ressource> ressourcesAffectes = new List<Ressource>();
        List<RessourceEntree> ressourcesVoulus = new List<RessourceEntree>();

        public Bloc(DateTime debut, DateTime fin, int type, int id)
        {


            System.Globalization.Calendar calendar = info.Calendar;
            this.debut = debut;
            this.fin = fin;
            this.typeBloc = type;
            this.id = id;


            erreurExiste = false;
            estComplet = false;

        }

        public int getType()
        {
            return typeBloc;
        }


        public void addRessourceVoulue(int nbvoulue, Ressource voulue)
        {
            //nom pas tant hot
            
            RessourceEntree ressourceToAdd;
            ressourceToAdd.voulue = voulue;
            ressourceToAdd.nbVoulue = nbvoulue;
            ressourceToAdd.nbAffectee = 0;

            ressourcesVoulus.Add(ressourceToAdd);
        }



        public void addRessource(Profil newEmp)
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
                    while (coun < ressourcesAffectes.Count && ((Profil)ressourcesAffectes[coun]).getAnciennete() <= newEmp.getAnciennete())
                    {
                        coun++;
                    }
                    
                   
                    
                    ressourcesAffectes.Insert(coun, newEmp);
                    
                }
                int i=0;
                int j = 0;
                //parse la liste des ressources voulues et ensuite la liste des poste de l'employé pour essayer de trouver un match
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

        public void addRessource(Equipe newEquipe)
        {
           ressourcesAffectes.Add(newEquipe);

            
            int i = 0;
            while (i < ressourcesVoulus.Count() && ressourcesVoulus[i++].voulue != newEquipe) ;
                

            if (i < ressourcesVoulus.Count())
            {
                RessourceEntree ressourceAdded = ressourcesVoulus[--i];
                ressourceAdded.nbAffectee++;
                ressourcesVoulus[i] = ressourceAdded;
            }
        
        checkCompletion();

        }

        public void removeEmplNouv()
        {
            //enlève l'employé le plus noob
            int i = 0;
            int j = 0;
            while (i < ressourcesVoulus.Count() && ressourcesVoulus[i].voulue != ((Profil)ressourcesAffectes[0]).getPoste(j))
                {
                    
                    j = 0;
                    while (j < ((Profil)ressourcesAffectes[0]).getPoste().Count && ressourcesVoulus[i].voulue != ((Profil)ressourcesAffectes[0]).getPoste(j++)) ;
                    j--;
                    if (ressourcesVoulus[i].voulue != ((Profil)ressourcesAffectes[0]).getPoste(j))
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
            while (i < ressourcesVoulus.Count() && ressourcesVoulus[i].voulue != ((Profil)ressourcesAffectes[position]).getPoste(j))
            {

                j = 0;
                while (j < ((Profil)ressourcesAffectes[position]).getPoste().Count && ressourcesVoulus[i].voulue != ((Profil)ressourcesAffectes[position]).getPoste(j++)) ;
                j--;
                if (ressourcesVoulus[i].voulue != ((Profil)ressourcesAffectes[position]).getPoste(j))
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

        public int getId()
        {
            return id;
        }

        public void setId(int id)
        {
            this.id = id;
        }


        public RessourceEntree getRessourceVoulus(int position)
        {
            return ressourcesVoulus[position];
        }

        public Profil getRessourceAffecte(int position) 
        {
            if (position < ressourcesAffectes.Count)
            {
                return ((Profil)ressourcesAffectes[position]);
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
