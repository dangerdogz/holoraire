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
        AjouterPoste ajouterposte = new AjouterPoste();
        AjouterEquipe ajouterequipe = new AjouterEquipe();
        public HoraireBeta(Loader loader)
        {
            this.loader = loader;
            InitializeComponent();
            
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

        private void pCentral_Horaire_OnMouseDown(object sender, MouseEventArgs e)
        {
            switch (e.Button)
                {
                case MouseButtons.Left:
                    grille.passeClique(e,"MouseDown");
                    break;
                }   


        }

        private void pCentral_Horaire_OnMouseUp(object sender, MouseEventArgs e)
        {
            switch (e.Button)
            {
                case MouseButtons.Left:
                    grille.passeClique(e,"MouseUp");
                    break;
            }


        }

        private void pCentral_Horaire_OnMouseEvent(object sender, MouseEventArgs e)
        {

            switch (e.Button)
            {
                case MouseButtons.Left:
                    //MessageBox.Show(this, "PanelCentral Horaire: Vous avez appuyez sur gauche en : " + e.X + " , " + e.Y);
                   // createBlock();
                   // grille.passeClique(e.X, e.Y);
                    //grille.passeClique(e);

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

        private void button_ajouter_PG_Click(object sender, EventArgs e)
        {
            popPostWindow();
        }

        private void button_aj_equipe_Click(object sender, EventArgs e)
        {
            popEquipeWindow();
        }

        private void popPostWindow(/*int x, int y, DateTime hd, DateTime hf*/)
        {
            AjouterPoste ajouterposte = new AjouterPoste();
            ajouterposte.ShowDialog();
            loader.posteCharge.Add(new Poste(ajouterposte.getpName(), ajouterposte.getpDesc()));
            MessageBox.Show(loader.posteCharge.Last().getNom());
          /*  CreateXml xml = new CreateXml();
            xml.CreateProfileXml();*/
            ajouterposte.Dispose();
        }

        private void popEquipeWindow(/*int x, int y, DateTime hd, DateTime hf*/)
        {
            AjouterEquipe ajouterequipe = new AjouterEquipe();
            ajouterequipe.ShowDialog();
            loader.equipe.Add(new Equipe(-1, ajouterequipe.geteName(), ajouterequipe.geteDesc()));
            MessageBox.Show(loader.equipe.Last().getNom());
            /*  CreateXml xml = new CreateXml();
              xml.CreateProfileXml();*/
            ajouterequipe.Dispose();
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

        private void posteaoccuper_gauche_Click(object sender, EventArgs e)
        {
            if (this.treeView_postechoisi.SelectedNode.IsSelected == true)
            {
                System.Windows.Forms.TreeNode name;
                name = new System.Windows.Forms.TreeNode(this.treeView_postechoisi.SelectedNode.Text);
                //NEGGA
                this.treeView_postdispo.Nodes.Add(name);
                this.treeView_postechoisi.SelectedNode.Remove();
            }
        }

        private void buttondroit_Click(object sender, EventArgs e)
        {
            if (this.treeView_postdispo.SelectedNode.IsSelected == true)
            {
                System.Windows.Forms.TreeNode name;
                name = new System.Windows.Forms.TreeNode(this.treeView_postdispo.SelectedNode.Text);
                //NEGGA
                this.treeView_postechoisi.Nodes.Add(name);
                this.treeView_postdispo.SelectedNode.Remove();
            }
        }

        private void postaaffectgauche_Click(object sender, EventArgs e)
        {
            if (this.treeView_postaaffectdroite.SelectedNode.IsSelected == true)
            {
                System.Windows.Forms.TreeNode name;
                name = new System.Windows.Forms.TreeNode(this.treeView_postaaffectdroite.SelectedNode.Text);
                //NEGGA2
                this.treeView_postaaffectgauche.Nodes.Add(name);
                this.treeView_postaaffectdroite.SelectedNode.Remove();
            }
        }

        private void postaaffectdroit_Click(object sender, EventArgs e)
        {
            if (this.treeView_postaaffectgauche.SelectedNode.IsSelected == true)
            {
                System.Windows.Forms.TreeNode name;
                name = new System.Windows.Forms.TreeNode(this.treeView_postaaffectgauche.SelectedNode.Text);
                //NEGGA2
                this.treeView_postaaffectdroite.Nodes.Add(name);
                this.treeView_postaaffectgauche.SelectedNode.Remove();
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

       /* public void ajoutposteBD()
        {

            loader.posteCharge.Add(new Poste(ajouterposte.getpName(), ajouterposte.getpDesc()));
   
            CreateXml xml = new CreateXml();
  
            xml.CreateProfileXml();
 
            AjouterPoste.ActiveForm.Dispose();

        }

        public void ajoutequipeBD()
        {

            loader.equipe.Add(new Equipe(-1, ajouterequipe.geteName(), ajouterequipe.geteDesc()));

            CreateXml xml = new CreateXml();

            xml.CreateProfileXml();

            AjouterEquipe.ActiveForm.Dispose();

        }*/

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


        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            DateTime debutSemaine = getDebutSemaine();
            grille.changeSemaine(debutSemaine);
        }
        public DateTime getDebutSemaine()
        {
            
            DateTime selectedDate = monthCalendar1.SelectionStart.Date;

            String dow = monthCalendar1.SelectionStart.DayOfWeek.ToString();

            switch (dow)
            {
                case "Sunday":
                    TimeSpan toSubstract = TimeSpan.FromDays(6);
                    DateTime monday = selectedDate.Subtract(toSubstract);
                    return monday;
                case "Monday":
                    monday = monthCalendar1.SelectionStart.Date;
                    return monday;
                case "Tuesday":
                    toSubstract = TimeSpan.FromDays(1);
                    monday = selectedDate.Subtract(toSubstract);
                    return monday;
                case "Wednesday":
                    toSubstract = TimeSpan.FromDays(2);
                    monday = selectedDate.Subtract(toSubstract);
                    return monday;
                case "Thursday":
                    toSubstract = TimeSpan.FromDays(3);
                    monday = selectedDate.Subtract(toSubstract);
                    return monday;
                case "Friday":
                    toSubstract = TimeSpan.FromDays(4);
                    monday = selectedDate.Subtract(toSubstract);
                    return monday;
                case "Saturday":
                    toSubstract = TimeSpan.FromDays(5);
                    monday = selectedDate.Subtract(toSubstract);
                    return monday;
            }
            return selectedDate;
        }

        private void button_generaux_Click(object sender, EventArgs e)
        {
            this.panelCentral_Parametre.Controls.Remove(this.label_postaffect);
            this.panelCentral_Parametre.Controls.Remove(this.treeView_postaaffectgauche);
            this.panelCentral_Parametre.Controls.Remove(this.treeView_postaaffectdroite);
            this.panelCentral_Parametre.Controls.Remove(this.button_postaaffectgauche);
            this.panelCentral_Parametre.Controls.Remove(this.button_postaaffectdroit);
            this.panelCentral_Parametre.Controls.Remove(this.button_affecter);
            this.panelCentral_Parametre.Controls.Remove(this.treeView_postspec2);
            this.panelCentral_Parametre.Controls.Remove(this.label_postspec);
            this.panelCentral_Parametre.Controls.Remove(this.treeView_postspec);
            this.panelCentral_Parametre.Controls.Remove(this.button_del_postspec);
            this.panelCentral_Parametre.Controls.Remove(this.button_aj_postspec);
            this.panelCentral_Parametre.Controls.Remove(this.label_equipes);
            this.panelCentral_Parametre.Controls.Remove(this.treeView_equipe);
            this.panelCentral_Parametre.Controls.Remove(this.button_del_equipe);
            this.panelCentral_Parametre.Controls.Remove(this.button_aj_equipe);
            this.panelCentral_Parametre.Controls.Remove(this.treeView_postgen);
            this.panelCentral_Parametre.Controls.Remove(this.button_supprimer);
            this.panelCentral_Parametre.Controls.Remove(this.button_ajouter_PG);
            this.panelCentral_Parametre.Controls.Remove(this.label_postgeneral);

           

            this.panelCentral_Parametre.Controls.Add(this.label_partexte);
            this.panelCentral_Parametre.Controls.Add(this.textBox_graduation);
            this.panelCentral_Parametre.Controls.Add(this.textBox_quotasemaine);
            this.panelCentral_Parametre.Controls.Add(this.textBox_qtheurejou);
            this.panelCentral_Parametre.Controls.Add(this.label_graduation);
            this.panelCentral_Parametre.Controls.Add(this.label_quotasemaine);
            this.panelCentral_Parametre.Controls.Add(this.label_quotajour);
            this.panelCentral_Parametre.Controls.Add(this.label_horaire);
            this.panelCentral_Parametre.Controls.Add(this.label_heurest);
        }
        

        private void button_ressource_Click(object sender, EventArgs e)
        {
            this.panelCentral_Parametre.Controls.Remove(this.label_partexte);
            this.panelCentral_Parametre.Controls.Remove(this.textBox_graduation);
            this.panelCentral_Parametre.Controls.Remove(this.textBox_quotasemaine);
            this.panelCentral_Parametre.Controls.Remove(this.textBox_qtheurejou);
            this.panelCentral_Parametre.Controls.Remove(this.label_graduation);
            this.panelCentral_Parametre.Controls.Remove(this.label_quotasemaine);
            this.panelCentral_Parametre.Controls.Remove(this.label_quotajour);
            this.panelCentral_Parametre.Controls.Remove(this.label_horaire);
            this.panelCentral_Parametre.Controls.Remove(this.label_heurest);

            this.panelCentral_Parametre.Controls.Add(this.label_postaffect);
            this.panelCentral_Parametre.Controls.Add(this.treeView_postaaffectgauche);
            this.panelCentral_Parametre.Controls.Add(this.treeView_postaaffectdroite);
            this.panelCentral_Parametre.Controls.Add(this.button_postaaffectgauche);
            this.panelCentral_Parametre.Controls.Add(this.button_postaaffectdroit);
            this.panelCentral_Parametre.Controls.Add(this.button_affecter);
            this.panelCentral_Parametre.Controls.Add(this.treeView_postspec2);
            this.panelCentral_Parametre.Controls.Add(this.label_postspec);
            this.panelCentral_Parametre.Controls.Add(this.treeView_postspec);
            this.panelCentral_Parametre.Controls.Add(this.button_del_postspec);
            this.panelCentral_Parametre.Controls.Add(this.button_aj_postspec);
            this.panelCentral_Parametre.Controls.Add(this.label_equipes);
            this.panelCentral_Parametre.Controls.Add(this.treeView_equipe);
            this.panelCentral_Parametre.Controls.Add(this.button_del_equipe);
            this.panelCentral_Parametre.Controls.Add(this.button_aj_equipe);
            this.panelCentral_Parametre.Controls.Add(this.treeView_postgen);
            this.panelCentral_Parametre.Controls.Add(this.button_supprimer);
            this.panelCentral_Parametre.Controls.Add(this.button_ajouter_PG);
            this.panelCentral_Parametre.Controls.Add(this.label_postgeneral);
        }

        private void Sauvegarder_button_Click(object sender, EventArgs e)
        {
        Profil profil = new Profil(nom_textbox.Text, prenom_textbox.Text, courriel_textbox.Text, telephone_textbox.Text, 0);
        loader.profilCharge.Add(profil);
        profil.save();
        numemp_textbox.Text = "";
        nom_textbox.Text = "";
        prenom_textbox.Text = "";

        courriel_textbox.Text = "";
        telephone_textbox.Text = "";

        }
    }
} 
           

          


            
