using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using HoraireBeta;
//using Draw_Rectangle;


namespace HoraireBeta
{
    public partial class HoraireBeta : Form
    {
        Boolean test = true;
        Bloc presetSelected = null;
        AjouterPoste ajouterposte = new AjouterPoste();
        AjouterEquipe ajouterequipe = new AjouterEquipe();
        SelectDispo dispoWindow;
        Profil profilSelected = null;
        bool mod = false;
        private Font verdana10Font;
        private StreamReader reader;
        private StreamWriter writer;
        private String file = "employeesOfTheWeek.txt";
        public HoraireBeta(Loader loader)
        {
            this.loader = loader;
            InitializeComponent();
            FillInterface();
            Graphics grfx = this.panelCentral_Horaire.CreateGraphics();
            grille = new GrilleHoraire(grfx, loader, getDebutSemaine());
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
        /*
        private void pCentral_Horaire_Paint(object sender, PaintEventArgs e)
        {
        
        }
        */
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
                  //  MessageBox.Show(this, "PanelGauche Employé: Vous avez appuyez sur gauche en : " + e.X + " , " + e.Y);
                    
                    break;
                }
        }

        private void pCentral_Employe_OnMouseEvent(object sender, MouseEventArgs e)
        {

            switch (e.Button)
            {
                case MouseButtons.Left:
                   // MessageBox.Show(this, "PanelCentral Employé: Vous avez appuyez sur gauche en : " + e.X + " , " + e.Y);
                    

                    break;
            }
        }



        private void pGauche_Horaire_OnMouseEvent(object sender, MouseEventArgs e)
        {

            switch (e.Button)
            {
                case MouseButtons.Left:
                    //MessageBox.Show(this, "PanelGauche Horaire: Vous avez appuyez sur gauche en : " + e.X + " , " + e.Y);

                    break;
            }
        }

        private void pCentral_Horaire_OnMouseDown(object sender, MouseEventArgs e)
        {
            switch (e.Button)
                {
                case MouseButtons.Left:
                        grille.passeClique(e, "MouseDown", presetSelected);
                        listPoste.Items.Clear();
                        listEmploye.Items.Clear();
                        listEquipe.Items.Clear();
                    break;
                case MouseButtons.Right:
                        presetSelected = null;
                        listPreset.ClearSelected();
                    break;
                }   


        }

        private void listPreset_MouseDown(object sender, MouseEventArgs e)
        {
            try
            {
                int index = listPreset.IndexFromPoint(e.Location.X, e.Location.Y);
                if (listPreset.Items[index] != null)
                {
                    //MessageBox.Show(listPreset.GetItemText(listPreset.Items[index]));
                    if (loader.findBloc(Convert.ToInt32(listPreset.GetItemText(listPreset.Items[index])), loader.bloc) != null)
                    {
                        presetSelected = loader.findBloc(Convert.ToInt32(listPreset.GetItemText(listPreset.Items[index])), loader.bloc);
                    }
                }
            }
            catch (Exception ex)
            {
                
            }


        }

        private void pCentral_Horaire_OnMouseUp(object sender, MouseEventArgs e)
        {
            switch (e.Button)
            {
                  
                  case MouseButtons.Left:
                   grille.passeClique(e,"MouseUp");
                   // updateInterfaceHoraire();
                    if (grille.selectionEnCours != null)
                    {
                        fillEmployeListBox(grille.selectionEnCours);
                        fillPosteListBox(grille.selectionEnCours);
                        fillEquipeListBox(grille.selectionEnCours);
                    }
                    break;
            }
            
        }

