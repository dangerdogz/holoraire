using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using HoraireBeta;
//using Draw_Rectangle;


namespace HoraireBeta
{
    public partial class HoraireBeta : Form
    {
       
        public HoraireBeta()
        {
            InitializeComponent();
            initInterface();
        }

        private void horaire_Click(object sender, EventArgs e)
        {
           

        }

        private void pGauche_Employe_Paint(object sender, PaintEventArgs e)
        {
          
        }

        private void employe_Click(object sender, EventArgs e)
        {

        }

        private void pCentral_Horaire_Paint(object sender, PaintEventArgs e)
        {
        
        }

        private void pCentral_Employe_Paint(object sender, PaintEventArgs e)
        {

        }

        private void parametre_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pGauche_Employe_OnMouseEvent(object sender, MouseEventArgs e)
        {
          
           switch(e.Button)
                {
                case MouseButtons.Left:
                    MessageBox.Show(this, "PanelGauche Employé: Vous avez appuyez sur gauche en : " + e.X + " , " + e.Y);
                    
                    break;
                }
        }

        private void pCentral_Employe_OnMouseEvent(object sender, MouseEventArgs e)
        {

            switch (e.Button)
            {
                case MouseButtons.Left:
                    MessageBox.Show(this, "PanelCentral Employé: Vous avez appuyez sur gauche en : " + e.X + " , " + e.Y);
                    

                    break;
            }
        }

        private void pGauche_Horaire_OnMouseEvent(object sender, MouseEventArgs e)
        {

            switch (e.Button)
            {
                case MouseButtons.Left:
                    MessageBox.Show(this, "PanelGauche Horaire: Vous avez appuyez sur gauche en : " + e.X + " , " + e.Y);

                    break;
            }
        }

        private void pCentral_Horaire_OnMouseEvent(object sender, MouseEventArgs e)
        {

            switch (e.Button)
            {
                case MouseButtons.Left:
                    //MessageBox.Show(this, "PanelCentral Horaire: Vous avez appuyez sur gauche en : " + e.X + " , " + e.Y);
                    createBlock();
                    grille.passeClique(e.X, e.Y);
                    break;
            }
        }


        private void pGauche_Parametre_OnMouseEvent(object sender, MouseEventArgs e)
        {

            switch (e.Button)
            {
                case MouseButtons.Left:
                    MessageBox.Show(this, "PanelGauche Parametre: Vous avez appuyez sur gauche en : " + e.X + " , " + e.Y);

                    break;
            }
        }

        private void pCentral_Parametre_OnMouseEvent(object sender, MouseEventArgs e)
        {

            switch (e.Button)
            {
                case MouseButtons.Left:
                    MessageBox.Show(this, "PanelCentral Parametre: Vous avez appuyez sur gauche en : " + e.X + " , " + e.Y);

                    break;
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
        DBConnect dbc;

        private void resultDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void sqlTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            dbc = new DBConnect();// enabling the DB conection
            bouton_requete.Enabled = true;
            MessageBox.Show(this, "connecté");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            resultDataGrid.DataSource = dbc.getResult(sqlTextBox.Text);
            resultDataGrid.Refresh();
        }

        private void modifier_button_Click(object sender, EventArgs e)
        {
            ajprofemp_label.Text = "Modifier un profil d'employé";
            numemp_textbox.Text = "";
            nom_textbox.Text = "";
            prenom_textbox.Text = "";
            courriel_textbox.Text = "";
            telephone_textbox.Text = "";

        }

        private void numemp_textbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void nom_textbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void prenom_textbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void courriel_textbox_TextChanged(object sender, EventArgs e)
        {

        }


        private void panelCentral_Horaire_Paint(object sender, PaintEventArgs e)
        {
            this.grille.activer();   
        }



        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }


        private void telephone_textbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void ajouter_button_Click(object sender, EventArgs e)
        {
            ajprofemp_label.Text = "Ajouter un profil d'employé";
        }

        private void buttondroit_Click(object sender, EventArgs e)
        {
            if (this.treeView_postdispo.SelectedNode.IsSelected == true)
            {
                System.Windows.Forms.TreeNode name;
                name = new System.Windows.Forms.TreeNode(this.treeView_postdispo.SelectedNode.Text);
              
                this.treeView_postechoisi.Nodes.Add(name);
                this.treeView_postdispo.SelectedNode.Remove();
            }



        }


