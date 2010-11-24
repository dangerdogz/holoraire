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

        Loader l = new Loader();

        public int generate(List<Bloc> blocs, List<Ressource> employee)
        {

            int valide = 0;

            for (int i = 0; i < blocs.Count; i++)
            {
                if (!blocs[i].checkCompletion())
                {
                    Console.WriteLine(blocs[i].getId() + " " + blocs[i].getDebut() + " " + blocs[i].getFin());
                    for (int j = 0; j < employee.Count; j++)
                    {
                        for (int k = 0; k < ((Profil)employee.ElementAt(j)).getPref().Count; k++)
                        {

                            Console.WriteLine("       " + ((Profil)employee[j]).getNom() + " " + (((Profil)employee[j]).getPref()[k].getDebut()) + " " + (((Profil)employee[j]).getPref()[k].getFin()) + " " + ((Profil)employee[j]).getHeuresMax() + " " + ((Profil)employee[j]).getHeuresTravaillees() + " ");
                            //si l'heure de début et avant le début du bloc, et l'heure de fin est après la fin du bloc, et le jour de la semaine est le même et que l'employé n'as pas dépassé son quota d'heure
                            if (Convert.ToInt32(((Profil)employee[j]).getPref()[k].getDebut().ToString("HHmm")) <= Convert.ToInt32(blocs[i].getDebut().ToString("HHmm")) && Convert.ToInt32(((Profil)employee[j]).getPref()[k].getFin().ToString("HHmm")) >= Convert.ToInt32(blocs[i].getFin().ToString("HHmm")) && ((Profil)employee[j]).getHeuresMax() > ((Profil)employee[j]).getHeuresTravaillees() && ((Profil)employee[j]).getPref()[k].getDebut().DayOfWeek.Equals(blocs[i].getDebut().DayOfWeek) && !blocs[i].estDejaPresent(employee[j]))
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

                        //blocs[i].removeEmplNouv();
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

                        //   MessageBox.Show(" " + Convert.ToInt32(((Profil)employee[j]).getDispo()[k].getDebut().ToString("HHMM")) + " " + Convert.ToInt32(blocs[i].getDebut().ToString("HHMM")) + " " + Convert.ToInt32(((Profil)employee[j]).getDispo()[k].getFin().ToString("HHMM")) + " " + Convert.ToInt32(blocs[i].getFin().ToString("HHMM")) + " " + ((Profil)employee[j]).getHeuresMax() + " " + ((Profil)employee[j]).getHeuresTravaillees() + " " + ((Profil)employee[j]).getDispo()[k].getDebut().DayOfWeek + " " + (blocs[i].getDebut().DayOfWeek));
                        //si l'heure de début et avant le début du bloc, et l'heure de fin est après la fin du bloc, et le jour de la semaine est le même et que l'employé n'as pas dépassé son quota d'heure, et que le bloc n'est pas plein
                        if (Convert.ToInt32(((Profil)employee[j]).getDispo()[k].getDebut().ToString("HHmm")) <= Convert.ToInt32(blocs[i].getDebut().ToString("HHmm")) && Convert.ToInt32(((Profil)employee[j]).getDispo()[k].getFin().ToString("HHmm")) >= Convert.ToInt32(blocs[i].getFin().ToString("HHmm")) && ((Profil)employee[j]).getHeuresMax() > ((Profil)employee[j]).getHeuresTravaillees() && ((Profil)employee[j]).getDispo()[k].getDebut().DayOfWeek.Equals(blocs[i].getDebut().DayOfWeek) && !blocs[i].estDejaPresent(employee[j]))
                        {
                            // MessageBox.Show("han?");
                            for (int l = 0; l < ((Profil)employee[j]).getPoste().Count; l++)
                            {
                                if (blocs[i].estVoulue(((Profil)employee[j]).getPoste(l)))
                                {
                                    for (int m = 0; m < blocs[i].getRessourceVoulus().Count; m++)
                                    {
                                        if (blocs[i].getRessourceVoulus(m).nbVoulue > blocs[i].getRessourceVoulus(m).nbAffectee && !blocs[i].estDejaPresent(employee[j]))
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
                if (!(blocs[i].checkCompletion()) && l.erreur.Count > 1)
                {

                    l.returnErreur(1);

                }
            }


            for (int i = 0; i < blocs.Count; i++)
            {
                for (int j = 0; j < blocs[i].getRessourceVoulus().Count; j++)
                {

                    if (blocs[i].getRessourceVoulus(j).nbAffectee == 0 && l.erreur.Count > 2)
                    {

                        l.returnErreur(2);

                    }
                }
            }

            return valide;
        }


    }
}
