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


        public List<Profil> profilCharge = new List<Profil>();
        public List<Equipe> equipe = new List<Equipe>();
        public List<Bloc> bloc = new List<Bloc>();


        DBConnect proc = new DBConnect();

        public List<Profil> LoadProfil()
        {

          
            DataTable rs;
            DataTable rs2;


            int i=0;
            rs = proc.getAllProfil();
            while (i < rs.Rows.Count)
            {
                
                if (rs.Rows[i]["prenom"].ToString() != "")
                {
                    Profil newprof = new Profil(rs.Rows[i]["prenom"].ToString(), rs.Rows[i]["nom"].ToString(), rs.Rows[i]["email"].ToString(), rs.Rows[i]["phoneNumber"].ToString(), Convert.ToInt32(rs.Rows[i]["seniority"].ToString()));
                    newprof.setId(Convert.ToInt32(rs.Rows[i]["idProfil"].ToString()));

                    if (posteCharge[0] != null)
                    {


                        rs2 = proc.getProfilPoste(newprof.getId());

                        for (int j = 0; j < rs2.Rows.Count; j++)
                        {
                            int k = 0;
                            while (Convert.ToInt32(rs2.Rows[j]["idPoste"].ToString()) != posteCharge[k++].getId()) ;
                            newprof.setPoste(posteCharge[--k]);
                        }

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

                Bloc newBloc = new Bloc(Convert.ToDateTime(rsBloc.Rows[i]["debut"].ToString()), Convert.ToDateTime(rsBloc.Rows[i]["fin"].ToString()), Convert.ToInt32(rsBloc.Rows[i]["description"].ToString()), Convert.ToInt32(rsBloc.Rows[i]["id"].ToString()));
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


    }
}
