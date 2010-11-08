﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.Drawing;

namespace HoraireBeta
{

    public struct RessourceEntree
    {
        //struct qui sert a rentrer toutes les variables dans une liste   
        public Ressource voulue;
        public int nbVoulue;
        public int nbAffectee;
    }

    public class Bloc : IComponent 
    {



        private DateTime debut;
        private DateTime fin;
        private int typeBloc;
        private bool erreurExiste;
        private bool estComplet;
        private int id;
        private int x;
        private int y;
        private int haut;


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

            y = Convert.ToInt32(debut.ToString("HH")) * 20 + Convert.ToInt32(debut.ToString("MM"))/20;

            x = (Loader.SemaineToInt(debut) - 1) * 100;
            haut = (Convert.ToInt32(fin.ToString("HH")) * 20 + Convert.ToInt32(fin.ToString("MM")) / 20)-y;


            erreurExiste = false;
            estComplet = false;

        }

        public Bloc(int debutY, int finY, String jour, int type, int id)
        {


            System.Globalization.Calendar calendar = info.Calendar;
            
            this.typeBloc = type;
            this.id = id;
            int hh = debutY / 20;
            int mm = (debutY%20)*3;
            DateTime.ParseExact(jour+"/"+hh+"/"+mm, "ddd/HH/mm", null);

            y = debutY;

            x = (Loader.SemaineToInt(debut) - 1) * 100;
            haut = finY-debutY;


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

        public Boolean estVoulue(Ressource ress)
        {
            Boolean oui = false;
            for (int i = 0; i<ressourcesVoulus.Count; i++){
                

                    if (ress == ((Poste)ressourcesVoulus[i].voulue))
                        oui = true;
                }
            
            return oui;
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

        public List<RessourceEntree> getRessourceVoulus()
        {
            return ressourcesVoulus;
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

        public bool checkCompletion()
        {
            int i = -1;

            estComplet=false;

            while (++i != ressourcesVoulus.Count)
            {
                if (ressourcesVoulus[i].nbVoulue>=ressourcesVoulus[i].nbAffectee)
                {
                    estComplet = true;
                }
            }

            return estComplet;
        }

        public void draw(Graphics gfx)
        {
            Pen pen = new Pen(Color.Cyan);
            SolidBrush brush = new SolidBrush(Color.Cyan);
            gfx.DrawRectangle(pen, x, y, 100, haut);
            gfx.FillRectangle(brush, x-1, y-1, 100-2, haut-2);


        }

        #region IComponent Membres

        public event EventHandler Disposed;

        public ISite Site
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        #endregion

        #region IDisposable Membres

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        #endregion

    }
}
