/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HoraireBeta
{
   public class TabSchedule
    {
       public int generate(List<Bloc> blocs, List<Ressource> employee)
       {
           for (int i = 0; i < blocs.Count; i++) {
               for (int j = 0; j < employee.Count; j++) { 
                    for(int k =0; k<((Profil)employee[j]).getPref().Count;k++){

                        //si l'heure de début et avant le début du bloc, et l'heure de fin est après la fin du bloc, et le jour de la semaine est le même et que l'employé n'as pas dépassé son quota d'heure
                        if (Convert.ToInt32(((Profil)employee[j]).getPref()[k].getDebut().ToString("HHMM")) <= Convert.ToInt32(blocs[i].getDebut().ToString("HHMM")) && Convert.ToInt32(employee[j].getPref()[k].getFin().ToString("HHMM")) >= Convert.ToInt32(blocs[i].getFin().ToString("HHMM")) && employee[j].getHeuresMax() > employee[j].getHeuresTravaillees() && employee[j].getPref()[k].getDebut().ToString("ddd").Equals(blocs[i].getDebut().ToString("ddd")))
                        {
                            for (int l =0; l<((Profil)employee[j]).getPoste().Count; l++){
                                if( blocs[i].estVoulue(((Profil)employee[j]).getPoste(l))){
                                    blocs[i].addRessource(((Profil)employee[j]));
                                }
                             }
                        }
                    }
               }
           }

           for (int i = 0; i < blocs.Count; i++)
           {
               for (int j =0; i<blocs[i].getRessourceVoulus().Count; j++){

           }
       }


    }
}*/