        private void createBlock(/*int x, int y, DateTime hd, DateTime hf*/)
        {
            CreationBloc creationbloc = new CreationBloc();
            creationbloc.ShowDialog();
            loader.bloc.Add(new Bloc(new DateTime(2010, 11, 03, Convert.ToInt32(creationbloc.getHd()), 0, 0), new DateTime(2010, 11, 03, Convert.ToInt32(creationbloc.getHf()), 0, 0), 0, 0));
            creationbloc.Dispose();
            //Application.Run(creationbloc);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            String textInForm;           
            
            textInForm = this.textBox1.Text.Clone().ToString();
            Chilkat.Xml xml = new Chilkat.Xml();
            Chilkat.Xml xmlProfiles = new Chilkat.Xml();
            Chilkat.Xml xmlPostes = new Chilkat.Xml();
            Chilkat.Xml xmlTeams = new Chilkat.Xml();
            xmlProfiles.LoadXmlFile("profiles.xml");
            xmlPostes.LoadXmlFile("postes.xml");
            xmlTeams.LoadXmlFile("teams.xml");
            

            
            /*foreach (TreeNode ressource in RessourceTree.Nodes)
            {
                foreach (TreeNode childs in ressource.Nodes)
                {
                    //MessageBox.Show(childs.Text, "lol");
                    if (!childs.Text.Contains(textInForm))
                    {
                       // childs.Remove();
                    }
                }
            }*/
           
            
            foreach (TreeNode tree in RessourceTree.Nodes[0].Nodes)
            {
                tree.Remove();
            }
            foreach (TreeNode tree in RessourceTree.Nodes[1].Nodes)
            {
                tree.Remove();
            } 
            foreach (TreeNode tree in RessourceTree.Nodes[2].Nodes)
            {
                tree.Remove();
            }
            xml = xmlProfiles;
                // Navigate to the first company record.
                xml.FirstChild2();

                while (xml != null)
                {
                    // FindNextRecord *will* return the current record if it
                    // matches the criteria. 
                    xml = xml.FindNextRecord("nom", textInForm.ToLower()+"*");
                    if (xml != null)
                    {
                        // Add the company name to the listbox.
                        
                        RessourceTree.Nodes[0].Nodes.Add(new System.Windows.Forms.TreeNode(xml.GetChildContent("nom") + ", "+ xml.GetChildContent("prenom")));
                        

                        // Advance past this record.
                        xml = xml.NextSibling();
                    }

                }
                xml = xmlPostes;
                // Navigate to the first company record.
                xml.FirstChild2();

                while (xml != null)
                {
                    // FindNextRecord *will* return the current record if it
                    // matches the criteria. 
                    xml = xml.FindNextRecord("nom", textInForm.ToLower() + "*");
                    if (xml != null)
                    {
                        // Add the company name to the listbox.

                        RessourceTree.Nodes[1].Nodes.Add(new System.Windows.Forms.TreeNode(xml.GetChildContent("nom")));


                        // Advance past this record.
                        xml = xml.NextSibling();
                    }

                }
                xml = xmlTeams;
                // Navigate to the first company record.
                xml.FirstChild2();

                while (xml != null)
                {
                    // FindNextRecord *will* return the current record if it
                    // matches the criteria. 
                    xml = xml.FindNextRecord("nom", textInForm.ToLower() + "*");
                    if (xml != null)
                    {
                        // Add the company name to the listbox.

                        RessourceTree.Nodes[2].Nodes.Add(new System.Windows.Forms.TreeNode(xml.GetChildContent("nom")));


                        // Advance past this record.
                        xml = xml.NextSibling();
                    }

                }
    
           /*foreach (Poste poste in posteCharge)
            {
                if (poste.getNom().Contains(textInForm))
                {
                    RessourceTree.Nodes[1].Nodes.Add(new System.Windows.Forms.TreeNode(poste.getNom()));
                }
                
            }
            foreach (Equipe team in equipe)
            {
                if (team.getNom().Contains(textInForm))
                {
                    RessourceTree.Nodes[2].Nodes.Add(new System.Windows.Forms.TreeNode(team.getNom()));
                }

            }*/
            
            
        }






    }
} 
           

          


            
