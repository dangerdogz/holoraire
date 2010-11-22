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
        Boolean test = true;
        AjouterPoste ajouterposte = new AjouterPoste();
        AjouterEquipe ajouterequipe = new AjouterEquipe();
        
        public HoraireBeta(Loader loader)
        {
            this.loader = loader;
            InitializeComponent();
            FillInterface();
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
                    if (grille.selectionEnCours != null)
                    {
                        fillEmployeListBox(grille.selectionEnCours);
                    }
                    break;
            }

            
        }

        private void pCentral_Horaire_DoubleClick(object sender, EventArgs e)
        {
           // MessageBox.Show(""+e.X);
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

        }

        private void popPostDelWindow()
        {

        }

        private void popPostWindow()
        {
            
            AjouterPoste ajouterposte = new AjouterPoste();
            ajouterposte.ShowDialog();
            loader.posteCharge.Add(new Poste(ajouterposte.getpName(), ajouterposte.getpDesc()));

            //MessageBox.Show(((Poste)loader.posteCharge.Last()).getNom());

            ajouterposte.save();
          //  MessageBox.Show(((Poste)loader.posteCharge.Last()).getNom());

            CreateXml.CreateProfileXml();
            ajouterposte.Dispose();
            Chilkat.Xml xmlPoste5 = new Chilkat.Xml();
            xmlPoste5.LoadXmlFile("postes.xml");
            Chilkat.Xml xmlPoste6 = new Chilkat.Xml();
            xmlPoste6.LoadXmlFile("postes.xml");
            treeView_postgen.Nodes.Clear();
            treeView_postaaffectgauche.Nodes.Clear();
            FillTree(treeView_postgen.Nodes, xmlPoste5);
            FillTree(treeView_postaaffectgauche.Nodes, xmlPoste6);
        }

        private void popEquipeWindow()
        {
            AjouterEquipe ajouterequipe = new AjouterEquipe();
            ajouterequipe.ShowDialog();
            loader.equipe.Add(new Equipe(-1, ajouterequipe.geteName(), ajouterequipe.geteDesc()));

            //MessageBox.Show(((Equipe)loader.equipe.Last()).getNom());

            ajouterequipe.save();
            //MessageBox.Show(((Profil)loader.equipe.Last()).getNom());

            CreateXml.CreateProfileXml();
            ajouterequipe.Dispose();
            Chilkat.Xml xmlEquipe5 = new Chilkat.Xml();
            xmlEquipe5.LoadXmlFile("teams.xml");
            treeView_equipe.Nodes.Clear();
            FillTree(treeView_equipe.Nodes, xmlEquipe5);
            
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
                xml = xml.FindNextRecord("nom", textInForm.ToLower() + "*");
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
        private void FillInterface()
        {
            CreateXml.CreateProfileXml();
            Chilkat.Xml xml = new Chilkat.Xml();
            Chilkat.Xml xmlProfiles = new Chilkat.Xml();
            Chilkat.Xml xmlPostes = new Chilkat.Xml();
            Chilkat.Xml xmlPostes2 = new Chilkat.Xml();
            Chilkat.Xml xmlPostes3 = new Chilkat.Xml();
            Chilkat.Xml xmlPostes4 = new Chilkat.Xml();
            Chilkat.Xml xmlTeams = new Chilkat.Xml();
            Chilkat.Xml xmlTeams2 = new Chilkat.Xml();
            xmlProfiles.LoadXmlFile("profiles.xml");
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
            Profil profil = new Profil(Convert.ToInt32(numemp_textbox.Text.ToString()) ,nom_textbox.Text, prenom_textbox.Text, courriel_textbox.Text, telephone_textbox.Text, 0);
            int nemploye = Convert.ToInt32(numemp_textbox.Text.ToString());
            for (int cul = 1; cul <= treeView_postechoisi.GetNodeCount(false); cul++)
            {
                int i = 0;
                while (treeView_postechoisi.GetNodeAt(1, (int)(cul * 15)).Text != ((Poste)(loader.posteCharge[i++])).getNom()) ;
                profil.setPoste((Poste)(loader.posteCharge[--i]));
                
            }

            

            loader.profilCharge.Add(profil);



            profil.save();
            numemp_textbox.Text = "";
            nom_textbox.Text = "";
            prenom_textbox.Text = "";
            courriel_textbox.Text = "";
            telephone_textbox.Text = "";
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
            if (res is Profil)
                bloc.addProfil((Profil)res);
            else
                if (res is Equipe)
                    bloc.addRessource((Equipe)res);
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



                        NbPoste input = new NbPoste(((Poste)res).getNom(), nb);
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
                xml = xml.FindNextRecord("nom", nom.ToLower() + "*");
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
        public void fillEmployeListBox(Bloc bloc)
        {
            listEmploye.Items.Clear();

            List<Ressource> ressources = bloc.getListRessourceAffecte();

          //  MessageBox.Show(bloc.getRessourceVoulus().Count.ToString());
            //MessageBox.Show(bloc.getListRessourceAffecte().Count.ToString());

            for (int i = 0; i < ressources.Count(); i++)
            {

                // Add the employee name to the listbox.
                listEmploye.Items.Add(((Profil)ressources.ElementAt(i)).getNom() + ", " + ((Profil)ressources.ElementAt(i)).getPrenom());


            }

            listEmploye.MouseDoubleClick += new MouseEventHandler(listEmploye_MouseDoubleClick);
        }
        void listEmploye_MouseDoubleClick(object sender, MouseEventArgs e)
        {

            int index = this.listEmploye.IndexFromPoint(e.Location);

            if (index != System.Windows.Forms.ListBox.NoMatches)
            {

                //MessageBox.Show(index.ToString());

                //do your stuff here

            }

        }
        public void fillPosteListBox(Bloc bloc)
        {

            
            listEmploye.Items.Clear();

            List<Ressource> ressources = bloc.getListRessourceAffecte();

           // MessageBox.Show(bloc.getListRessourceAffecte().Count.ToString());

            for (int i = 0; i < ressources.Count(); i++)
            {

                // Add the employee name to the listbox.
                listPoste.Items.Add(((Poste)ressources.ElementAt(i)).getNom());


            }

            listEmploye.MouseDoubleClick += new MouseEventHandler(listPoste_MouseDoubleClick);
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

       
        
    }
} 
           

          


            
