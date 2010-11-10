using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Windows.Forms;


namespace HoraireBeta

{
    public class Loader
    {

        public List<Poste> posteCharge = new List<Poste>();
         public List<Ressource> profilCharge = new List<Ressource>();
        public List<Equipe> equipe = new List<Equipe>();
        public List<Bloc> bloc = new List<Bloc>();


        DBConnect proc = new DBConnect();

        public List<Ressource> LoadProfil()
        {

          
            DataTable rs;
            DataTable rs2;
            DataTable rs3;
            DataTable rs4;


            int i=0;
            rs = proc.getAllProfil();
            
            while (i < rs.Rows.Count)
            {
                
                if (rs.Rows[i]["prenom"].ToString() != "")
                {
                    Profil newprof = new Profil(rs.Rows[i]["prenom"].ToString(), rs.Rows[i]["nom"].ToString(), rs.Rows[i]["email"].ToString(), rs.Rows[i]["phoneNumber"].ToString(), Convert.ToInt32(rs.Rows[i]["seniority"].ToString()),Convert.ToInt32(rs.Rows[i]["quotaHeureMax"].ToString()));
                    newprof.setId(Convert.ToInt32(rs.Rows[i]["idProfil"].ToString()));

                    if (posteCharge.Count != 0)
                    {


                        rs2 = proc.getProfilPoste(newprof.getId());

                        for (int j = 0; j < rs2.Rows.Count; j++)
                        {
                            int k = 0;
                            while (Convert.ToInt32(rs2.Rows[j]["idPoste"].ToString()) != posteCharge[k++].getId()) ;
                            newprof.setPoste(posteCharge[--k]);
                        }

                    }

                    rs3 = proc.getProfilDispo(newprof.getId());
                    rs4 = proc.getProfilPreference(newprof.getId());

                    for (int j = 0; j < rs3.Rows.Count; j++)
                    {
                        Bloc newBloc = new Bloc(DateTime.ParseExact(rs3.Rows[i]["debut"].ToString(), "yyyy-MM-dd HH:mm:ss", null), DateTime.ParseExact(rs3.Rows[i]["fin"].ToString(), "yyyy-MM-dd HH:mm:ss", null), 0, Convert.ToInt32(rs3.Rows[j]["idPlage"].ToString()));
                        newprof.addDispo(newBloc);
                
                            
              
                       

                    }

                    for (int j = 0; j < rs4.Rows.Count; j++)
                    {
                        Bloc newBloc = new Bloc(DateTime.ParseExact(rs4.Rows[i]["debut"].ToString(), "yyyy-MM-dd HH:mm:ss", null), Convert.ToDateTime(rs4.Rows[i]["fin"].ToString()), 0, Convert.ToInt32(rs4.Rows[j]["idPlage"].ToString()));
                        newprof.addPref(newBloc);
                    }

                    profilCharge.Add(newprof);
            

                }
                i++;


            }

            return (profilCharge);
        }

        public List<Poste> loadPoste()
        {
            DataTable rs;
            rs = proc.getAllPoste();
            int i =0;
            while (i != rs.Rows.Count)
            {
                Poste newposte = new Poste(Convert.ToInt32(rs.Rows[i]["idPoste"].ToString()), rs.Rows[i]["nom"].ToString(), rs.Rows[i]["description"].ToString());
                posteCharge.Add(newposte);
                i++;
            }

            return (posteCharge);

        }


        public List<Equipe> LoadEquipe()
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
                    equipe[i].setEmploye(profilCharge[--k]);
                    

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

                Bloc newBloc = new Bloc(DateTime.ParseExact(rsBloc.Rows[i]["debut"].ToString(), "yyyy-MM-dd HH:mm:ss", null), DateTime.ParseExact(rsBloc.Rows[i]["fin"].ToString(), "yyyy-MM-dd HH:mm:ss", null), Convert.ToInt32(rsBloc.Rows[i]["idType"].ToString()), Convert.ToInt32(rsBloc.Rows[i]["idBlock"].ToString()));

                bloc.Add(newBloc);
                rsRessource = proc.getRessource(bloc[i].getId());
                for (int j = 0; j < rsRessource.Rows.Count; j++)
                {
                    if (rsRessource.Rows[j]["idPoste"] == null)
                    {

                        int id = Convert.ToInt32(rsRessource.Rows[j]["idPoste"].ToString());
                        k = 0;
                        while (k < profilCharge.Count && id != profilCharge[k++].getId()) ;
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

        public static int SemaineToInt(DateTime entree) {
            int jour=0;
            switch (entree.ToString("ddd"))
            {
                case "mon": 
                    jour = 1;
                    break;
                case "tue": 
                    jour = 2;
                    break;
                case "wen":
                    jour = 3;
                    break;
                case "thu" :
                    jour = 4;
                    break;
                case "fri" :
                    jour = 5;
                    break;
                case "sat" :
                    jour = 6;
                    break;
                case "sun" :
                    jour = 7;
                    break;
            }
        return jour;
            }


    }
}
