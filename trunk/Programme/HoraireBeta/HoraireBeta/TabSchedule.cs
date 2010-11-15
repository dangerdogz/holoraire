using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace HoraireBeta
{
    public class TabSchedule
    {
        public int generate(List<Bloc> blocs, List<Ressource> employee)
        {

            int valide = 0;

            for (int i = 0; i < blocs.Count; i++)
            {
                if (!blocs[i].checkCompletion())
                {
                    for (int j = 0; j < employee.Count; j++)
                    {
                        for (int k = 0; k < ((Profil)employee.ElementAt(j)).getPref().Count; k++)
                        {


                            //si l'heure de début et avant le début du bloc, et l'heure de fin est après la fin du bloc, et le jour de la semaine est le même et que l'employé n'as pas dépassé son quota d'heure
                            if (Convert.ToInt32(((Profil)employee[j]).getPref()[k].getDebut().ToString("HHMM")) <= Convert.ToInt32(blocs[i].getDebut().ToString("HHMM")) && Convert.ToInt32(((Profil)employee[j]).getPref()[k].getFin().ToString("HHMM")) >= Convert.ToInt32(blocs[i].getFin().ToString("HHMM")) && ((Profil)employee[j]).getHeuresMax() > ((Profil)employee[j]).getHeuresTravaillees() && ((Profil)employee[j]).getPref()[k].getDebut().DayOfWeek.Equals(blocs[i].getDebut().DayOfWeek))
                            {
                                for (int l = 0; l < ((Profil)employee[j]).getPoste().Count; l++)
                                {
                                    if (blocs[i].estVoulue(((Profil)employee[j]).getPoste(l)))
                                    {
                                        blocs[i].addRessource(((Profil)employee[j]));
                                    }
                                }
                            }
                        }
                    }
                }
            }

           for (int i = 0; i < blocs.Count; i++)
           {
               for (int j = 0; j < blocs[i].getRessourceVoulus().Count; j++)
               {
                    if (blocs[i].getRessourceVoulus(j).nbVoulue < blocs[i].getRessourceVoulus(j).nbAffectee)
                   {

                       blocs[i].removeEmplNouv();
                       j--;
                   }

                 }
            }
     


           for (int i = 0; i < blocs.Count; i++)
           {
               for (int j = 0; j < employee.Count; j++)
               {
                   for (int k = 0; k < ((Profil)employee[j]).getDispo().Count; k++)
                   {

                       //si l'heure de début et avant le début du bloc, et l'heure de fin est après la fin du bloc, et le jour de la semaine est le même et que l'employé n'as pas dépassé son quota d'heure, et que le bloc n'est pas plein
                       if (Convert.ToInt32(((Profil)employee[j]).getDispo()[k].getDebut().ToString("HHMM")) <= Convert.ToInt32(blocs[i].getDebut().ToString("HHMM")) && Convert.ToInt32(((Profil)employee[j]).getDispo()[k].getFin().ToString("HHMM")) >= Convert.ToInt32(blocs[i].getFin().ToString("HHMM")) && ((Profil)employee[j]).getHeuresMax() > ((Profil)employee[j]).getHeuresTravaillees() && ((Profil)employee[j]).getDispo()[k].getDebut().DayOfWeek.Equals(blocs[i].getDebut().DayOfWeek))
                       {

                           for (int l = 0; l < ((Profil)employee[j]).getPoste().Count; l++)
                           {
                               if (blocs[i].estVoulue(((Profil)employee[j]).getPoste(l)))
                               {
                                    if (blocs[i].getRessourceVoulus(k).nbVoulue > blocs[i].getRessourceVoulus(k).nbAffectee)
                                           blocs[i].addRessource(((Profil)employee[j]));
                                   
                               }
                           } 
                           
                          
                       }
                   }
               }
           }

           for (int i = 0; i < blocs.Count; i++)
           {
               if (!(blocs[i].checkCompletion()))
               {
                   MessageBox.Show("erreur 1", "LOL");

                   valide = 1;
               }
           }


           for (int i = 0; i < blocs.Count; i++)
           {
               for (int j = 0; j < blocs[i].getRessourceVoulus().Count; j++)
               {

                   if (blocs[i].getRessourceVoulus(j).nbAffectee == 0)
                   {
                       MessageBox.Show("erreur 1", "LOL");
                       valide = 1;
                   }
               }
           }

           return valide;
      }


    }
}
