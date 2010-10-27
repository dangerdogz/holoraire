using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace DBConnect
{
    class DBConnector
    {
        private SQLiteConnection sqlite;

        public DBConnector()
        {
            //This part killed me in the beginning.  I was specifying "DataSource"
            //instead of "Data Source"
            sqlite = new SQLiteConnection("Data Source=../../holoraire.s3db");

        }

        public DataTable selectQuery(string query)
        {
            SQLiteDataAdapter ad;
            DataTable dt = new DataTable();

            try
            {
                SQLiteCommand cmd;
                sqlite.Open();  //Initiate connection to the db
                cmd = sqlite.CreateCommand();
                cmd.CommandText = query;  //set the passed query
                ad = new SQLiteDataAdapter(cmd);
                MessageBox.Show("WindowsFormsApplication3", "uterus");
                ad.Fill(dt); //fill the datasource
                MessageBox.Show("WindowsFormsApplication3", "tompe de faloppe");
            }
            catch (SQLiteException ex)
            {
                MessageBox.Show(ex.Message, "ovaires");
            }
            sqlite.Close();
            return dt;
        }
    }
}
