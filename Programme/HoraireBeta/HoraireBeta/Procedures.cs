using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HoraireAlpha
{
    public class dbConnector
    {
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
        void showProfil(int idProfil)
        {
            String requete;
            requete = "SELECT idProfil, profilPrenom, profilNom, profilPhoneNumber, profilHeureMax, profilHeureMin, email" +
                      "FROM Profil WHERE idProfil=" + idProfil;
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
        void addRessource(String beginDate, String endDate, String nom)
        {
            String requete;
            requete = "INSERT INTO Preset(beginDate, endDate, nom) VALUES(" + beginDate + "," + endDate + "," + nom + ")";
        }



    }
}
