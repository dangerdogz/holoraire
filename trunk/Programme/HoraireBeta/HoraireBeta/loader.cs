using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.OleDb;
using System.Data.SqlClient;

namespace HoraireBeta
{
    public class Loader
    {
        dbConnector proc = new dbConnector();

        public void LoadProfil()
        {
            string SQL = proc.getProfil;

            string ConnectionString = "server=(local)\\SQLEXPRESS;database=MyDatabase;Integrated Security=SSPI;";
            SqlConnection conn = new SqlConnection(ConnectionString);

            SqlCommand cmd = new SqlCommand(SQL, conn);

            conn.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            try
            {
                while (reader.Read())
                {
                    Console.Write("ID:" + reader.GetInt32(0).ToString());
                    Console.Write(" ,");
                    Console.WriteLine("Name:" + reader.GetString(1).ToString());
                }
            }
            finally
            {
                reader.Close();
                conn.Close();
            }

        }
    }
}
