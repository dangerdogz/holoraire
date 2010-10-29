using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;


namespace HoraireBeta

{
    public class Loader
    {

        List<Poste> posteCharge = new List<Poste>();


        List<Profil> profilCharge = new List<Profil>();
        List<Equipe> equipe = new List<Equipe>();
        List<Bloc> bloc = new List<Bloc>();


        DBConnect proc = new DBConnect();

        public List<Profil> LoadProfil()
        {

          
            DataTable rs;
            DataTable rs2;


            int i=0;
            rs = proc.getAllProfil();
            while (i < rs.Rows.Count)
            {
                Profil newprof = new Profil(rs.Rows[i]["prenom"].ToString(), rs.Rows[i]["nom"].ToString(), rs.Rows[i]["email"].ToString(), rs.Rows[i]["numTelephone"].ToString(), Convert.ToInt32(rs.Rows[i]["ancienete"].ToString()));
                newprof.setId(Convert.ToInt32(rs.Rows[i]["ancienete"].ToString()));

                if (posteCharge[0] != null)
                {
                    

                    rs2 = proc.getProfilPoste(newprof.getId());

                    for (int j = 0; j < rs2.Rows.Count; j++)
                    {
                        int k=0;
                        while (Convert.ToInt32(rs2.Rows[j]["Poste"].ToString()) != posteCharge[k++].getId()) ;
                        newprof.setPoste(posteCharge[--k]);
                    }

                }
                profilCharge.Add(newprof);

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
                Poste newposte = new Poste(rs.Rows[i]["nom"].ToString(), rs.Rows[i]["description"].ToString());
                posteCharge.Add(newposte);
            }

            return (posteCharge);

        }


        public List<Equipe> LoadEquipe()
        {
            DataTable rsEquipe;
            DataTable rsEquipeProfil;
            rsEquipe = proc.getAllTeam();
            int k = 0;

            for (int i = 0; i > rsEquipe.Rows.Count; i++)
            {
                rsEquipeProfil = proc.getTeamProfile(i);
                Equipe newEquipe = new Equipe(Convert.ToInt32(rsEquipe.Rows[i]["idTeam"].ToString()), rsEquipe.Rows[i]["nom"].ToString(), rsEquipe.Rows[i]["description"].ToString());
                equipe.Add(newEquipe);
                for (int j = 0; j > rsEquipeProfil.Rows.Count; j++)
                {
                    int id = Convert.ToInt32(rsEquipeProfil.Rows[j]["idProfil"].ToString());

                    while (id != profilCharge[k++].getId()) ;
                    equipe[i].setEmploye(profilCharge[--k]);
                    

                }
            }

            return equipe;

        }


    }
}
