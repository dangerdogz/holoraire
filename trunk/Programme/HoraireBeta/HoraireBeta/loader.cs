using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Windows.Forms;


namespace HoraireBeta
{

    public struct Erreur
    {
        public int id;
        public String nom;
        public String description;
    }

    public class Loader
    {


        public List<Erreur> erreur = new List<Erreur>();
        public List<Ressource> posteCharge = new List<Ressource>();
        public List<Ressource> profilCharge = new List<Ressource>();
        public List<Ressource> equipe = new List<Ressource>();
        public List<Bloc> bloc = new List<Bloc>();


        DBConnect proc = new DBConnect();

        public List<Ressource> LoadProfil()
        {


            DataTable rs;
            DataTable rs2;
            DataTable rs3;
            DataTable rs4;


            int i = 0;
            rs = proc.getAllProfil();

            while (i < rs.Rows.Count)
            {

                if (rs.Rows[i]["prenom"].ToString() != "")
                {
                    Profil newprof = new Profil(Convert.ToInt32(rs.Rows[i]["idProfil"].ToString()), rs.Rows[i]["prenom"].ToString(), rs.Rows[i]["nom"].ToString(), rs.Rows[i]["email"].ToString(), rs.Rows[i]["phoneNumber"].ToString(), Convert.ToInt32(rs.Rows[i]["seniority"].ToString()), Convert.ToInt32(rs.Rows[i]["quotaHeureMax"].ToString()));
                    

                    if (posteCharge.Count != 0)
                    {


                        rs2 = proc.getProfilPoste(newprof.getId());

                        for (int j = 0; j < rs2.Rows.Count; j++)
                        {
                            int k = 0;
                           // MessageBox.Show(Convert.ToInt32(rs2.Rows[j]["idPoste"].ToString()) + "" + posteCharge[k].getId());
                            while (k<posteCharge.Count && Convert.ToInt32(rs2.Rows[j]["idPoste"].ToString()) != posteCharge[k++].getId())
                            { //MessageBox.Show(Convert.ToInt32(rs2.Rows[j]["idPoste"].ToString()) +""+ posteCharge[k].getId()); 
                            }

                            newprof.setPoste((Poste)posteCharge[--k]);
                        }

                    }

                    rs3 = proc.getProfilDispo(newprof.getId());
                    rs4 = proc.getProfilPreference(newprof.getId());
                    Console.WriteLine(rs4.Rows.Count+"");
                    for (int j = 0; j < rs3.Rows.Count; j++)
                    {


                       

                        Bloc newBloc = new Bloc(DateTime.ParseExact(rs3.Rows[j]["debut"].ToString(), "yyyy-MM-dd HH:mm:ss", null), DateTime.ParseExact(rs3.Rows[j]["fin"].ToString(), "yyyy-MM-dd HH:mm:ss", null), 0, Convert.ToInt32(rs3.Rows[j]["idPlage"].ToString() ));



                        newprof.addDispo(newBloc);


                    }

                    for (int j = 0; j < rs4.Rows.Count; j++)
                    {
                        Bloc newBloc = new Bloc(DateTime.ParseExact(rs4.Rows[j]["debut"].ToString(), "yyyy-MM-dd HH:mm:ss", null), DateTime.ParseExact(rs4.Rows[j]["fin"].ToString(), "yyyy-MM-dd HH:mm:ss", null), 0, Convert.ToInt32(rs4.Rows[j]["idPlage"].ToString()), Convert.ToInt32(rs4.Rows[j]["idPlage"].ToString()));
                        newprof.addPref(newBloc);
                    }
                    
                    profilCharge.Add(newprof);


                }
                i++;


            }

            return (profilCharge);
        }

        public List<Ressource> loadPoste()
        {
            DataTable rs;
            rs = proc.getAllPoste();
            int i = 0;
            while (i != rs.Rows.Count)
            {
                Poste newposte = new Poste(Convert.ToInt32(rs.Rows[i]["idPoste"].ToString()), rs.Rows[i]["nom"].ToString(), rs.Rows[i]["description"].ToString());
                posteCharge.Add(newposte);
                i++;
            }

            return (posteCharge);

        }


        public List<Ressource> LoadEquipe()
        {
            DataTable rsEquipe;
            DataTable rsEquipeProfil;
            rsEquipe = proc.getAllTeam();
            int k = 0;

            for (int i = 0; i < rsEquipe.Rows.Count; i++)
            {

                Equipe newEquipe = new Equipe(Convert.ToInt32(rsEquipe.Rows[i]["idTeam"].ToString()), rsEquipe.Rows[i]["nom"].ToString(), rsEquipe.Rows[i]["description"].ToString());
                equipe.Add(newEquipe);
                rsEquipeProfil = proc.getTeamProfile(equipe[i].getId());
                for (int j = 0; j < rsEquipeProfil.Rows.Count; j++)
                {
                    int id = Convert.ToInt32(rsEquipeProfil.Rows[j]["idProfil"].ToString());
                    k = 0;
                    while (k < profilCharge.Count && id != profilCharge[k++].getId()) ;
                    ((Equipe)equipe[i]).setEmploye(profilCharge[--k]);


                }
            }

            return equipe;

        }


