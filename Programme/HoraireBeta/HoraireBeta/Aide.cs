using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace HoraireBeta
{
    public partial class Aide : Form
    {
        //Variables
        int nbJonc;
        DBConnect proc = new DBConnect();
        DataTable dataAide;
        DataTable dataJonction;
        String contenuTextBox;
        

        public Aide()
        {
            InitializeComponent();
          //  construireTreeNode();
            kutsomzTrees();
            fillTextBox();
        }

        public void fillTreeView() {
           
            
        
        }

        public void construireTreeNode() {
            dataAide = proc.getMenu_Aide();
            dataJonction = proc.getJonction();
            nbJonc = dataAide.Rows.Count;
            DataTable tableEnfant;
            int lengthEnfant;
            int nodeActu;
            int enfantActu;

            for (int i = 0; i < nbJonc ;i++ )
                {
                //Création du parent
                treeAide.Nodes.Add(dataAide.Rows[i]["Titre"].ToString());
                
                nodeActu = int.Parse(dataAide.Rows[i]["idAide"].ToString());
                
                treeAide.Nodes[i].Name = nodeActu+"";
               
                tableEnfant = proc.getEnfant_Jonc(nodeActu);
                lengthEnfant = tableEnfant.Rows.Count;

                //Si l'enregistrement n'est pas vide
                if (lengthEnfant > 0)
                {
                    //Création de l'enfant
                    for (int j = 0; j < lengthEnfant; j++)
                        {
                        enfantActu = int.Parse(tableEnfant.Rows[j]["idEnfant"].ToString());
                        treeAide.Nodes[i].Nodes.Add(proc.getTitre_Aide(enfantActu).Rows[0]["Titre"].ToString());
                        treeAide.Nodes[i].LastNode.Name = enfantActu+"";
                        
                        }


                    //treeAide.Nodes[i].Nodes.Add(dataAide.Rows[int.Parse(dataJonction.Rows[i]["idEnfant"].ToString())]["Titre"].ToString());
                }
                               
                }

        }

        public void kutsomzTrees() {
            int minId = int.Parse(proc.getMinLevel().Rows[0]["idAide"].ToString());
            int minLvl = int.Parse(proc.getMinLevel().Rows[0]["min"].ToString());

            DataTable laTable = proc.getMenu_Aide();
            int lengthParent = laTable.Rows.Count;
           

            for (int i = 0; i < lengthParent; i++)
            {
                treeAide.Nodes.Add(fetchKid(int.Parse(laTable.Rows[i]["idAide"].ToString())));
               
            }

        
        }

       
        public TreeNode fetchKid(int id)
        {
            String titre = proc.getTitre_Aide(id).Rows[0]["Titre"].ToString();
            TreeNode tempNode = new TreeNode(titre);
            DataTable tempTable = proc.getEnfant_Jonc(id);
            

            if (tempTable.Rows.Count > 0)
            {
      
                for (int i = 0; i < tempTable.Rows.Count; i++)
                {
                    tempNode.Nodes.Add(fetchKid(int.Parse(tempTable.Rows[i]["idEnfant"].ToString())));
                }

            }
            return tempNode;
        }

        public void addNode(String labelNode, int degre) {
            
        
        }

        public void AfficherTexte(String textNode) {
            textBox.Text = proc.getText_Aide(textNode).Rows[0]["Description"].ToString();
        
        }
        
        public void fillTextBox() {

            for (int i = 0; i < 5899; i++)
            {
                textBox.Text += "WATFFFFF";
            }
        }

        private void treeAide_AfterSelect(object sender, TreeViewEventArgs e)
        {
            AfficherTexte(e.Node.Text);
          
        }

        
    }
}
