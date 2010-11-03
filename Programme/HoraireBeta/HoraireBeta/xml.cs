using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Chilkat;


namespace HoraireBeta
{
    public class CreateXml
    {
        public void CreateProfileXml()
        {
            DBConnect proc = new DBConnect();
            DataTable rs3;
            DataTable rs2;
            DataTable rs;
            int i = 0;
            int j = 0;
            int k = 0;
            rs = proc.getAllProfil();
            rs2 = proc.getAllPoste();
            rs3 = proc.getAllTeam();
            // Create the root node of a new XML document.
            Chilkat.Xml xml = new Chilkat.Xml();

            // This is going to be a collection of contacts.
            xml.Tag = "infos";

            // Create a child node to hold a contact record.
            // Our "xml" object will now reference the new node.
            while (i < rs.Rows.Count)
            {
                xml = xml.NewChild("profil", "");


                // Create a "company" record.  NewChild2 does not return the child node that is created
                xml.NewChild2("id", Convert.ToString(rs.Rows[i]["idProfil"]));
                xml.NewChild2("prenom", rs.Rows[i]["prenom"].ToString());
                xml.NewChild2("nom", rs.Rows[i]["nom"].ToString());
                xml.NewChild2("email", rs.Rows[i]["email"].ToString());
                xml.NewChild2("phone", rs.Rows[i]["phoneNumber"].ToString());
                xml.NewChild2("seniority", Convert.ToString(rs.Rows[i]["seniority"]));



                // Move up the tree and create another contact record.
                // GetParent2 updates our internal reference to the parent.
                xml.GetParent2();
                i++;
            }
            while (j < rs2.Rows.Count)
            {
                xml = xml.NewChild("poste", "");
                xml.NewChild2("id", Convert.ToString(rs2.Rows[j]["idPoste"]));
                xml.NewChild2("nom", rs2.Rows[j]["nom"].ToString());
                xml.NewChild2("description", rs2.Rows[j]["description"].ToString());
                xml.GetParent2();
                j++;
            }
            while (k < rs3.Rows.Count)
            {
                xml = xml.NewChild("team", "");
                xml.NewChild2("id", Convert.ToString(rs3.Rows[k]["idTeam"]));
                xml.NewChild2("nom", rs3.Rows[k]["nom"].ToString());
                xml.NewChild2("description", rs3.Rows[k]["description"].ToString());
                xml.GetParent2();
                k++;
            }
            // We can always get back to the root by calling GetRoot (or GetRoot2)
            xml.GetRoot2();

            // Add the tag that specifies our character encoding.
            xml.Encoding = "utf-8";

            // Save the document.
            xml.SaveXml("profiles.xml");
        }
    }
}