        public List<Bloc> loadBloc()
        {
            DataTable rsBloc;
            DataTable rsRessource;
            rsBloc = proc.getAllBlock();
            int k = 0;

            for (int i = 0; i < rsBloc.Rows.Count; i++)
            {



                Bloc newBloc = new Bloc(DateTime.ParseExact(rsBloc.Rows[i]["debut"].ToString(), "yyyy-MM-dd HH:mm:ss", null), DateTime.ParseExact(rsBloc.Rows[i]["fin"].ToString(), "yyyy-MM-dd HH:mm:ss", null), Convert.ToInt32(rsBloc.Rows[i]["idType"].ToString()), Convert.ToInt32(rsBloc.Rows[i]["idBlock"].ToString()), (Boolean)(rsBloc.Rows[i]["preset"]));



                

                bloc.Add(newBloc);
                rsRessource = proc.getRessource(bloc[i].getId());
                for (int j = 0; j < rsRessource.Rows.Count; j++)
                {
                    if (rsRessource.Rows[j]["idPoste"] != null)
                    {

                        int id = Convert.ToInt32(rsRessource.Rows[j]["idPoste"].ToString());
                        k = 0;
                        while (k < posteCharge.Count && id != posteCharge[k++].getId()) ;
                        bloc[i].addRessourceVoulue(Convert.ToInt32(rsRessource.Rows[j]["number"]), posteCharge[--k]);
                    }
                    else
                    {
                        int id = Convert.ToInt32(rsRessource.Rows[j]["idTeam"].ToString());
                        k = 0;
                        while (k < equipe.Count && id != equipe[k++].getId()) ;
                        bloc[i].addRessourceVoulue(Convert.ToInt32(rsRessource.Rows[j]["number"]), equipe[--k]);
                    }



                }
            }

            return (bloc);
        }

        public static int SemaineToInt(DateTime entree)
        {

            return (int)entree.DayOfWeek + 1;
        }

        public List<Bloc> getBlocFromDate(DateTime day)
        {
            List<Bloc> temp = new List<Bloc>();
            if (bloc.Count != 0)
            {
                for (int i = 0; i < bloc.Count; i++)
                {

                    DateTime datebloc = bloc.ElementAt(i).getDebut();
                    if (datebloc.DayOfYear == day.DayOfYear && datebloc.Month == day.Month && datebloc.Year == day.Year)
                    {
                        temp.Add(bloc.ElementAt(i));

                    }
                }
            }
            return temp;
        }

        public List<Erreur> loadErreurs()
        {
            DataTable rs = proc.getAllErreur();
            int i = 0;
            while (i != rs.Rows.Count)
            {
                Erreur e = new Erreur();
                e.id = Convert.ToInt32(rs.Rows[i]["idErreur"].ToString());
                e.nom = rs.Rows[i]["nom"].ToString();
                e.description = rs.Rows[i]["description"].ToString();

                erreur.Add(e);
                i++;
            }

            erreur.Sort(delegate(Erreur p1, Erreur p2) { return p1.id.CompareTo(p2.id); });

            return erreur;

        }

        public void returnErreur(int id)
        {
            int i = 0;

            while (id != erreur.ElementAt(i).id)
            {
                i++;
            }

            MessageBox.Show("Erreur : " + erreur.ElementAt(i).nom + "\n" + "Description : " + erreur.ElementAt(i).description + "\n", "Erreur #" + erreur.ElementAt(i).id.ToString());

        }

        public Ressource findRessource(int id, List<Ressource> liste)
        {
            int i = 0;

            while (id != liste.ElementAt(i).getId())
            {
                i++;
            }

            return liste.ElementAt(i);

        }

        //Modifis le bloc correspondant a celui fournis
        public bool modifierBloc(Bloc leBloc, Bloc leBloc2)
        {
            int nbBloc = bloc.Count;
            bool blocTrouve = false;

            //Les conditions a modifier devront être unique a chaque blocs
            for (int i = 0; i < nbBloc; i++)
            {
                if (bloc[i].getDebut() == leBloc.getDebut())
                {
                    bloc[i] = leBloc2;
                    blocTrouve = true;
                    break;
                }

            }

            return blocTrouve;

        }

        public List<Bloc> getBlocDeLaSemaine(DateTime dimanche)
        {
           List<Bloc> blocdelasemaine = new List<Bloc>();

           foreach (Bloc lui in bloc) {

               if ((lui.getDebut() >= dimanche) && (lui.getFin() <= dimanche.Add(new TimeSpan(7, 0, 0, 0))))
                    {
                       blocdelasemaine.Add(lui);
                       MessageBox.Show(lui.getDebut() + " : " + dimanche);
                    }
                }
           

           return blocdelasemaine;

        }

        //Supprime le bloc correspondant a celui fournis
        public bool supprimerBloc(Bloc leBloc)
        {
            bool supConf = false;
            int nbBloc = bloc.Count;
            //Les conditions a modifier devront être unique a chaque blocs
            for (int i = 0; i < nbBloc; i++)
            {
                if (bloc[i].getDebut() == leBloc.getDebut())
                {
                   // bloc.Remove(bloc.ElementAt(i));
                    bloc.RemoveAt(i);
                    supConf = true;
                    break;
                }

            }

            return supConf;
        }

    }
}
