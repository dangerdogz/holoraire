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
    public class DBConnect
    {
        private SQLiteConnection sqlite;

       public DBConnect()
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
            }
            catch (SQLiteException ex)
            {
                MessageBox.Show(ex.Message+" "+query, "SQL Lite Error : "+ex.ToString());
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
             
               
              
            }
            catch (SQLiteException ex)
            {
                MessageBox.Show(ex.Message, query);
            }
            sqlite.Close();
           
        }
    
   
        public void ajouterProfil(int profilid, String profilPrenom, String profilNom, String profilPhoneNumber, int profilHeureMax, int profilHeureMin, String profilEmail, int seniority)
        {
            String requete;
            requete = "INSERT INTO Profil(idProfil, prenom, nom, phoneNumber, quotaHeureMax, quotaHeureMin, email, seniority)" +
                      " VALUES(\"" + profilid + "\", \"" + profilPrenom + "\", \"" + profilNom + "\", \"" + profilPhoneNumber + "\", " + profilHeureMax +
                      ", " + profilHeureMin + ", \"" + profilEmail + "\", " + seniority + ")";
            MessageBox.Show(requete);
            getResult(requete);
        }
        public void modifierProfil(int idProfil, String profilPrenom, String profilNom, String profilPhoneNumber, int profilHeureMax, int profilHeureMin, String profilEmail, int seniority)
        {
            String requete;
            requete = "UPDATE Profil SET prenom=\"" + profilPrenom + "\", nom=\"" + profilNom + "\", phoneNumber=\"" + profilPhoneNumber +
                      "\", quotaHeureMax=" + profilHeureMax + ", quotaHeureMin=" + profilHeureMin + ", email=\"" + profilEmail + "\", seniority = \"" + seniority + "\" WHERE idProfil=" + idProfil + "";
            MessageBox.Show(requete);
            getResult(requete);
        }
        public DataTable getProfil(int idProfil)
        {
            String requete;
            requete = "SELECT idProfil, prenom, nom, phoneNumber, quotaHeureMax, quotaHeureMin, email, seniority" +
                      " FROM Profil WHERE idProfil=" + idProfil+"";
            return getResult(requete);
           
        }
        public DataTable getMAXID()
        {
            String requete;
            requete = "SELECT MAX(idProfil) FROM Profil;";
            MessageBox.Show(requete);
            return getResult(requete);
        }
        public DataTable getLastStuff(String quoi)
        {
            string requete;
            requete = "SELECT * FROM "+quoi+" order by id"+quoi+" desc;";
            MessageBox.Show(requete);
            return getResult(requete);

        }

        public DataTable getAllProfil()
        {
            String requete;
            requete = "SELECT idProfil, prenom, nom, phoneNumber, quotaHeureMax, quotaHeureMin, email, seniority" +
                      " FROM Profil";
            return getResult(requete);

        }
        public void deleteProfil(int idProfil)
        {
            String requete;
            requete = "DELETE * FROM Profil WHERE idProfil = " +idProfil+"";
        }


        public DataTable getAllPoste()
        {
            String requete;
            requete = "SELECT * FROM Poste";
            return getResult(requete);
        }
        public void addPoste(String nom, String description)
        {
            String requete;
            requete = "INSERT INTO Poste(nom, description) VALUES(\"" + nom + "\", \"" + description + "\")";
            getResult(requete);
        }
        public void deletePoste(int idPoste)
        {
            String requete;
            requete = "DELETE * FROM Poste WHERE idPoste = " + idPoste+"";
        }
        public void modifyPoste(int idPoste, String nom, String description)
        {
            String requete;
            requete = "UPDATE Poste SET nom=" + nom + ", description=" + description + " where idPoste = "+idPoste+"";
        }
        public DataTable getPoste(int idPoste)
        {
            String requete;
            requete = "SELECT * FROM Poste WHERE idPoste = "+idPoste+"";
            return getResult(requete);
        }
        public DataTable getPoste2(int idPoste)
        {
            String requete;
            requete = "SELECT nom FROM Poste WHERE idPoste = " + idPoste + "";
            return getResult(requete);
        }
        public void addBlock(String debut, String fin, int idType)
        {
            String requete;
            requete = "INSERT INTO Block(idType, debut, fin) VALUES(" + idType + "," + debut + "," + fin + ")";
        }
        public void deleteBlock(int idBlock)
        {
            String requete;
            requete = "DELETE * FROM Block WHERE idBlock = "+idBlock+"";
        }
        public void modifyBlock(String debut, String fin, int idBlock)
        {
            String requete;
            requete = "UPDATE Block SET debut = "+debut+", "+fin+" WHERE idBlock="+idBlock+"";
        }
        public DataTable getBlock(int idBlock)
        {
            String requete;
            requete = "SELECT * FROM Block WHERE idBlock = " + idBlock + "";
            return getResult(requete);
        }
        public DataTable getAllBlock()
        {
            String requete;
            requete = "SELECT * FROM Block";
            return getResult(requete);
        }
        public DataTable getAllBlockType()
        {
            String requete;
            requete = "SELECT * FROM BlockType";
            return getResult(requete);
        }
        public DataTable getErreur(int idErreur)
        {
            String requete;
            requete = "SELECT * FROM Erreur WHERE idErreur = "+idErreur+"";
            return getResult(requete);
        }
        public DataTable getAllErreur()
        {
            String requete;
            requete = "SELECT * FROM Erreur";
            return getResult(requete);
        }
        public DataTable getParametre(int idParametre)
        {
            String requete;
            requete = "SELECT * FROM Parametre WHERE idParametre = " + idParametre+"";
            return getResult(requete);
        }
        public DataTable getAllParametre()
        {
            String requete;
            requete = "SELECT * FROM Parametre";
            return getResult(requete);
        }
        public void addPlage(String debut, String fin, int day)
        {
            String requete;
            requete = "INSERT INTO Plage(debut, fin, day) VALUES(" + debut + "," + fin + "," + day + ")";
        }
        public void modifyPlage(String debut, String fin, int day)
        {
            String requete;
            requete = "UPDATE Plage SET debut="+debut+", fin="+fin+", day="+day+"";
        }
        public void deletePlage(int idPlage)
        {
            String requete;
            requete = "DELETE * FROM Plage WHERE idPlage=" + idPlage+"";
        }
        public DataTable getPlage(int idPlage)
        {
            String requete;
            requete = "SELECT * FROM Plage WHERE idPlage = " + idPlage+"";
            return getResult(requete);
        }
        public DataTable getAllPlage()
        {
            String requete;
            requete = "SELECT * FROM Plage";
            return getResult(requete);
        }
        public void addPreset(String beginDate, String endDate, String nom)
        {
            String requete;
            requete = "INSERT INTO Preset(beginDate, endDate, nom) VALUES(" + beginDate + "," + endDate + "," + nom + ")";
        }
        public void modifyPreset(String beginDate, String endDate, String nom)
        {
            String requete;
            requete = "UPDATE Preset SET beginDate=" + beginDate + ", endDate=" + endDate + ", nom=" + nom+"";
        }
        public void deletePreset(int idPreset)
        {
            String requete;
            requete = "DELETE * FROM Preset WHERE idPreset=" + idPreset+"";
        }
        public DataTable getPreset(int idPreset)
        {
            String requete;
            requete = "SELECT * FROM Preset WHERE idPreset=" + idPreset+"";
            return getResult(requete);
        }
        public DataTable getAllPreset()
        {
            String requete;
            requete = "SELECT * FROM Preset";
            return getResult(requete);
        }
        public void addRessource(int idBlock, int idPoste, int idTeam, int number)
        {
            String requete;
            requete = "INSERT INTO Ressource(idBlock, idPoste, idTeam, number) VALUES(" + idBlock + "," + idPoste + "," + idTeam + ","+number+")";
        }
        public void modifyRessource(int idBlock, int idPoste, int idTeam)
        {
            String requete;
            requete = "UPDATE Ressource SET idBlock="+idBlock+", idPoste = "+idPoste+", idTeam = "+idTeam+"";
        }
        public void deleteRessource(int idBlock)
        {
            String requete;
            requete = "DELETE * FROM Ressource WHERE idBlock=" + idBlock + "";
        }
        public DataTable getRessource(int idBlock)
        {
            String requete;
            requete = "SELECT * FROM Ressource WHERE idBlock = " + idBlock + "";
            return getResult(requete);
        }
        public DataTable getAllRessource()
        {
            String requete;
            requete = "SELECT * FROM Ressource";
            return getResult(requete);
        }
        public void addTeam(String nom, String description)
        {
            String requete;
            requete = "INSERT INTO Team(nom, description) VALUES(\"" + nom + "\", \"" + description + "\")";
            getResult(requete);
        }
        public void modifyTeam(int id, String nom, String description)
        {
            String requete;
            requete = "UPDATE Team SET nom=" + nom + ", description = " + description + " where idTeam ="+id+"";
        }
        public void deleteTeam(int idTeam)
        {
            String requete;
            requete = "DELETE FROM Team WHERE idTeam=" + idTeam + "";
        }

        public void deleteTeam2(String ename)
        {
            String requete;
            requete = "DELETE FROM Team WHERE nom=\"" + ename + "\"";
            getResult(requete);
        }
        public DataTable getTeam(int idTeam)
        {
            String requete;
            requete = "SELECT * FROM Team WHERE idTeam = " + idTeam + "";
            return getResult(requete);
        }
        public DataTable getAllTeam()
        {
            String requete;
            requete = "SELECT * FROM Team";
            return getResult(requete);
        }
        public void addTeamProfile(int idTeam, int idProfil, int idPoste)
        {
            String requete;
            requete = "INSERT INTO Team_Profil(idTeam, idProfil, idPoste) VALUES(" + idTeam + ", " + idProfil + ", " + idPoste + ")";
        }
        public void modifyTeamProfile(int idTeam, int idProfil, int idPoste)
        {
            String requete;
            requete = "UPDATE Team_Profil SET idTeam=" + idTeam + ", idProfil = " + idProfil + ", idPoste = " + idPoste + "";
        }
        public void deleteTeamProfile(int idTeam)
        {
            String requete;
            requete = "DELETE * FROM Team_Profil WHERE idTeam=" + idTeam + "";
        }

        public DataTable getTeamProfile(int idTeam)
        {
            String requete;
            requete = "SELECT * FROM Team_Profil WHERE idTeam = " + idTeam + "";
            return getResult(requete);
        }
        public DataTable getAllTeamProfile()
        {
            String requete;
            requete = "SELECT * FROM Team_Profil";
            return getResult(requete);
        }
        public DataTable getPosteProfil(int idPoste)
        {
            String requete;
            requete = "SELECT * FROM Poste_Profil WHERE idPoste = " + idPoste + "";
            return getResult(requete);
        }
        public DataTable getPosteProfil2(int idProfil)
        {
            String requete;
            requete = "SELECT idPoste FROM Poste_Profil WHERE idProfil = " + idProfil + "";
            return getResult(requete);
        }
        public DataTable getPostId(String pname)
        {
            String requete;
            requete = "SELECT idPoste FROM Poste WHERE nom = \"" + pname + "\"";
           // MessageBox.Show(requete);
            return getResult(requete);
        }
        public void addPosteProfil(int idPoste, int idProfil)
        {
            String requete;
            requete = "INSERT INTO Poste_Profil(idPoste, idProfil) VALUES(" + idPoste + ", " + idProfil + ")";
            getResult(requete);
           // MessageBox.Show(requete);
        }
        public void deletePosteProfil(int idProfil)
        {
            String requete;
            requete = "DELETE FROM Poste_Profil WHERE idProfil = " + idProfil + ";";
            getResult(requete);
        }
        public DataTable getProfilPoste(int idProfil)
        {
            String requete;
            requete = "SELECT * FROM Poste_Profil WHERE idProfil = " + idProfil + "";
            return getResult(requete);
        }
        public DataTable getAllProfilPoste()
        {
            String requete;
            requete = "SELECT * FROM Poste_Profil";
            return getResult(requete);
        }
        public DataTable getProfilDispo(int id)
        {
            String requete;
            requete = "SELECT Plage.idPlage, debut, fin, day FROM Plage, Profil_Dispo WHERE Profil_Dispo.idProfil = " + id + " AND Profil_Dispo.idPlage = Plage.idPlage";
            return getResult(requete);
        }
        public void addProfilDispo(int idProfil, int idPlage)
        {
            String requete;
            requete = "INSERT INTO Profil_Dispo(idProfil, idPlage) VALUES(" + idProfil + ", " + idPlage + ")";
        }
        public void deleteProfilDispo(int idProfil)
        {
            String requete;
            requete = "DELETE * FROM Profil_Dispo WHERE idProfil = " + idProfil + "";
        }
        public DataTable getProfilPreference(int idProfil)
        {
            String requete;
            requete = "SELECT Plage.idPlage, debut, fin, day FROM Plage, Profil_Preference WHERE Profil_Preference.idProfil = " + idProfil + " AND Profil_Preference.idPlage = Plage.idPlage";
            return getResult(requete);
        }
        public void addProfilPreference(int idProfil, int idPreference)
        {
            String requete;
            requete = "INSERT INTO Profil_Preference(idProfil, idPreference) VALUES(" + idProfil + ", " + idPreference + ")";
        }
        public void deleteProfilPreference(int idProfil)
        {
            String requete;
            requete = "DELETE * FROM Profil_Preference WHERE idProfil = " + idProfil + "";
        }

    }
}
