using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;


namespace HoraireBeta
{
    public class Loader
    {
        Procedure proc = new Procedure();

       /* public List<Profil> LoadProfil()
        {

            List<Profil> profilCharge = new List<Profil>();
            DataTable rs;

            int i=0;
            rs = proc.getProfil(0);
            while (i != rs.Rows.Count)
            {
                Profil newprof = new Profil(rs.Rows[i]["prenom"].ToString(), rs.Rows[i]["nom"].ToString(), rs.Rows[i]["email"].ToString(), rs.Rows[i]["numTelephone"].ToString(), Convert.ToInt32(rs.Rows[i]["ancienete"].ToString()), 0);
                profilCharge.Add(newprof);
            }
            return (profilCharge);
        }*/
    }
}
