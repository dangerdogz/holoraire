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
    class DBConnector
    {
        private SQLiteConnection sqlite;

        public DBConnector()
        {
            //This part killed me in the beginning.  I was specifying "DataSource"
            //instead of "Data Source"
            sqlite = new SQLiteConnection("Data Source=../../holoraire.s3db");

        }

        public DataTable getResult(string query)
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
                
                ad.Fill(dt); //fill the datasource
                MessageBox.Show(dt.Rows[0][1].ToString(), "tompe de faloppe");
            }
            catch (SQLiteException ex)
            {
                MessageBox.Show(ex.Message, "ovaires");
            }
            sqlite.Close();
            return dt;
        }
        public void doQuery(string query)
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
                MessageBox.Show(query, "Yikes");
               
              
            }
            catch (SQLiteException ex)
            {
                MessageBox.Show(query, "Failed");
            }
            sqlite.Close();
           
        }
    
   
        void ajouterProfil(String profilPrenom, String profilNom, String profilPhoneNumber, int profilHeureMax, int profilHeureMin, String profilEmail)
        {
            String requete;
            requete = "INSERT INTO Profil(prenom, nom, phoneNumber, quotaHeureMax, quotaHeureMin, email)" +
                      "VALUES(" + profilPrenom + ", " + profilNom + ", " + profilPhoneNumber + ", " + profilHeureMax +
                      ", " + profilHeureMin + ", " + profilEmail + ")";
        }
        void modifierProfil(int idProfil, String profilPrenom, String profilNom, String profilPhoneNumber, int profilHeureMax, int profilHeureMin, String profilEmail)
        {
            String requete;
            requete = "UPDATE Profil SET prenom=" + profilPrenom + ", nom=" + profilNom + ", phoneNumber=" + profilPhoneNumber +
                      ", quotaHeureMax=" + profilHeureMax + ", quotaHeureMin=" + profilHeureMin + ", email=" + profilEmail + " WHERE idProfil=" + idProfil;

        }
        DataTable getProfil(int idProfil)
        {
            String requete;
            requete = "SELECT idProfil, profilPrenom, profilNom, profilPhoneNumber, profilHeureMax, profilHeureMin, email" +
                      "FROM Profil WHERE idProfil=" + idProfil;
            return getResult(requete);
           
        }
        void deleteProfil(int idProfil)
        {
            String requete;
            requete = "DELETE * FROM Profil WHERE idProfil = " +idProfil;
        }
        void showAllPoste()
        {
            String requete;
            requete = "SELECT * FROM Poste";
        }
        void addPoste(String nom, String description)
        {
            String requete;
            requete = "INSERT INTO Poste(nom, description) VALUES(" + nom + ", " + description + ")";
        }
        void deletePoste(int idPoste)
        {
            String requete;
            requete = "DELETE * FROM Poste WHERE idPoste = " + idPoste;
        }
        void addBlock(String debut, String fin, int idType)
        {
            String requete;
            requete = "INSERT INTO Block(idType, debut, fin) VALUES(" + idType + "," + debut + "," + fin + ")";
        }
        void deleteBlock(int idBlock)
        {
            String requete;
            requete = "DELETE * FROM Block WHERE idBlock = "+idBlock;
        }
        void modifyBlock(String debut, String fin, int idBlock)
        {
            String requete;
            requete = "UPDATE Block SET debut = "+debut+", "+fin+" WHERE idBlock="+idBlock;
        }
        void getBlockType()
        {
            String requete;
            requete = "SELECT * FROM BlockType";
        }
        void getErreur(int idErreur)
        {
            String requete;
            requete = "SELECT * FROM Erreur WHERE idErreur = "+idErreur;
        }
        void getParametre(int idParametre)
        {
            String requete;
            requete = "SELECT * FROM Parametre WHERE idParametre = " + idParametre;
        }
        void addPlage(String debut, String fin, int day)
        {
            String requete;
            requete = "INSERT INTO Plage(debut, fin, day) VALUES(" + debut + "," + fin + "," + day + ")";
        }
        void modifyPlage(String debut, String fin, int day)
        {
            String requete;
            requete = "UPDATE Plage SET debut="+debut+", fin="+fin+", day="+day;
        }
        void deletePlage(int idPlage)
        {
            String requete;
            requete = "DELETE * FROM Plage WHERE idPlage=" + idPlage;
        }
        void getPlage(int idPlage)
        {
            String requete;
            requete = "SELECT * FROM Plage WHERE idPlage = " + idPlage;
        }
        void addPreset(String beginDate, String endDate, String nom)
        {
            String requete;
            requete = "INSERT INTO Preset(beginDate, endDate, nom) VALUES(" + beginDate + "," + endDate + "," + nom + ")";
        }
        void modifyPreset(String beginDate, String endDate, String nom)
        {
            String requete;
            requete = "UPDATE Preset SET beginDate=" + beginDate + ", endDate=" + endDate + ", nom=" + nom;
        }
        void deletePreset(int idPreset)
        {
            String requete;
            requete = "DELETE * FROM Preset WHERE idPreset=" + idPreset;
        }
        void getPreset(int idPreset)
        {
            String requete;
            requete = "SELECT * FROM Preset WHERE idPreset=" + idPreset;
        }
        void addRessource(int idBlock, int idPoste, int idTeam)
        {
            String requete;
            requete = "INSERT INTO Ressource(idBlock, idPoste, idTeam) VALUES(" + idBlock + "," + idPoste + "," + idTeam + ")";
        }
        void modifyRessource(int idBlock, int idPoste, int idTeam)
        {
        } 


    }
}
