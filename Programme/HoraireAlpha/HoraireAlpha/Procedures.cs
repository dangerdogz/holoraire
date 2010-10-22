using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HoraireAlpha
{
    class dbConnector
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
        void showPoste()
        {
            String requete;
            requete = "SELECT * FROM Poste";
        }
        void addPoste(String nom, String description)
        {
            String requete;
            requete = "INSERT INTO Poste(nom, description) VALUES(" + nom + ", " + description + ")";
        }
    }
}
