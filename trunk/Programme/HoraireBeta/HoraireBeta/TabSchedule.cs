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
        int coun = 0;

        Loader l = new Loader();


        public int generate(List<Bloc> blocs, List<Ressource> employee)
        {
            
            int valide = 0;
            bool breakthefuck = false;

            for (int j = 0; j < employee.Count; j++)
            {
                //MessageBox.Show("Han? -4 : " + ((Profil)employee[j]).getHeuresMax() + " 2em Han :" + ((Profil)employee[j]).getHeuresTravaillees());
                if (((Profil)employee[j]).getHeuresMax() > ((Profil)employee[j]).getHeuresTravaillees())
                {
                    for (int i = 0; i < blocs.Count; i++)
                    {
                       // MessageBox.Show("Han? -3");
                        if (!blocs[i].checkCompletion())
                        {
                            Console.WriteLine(blocs[i].getId() + " " + blocs[i].getDebut() + " " + blocs[i].getFin());
                    

                            for (int k = 0; k < ((Profil)employee.ElementAt(j)).getPref().Count; k++)
                            {
                                Console.WriteLine("       " + ((Profil)employee[j]).getNom() + " " + (((Profil)employee[j]).getPref()[k].getDebut()) + " " + (((Profil)employee[j]).getPref()[k].getFin()) + " " + ((Profil)employee[j]).getHeuresMax() + " " + ((Profil)employee[j]).getHeuresTravaillees() + " ");
                                //MessageBox.Show("Han? -2");   
                                //si l'heure de début et avant le début du bloc, et l'heure de fin est après la fin du bloc, et le jour de la semaine est le même et que l'employé n'as pas dépassé son quota d'heure
                                if (Convert.ToInt32(((Profil)employee[j]).getPref()[k].getDebut().ToString("HHmm")) <= Convert.ToInt32(blocs[i].getDebut().ToString("HHmm")) && Convert.ToInt32(((Profil)employee[j]).getPref()[k].getFin().ToString("HHmm")) >= Convert.ToInt32(blocs[i].getFin().ToString("HHmm")) && ((Profil)employee[j]).getHeuresMax() > ((Profil)employee[j]).getHeuresTravaillees() && ((Profil)employee[j]).getPref()[k].getDebut().DayOfWeek.Equals(blocs[i].getDebut().DayOfWeek) && !blocs[i].estDejaPresent(employee[j]))
                                {
                                    for (int l = 0; l < ((Profil)employee[j]).getPoste().Count; l++)
                                    {

                                      
                                        //MessageBox.Show("Han? -1");
                                        if (blocs[i].estVoulue(((Profil)employee[j]).getPoste(l)) && !blocs[i].estDejaPresent(employee[j]))
                                        {
                                            blocs[i].addRessource(((Profil)employee[j]), ((Profil)employee[j]).getPoste(l));
                                            //MessageBox.Show("han?");
                                            //pour sortir des boucles useless;
                                            l = ((Profil)employee[j]).getPoste().Count;
                                            k = ((Profil)employee.ElementAt(j)).getPref().Count;
                                            if (((Profil)employee[j]).getHeuresMax() > ((Profil)employee[j]).getHeuresTravaillees())
                                                i = blocs.Count;


                                        }
                                        coun++;
                                    }
                                }
                            }
                        }
                    }
                }
            }





            for (int j = 0; j < employee.Count; j++)
            {
                if (((Profil)employee[j]).getHeuresMax() > ((Profil)employee[j]).getHeuresTravaillees())
                {
                    for (int i = 0; i < blocs.Count; i++)
                    {
                        if (!blocs[i].checkCompletion())
                        {
                            Console.WriteLine(blocs[i].getId() + " " + blocs[i].getDebut() + " " + blocs[i].getFin());


                            for (int k = 0; k < ((Profil)employee.ElementAt(j)).getDispo().Count; k++)
                            {
                                //si l'heure de début et avant le début du bloc, et l'heure de fin est après la fin du bloc, et le jour de la semaine est le même et que l'employé n'as pas dépassé son quota d'heure
                                    
                                if (Convert.ToInt32(((Profil)employee[j]).getDispo()[k].getDebut().ToString("HHmm")) <= Convert.ToInt32(blocs[i].getDebut().ToString("HHmm")) && Convert.ToInt32(((Profil)employee[j]).getDispo()[k].getFin().ToString("HHmm")) >= Convert.ToInt32(blocs[i].getFin().ToString("HHmm")) && ((Profil)employee[j]).getHeuresMax() > ((Profil)employee[j]).getHeuresTravaillees() && ((Profil)employee[j]).getDispo()[k].getDebut().DayOfWeek.Equals(blocs[i].getDebut().DayOfWeek) && !blocs[i].estDejaPresent(employee[j]))
                                {
                                    for (int l = 0; l < ((Profil)employee[j]).getPoste().Count; l++)
                                    {

                                        Console.WriteLine("       " + ((Profil)employee[j]).getNom() + " " + (((Profil)employee[j]).getDispo()[k].getDebut()) + " " + (((Profil)employee[j]).getDispo()[k].getFin()) + " " + ((Profil)employee[j]).getHeuresMax() + " " + ((Profil)employee[j]).getHeuresTravaillees() + " ");
                                        if (blocs[i].estVoulue(((Profil)employee[j]).getPoste(l)) && !blocs[i].estDejaPresent(employee[j]))
                                        {
                                            blocs[i].addRessource(((Profil)employee[j]), ((Profil)employee[j]).getPoste(l));
                                            MessageBox.Show("han?");
                                            //pour sortir des boucles useless;
                                            l = ((Profil)employee[j]).getPoste().Count;
                                            k = ((Profil)employee.ElementAt(j)).getDispo().Count;

                                        }
                                        coun++;
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
                coun++;
            }


            for (int i = 0; i < blocs.Count; i++)
            {
                for (int j = 0; j < blocs[i].getRessourceVoulus().Count; j++)
                {

                    if (blocs[i].getRessourceVoulus(j).nbAffectee == 0 && l.erreur.Count > 2)
                    {

                        l.returnErreur(2);
                        
                    }
                    coun++;
                }
            }
            foreach (Bloc bloc in blocs)
            {
                bloc.save();
            }
            foreach (Ressource emp in employee)
            {
                ((Profil)emp).save();
            }

            MessageBox.Show(coun+"");
            return valide;
        }
    }
}