        private void pCentral_Horaire_DoubleClick(object sender, EventArgs me)
        {

            MouseEventArgs e = me as MouseEventArgs;

            grille.passeClique(e, "DoubleClick");

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
                   // MessageBox.Show(this, "PanelGauche Parametre: Vous avez appuyez sur gauche en : " + e.X + " , " + e.Y);

                    break;
            }
        }

        private void pCentral_Parametre_OnMouseEvent(object sender, MouseEventArgs e)
        {
            
            switch (e.Button)
            {
                case MouseButtons.Left:
                    //MessageBox.Show(this, "PanelCentral Parametre: Vous avez appuyez sur gauche en : " + e.X + " , " + e.Y);

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
           // MessageBox.Show(this, "connecté");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            resultDataGrid.DataSource = dbc.getResult(sqlTextBox.Text);
            resultDataGrid.Refresh();
        }

        private void modifier_button_Click(object sender, EventArgs e)
        {
            CreateXml.CreateProfileXml();
            Chilkat.Xml xmlProfiles3 = new Chilkat.Xml();
            xmlProfiles3.LoadXmlFile("profiles.xml");

            treeView_modemploye.Nodes.Clear();
            FillTree(treeView_modemploye.Nodes, xmlProfiles3);

            mod = true;
            numemp_textbox.ReadOnly.ToString();
            panelCentral_Employe.Controls.Add(this.supprimer_button);
            ajprofemp_label.Text = "Modifier un profil d'employé";
            numemp_textbox.Text = "";
            nom_textbox.Text = "";
            prenom_textbox.Text = "";
            courriel_textbox.Text = "";
            telephone_textbox.Text = "";
            this.panelGauche_Employe.Controls.Add(this.treeView_modemploye);

        }

        private void button_ajouter_PG_Click(object sender, EventArgs e)
        {
            popPostWindow();
        }

        private void button_aj_equipe_Click(object sender, EventArgs e)
        {
            popEquipeWindow();
        }

        private void button_del_equipe_Click(object sender, EventArgs e)
        {
            popTeamDelWindow();
        }

        private void button_supprimer_Click(object sender, EventArgs e)
        {
            popPostDelWindow();
        }

        private void popTeamDelWindow()
        {
            DeleteEquipe delequipe = new DeleteEquipe();
            if (treeView_equipe.SelectedNode != null)
            {
                delequipe.setName(treeView_equipe.SelectedNode.Text.ToString());
                delequipe.ShowDialog();

                CreateXml.CreateProfileXml();
                Chilkat.Xml xmlEquipe6 = new Chilkat.Xml();
                xmlEquipe6.LoadXmlFile("teams.xml");
                

                delequipe.Dispose();
                treeView_equipe.Nodes.Clear();
                FillTree(treeView_equipe.Nodes, xmlEquipe6);
            }
            else
            {
                MessageBox.Show("Veuillez sélectionner une équipe");
            }
        }

        private void popPostDelWindow()
        {
            DeletePost delposte = new DeletePost();
            if (treeView_postgen.SelectedNode != null)
            {
                delposte.setName(treeView_postgen.SelectedNode.Text.ToString());
                delposte.ShowDialog();

                CreateXml.CreateProfileXml();
                Chilkat.Xml xmlPoste10 = new Chilkat.Xml();
                xmlPoste10.LoadXmlFile("postes.xml");
                Chilkat.Xml xmlPoste7 = new Chilkat.Xml();
                xmlPoste7.LoadXmlFile("postes.xml");
                Chilkat.Xml xmlPoste15 = new Chilkat.Xml();
                xmlPoste15.LoadXmlFile("postes.xml");

                
                delposte.Dispose();
                treeView_postgen.Nodes.Clear();
                FillTree(treeView_postgen.Nodes, xmlPoste10);
                treeView_postaaffectgauche.Nodes.Clear();
                FillTree(treeView_postaaffectgauche.Nodes, xmlPoste7);
                treeView_postdispo.Nodes.Clear();
                FillTree(treeView_postdispo.Nodes, xmlPoste15);
            }
            else
            {
                MessageBox.Show("Veuillez sélectionner un poste");
            }
        }

        private void popPostWindow()
        {
            AjouterPoste ajouterposte = new AjouterPoste();
            ajouterposte.ShowDialog();
            bool saveannul;
            saveannul = ajouterposte.getannul();
            if (saveannul == false)
            {
                if (ajouterposte.getpName().ToString() == "")
                {
                    MessageBox.Show("Poste non ajouté, nom manquant");
                }
                else
                {
                    loader.posteCharge.Add(new Poste(ajouterposte.getpName(), ajouterposte.getpDesc()));

                    ajouterposte.save();

                    CreateXml.CreateProfileXml();
                    ajouterposte.Dispose();
                    Chilkat.Xml xmlPoste5 = new Chilkat.Xml();
                    xmlPoste5.LoadXmlFile("postes.xml");
                    Chilkat.Xml xmlPoste6 = new Chilkat.Xml();
                    xmlPoste6.LoadXmlFile("postes.xml");
                    Chilkat.Xml xmlPoste16 = new Chilkat.Xml();
                    xmlPoste16.LoadXmlFile("postes.xml");

                    treeView_postgen.Nodes.Clear();
                    treeView_postaaffectgauche.Nodes.Clear();
                    treeView_postdispo.Nodes.Clear();
                    FillTree(treeView_postdispo.Nodes, xmlPoste16);
                    FillTree(treeView_postgen.Nodes, xmlPoste5);
                    FillTree(treeView_postaaffectgauche.Nodes, xmlPoste6);
                }
            }
        }

        private void popEquipeWindow()
        {
            AjouterEquipe ajouterequipe = new AjouterEquipe();
            ajouterequipe.ShowDialog();
            bool saveannul;
            saveannul = ajouterequipe.getannul();
            if (saveannul == false)
            {
                if (ajouterequipe.geteName().ToString() == "")
                {
                    MessageBox.Show("Equipe non ajouté, nom manquant");
                }
                else
                {
                    loader.equipe.Add(new Equipe(-1, ajouterequipe.geteName(), ajouterequipe.geteDesc()));

                    ajouterequipe.save();

                    CreateXml.CreateProfileXml();
                    ajouterequipe.Dispose();
                    Chilkat.Xml xmlEquipe5 = new Chilkat.Xml();
                    xmlEquipe5.LoadXmlFile("teams.xml");
                    treeView_equipe.Nodes.Clear();
                    FillTree(treeView_equipe.Nodes, xmlEquipe5);
                }
            }   
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
            CreateXml.CreateProfileXml();
            Chilkat.Xml xmlPoste12 = new Chilkat.Xml();
            xmlPoste12.LoadXmlFile("postes.xml");

            treeView_postdispo.Nodes.Clear();
            treeView_postechoisi.Nodes.Clear();
            FillTree(treeView_postdispo.Nodes, xmlPoste12);

            mod = false;
            this.panelCentral_Employe.Controls.Remove(this.supprimer_button);
            this.panelCentral_Employe.Controls.Add(this.numemp_textbox);
            this.panelCentral_Employe.Controls.Add(this.nemp_label);
            ajprofemp_label.Text = "Ajouter un profil d'employé";
            numemp_textbox.Text = "";
            nom_textbox.Text = "";
            prenom_textbox.Text = "";
            courriel_textbox.Text = "";
            telephone_textbox.Text = "";
            this.panelGauche_Employe.Controls.Remove(this.treeView_modemploye);
        }

        private void posteaoccuper_gauche_Click(object sender, EventArgs e)
        {
            try
                {
                    if (this.treeView_postechoisi.SelectedNode.IsSelected == true)
                    {
                        System.Windows.Forms.TreeNode name;
                        name = new System.Windows.Forms.TreeNode(this.treeView_postechoisi.SelectedNode.Text);
                        this.treeView_postdispo.Nodes.Add(name);
                        this.treeView_postechoisi.SelectedNode.Remove();
                    }
                }
            catch (Exception ex)
            {
                MessageBox.Show("Veuillez sélectionner un poste dans les poste choisis pour le transferer dans les postes disponibles");
            }
        }

        private void buttondroit_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.treeView_postdispo.SelectedNode.IsSelected == true)
                {
                    System.Windows.Forms.TreeNode name;
                    name = new System.Windows.Forms.TreeNode(this.treeView_postdispo.SelectedNode.Text);
                    this.treeView_postechoisi.Nodes.Add(name);
                    this.treeView_postdispo.SelectedNode.Remove();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Veuillez sélectionner un poste dans les poste disponibles pour le transferer dans les postes choisis");
            }
        }

        private void postaaffectgauche_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.treeView_postaaffectdroite.SelectedNode.IsSelected == true)
                {
                    System.Windows.Forms.TreeNode name;
                    name = new System.Windows.Forms.TreeNode(this.treeView_postaaffectdroite.SelectedNode.Text);
                    this.treeView_postaaffectgauche.Nodes.Add(name);
                    this.treeView_postaaffectdroite.SelectedNode.Remove();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Veuillez sélectionner un poste à affecter dans la liste des postes disponibles");
            }
            
        }

        private void postaaffectdroit_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.treeView_postaaffectgauche.SelectedNode.IsSelected == true)
                {
                    System.Windows.Forms.TreeNode name;
                    name = new System.Windows.Forms.TreeNode(this.treeView_postaaffectgauche.SelectedNode.Text);
                    this.treeView_postaaffectdroite.Nodes.Add(name);
                    this.treeView_postaaffectgauche.SelectedNode.Remove();
                }
            }
            catch
            {
                MessageBox.Show("Veuillez sélectionner un postes affecté pour le transferer dans les postes disponibles");
            }
        }

        private void createBlock(/*int x, int y, DateTime hd, DateTime hf*/)
        {/*
            CreationBloc creationbloc = new CreationBloc();
            creationbloc.ShowDialog();
            loader.bloc.Add(new Bloc(new DateTime(2010, 11, 03, Convert.ToInt32(creationbloc.getHd()), 0, 0), new DateTime(2010, 11, 03, Convert.ToInt32(creationbloc.getHf()), 0, 0), 0, 0));
            creationbloc.Dispose();
            //Application.Run(creationbloc);*/
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
                xml = xml.FindNextRecord("nom", textInForm + "*");
                if (xml != null)
                {
                    // Add the company name to the listbox.

                    RessourceTree.Nodes[0].Nodes.Add(new System.Windows.Forms.TreeNode(xml.GetChildContent("nom") + ", " + xml.GetChildContent("prenom")));


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
                xml = xml.FindNextRecord("nom", textInForm + "*");
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
                xml = xml.FindNextRecord("nom", textInForm + "*");
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
        private void FillInterface()
        {
            CreateXml.CreateProfileXml();
            Chilkat.Xml xml = new Chilkat.Xml();
            Chilkat.Xml xmlProfiles = new Chilkat.Xml();
            Chilkat.Xml xmlProfiles2 = new Chilkat.Xml();
            Chilkat.Xml xmlPostes = new Chilkat.Xml();
            Chilkat.Xml xmlPostes2 = new Chilkat.Xml();
            Chilkat.Xml xmlPostes3 = new Chilkat.Xml();
            Chilkat.Xml xmlPostes4 = new Chilkat.Xml();
            Chilkat.Xml xmlTeams = new Chilkat.Xml();
            Chilkat.Xml xmlTeams2 = new Chilkat.Xml();
            xmlProfiles.LoadXmlFile("profiles.xml");
            xmlProfiles2.LoadXmlFile("profiles.xml");
            xmlPostes.LoadXmlFile("postes.xml");
            xmlPostes2.LoadXmlFile("postes.xml");
            xmlPostes3.LoadXmlFile("postes.xml");
            xmlPostes4.LoadXmlFile("postes.xml");
            xmlTeams.LoadXmlFile("teams.xml");
            xmlTeams2.LoadXmlFile("teams.xml");


            FillTree(RessourceTree.Nodes[0].Nodes, xmlProfiles);
            FillTree(RessourceTree.Nodes[1].Nodes, xmlPostes);
            FillTree(RessourceTree.Nodes[2].Nodes, xmlTeams);
            FillTree(treeView_postdispo.Nodes, xmlPostes2);
            FillTree(treeView_postaaffectgauche.Nodes, xmlPostes3);
            FillTree(treeView_equipe.Nodes, xmlTeams2);
            FillTree(treeView_postgen.Nodes, xmlPostes4);
            FillTree(treeView_modemploye.Nodes, xmlProfiles2);
            fillPresetListBox();
            //fillEmployeListBox();

            //FillTree(treeView_postdispo.Nodes, xmlPostes2);
            


        }
        public void FillTree(TreeNodeCollection treeNodes, Chilkat.Xml xml)
        {
            foreach (TreeNode tree in treeNodes)
            {
                tree.Remove();
            }
            
            // Navigate to the first xml record.
            xml.FirstChild2();

            while (xml != null && xml.GetChildContent("nom") != "")
            {
               treeNodes.Add(new TreeNode(xml.GetChildContent("nom")));

                xml = xml.NextSibling();
            }
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
            bool exception = false;
            if (nom_textbox.Text == "" || prenom_textbox.Text == "" || numemp_textbox.Text == "")
            {
                MessageBox.Show("Veuillez entrer un numéro d'employé, un nom et un prenom pour l'employé");
            }
            else
            {
            Profil profil = profilSelected;
            try
            {
                profil.setId(Convert.ToInt32(numemp_textbox.Text));
            }
            catch (Exception ex)
            {
                exception = true;
                MessageBox.Show("Vous avez entrer un nombre invalide ou des caractères non autorisé pour le numéro d'employé, veuillez en choisir un autre");
            }
            if (exception != true)
            {
                profil.setNom(nom_textbox.Text);
                profil.setPrenom(prenom_textbox.Text);
                profil.setEmail(courriel_textbox.Text);
                profil.setNumTelephone(telephone_textbox.Text);
                profil.setAnciennete(0);

                //new Profil(Convert.ToInt32(numemp_textbox.Text), prenom_textbox.Text, nom_textbox.Text, courriel_textbox.Text, telephone_textbox.Text, 0, 0);
                for (int cul = 0; cul < treeView_postechoisi.Nodes.Count; cul++)
                {
                    int i = 0;
                    while (treeView_postechoisi.Nodes[cul].Text != ((Poste)(loader.posteCharge[i++])).getNom()) ;
                    profil.setPoste((Poste)(loader.posteCharge[--i]));

                }
                loader.profilCharge.Add(profil);


                profil.save(mod);
                MessageBox.Show("Sauvegarde réussie!");
            }
            else
            {
                MessageBox.Show("Sauvegarde échoué");
            }

            numemp_textbox.Text = "";
            nom_textbox.Text = "";
            prenom_textbox.Text = "";
            courriel_textbox.Text = "";
            telephone_textbox.Text = "";
            profilSelected = new Profil();
            }

            CreateXml.CreateProfileXml();
            Chilkat.Xml xmlPoste11 = new Chilkat.Xml();
            xmlPoste11.LoadXmlFile("postes.xml");

            treeView_postdispo.Nodes.Clear();
            treeView_postechoisi.Nodes.Clear();
            FillTree(treeView_postdispo.Nodes, xmlPoste11);

        }

        private void UnlinkBlocToRessource(Ressource res, Bloc bloc)
        {
            for (int i = 0; i < bloc.getListRessourceAffecte().Count; i++)
            {
                if (res == bloc.getListRessourceAffecte()[i])
                    bloc.getListRessourceAffecte().Remove(res);
            }

        }

        private void LinkBlocToRessource(Ressource res, Bloc bloc)
        {
            NbPoste showPosteDialog;
            if (res is Profil)
                bloc.addProfil((Profil)res);
            else
                if (res is Equipe)
                    bloc.addRessource((Equipe)res);
                else
                    if (res is Poste)
                    {
                        if (bloc.estVoulue(res))
                            showPosteDialog = new NbPoste(res.getNom(), bloc.getRessourceVoulus(res).nbVoulue);
                        else
                            showPosteDialog = new NbPoste();

                        showPosteDialog.ShowDialog();
                        if (showPosteDialog.confirm)
                        {
                            
                            if (!bloc.estVoulue(res))
                                bloc.addRessourceVoulue(Convert.ToInt32(showPosteDialog.nb), (Poste)res);
                            else
                            {
                                RessourceEntree holy = bloc.getRessourceVoulus(res);
                                holy.nbVoulue = Convert.ToInt32(showPosteDialog.nb);
                                bloc.getRessourceVoulus().RemoveAt(bloc.getiRessourceVoulus(res));
                                bloc.addRessourceVoulue(holy);

                            }
                            //grille.refresh();
                            //FillInterface();
                            fillPosteListBox(bloc);
                           // FillTree();
                            //todo eille fadrait que ca edit un moment donné ca
                            //faut passer un int a nbposte, pis savoir que t'es en mode édit qq part
                        }
                        showPosteDialog.Dispose();
                    }
                    else
                    {
                        String nb = "";
                        int position;
                        bool existe = false;

                        for (position = 0; position < bloc.getRessourceVoulus().Count; position++)
                        {

                            if (((Poste)bloc.getRessourceVoulus(position).voulue).getNom().Equals(((Poste)res).getNom()))
                            {
                                nb = bloc.getRessourceVoulus(position).nbVoulue.ToString();
                                // MessageBox.Show(nb);
                                existe = true;
                                break;
                            }
                        }
                    }
        }


                      /*  NbPoste input = new NbPoste(((Poste)res).getNom(), nb);
                        input.ShowDialog();

                        if (existe)
                        {

                            RessourceEntree resNb = bloc.getRessourceVoulus(position);
                            resNb.nbVoulue = Convert.ToInt32(input.getNb());
                            bloc.removeRessourceVoulu(bloc.getRessourceVoulus()[position]);

                            bloc.addRessourceVoulue(Convert.ToInt32(input.getNb()), res);
                            input.Dispose();


                            bloc.addRessourceVoulue(resNb);

                        }
                        else
                            bloc.addRessourceVoulue(Convert.ToInt32(input.getNb()), res);

                        input.Dispose();
                    }
                }
        }

*/
        private void RessourceTree_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {

            Ressource ressource = null;

            if (grille.selectionEnCours != null)
            {
                String textInForm;
          
                textInForm = e.Node.Text;
                Chilkat.Xml xml = new Chilkat.Xml();
                Chilkat.Xml xmlProfiles = new Chilkat.Xml();
                Chilkat.Xml xmlPostes = new Chilkat.Xml();
                Chilkat.Xml xmlTeams = new Chilkat.Xml();
                xmlProfiles.LoadXmlFile("profiles.xml");
                xmlPostes.LoadXmlFile("postes.xml");
                xmlTeams.LoadXmlFile("teams.xml");
                String id;
                id = findRessourceXML(textInForm, xmlProfiles);

                if (id != null)
                {
                    ressource = loader.findRessource(Convert.ToInt32(id), loader.profilCharge);
                }
                else
                {
                    id = findRessourceXML(textInForm, xmlPostes);

                    if (id != null)
                    {
                        ressource = loader.findRessource(Convert.ToInt32(id), loader.posteCharge);
                    }
                    else
                    {
                        id = findRessourceXML(textInForm, xmlTeams);

                        if (id != null)
                        {
                            ressource = loader.findRessource(Convert.ToInt32(id), loader.equipe);
                        }
                    }
                }


                if (e.Node.BackColor != Color.Cyan)
                {
         
                    if (ressource != null)
                    {
                        LinkBlocToRessource(ressource, grille.selectionEnCours);
                        e.Node.BackColor = Color.Cyan;
                    }
                }
                else
                {
                    if (ressource != null)
                    {
                        UnlinkBlocToRessource(ressource, grille.selectionEnCours);
                        e.Node.BackColor = Color.White;
                    }
                }
            }
        }

        public String findRessourceXML(String nom, Chilkat.Xml xml)
        {
            xml.FirstChild2();

            while (xml != null)
            {
                // FindNextRecord *will* return the current record if it
                // matches the criteria. 
                xml = xml.FindNextRecord("nom", nom + "*");

                if (xml != null)
                {
                    // Add the company name to the listbox.
                    String id = null;
                    id = xml.GetChildContent("id");

                    return id;
                }
            }
            return null;
        }
        

        private void treeView_modemploye_AfterSelect(object sender, TreeViewEventArgs e)
        {
            Profil ressource = null;
            Chilkat.Xml xmlProfiles = new Chilkat.Xml();
            xmlProfiles.LoadXmlFile("profiles.xml");

            Chilkat.Xml xmlPoste7 = new Chilkat.Xml();
            xmlPoste7.LoadXmlFile("postes.xml");
            treeView_postdispo.Nodes.Clear();
            treeView_postechoisi.Nodes.Clear();
            FillTree(treeView_postdispo.Nodes, xmlPoste7);           

            String textInForm;
            textInForm = treeView_modemploye.SelectedNode.Text.ToString();
            String id;
            int idprofil;
            id = findRessourceXML(textInForm, xmlProfiles);

            if (id != null)
            {
                profilSelected = (Profil)loader.findRessource(Convert.ToInt32(id), loader.profilCharge);
                ressource = profilSelected;
                idprofil = ressource.getId();
                numemp_textbox.Text = ressource.getId().ToString();
                nom_textbox.Text = ressource.getNom();
                prenom_textbox.Text = ressource.getPrenom();
                courriel_textbox.Text = ressource.getEmail();
                telephone_textbox.Text = ressource.getNumTelephone();
                DataTable datatable;
                DataTable datatable2;
                DBConnect proc = new DBConnect();
                datatable = proc.getPosteProfil2(idprofil);
                int pid;
                String pname;

                for(int i = 0; i < datatable.Rows.Count; i++)
                {

                    pid = Convert.ToInt32(datatable.Rows[i]["idPoste"]);
                    datatable2 = proc.getPoste2(pid);
                    pname = datatable2.Rows[0]["nom"].ToString();

                    //pname = datatable.Rows[i].ToString();

                    System.Windows.Forms.TreeNode name;
                    name = new System.Windows.Forms.TreeNode(pname);
                    this.treeView_postechoisi.Nodes.Add(pname);

                    for (int j = 0; j < treeView_postdispo.Nodes.Count; j++)
                    {
                        if (treeView_postdispo.Nodes[j].Text.ToString() == pname)
                        {
                            treeView_postdispo.Nodes[j].Remove();
                        }
                    }

                    this.treeView_postdispo.Nodes.Remove(name);

                }

                 

            }  
        }
        private void loadEmployeInfos(int id)
        {
            Admin.SelectedTab = this.employe;
            Profil ressource = null;
            treeView_postdispo.Nodes.Clear();
            this.panelCentral_Employe.Controls.Add(clear_button);
            this.panelCentral_Employe.Controls.Remove(Sauvegarder_button);
            this.panelCentral_Employe.Controls.Remove(button_Valider);
            this.panelGauche_Employe.Controls.Remove(ajouter_button);
            this.panelGauche_Employe.Controls.Remove(modifier_button);
            int idprofil;
            if (id != null)
            {
                profilSelected = (Profil)loader.findRessource(Convert.ToInt32(id), loader.profilCharge);
                ressource = profilSelected;
                idprofil = ressource.getId();
                numemp_textbox.Text = ressource.getId().ToString();
                nom_textbox.Text = ressource.getNom();
                prenom_textbox.Text = ressource.getPrenom();
                courriel_textbox.Text = ressource.getEmail();
                telephone_textbox.Text = ressource.getNumTelephone();
                
            }
        }
        private void restablishInterface()
        {
            if (!panelCentral_Employe.Controls.Contains(Sauvegarder_button))
            {
                this.panelCentral_Employe.Controls.Add(Sauvegarder_button);
                this.panelCentral_Employe.Controls.Add(button_Valider);
                this.panelGauche_Employe.Controls.Add(ajouter_button);
                this.panelGauche_Employe.Controls.Add(modifier_button);
                this.panelCentral_Employe.Controls.Remove(clear_button);
                numemp_textbox.Text = "";
                nom_textbox.Text = "";
                prenom_textbox.Text = "";
                courriel_textbox.Text = "";
                telephone_textbox.Text = "";
            }

        }
        private void supprimer_button_Click(object sender, EventArgs e)
        {

            
        }
        public void fillEmployeListBox(Bloc bloc)
        {
            listEmploye.Items.Clear();

            List<Ressource> ressources = bloc.getListRessourceAffecte();
            for (int i = 0; i < ressources.Count(); i++)
            {

                // Add the employee name to the listbox.
                if (ressources.ElementAt(i) is Profil)
                {
                    listEmploye.Items.Add(((Profil)ressources.ElementAt(i)).getId() + " - " + ((Profil)ressources.ElementAt(i)).getNom() + " " + ((Profil)ressources.ElementAt(i)).getPrenom());
                }


            }


        }


        void listEmploye_MouseDoubleClick(object sender, MouseEventArgs e)
        {

            int index = this.listEmploye.IndexFromPoint(e.Location);

            if (index != System.Windows.Forms.ListBox.NoMatches)
            {
                int idEmployeClicked = Convert.ToInt32(listEmploye.Items[index].ToString().Substring(0, 1));

                loadEmployeInfos(idEmployeClicked);


            }

        }
        public void fillPosteListBox(Bloc bloc)
        {

            listPoste.Items.Clear();
            
            List<RessourceEntree> ressources = bloc.getRessourceVoulus();

           // MessageBox.Show(bloc.getListRessourceAffecte().Count.ToString());

            for (int i = 0; i < ressources.Count(); i++)
            {
                if (ressources.ElementAt(i).voulue is Poste)
                {
                    // Add the employee name to the listbox.
                    listPoste.Items.Add(((Poste)ressources.ElementAt(i).voulue).getNom()+" ("+ressources.ElementAt(i).nbAffectee+"/"+ressources.ElementAt(i).nbVoulue+")");
                }

            }

        }

        void listPoste_MouseDoubleClick(object sender, MouseEventArgs e)
        {

            int index = this.listPoste.IndexFromPoint(e.Location);

            if (index != System.Windows.Forms.ListBox.NoMatches)
            {

                //MessageBox.Show(index.ToString());

                //do your stuff here

            }

        }
        public void fillEquipeListBox(Bloc bloc)
        {
            listEquipe.Items.Clear();
            List<Ressource> ressources = bloc.getListRessourceAffecte();

            // MessageBox.Show(bloc.getListRessourceAffecte().Count.ToString());

            for (int i = 0; i < ressources.Count(); i++)
            {
                if (ressources.ElementAt(i) is Equipe)
                {
                    // Add the employee name to the listbox.
                    listEquipe.Items.Add(((Equipe)ressources.ElementAt(i)).getNom());
                }

            }

        }
        void listEquipe_MouseDoubleClick(object sender, MouseEventArgs e)
        {

            int index = this.listEquipe.IndexFromPoint(e.Location);

            if (index != System.Windows.Forms.ListBox.NoMatches)
            {

                //MessageBox.Show(index.ToString());

                //do your stuff here

            }

        }
        public void fillPresetListBox()
        {
           // MessageBox.Show("Cockshit");
            listPreset.Items.Clear();
            List<Bloc> blocs = loader.bloc;
            for (int i = 0; i < blocs.Count(); i++)
            {
                //MessageBox.Show("Chat"+i);
                if (((Bloc)blocs.ElementAt(i)).getPreset())
                {
                    listPreset.Items.Add(((Bloc)blocs.ElementAt(i)).getId() + " " + ((Bloc)blocs.ElementAt(i)).getNom());
                    //MessageBox.Show(((Bloc)blocs.ElementAt(i)).getId() + " " + ((Bloc)blocs.ElementAt(i)).getNom());
                }
                else
                {
                    //MessageBox.Show(((Bloc)blocs.ElementAt(i)).getPreset().ToString());
                }
            }

        }
        void listPreset_MouseDoubleClick(object sender, MouseEventArgs e)
        {

            int index = this.listPreset.IndexFromPoint(e.Location);

            if (index != System.Windows.Forms.ListBox.NoMatches)
            {

                MessageBox.Show(index.ToString());

                //do your stuff here

            }

        }
        void clearList()
        {
            listEmploye.Items.Clear();
            listEquipe.Items.Clear();
            listPoste.Items.Clear();
            listPreset.Items.Clear();
        }

        void updateInterfaceHoraire()
        {
            resetTree(RessourceTree.Nodes[0].Nodes);
            resetTree(RessourceTree.Nodes[1].Nodes);
            resetTree(RessourceTree.Nodes[2].Nodes);
            fillPresetListBox();
            clearList();
            

            if (grille.selectionEnCours != null)
            {
                Bloc blocCourant = grille.selectionEnCours;
                Ressource ressource;
              //  MessageBox.Show("" + blocCourant.getListRessourceAffecte().Count);

                foreach (RessourceEntree ressources in blocCourant.getRessourceVoulus())
                {

                    String nom;
                    foreach (TreeNode nodes in RessourceTree.Nodes[1].Nodes)
                    {
                        nom = ((Poste)(ressources.voulue)).getNom();
                        //    MessageBox.Show(nom);
                        if (nom == nodes.Text)
                        {
                            nodes.BackColor = Color.Cyan;
                        }
                    }
                }
                for(int i=0;i<blocCourant.getListRessourceAffecte().Count;i++)
                {
                    
                    ressource = blocCourant.getListRessourceAffecte().ElementAt(i);
                    
                    if (ressource is Profil)
                    {

                        //MessageBox.Show("LOL1.5");

                       // MessageBox.Show(((Profil)ressource).getNom());

                        String nomPrenom;
                        foreach (TreeNode nodes in RessourceTree.Nodes[0].Nodes)
                        {
                            nomPrenom = ((Profil)ressource).getNom() + ", " + ((Profil)ressource).getPrenom();
                            //MessageBox.Show(nomPrenom+" "+nodes.Text);
                            
                            if (nomPrenom == nodes.Text)
                            {
                                nodes.BackColor = Color.Cyan;
                                break;
                               
                            }
                            
                        }

                    }

                    

                    if (ressource is Equipe)
                    {
                        String nom;
                        foreach (TreeNode nodes in RessourceTree.Nodes[2].Nodes)
                        {
                            nom = ((Equipe)ressource).getNom();
                         //   MessageBox.Show(nom);
                            if (nom == nodes.Text)
                            {
                                nodes.BackColor = Color.Cyan;
                            }
                        }
                    }

                }
            }
        }
        void resetTree(TreeNodeCollection tree)
        {
            foreach (TreeNode nodes in tree)
            {
                nodes.BackColor = Color.White; 
            }
        }
        
        private void button1_Click_1(object sender, EventArgs e)
        {
            if (profilSelected != null)
            dispoWindow = new SelectDispo(profilSelected);
            if (dispoWindow != null)
            {
                dispoWindow.ShowDialog();
            }
        }
        private void button_genere_Click(object sender, EventArgs e)
        {
            
            TabSchedule leTableSchedule = new TabSchedule();
            leTableSchedule.generate(loader.getBlocDeLaSemaine(getDebutSemaine().Subtract(new TimeSpan(1,0,0,0))),loader.profilCharge);
            grille.refresh();
        }
        public void generateEmployeList()
        {
            writer = new StreamWriter(file);
            TimeSpan time = new TimeSpan(24, 0, 0);
            List<Bloc> blocs = loader.getBlocDeLaSemaine(getDebutSemaine() - time);
            List<Ressource> profils = loader.profilCharge;
            

                foreach (Bloc bloc in blocs)
                {
                    writer.WriteLine("Bloc #" + bloc.getId());
                    writer.WriteLine("Début : " + bloc.getDebut());
                    writer.WriteLine("Fin : " +bloc.getFin());
                    writer.WriteLine("Employés qui travaillent durant ce quart");
                    writer.WriteLine("");
                    foreach (Ressource ressource in bloc.getListRessourceAffecte())
                    {
                      
                        if (ressource is Profil)
                        {
                            foreach (Ressource profil in profils)
                            {
                                if (ressource == profil)
                                {
                                    writer.WriteLine(((Profil)profil).getNom() + " " + ((Profil)profil).getPrenom());
                                }
                            }        
                        }
                    }
                    writer.WriteLine("");
                }

            
            writer.Close();
        }       

        [System.Runtime.InteropServices.DllImport("gdi32.dll")]
        public static extern long BitBlt(IntPtr hdcDest, int nXDest, int nYDest, int nWidth, int nHeight, IntPtr hdcSrc, int nXSrc, int nYSrc, int dwRop);
        private Bitmap memoryImage;
        private void CaptureScreen()
        {
            Graphics mygraphics = this.CreateGraphics();
            Size s = this.Size;
            memoryImage = new Bitmap(s.Width, s.Height, mygraphics);
            Graphics memoryGraphics = Graphics.FromImage(memoryImage);
            IntPtr dc1 = mygraphics.GetHdc();
            IntPtr dc2 = memoryGraphics.GetHdc();
            BitBlt(dc2, 0, 0, this.ClientRectangle.Width, this.ClientRectangle.Height, dc1, 250, 30, 13369376);
            mygraphics.ReleaseHdc(dc1);
            memoryGraphics.ReleaseHdc(dc2);
        }

        private void printDocument1_PrintPage(System.Object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(memoryImage, 0, 0);

        }
        private void PrintTextFileHandler(object sender, PrintPageEventArgs ppeArgs)
        {

            //Get the Graphics object
            Graphics g = ppeArgs.Graphics;
            float linesPerPage = 0;
            float yPos = 0;
            int count = 0;
            //Read margins from PrintPageEventArgs
            float leftMargin = ppeArgs.MarginBounds.Left;
            float topMargin = ppeArgs.MarginBounds.Top;
            string line = null;
            //Calculate the lines per page on the basis of the height of the page and the height of the font
            linesPerPage = ppeArgs.MarginBounds.Height /
            verdana10Font.GetHeight(g);
            //Now read lines one by one, using StreamReader
            while (count < linesPerPage && ((line = reader.ReadLine()) != null))
            {
                //Calculate the starting position
                yPos = topMargin + (count * verdana10Font.GetHeight(g));
                //Draw text
                g.DrawString(line, verdana10Font, Brushes.Black, leftMargin, yPos, new StringFormat());

                //Move to next line

                count++;

            }

            //If PrintPageEventArgs has more pages to print

            if (line != null)
            {

                ppeArgs.HasMorePages = true;

            }

            else
            {

                ppeArgs.HasMorePages = false;

            }

        }
        private void button_imprime_Click_1(object sender, EventArgs e)
        {
            CaptureScreen();
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            printDocument1.Print();
            //Create a StreamReader object
            generateEmployeList();
            reader = new StreamReader(file);
            //Create a Verdana font with size 10
            verdana10Font = new Font("Verdana", 10);
            //Create a PrintDocument object
            PrintDocument pd = new PrintDocument();
            //Add PrintPage event handler
            pd.PrintPage += new PrintPageEventHandler(this.PrintTextFileHandler);
            //Call Print Method
            pd.Print();
            //Close the reader

            if (reader != null)

                reader.Close();
        }

        private void button_exporter_Click(object sender, EventArgs e)
        {
            generateEmployeList();
        }

        private void clear_button_Click(object sender, EventArgs e)
        {
            restablishInterface();
        }

        

        


    }
} 