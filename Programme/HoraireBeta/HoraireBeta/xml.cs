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
            DataTable rs;
            int i = 0;
            rs = proc.getAllProfil();

            // Create the root node of a new XML document.
            Chilkat.Xml xml = new Chilkat.Xml();

            // This is going to be a collection of contacts.
            xml.Tag = "profiles";

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

            // We can always get back to the root by calling GetRoot (or GetRoot2)
            xml.GetRoot2();

            // Add the tag that specifies our character encoding.
            xml.Encoding = "utf-8";

            // Save the document.
            xml.SaveXml("profiles.xml");
        }
    }
}