﻿using System.Windows.Forms;
using System.Drawing;
using System.Windows;
using System.Linq;
using System.Text;
using System.Data;
using System;
using System.Collections.Generic;
//using COCKFAGS;
namespace HoraireBeta
{
    partial class HoraireBeta
    {


        public event TreeNodeMouseClickEventHandler NodeMouseDoubleClick;

        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        public void InitializeComponent()
        {


            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("Employé");
            System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("Postes");
            System.Windows.Forms.TreeNode treeNode12 = new System.Windows.Forms.TreeNode("Équipes");

            this.Admin = new System.Windows.Forms.TabControl();
            this.horaire = new System.Windows.Forms.TabPage();
            this.panelCentral_Horaire = new System.Windows.Forms.Panel();
            this.tabConflits = new System.Windows.Forms.TabControl();
            this.tab_Conflits = new System.Windows.Forms.TabPage();
            this.text_Conflits = new System.Windows.Forms.RichTextBox();
            this.tabEmploye = new System.Windows.Forms.TabPage();
            this.listEmploye = new System.Windows.Forms.ListBox();
            this.tabPoste = new System.Windows.Forms.TabPage();
            this.listPoste = new System.Windows.Forms.ListBox();
            this.tabEquipe = new System.Windows.Forms.TabPage();
            this.listEquipe = new System.Windows.Forms.ListBox();
            this.panelGauche_Horaire = new System.Windows.Forms.Panel();
            this.Presets = new System.Windows.Forms.TabControl();
            this.tab_Presets = new System.Windows.Forms.TabPage();
            this.listPreset = new System.Windows.Forms.ListBox();
            this.tab_Ressources = new System.Windows.Forms.TabPage();
            this.RessourceTree = new System.Windows.Forms.TreeView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label_recherche = new System.Windows.Forms.Label();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.button_exporter = new System.Windows.Forms.Button();
            this.button_imprime = new System.Windows.Forms.Button();
            this.button_genere = new System.Windows.Forms.Button();
            this.employe = new System.Windows.Forms.TabPage();
            this.panelCentral_Employe = new System.Windows.Forms.Panel();
            this.treeView_postdispo = new System.Windows.Forms.TreeView();
            this.treeView_postechoisi = new System.Windows.Forms.TreeView();
            this.posteaoccuper_gauche = new System.Windows.Forms.Button();
            this.buttondroit = new System.Windows.Forms.Button();
            this.postchoisi_label = new System.Windows.Forms.Label();
            this.postedisp_label = new System.Windows.Forms.Label();
            this.postoccuper_label = new System.Windows.Forms.Label();
            this.Sauvegarder_button = new System.Windows.Forms.Button();
            this.button_Valider = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label_infoperss = new System.Windows.Forms.Label();
            this.telephone_textbox = new System.Windows.Forms.TextBox();
            this.courriel_textbox = new System.Windows.Forms.TextBox();
            this.prenom_textbox = new System.Windows.Forms.TextBox();
            this.nom_textbox = new System.Windows.Forms.TextBox();
            this.numemp_textbox = new System.Windows.Forms.TextBox();
            this.telephone_label = new System.Windows.Forms.Label();
            this.courriel_label = new System.Windows.Forms.Label();
            this.prenom_label = new System.Windows.Forms.Label();
            this.nom_label = new System.Windows.Forms.Label();
            this.nemp_label = new System.Windows.Forms.Label();
            this.infopers_label = new System.Windows.Forms.Label();
            this.ajprofemp_label = new System.Windows.Forms.Label();
            this.panelGauche_Employe = new System.Windows.Forms.Panel();
            this.modifier_button = new System.Windows.Forms.Button();
            this.ajouter_button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.parametre = new System.Windows.Forms.TabPage();
            this.panelCentral_Parametre = new System.Windows.Forms.Panel();
            this.label_partexte = new System.Windows.Forms.Label();
            this.textBox_graduation = new System.Windows.Forms.TextBox();
            this.textBox_quotasemaine = new System.Windows.Forms.TextBox();
            this.textBox_qtheurejou = new System.Windows.Forms.TextBox();
            this.label_graduation = new System.Windows.Forms.Label();
            this.label_quotasemaine = new System.Windows.Forms.Label();
            this.label_quotajour = new System.Windows.Forms.Label();
            this.label_horaire = new System.Windows.Forms.Label();
            this.label_heurest = new System.Windows.Forms.Label();
            this.panelGauche_Parametre = new System.Windows.Forms.Panel();
            this.button_ressource = new System.Windows.Forms.Button();
            this.button_presets = new System.Windows.Forms.Button();
            this.button_generaux = new System.Windows.Forms.Button();
            this.parametre_label = new System.Windows.Forms.Label();
            this.admin_table = new System.Windows.Forms.TabPage();
            this.admin_central = new System.Windows.Forms.Panel();
            this.resultDataGrid = new System.Windows.Forms.DataGridView();
            this.sqlTextBox = new System.Windows.Forms.TextBox();
            this.bouton_requete = new System.Windows.Forms.Button();
            this.bouton_connecter = new System.Windows.Forms.Button();
            this.admin_gauche = new System.Windows.Forms.Panel();
            this.supprimer_button = new System.Windows.Forms.Button();
            this.treeView_modemploye = new System.Windows.Forms.TreeView();
            this.label_postaffect = new System.Windows.Forms.Label();
            this.treeView_postaaffectgauche = new System.Windows.Forms.TreeView();
            this.treeView_postaaffectdroite = new System.Windows.Forms.TreeView();
            this.button_postaaffectgauche = new System.Windows.Forms.Button();
            this.button_postaaffectdroit = new System.Windows.Forms.Button();
            this.button_affecter = new System.Windows.Forms.Button();
            this.treeView_postspec2 = new System.Windows.Forms.TreeView();
            this.label_postspec = new System.Windows.Forms.Label();
            this.treeView_postspec = new System.Windows.Forms.TreeView();
            this.button_del_postspec = new System.Windows.Forms.Button();
            this.button_aj_postspec = new System.Windows.Forms.Button();
            this.label_equipes = new System.Windows.Forms.Label();
            this.treeView_equipe = new System.Windows.Forms.TreeView();
            this.button_del_equipe = new System.Windows.Forms.Button();
            this.button_aj_equipe = new System.Windows.Forms.Button();
            this.treeView_postgen = new System.Windows.Forms.TreeView();
            this.button_supprimer = new System.Windows.Forms.Button();
            this.button_ajouter_PG = new System.Windows.Forms.Button();
            this.label_postgeneral = new System.Windows.Forms.Label();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.clear_button = new System.Windows.Forms.Button();
            this.Admin.SuspendLayout();
            this.horaire.SuspendLayout();
            this.panelCentral_Horaire.SuspendLayout();
            this.tabConflits.SuspendLayout();
            this.tab_Conflits.SuspendLayout();
            this.tabEmploye.SuspendLayout();
            this.tabPoste.SuspendLayout();
            this.tabEquipe.SuspendLayout();
            this.panelGauche_Horaire.SuspendLayout();
            this.Presets.SuspendLayout();
            this.tab_Presets.SuspendLayout();
            this.tab_Ressources.SuspendLayout();
            this.employe.SuspendLayout();
            this.panelCentral_Employe.SuspendLayout();
            this.panelGauche_Employe.SuspendLayout();
            this.parametre.SuspendLayout();
            this.panelCentral_Parametre.SuspendLayout();
            this.panelGauche_Parametre.SuspendLayout();
            this.admin_table.SuspendLayout();
            this.admin_central.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.resultDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // Admin
            // 
            this.Admin.Appearance = System.Windows.Forms.TabAppearance.Buttons;
            this.Admin.Controls.Add(this.horaire);
            this.Admin.Controls.Add(this.employe);
            this.Admin.Controls.Add(this.parametre);
            this.Admin.Controls.Add(this.admin_table);
            this.Admin.Location = new System.Drawing.Point(0, 0);
            this.Admin.Name = "Admin";
            this.Admin.SelectedIndex = 0;
            this.Admin.Size = new System.Drawing.Size(1013, 736);
            this.Admin.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.Admin.TabIndex = 0;
            this.Admin.SelectedIndexChanged += new System.EventHandler(this.employe_Click);
            // 
            // horaire
            // 
            this.horaire.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.horaire.Controls.Add(this.panelCentral_Horaire);
            this.horaire.Controls.Add(this.panelGauche_Horaire);
            this.horaire.Location = new System.Drawing.Point(4, 25);
            this.horaire.Name = "horaire";
            this.horaire.Padding = new System.Windows.Forms.Padding(3);
            this.horaire.Size = new System.Drawing.Size(1005, 707);
            this.horaire.TabIndex = 0;
            this.horaire.Text = "Horaire";
            this.horaire.Click += new System.EventHandler(this.horaire_Click);
            // 
            // panelCentral_Horaire
            // 
            this.panelCentral_Horaire.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.panelCentral_Horaire.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.panelCentral_Horaire.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelCentral_Horaire.Controls.Add(this.tabConflits);
            this.panelCentral_Horaire.Location = new System.Drawing.Point(253, 7);
            this.panelCentral_Horaire.Name = "panelCentral_Horaire";
            this.panelCentral_Horaire.Size = new System.Drawing.Size(746, 694);
            this.panelCentral_Horaire.TabIndex = 1;
            this.panelCentral_Horaire.Paint += new System.Windows.Forms.PaintEventHandler(this.panelCentral_Horaire_Paint);
            this.panelCentral_Horaire.DoubleClick += new System.EventHandler(this.pCentral_Horaire_DoubleClick);
            this.panelCentral_Horaire.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pCentral_Horaire_OnMouseEvent);
            this.panelCentral_Horaire.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pCentral_Horaire_OnMouseDown);
            this.panelCentral_Horaire.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pCentral_Horaire_OnMouseEvent);
            this.panelCentral_Horaire.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pCentral_Horaire_OnMouseUp);
            // 
            // tabConflits
            // 
            this.tabConflits.Controls.Add(this.tab_Conflits);
            this.tabConflits.Controls.Add(this.tabEmploye);
            this.tabConflits.Controls.Add(this.tabPoste);
            this.tabConflits.Controls.Add(this.tabEquipe);
            this.tabConflits.Location = new System.Drawing.Point(291, 536);
            this.tabConflits.Name = "tabConflits";
            this.tabConflits.SelectedIndex = 0;
            this.tabConflits.Size = new System.Drawing.Size(450, 153);
            this.tabConflits.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabConflits.TabIndex = 0;
            // 
            // tab_Conflits
            // 
            this.tab_Conflits.Controls.Add(this.text_Conflits);
            this.tab_Conflits.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.tab_Conflits.Location = new System.Drawing.Point(4, 22);
            this.tab_Conflits.Name = "tab_Conflits";
            this.tab_Conflits.Padding = new System.Windows.Forms.Padding(3);
            this.tab_Conflits.Size = new System.Drawing.Size(442, 127);
            this.tab_Conflits.TabIndex = 0;
            this.tab_Conflits.Text = "Conflits";
            this.tab_Conflits.UseVisualStyleBackColor = true;
            // 
            // text_Conflits
            // 
            this.text_Conflits.Location = new System.Drawing.Point(3, 3);
            this.text_Conflits.Name = "text_Conflits";
            this.text_Conflits.Size = new System.Drawing.Size(455, 113);
            this.text_Conflits.TabIndex = 0;
            this.text_Conflits.Text = "";
            // 
            // tabEmploye
            // 
            profilSelected = new Profil();
            this.tabEmploye.Controls.Add(this.listEmploye);
            this.tabEmploye.Location = new System.Drawing.Point(4, 22);
            this.tabEmploye.Name = "tabEmploye";
            this.tabEmploye.Size = new System.Drawing.Size(442, 127);
            this.tabEmploye.TabIndex = 1;
            this.tabEmploye.Text = "Employés";
            this.tabEmploye.UseVisualStyleBackColor = true;

            // 
            // listEmploye
            // 
            this.listEmploye.FormattingEnabled = true;
            this.listEmploye.Location = new System.Drawing.Point(3, 5);
            this.listEmploye.Name = "listEmploye";
            this.listEmploye.Size = new System.Drawing.Size(439, 121);
            this.listEmploye.TabIndex = 0;
            this.listEmploye.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listEmploye_MouseDoubleClick);
            // 
            // tabPoste
            // 
            this.tabPoste.Controls.Add(this.listPoste);
            this.tabPoste.Location = new System.Drawing.Point(4, 22);
            this.tabPoste.Name = "tabPoste";
            this.tabPoste.Size = new System.Drawing.Size(442, 127);
            this.tabPoste.TabIndex = 2;
            this.tabPoste.Text = "Poste";
            this.tabPoste.UseVisualStyleBackColor = true;
            // 
            // listPoste
            // 
            this.listPoste.FormattingEnabled = true;
            this.listPoste.Location = new System.Drawing.Point(3, 5);
            this.listPoste.Name = "listPoste";
            this.listPoste.Size = new System.Drawing.Size(436, 121);
            this.listPoste.TabIndex = 0;
            this.listPoste.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listEmploye_MouseDoubleClick);
            // 
            // tabEquipe
            // 
            this.tabEquipe.Controls.Add(this.listEquipe);
            this.tabEquipe.Location = new System.Drawing.Point(4, 22);
            this.tabEquipe.Name = "tabEquipe";
            this.tabEquipe.Size = new System.Drawing.Size(442, 127);
            this.tabEquipe.TabIndex = 3;
            this.tabEquipe.Text = "Équipes";
            this.tabEquipe.UseVisualStyleBackColor = true;
            // 
            // listEquipe
            // 
            this.listEquipe.FormattingEnabled = true;
            this.listEquipe.Location = new System.Drawing.Point(0, 3);
            this.listEquipe.Name = "listEquipe";
            this.listEquipe.Size = new System.Drawing.Size(439, 121);
            this.listEquipe.TabIndex = 0;
            this.listEquipe.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listEmploye_MouseDoubleClick);
            // 
            // panelGauche_Horaire
            // 
            this.panelGauche_Horaire.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.panelGauche_Horaire.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelGauche_Horaire.Controls.Add(this.Presets);
            this.panelGauche_Horaire.Controls.Add(this.textBox1);
            this.panelGauche_Horaire.Controls.Add(this.label_recherche);
            this.panelGauche_Horaire.Controls.Add(this.monthCalendar1);
            this.panelGauche_Horaire.Controls.Add(this.button_exporter);
            this.panelGauche_Horaire.Controls.Add(this.button_imprime);
            this.panelGauche_Horaire.Controls.Add(this.button_genere);
            this.panelGauche_Horaire.Location = new System.Drawing.Point(7, 7);
            this.panelGauche_Horaire.Name = "panelGauche_Horaire";
            this.panelGauche_Horaire.Size = new System.Drawing.Size(240, 694);
            this.panelGauche_Horaire.TabIndex = 0;
            this.panelGauche_Horaire.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pGauche_Horaire_OnMouseEvent);
            this.panelGauche_Horaire.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pGauche_Horaire_OnMouseEvent);
            // 
            // Presets
            // 
            this.Presets.Controls.Add(this.tab_Presets);
            this.Presets.Controls.Add(this.tab_Ressources);
            this.Presets.ItemSize = new System.Drawing.Size(112, 18);
            this.Presets.Location = new System.Drawing.Point(6, 335);
            this.Presets.Name = "Presets";
            this.Presets.SelectedIndex = 0;
            this.Presets.Size = new System.Drawing.Size(229, 354);
            this.Presets.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.Presets.TabIndex = 6;
            // 
            // tab_Presets
            // 
            this.tab_Presets.Controls.Add(this.listPreset);
            this.tab_Presets.Location = new System.Drawing.Point(4, 22);
            this.tab_Presets.Name = "tab_Presets";
            this.tab_Presets.Padding = new System.Windows.Forms.Padding(3);
            this.tab_Presets.Size = new System.Drawing.Size(221, 328);
            this.tab_Presets.TabIndex = 0;
            this.tab_Presets.Text = "Presets";
            this.tab_Presets.UseVisualStyleBackColor = true;
            // 
            // listPreset
            // 
            this.listPreset.FormattingEnabled = true;
            this.listPreset.Location = new System.Drawing.Point(0, 2);
            this.listPreset.Name = "listPreset";
            this.listPreset.Size = new System.Drawing.Size(218, 316);
            this.listPreset.TabIndex = 0;
            this.listPreset.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listPreset_MouseDoubleClick);
            this.listPreset.MouseDown += new System.Windows.Forms.MouseEventHandler(this.listPreset_MouseDown);
            // 
            // tab_Ressources
            // 
            this.tab_Ressources.Controls.Add(this.RessourceTree);
            this.tab_Ressources.Location = new System.Drawing.Point(4, 22);
            this.tab_Ressources.Name = "tab_Ressources";
            this.tab_Ressources.Padding = new System.Windows.Forms.Padding(3);
            this.tab_Ressources.Size = new System.Drawing.Size(221, 328);
            this.tab_Ressources.TabIndex = 1;
            this.tab_Ressources.Text = "Ressources";
            this.tab_Ressources.UseVisualStyleBackColor = true;
            // 
            // RessourceTree
            // 
            this.RessourceTree.BackColor = System.Drawing.SystemColors.Window;
            this.RessourceTree.Location = new System.Drawing.Point(7, 6);
            this.RessourceTree.Name = "RessourceTree";

            treeNode10.Name = "Employe";
            treeNode10.Text = "Employé";
            treeNode11.Name = "Postes";
            treeNode11.Text = "Postes";
            treeNode12.Name = "Équipes";
            treeNode12.Text = "Équipes";


            this.RessourceTree.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {

            treeNode10,
            treeNode11,
            treeNode12});

            
            this.RessourceTree.Size = new System.Drawing.Size(208, 316);
            this.RessourceTree.TabIndex = 0;
            this.RessourceTree.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            this.RessourceTree.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.RessourceTree_NodeMouseDoubleClick);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(6, 305);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(227, 20);
            this.textBox1.TabIndex = 5;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label_recherche
            // 
            this.label_recherche.AutoSize = true;
            this.label_recherche.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_recherche.Location = new System.Drawing.Point(3, 285);
            this.label_recherche.Name = "label_recherche";
            this.label_recherche.Size = new System.Drawing.Size(77, 17);
            this.label_recherche.TabIndex = 4;
            this.label_recherche.Text = "Recherche";
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(6, 114);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 3;
            this.monthCalendar1.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateChanged);
            // 
            // button_exporter
            // 
            this.button_exporter.Location = new System.Drawing.Point(3, 73);
            this.button_exporter.Name = "button_exporter";
            this.button_exporter.Size = new System.Drawing.Size(230, 29);
            this.button_exporter.TabIndex = 2;
            this.button_exporter.Text = "Exporter";
            this.button_exporter.UseVisualStyleBackColor = true;
            this.button_exporter.Click += new System.EventHandler(this.button_exporter_Click);
            // 
            // button_imprime
            // 
            this.button_imprime.Location = new System.Drawing.Point(3, 38);
            this.button_imprime.Name = "button_imprime";
            this.button_imprime.Size = new System.Drawing.Size(230, 29);
            this.button_imprime.TabIndex = 1;
            this.button_imprime.Text = "Imprimer";
            this.button_imprime.UseVisualStyleBackColor = true;
            this.button_imprime.Click += new System.EventHandler(this.button_imprime_Click_1);
            // 
            // button_genere
            // 
            this.button_genere.Location = new System.Drawing.Point(3, 3);
            this.button_genere.Name = "button_genere";
            this.button_genere.Size = new System.Drawing.Size(230, 29);
            this.button_genere.TabIndex = 0;
            this.button_genere.Text = "PlayBall";
            this.button_genere.UseVisualStyleBackColor = true;
            this.button_genere.Click += new System.EventHandler(this.button_genere_Click);
            // 
            // employe
            // 
            this.employe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.employe.Controls.Add(this.panelCentral_Employe);
            this.employe.Controls.Add(this.panelGauche_Employe);
            this.employe.Location = new System.Drawing.Point(4, 25);
            this.employe.Name = "employe";
            this.employe.Padding = new System.Windows.Forms.Padding(3);
            this.employe.Size = new System.Drawing.Size(1005, 707);
            this.employe.TabIndex = 1;
            this.employe.Text = "Employé";
            this.employe.Click += new System.EventHandler(this.employe_Click);
            // 
            // panelCentral_Employe
            // 
            this.panelCentral_Employe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.panelCentral_Employe.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            //this.panelCentral_Employe.Controls.Add(this.clear_button);
            this.panelCentral_Employe.Controls.Add(this.treeView_postdispo);
            this.panelCentral_Employe.Controls.Add(this.treeView_postechoisi);
            this.panelCentral_Employe.Controls.Add(this.posteaoccuper_gauche);
            this.panelCentral_Employe.Controls.Add(this.buttondroit);
            this.panelCentral_Employe.Controls.Add(this.postchoisi_label);
            this.panelCentral_Employe.Controls.Add(this.postedisp_label);
            this.panelCentral_Employe.Controls.Add(this.postoccuper_label);
            this.panelCentral_Employe.Controls.Add(this.Sauvegarder_button);
            this.panelCentral_Employe.Controls.Add(this.button_Valider);
            this.panelCentral_Employe.Controls.Add(this.richTextBox1);
            this.panelCentral_Employe.Controls.Add(this.button1);
            this.panelCentral_Employe.Controls.Add(this.label2);
            this.panelCentral_Employe.Controls.Add(this.label_infoperss);
            this.panelCentral_Employe.Controls.Add(this.telephone_textbox);
            this.panelCentral_Employe.Controls.Add(this.courriel_textbox);
            this.panelCentral_Employe.Controls.Add(this.prenom_textbox);
            this.panelCentral_Employe.Controls.Add(this.nom_textbox);
            this.panelCentral_Employe.Controls.Add(this.numemp_textbox);
            this.panelCentral_Employe.Controls.Add(this.telephone_label);
            this.panelCentral_Employe.Controls.Add(this.courriel_label);
            this.panelCentral_Employe.Controls.Add(this.prenom_label);
            this.panelCentral_Employe.Controls.Add(this.nom_label);
            this.panelCentral_Employe.Controls.Add(this.nemp_label);
            this.panelCentral_Employe.Controls.Add(this.infopers_label);
            this.panelCentral_Employe.Controls.Add(this.ajprofemp_label);
            this.panelCentral_Employe.Location = new System.Drawing.Point(253, 7);
            this.panelCentral_Employe.Name = "panelCentral_Employe";
            this.panelCentral_Employe.Size = new System.Drawing.Size(746, 694);
            this.panelCentral_Employe.TabIndex = 3;
            this.panelCentral_Employe.Paint += new System.Windows.Forms.PaintEventHandler(this.pCentral_Employe_Paint);
            this.panelCentral_Employe.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pCentral_Employe_OnMouseEvent);
            this.panelCentral_Employe.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pCentral_Employe_OnMouseEvent);
            // 
            // treeView_postdispo
            // 
            this.treeView_postdispo.Location = new System.Drawing.Point(373, 329);
            this.treeView_postdispo.Name = "treeView_postdispo";
            this.treeView_postdispo.Size = new System.Drawing.Size(161, 264);
            this.treeView_postdispo.TabIndex = 25;
            // 
            // treeView_postechoisi
            // 
            this.treeView_postechoisi.Location = new System.Drawing.Point(580, 329);
            this.treeView_postechoisi.Name = "treeView_postechoisi";
            this.treeView_postechoisi.Size = new System.Drawing.Size(161, 264);
            this.treeView_postechoisi.TabIndex = 24;
            // 
            // posteaoccuper_gauche
            // 
            this.posteaoccuper_gauche.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.posteaoccuper_gauche.Location = new System.Drawing.Point(542, 452);
            this.posteaoccuper_gauche.Name = "posteaoccuper_gauche";
            this.posteaoccuper_gauche.Size = new System.Drawing.Size(32, 32);
            this.posteaoccuper_gauche.TabIndex = 22;
            this.posteaoccuper_gauche.Text = "<";
            this.posteaoccuper_gauche.UseVisualStyleBackColor = true;
            this.posteaoccuper_gauche.Click += new System.EventHandler(this.posteaoccuper_gauche_Click);
            // 
            // buttondroit
            // 
            this.buttondroit.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttondroit.Location = new System.Drawing.Point(542, 414);
            this.buttondroit.Name = "buttondroit";
            this.buttondroit.Size = new System.Drawing.Size(32, 32);
            this.buttondroit.TabIndex = 21;
            this.buttondroit.Text = ">";
            this.buttondroit.UseVisualStyleBackColor = true;
            this.buttondroit.Click += new System.EventHandler(this.buttondroit_Click);
            // 
            // postchoisi_label
            // 
            this.postchoisi_label.AutoSize = true;
            this.postchoisi_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.postchoisi_label.Location = new System.Drawing.Point(615, 302);
            this.postchoisi_label.Name = "postchoisi_label";
            this.postchoisi_label.Size = new System.Drawing.Size(85, 15);
            this.postchoisi_label.TabIndex = 20;
            this.postchoisi_label.Text = "Postes choisis";
            // 
            // postedisp_label
            // 
            this.postedisp_label.AutoSize = true;
            this.postedisp_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.postedisp_label.Location = new System.Drawing.Point(400, 302);
            this.postedisp_label.Name = "postedisp_label";
            this.postedisp_label.Size = new System.Drawing.Size(110, 15);
            this.postedisp_label.TabIndex = 19;
            this.postedisp_label.Text = "Postes disponibles";
            // 
            // postoccuper_label
            // 
            this.postoccuper_label.AutoSize = true;
            this.postoccuper_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.postoccuper_label.Location = new System.Drawing.Point(495, 257);
            this.postoccuper_label.Name = "postoccuper_label";
            this.postoccuper_label.Size = new System.Drawing.Size(118, 17);
            this.postoccuper_label.TabIndex = 18;
            this.postoccuper_label.Text = "Postes à occuper";
            // 
            // Sauvegarder_button
            // 
            this.Sauvegarder_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Sauvegarder_button.Location = new System.Drawing.Point(169, 645);
            this.Sauvegarder_button.Name = "Sauvegarder_button";
            this.Sauvegarder_button.Size = new System.Drawing.Size(151, 31);
            this.Sauvegarder_button.TabIndex = 17;
            this.Sauvegarder_button.Text = "Sauvegarder";
            this.Sauvegarder_button.UseVisualStyleBackColor = true;
            this.Sauvegarder_button.Click += new System.EventHandler(this.Sauvegarder_button_Click);
            // 
            // button_Valider
            // 
            this.button_Valider.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Valider.Location = new System.Drawing.Point(10, 645);
            this.button_Valider.Name = "button_Valider";
            this.button_Valider.Size = new System.Drawing.Size(151, 31);
            this.button_Valider.TabIndex = 16;
            this.button_Valider.Text = "Valider";
            this.button_Valider.UseVisualStyleBackColor = true;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(11, 329);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(309, 264);
            this.richTextBox1.TabIndex = 15;
            this.richTextBox1.Text = "";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(45, 277);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(240, 34);
            this.button1.TabIndex = 14;
            this.button1.Text = "Modifier les plages de disponibilité";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(124, 257);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 17);
            this.label2.TabIndex = 13;
            this.label2.Text = "Disponibilité";
            // 
            // label_infoperss
            // 
            this.label_infoperss.AutoSize = true;
            this.label_infoperss.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_infoperss.Location = new System.Drawing.Point(7, 228);
            this.label_infoperss.Name = "label_infoperss";
            this.label_infoperss.Size = new System.Drawing.Size(218, 20);
            this.label_infoperss.TabIndex = 12;
            this.label_infoperss.Text = "Informations Professionnelles";
            // 
            // telephone_textbox
            // 
            this.telephone_textbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.telephone_textbox.Location = new System.Drawing.Point(95, 184);
            this.telephone_textbox.Name = "telephone_textbox";
            this.telephone_textbox.Size = new System.Drawing.Size(268, 21);
            this.telephone_textbox.TabIndex = 11;
            this.telephone_textbox.TextChanged += new System.EventHandler(this.telephone_textbox_TextChanged);
            // 
            // courriel_textbox
            // 
            this.courriel_textbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.courriel_textbox.Location = new System.Drawing.Point(80, 158);
            this.courriel_textbox.Name = "courriel_textbox";
            this.courriel_textbox.Size = new System.Drawing.Size(283, 21);
            this.courriel_textbox.TabIndex = 10;
            this.courriel_textbox.TextChanged += new System.EventHandler(this.courriel_textbox_TextChanged);
            // 
            // prenom_textbox
            // 
            this.prenom_textbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prenom_textbox.Location = new System.Drawing.Point(80, 129);
            this.prenom_textbox.Name = "prenom_textbox";
            this.prenom_textbox.Size = new System.Drawing.Size(284, 21);
            this.prenom_textbox.TabIndex = 9;
            this.prenom_textbox.TextChanged += new System.EventHandler(this.prenom_textbox_TextChanged);
            // 
            // nom_textbox
            // 
            this.nom_textbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nom_textbox.Location = new System.Drawing.Point(64, 104);
            this.nom_textbox.Name = "nom_textbox";
            this.nom_textbox.Size = new System.Drawing.Size(300, 21);
            this.nom_textbox.TabIndex = 8;
            this.nom_textbox.TextChanged += new System.EventHandler(this.nom_textbox_TextChanged);
            // 
            // numemp_textbox
            // 
            this.numemp_textbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numemp_textbox.Location = new System.Drawing.Point(155, 77);
            this.numemp_textbox.Name = "numemp_textbox";
            this.numemp_textbox.Size = new System.Drawing.Size(209, 21);
            this.numemp_textbox.TabIndex = 7;
            this.numemp_textbox.TextChanged += new System.EventHandler(this.numemp_textbox_TextChanged);
            // 
            // telephone_label
            // 
            this.telephone_label.AutoSize = true;
            this.telephone_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.telephone_label.Location = new System.Drawing.Point(8, 183);
            this.telephone_label.Name = "telephone_label";
            this.telephone_label.Size = new System.Drawing.Size(89, 18);
            this.telephone_label.TabIndex = 6;
            this.telephone_label.Text = "Téléphone : ";
            // 
            // courriel_label
            // 
            this.courriel_label.AutoSize = true;
            this.courriel_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.courriel_label.Location = new System.Drawing.Point(8, 156);
            this.courriel_label.Name = "courriel_label";
            this.courriel_label.Size = new System.Drawing.Size(72, 18);
            this.courriel_label.TabIndex = 5;
            this.courriel_label.Text = "Courriel : ";
            // 
            // prenom_label
            // 
            this.prenom_label.AutoSize = true;
            this.prenom_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prenom_label.Location = new System.Drawing.Point(7, 128);
            this.prenom_label.Name = "prenom_label";
            this.prenom_label.Size = new System.Drawing.Size(73, 18);
            this.prenom_label.TabIndex = 4;
            this.prenom_label.Text = "Prenom : ";
            // 
            // nom_label
            // 
            this.nom_label.AutoSize = true;
            this.nom_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nom_label.Location = new System.Drawing.Point(7, 104);
            this.nom_label.Name = "nom_label";
            this.nom_label.Size = new System.Drawing.Size(53, 18);
            this.nom_label.TabIndex = 3;
            this.nom_label.Text = "Nom : ";
            // 
            // nemp_label
            // 
            this.nemp_label.AutoSize = true;
            this.nemp_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nemp_label.Location = new System.Drawing.Point(4, 76);
            this.nemp_label.Name = "nemp_label";
            this.nemp_label.Size = new System.Drawing.Size(145, 18);
            this.nemp_label.TabIndex = 2;
            this.nemp_label.Text = "Numéro d\'employé : ";
            // 
            // infopers_label
            // 
            this.infopers_label.AutoSize = true;
            this.infopers_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.infopers_label.Location = new System.Drawing.Point(3, 38);
            this.infopers_label.Name = "infopers_label";
            this.infopers_label.Size = new System.Drawing.Size(193, 20);
            this.infopers_label.TabIndex = 1;
            this.infopers_label.Text = "Informations Personnelles";
            // 
            // ajprofemp_label
            // 
            this.ajprofemp_label.AutoSize = true;
            this.ajprofemp_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ajprofemp_label.Location = new System.Drawing.Point(217, 10);
            this.ajprofemp_label.Name = "ajprofemp_label";
            this.ajprofemp_label.Size = new System.Drawing.Size(222, 22);
            this.ajprofemp_label.TabIndex = 0;
            this.ajprofemp_label.Text = "Ajouter un profil d\'employé";
            // 
            // panelGauche_Employe
            // 
            this.panelGauche_Employe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.panelGauche_Employe.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelGauche_Employe.Controls.Add(this.modifier_button);
            this.panelGauche_Employe.Controls.Add(this.ajouter_button);
            this.panelGauche_Employe.Controls.Add(this.label1);
            this.panelGauche_Employe.Location = new System.Drawing.Point(8, 8);
            this.panelGauche_Employe.Name = "panelGauche_Employe";
            this.panelGauche_Employe.Size = new System.Drawing.Size(240, 694);
            this.panelGauche_Employe.TabIndex = 2;
            this.panelGauche_Employe.Paint += new System.Windows.Forms.PaintEventHandler(this.pGauche_Employe_Paint);
            this.panelGauche_Employe.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pGauche_Employe_OnMouseEvent);
            this.panelGauche_Employe.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pGauche_Employe_OnMouseEvent);
            // 
            // modifier_button
            // 
            this.modifier_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modifier_button.Location = new System.Drawing.Point(3, 75);
            this.modifier_button.Name = "modifier_button";
            this.modifier_button.Size = new System.Drawing.Size(232, 32);
            this.modifier_button.TabIndex = 2;
            this.modifier_button.Text = "Modifier";
            this.modifier_button.UseVisualStyleBackColor = true;
            this.modifier_button.Click += new System.EventHandler(this.modifier_button_Click);
            // 
            // ajouter_button
            // 
            this.ajouter_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ajouter_button.Location = new System.Drawing.Point(3, 37);
            this.ajouter_button.Name = "ajouter_button";
            this.ajouter_button.Size = new System.Drawing.Size(232, 32);
            this.ajouter_button.TabIndex = 1;
            this.ajouter_button.Text = "Ajouter";
            this.ajouter_button.UseVisualStyleBackColor = true;
            this.ajouter_button.Click += new System.EventHandler(this.ajouter_button_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(68, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Employé";
            // 
            // parametre
            // 
            this.parametre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.parametre.Controls.Add(this.panelCentral_Parametre);
            this.parametre.Controls.Add(this.panelGauche_Parametre);
            this.parametre.Location = new System.Drawing.Point(4, 25);
            this.parametre.Name = "parametre";
            this.parametre.Padding = new System.Windows.Forms.Padding(3);
            this.parametre.Size = new System.Drawing.Size(1005, 707);
            this.parametre.TabIndex = 2;
            this.parametre.Text = "Paramètre";
            // 
            // panelCentral_Parametre
            // 
            this.panelCentral_Parametre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.panelCentral_Parametre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelCentral_Parametre.Controls.Add(this.label_partexte);
            this.panelCentral_Parametre.Controls.Add(this.textBox_graduation);
            this.panelCentral_Parametre.Controls.Add(this.textBox_quotasemaine);
            this.panelCentral_Parametre.Controls.Add(this.textBox_qtheurejou);
            this.panelCentral_Parametre.Controls.Add(this.label_graduation);
            this.panelCentral_Parametre.Controls.Add(this.label_quotasemaine);
            this.panelCentral_Parametre.Controls.Add(this.label_quotajour);
            this.panelCentral_Parametre.Controls.Add(this.label_horaire);
            this.panelCentral_Parametre.Controls.Add(this.label_heurest);
            this.panelCentral_Parametre.Location = new System.Drawing.Point(253, 7);
            this.panelCentral_Parametre.Name = "panelCentral_Parametre";
            this.panelCentral_Parametre.Size = new System.Drawing.Size(746, 694);
            this.panelCentral_Parametre.TabIndex = 3;
            this.panelCentral_Parametre.Paint += new System.Windows.Forms.PaintEventHandler(this.parametre_Paint);
            this.panelCentral_Parametre.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pCentral_Parametre_OnMouseEvent);
            this.panelCentral_Parametre.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pCentral_Parametre_OnMouseEvent);
            // 
            // label_partexte
            // 
            this.label_partexte.AutoSize = true;
            this.label_partexte.Location = new System.Drawing.Point(17, 166);
            this.label_partexte.Name = "label_partexte";
            this.label_partexte.Size = new System.Drawing.Size(285, 13);
            this.label_partexte.TabIndex = 8;
            this.label_partexte.Text = "* L\'espace restant est disponible pour de futurs paramètres.";
            // 
            // textBox_graduation
            // 
            this.textBox_graduation.Location = new System.Drawing.Point(204, 130);
            this.textBox_graduation.Name = "textBox_graduation";
            this.textBox_graduation.Size = new System.Drawing.Size(261, 20);
            this.textBox_graduation.TabIndex = 7;
            // 
            // textBox_quotasemaine
            // 
            this.textBox_quotasemaine.Location = new System.Drawing.Point(220, 59);
            this.textBox_quotasemaine.Name = "textBox_quotasemaine";
            this.textBox_quotasemaine.Size = new System.Drawing.Size(245, 20);
            this.textBox_quotasemaine.TabIndex = 6;
            // 
            // textBox_qtheurejou
            // 
            this.textBox_qtheurejou.Location = new System.Drawing.Point(197, 33);
            this.textBox_qtheurejou.Name = "textBox_qtheurejou";
            this.textBox_qtheurejou.Size = new System.Drawing.Size(269, 20);
            this.textBox_qtheurejou.TabIndex = 5;
            // 
            // label_graduation
            // 
            this.label_graduation.AutoSize = true;
            this.label_graduation.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_graduation.Location = new System.Drawing.Point(46, 130);
            this.label_graduation.Name = "label_graduation";
            this.label_graduation.Size = new System.Drawing.Size(156, 15);
            this.label_graduation.TabIndex = 4;
            this.label_graduation.Text = "Graduation d\'une journée : ";
            // 
            // label_quotasemaine
            // 
            this.label_quotasemaine.AutoSize = true;
            this.label_quotasemaine.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_quotasemaine.Location = new System.Drawing.Point(46, 56);
            this.label_quotasemaine.Name = "label_quotasemaine";
            this.label_quotasemaine.Size = new System.Drawing.Size(172, 15);
            this.label_quotasemaine.TabIndex = 3;
            this.label_quotasemaine.Text = "Quota d\'heures par semaine : ";
            // 
            // label_quotajour
            // 
            this.label_quotajour.AutoSize = true;
            this.label_quotajour.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_quotajour.Location = new System.Drawing.Point(46, 32);
            this.label_quotajour.Name = "label_quotajour";
            this.label_quotajour.Size = new System.Drawing.Size(145, 15);
            this.label_quotajour.TabIndex = 2;
            this.label_quotajour.Text = "Quota d\'heures par jour : ";
            // 
            // label_horaire
            // 
            this.label_horaire.AutoSize = true;
            this.label_horaire.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_horaire.Location = new System.Drawing.Point(9, 103);
            this.label_horaire.Name = "label_horaire";
            this.label_horaire.Size = new System.Drawing.Size(57, 18);
            this.label_horaire.TabIndex = 1;
            this.label_horaire.Text = "Horaire\r\n";
            // 
            // label_heurest
            // 
            this.label_heurest.AutoSize = true;
            this.label_heurest.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_heurest.Location = new System.Drawing.Point(9, 10);
            this.label_heurest.Name = "label_heurest";
            this.label_heurest.Size = new System.Drawing.Size(118, 18);
            this.label_heurest.TabIndex = 0;
            this.label_heurest.Text = "Heures de travail";
            // 
            // panelGauche_Parametre
            // 
            this.panelGauche_Parametre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.panelGauche_Parametre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelGauche_Parametre.Controls.Add(this.button_ressource);
            this.panelGauche_Parametre.Controls.Add(this.button_presets);
            this.panelGauche_Parametre.Controls.Add(this.button_generaux);
            this.panelGauche_Parametre.Controls.Add(this.parametre_label);
            this.panelGauche_Parametre.Location = new System.Drawing.Point(8, 8);
            this.panelGauche_Parametre.Name = "panelGauche_Parametre";
            this.panelGauche_Parametre.Size = new System.Drawing.Size(240, 694);
            this.panelGauche_Parametre.TabIndex = 2;
            this.panelGauche_Parametre.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pGauche_Parametre_OnMouseEvent);
            this.panelGauche_Parametre.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pGauche_Parametre_OnMouseEvent);
            // 
            // button_ressource
            // 
            this.button_ressource.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_ressource.Location = new System.Drawing.Point(3, 67);
            this.button_ressource.Name = "button_ressource";
            this.button_ressource.Size = new System.Drawing.Size(232, 29);
            this.button_ressource.TabIndex = 3;
            this.button_ressource.Text = "Ressources";
            this.button_ressource.UseVisualStyleBackColor = true;
            this.button_ressource.Click += new System.EventHandler(this.button_ressource_Click);
            // 
            // button_presets
            // 
            this.button_presets.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_presets.Location = new System.Drawing.Point(3, 102);
            this.button_presets.Name = "button_presets";
            this.button_presets.Size = new System.Drawing.Size(232, 29);
            this.button_presets.TabIndex = 2;
            this.button_presets.Text = "Presets";
            this.button_presets.UseVisualStyleBackColor = true;
            // 
            // button_generaux
            // 
            this.button_generaux.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_generaux.Location = new System.Drawing.Point(3, 32);
            this.button_generaux.Name = "button_generaux";
            this.button_generaux.Size = new System.Drawing.Size(232, 29);
            this.button_generaux.TabIndex = 1;
            this.button_generaux.Text = "Généraux";
            this.button_generaux.UseVisualStyleBackColor = true;
            this.button_generaux.Click += new System.EventHandler(this.button_generaux_Click);
            // 
            // parametre_label
            // 
            this.parametre_label.AutoSize = true;
            this.parametre_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.parametre_label.Location = new System.Drawing.Point(77, 9);
            this.parametre_label.Name = "parametre_label";
            this.parametre_label.Size = new System.Drawing.Size(91, 20);
            this.parametre_label.TabIndex = 0;
            this.parametre_label.Text = "Paramètres";
            // 
            // admin_table
            // 
            this.admin_table.BackColor = System.Drawing.Color.Green;
            this.admin_table.Controls.Add(this.admin_central);
            this.admin_table.Controls.Add(this.admin_gauche);
            this.admin_table.Location = new System.Drawing.Point(4, 25);
            this.admin_table.Name = "admin_table";
            this.admin_table.Padding = new System.Windows.Forms.Padding(3);
            this.admin_table.Size = new System.Drawing.Size(1005, 707);
            this.admin_table.TabIndex = 3;
            this.admin_table.Text = "Admin";
            // 
            // admin_central
            // 
            this.admin_central.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.admin_central.Controls.Add(this.resultDataGrid);
            this.admin_central.Controls.Add(this.sqlTextBox);
            this.admin_central.Controls.Add(this.bouton_requete);
            this.admin_central.Controls.Add(this.bouton_connecter);
            this.admin_central.Location = new System.Drawing.Point(253, 7);
            this.admin_central.Name = "admin_central";
            this.admin_central.Size = new System.Drawing.Size(746, 694);
            this.admin_central.TabIndex = 1;
            this.admin_central.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // resultDataGrid
            // 
            this.resultDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.resultDataGrid.Location = new System.Drawing.Point(223, 145);
            this.resultDataGrid.Name = "resultDataGrid";
            this.resultDataGrid.Size = new System.Drawing.Size(215, 144);
            this.resultDataGrid.TabIndex = 7;
            this.resultDataGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.resultDataGrid_CellContentClick);
            // 
            // sqlTextBox
            // 
            this.sqlTextBox.Location = new System.Drawing.Point(223, 308);
            this.sqlTextBox.Name = "sqlTextBox";
            this.sqlTextBox.Size = new System.Drawing.Size(215, 20);
            this.sqlTextBox.TabIndex = 6;
            this.sqlTextBox.TextChanged += new System.EventHandler(this.sqlTextBox_TextChanged);
            // 
            // bouton_requete
            // 
            this.bouton_requete.Location = new System.Drawing.Point(387, 346);
            this.bouton_requete.Name = "bouton_requete";
            this.bouton_requete.Size = new System.Drawing.Size(75, 23);
            this.bouton_requete.TabIndex = 5;
            this.bouton_requete.Text = "requete";
            this.bouton_requete.UseVisualStyleBackColor = true;
            this.bouton_requete.Click += new System.EventHandler(this.button2_Click);
            // 
            // bouton_connecter
            // 
            this.bouton_connecter.Location = new System.Drawing.Point(202, 346);
            this.bouton_connecter.Name = "bouton_connecter";
            this.bouton_connecter.Size = new System.Drawing.Size(75, 23);
            this.bouton_connecter.TabIndex = 4;
            this.bouton_connecter.Text = "connecter";
            this.bouton_connecter.UseVisualStyleBackColor = true;
            this.bouton_connecter.Click += new System.EventHandler(this.button1_Click);
            // 
            // admin_gauche
            // 
            this.admin_gauche.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.admin_gauche.Location = new System.Drawing.Point(8, 7);
            this.admin_gauche.Name = "admin_gauche";
            this.admin_gauche.Size = new System.Drawing.Size(240, 694);
            this.admin_gauche.TabIndex = 0;
            // 
            // supprimer_button
            // 
            this.supprimer_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.supprimer_button.Location = new System.Drawing.Point(618, 599);
            this.supprimer_button.Name = "supprimer_button";
            this.supprimer_button.Size = new System.Drawing.Size(120, 32);
            this.supprimer_button.TabIndex = 3;
            this.supprimer_button.Text = "Supprimer";
            this.supprimer_button.UseVisualStyleBackColor = true;
            this.supprimer_button.Click += new System.EventHandler(this.supprimer_button_Click);
            // 
            // treeView_modemploye
            // 
            this.treeView_modemploye.LineColor = System.Drawing.Color.Empty;
            this.treeView_modemploye.Location = new System.Drawing.Point(3, 113);
            this.treeView_modemploye.Name = "treeView_modemploye";
            this.treeView_modemploye.Size = new System.Drawing.Size(232, 217);
            this.treeView_modemploye.TabIndex = 3;
            this.treeView_modemploye.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView_modemploye_AfterSelect);
            // 
            // label_postaffect
            // 
            this.label_postaffect.AutoSize = true;
            this.label_postaffect.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_postaffect.Location = new System.Drawing.Point(460, 400);
            this.label_postaffect.Name = "label_postaffect";
            this.label_postaffect.Size = new System.Drawing.Size(130, 20);
            this.label_postaffect.TabIndex = 30;
            this.label_postaffect.Text = "Postes à affecter";
            // 
            // treeView_postaaffectgauche
            // 
            this.treeView_postaaffectgauche.LineColor = System.Drawing.Color.Empty;
            this.treeView_postaaffectgauche.Location = new System.Drawing.Point(308, 430);
            this.treeView_postaaffectgauche.Name = "treeView_postaaffectgauche";
            this.treeView_postaaffectgauche.Size = new System.Drawing.Size(192, 259);
            this.treeView_postaaffectgauche.TabIndex = 29;
            // 
            // treeView_postaaffectdroite
            // 
            this.treeView_postaaffectdroite.LineColor = System.Drawing.Color.Empty;
            this.treeView_postaaffectdroite.Location = new System.Drawing.Point(544, 430);
            this.treeView_postaaffectdroite.Name = "treeView_postaaffectdroite";
            this.treeView_postaaffectdroite.Size = new System.Drawing.Size(192, 259);
            this.treeView_postaaffectdroite.TabIndex = 28;
            // 
            // button_postaaffectgauche
            // 
            this.button_postaaffectgauche.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_postaaffectgauche.Location = new System.Drawing.Point(506, 557);
            this.button_postaaffectgauche.Name = "button_postaaffectgauche";
            this.button_postaaffectgauche.Size = new System.Drawing.Size(32, 32);
            this.button_postaaffectgauche.TabIndex = 27;
            this.button_postaaffectgauche.Text = "<";
            this.button_postaaffectgauche.UseVisualStyleBackColor = true;
            this.button_postaaffectgauche.Click += new System.EventHandler(this.postaaffectgauche_Click);
            // 
            // button_postaaffectdroit
            // 
            this.button_postaaffectdroit.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_postaaffectdroit.Location = new System.Drawing.Point(506, 519);
            this.button_postaaffectdroit.Name = "button_postaaffectdroit";
            this.button_postaaffectdroit.Size = new System.Drawing.Size(32, 32);
            this.button_postaaffectdroit.TabIndex = 26;
            this.button_postaaffectdroit.Text = ">";
            this.button_postaaffectdroit.UseVisualStyleBackColor = true;
            this.button_postaaffectdroit.Click += new System.EventHandler(this.postaaffectdroit_Click);
            // 
            // button_affecter
            // 
            this.button_affecter.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_affecter.Location = new System.Drawing.Point(571, 38);
            this.button_affecter.Name = "button_affecter";
            this.button_affecter.Size = new System.Drawing.Size(112, 34);
            this.button_affecter.TabIndex = 13;
            this.button_affecter.Text = "Affecter";
            this.button_affecter.UseVisualStyleBackColor = true;
            // 
            // treeView_postspec2
            // 
            this.treeView_postspec2.LineColor = System.Drawing.Color.Empty;
            this.treeView_postspec2.Location = new System.Drawing.Point(506, 75);
            this.treeView_postspec2.Name = "treeView_postspec2";
            this.treeView_postspec2.Size = new System.Drawing.Size(230, 259);
            this.treeView_postspec2.TabIndex = 12;
            // 
            // label_postspec
            // 
            this.label_postspec.AutoSize = true;
            this.label_postspec.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_postspec.Location = new System.Drawing.Point(448, 15);
            this.label_postspec.Name = "label_postspec";
            this.label_postspec.Size = new System.Drawing.Size(142, 20);
            this.label_postspec.TabIndex = 11;
            this.label_postspec.Text = "Postes spécifiques";
            // 
            // treeView_postspec
            // 
            this.treeView_postspec.LineColor = System.Drawing.Color.Empty;
            this.treeView_postspec.Location = new System.Drawing.Point(270, 75);
            this.treeView_postspec.Name = "treeView_postspec";
            this.treeView_postspec.Size = new System.Drawing.Size(230, 259);
            this.treeView_postspec.TabIndex = 10;
            // 
            // button_del_postspec
            // 
            this.button_del_postspec.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_del_postspec.Location = new System.Drawing.Point(388, 38);
            this.button_del_postspec.Name = "button_del_postspec";
            this.button_del_postspec.Size = new System.Drawing.Size(112, 34);
            this.button_del_postspec.TabIndex = 9;
            this.button_del_postspec.Text = "Supprimer";
            this.button_del_postspec.UseVisualStyleBackColor = true;
            // 
            // button_aj_postspec
            // 
            this.button_aj_postspec.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_aj_postspec.Location = new System.Drawing.Point(270, 38);
            this.button_aj_postspec.Name = "button_aj_postspec";
            this.button_aj_postspec.Size = new System.Drawing.Size(112, 34);
            this.button_aj_postspec.TabIndex = 8;
            this.button_aj_postspec.Text = "Ajouter";
            this.button_aj_postspec.UseVisualStyleBackColor = true;
            // 
            // label_equipes
            // 
            this.label_equipes.AutoSize = true;
            this.label_equipes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_equipes.Location = new System.Drawing.Point(103, 359);
            this.label_equipes.Name = "label_equipes";
            this.label_equipes.Size = new System.Drawing.Size(67, 20);
            this.label_equipes.TabIndex = 7;
            this.label_equipes.Text = "Équipes";
            // 
            // treeView_equipe
            // 
            this.treeView_equipe.BackColor = System.Drawing.SystemColors.Window;
            this.treeView_equipe.LineColor = System.Drawing.Color.Empty;
            this.treeView_equipe.Location = new System.Drawing.Point(19, 430);
            this.treeView_equipe.Name = "treeView_equipe";
            this.treeView_equipe.Size = new System.Drawing.Size(230, 259);
            this.treeView_equipe.TabIndex = 6;
            this.treeView_equipe.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // button_del_equipe
            // 
            this.button_del_equipe.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_del_equipe.Location = new System.Drawing.Point(137, 393);
            this.button_del_equipe.Name = "button_del_equipe";
            this.button_del_equipe.Size = new System.Drawing.Size(112, 34);
            this.button_del_equipe.TabIndex = 5;
            this.button_del_equipe.Text = "Supprimer";
            this.button_del_equipe.UseVisualStyleBackColor = true;
            this.button_del_equipe.Click += new System.EventHandler(this.button_del_equipe_Click);
            // 
            // button_aj_equipe
            // 
            this.button_aj_equipe.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_aj_equipe.Location = new System.Drawing.Point(19, 393);
            this.button_aj_equipe.Name = "button_aj_equipe";
            this.button_aj_equipe.Size = new System.Drawing.Size(112, 34);
            this.button_aj_equipe.TabIndex = 4;
            this.button_aj_equipe.Text = "Ajouter";
            this.button_aj_equipe.UseVisualStyleBackColor = true;
            this.button_aj_equipe.Click += new System.EventHandler(this.button_aj_equipe_Click);
            // 
            // treeView_postgen
            // 
            this.treeView_postgen.BackColor = System.Drawing.SystemColors.Window;
            this.treeView_postgen.LineColor = System.Drawing.Color.Empty;
            this.treeView_postgen.Location = new System.Drawing.Point(19, 75);
            this.treeView_postgen.Name = "treeView_postgen";
            this.treeView_postgen.Size = new System.Drawing.Size(230, 259);
            this.treeView_postgen.TabIndex = 3;
            this.treeView_postgen.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // button_supprimer
            // 
            this.button_supprimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_supprimer.Location = new System.Drawing.Point(137, 38);
            this.button_supprimer.Name = "button_supprimer";
            this.button_supprimer.Size = new System.Drawing.Size(112, 34);
            this.button_supprimer.TabIndex = 2;
            this.button_supprimer.Text = "Supprimer";
            this.button_supprimer.UseVisualStyleBackColor = true;
            this.button_supprimer.Click += new System.EventHandler(this.button_supprimer_Click);
            // 
            // button_ajouter_PG
            // 
            this.button_ajouter_PG.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_ajouter_PG.Location = new System.Drawing.Point(19, 38);
            this.button_ajouter_PG.Name = "button_ajouter_PG";
            this.button_ajouter_PG.Size = new System.Drawing.Size(112, 34);
            this.button_ajouter_PG.TabIndex = 1;
            this.button_ajouter_PG.Text = "Ajouter";
            this.button_ajouter_PG.UseVisualStyleBackColor = true;
            this.button_ajouter_PG.Click += new System.EventHandler(this.button_ajouter_PG_Click);
            // 
            // label_postgeneral
            // 
            this.label_postgeneral.AutoSize = true;
            this.label_postgeneral.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_postgeneral.Location = new System.Drawing.Point(75, 10);
            this.label_postgeneral.Name = "label_postgeneral";
            this.label_postgeneral.Size = new System.Drawing.Size(119, 20);
            this.label_postgeneral.TabIndex = 0;
            this.label_postgeneral.Text = "Postes Général";
            // 
            // clear_button
            // 
            this.clear_button.Location = new System.Drawing.Point(458, 128);
            this.clear_button.Name = "clear_button";
            this.clear_button.Size = new System.Drawing.Size(177, 46);
            this.clear_button.TabIndex = 26;
            this.clear_button.Text = "Rétablir l\'affichage normal";
            this.clear_button.UseVisualStyleBackColor = true;
            this.clear_button.Click += new System.EventHandler(this.clear_button_Click);
            // 
            // HoraireBeta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 730);
            this.Controls.Add(this.Admin);
            this.Name = "HoraireBeta";
            this.Text = "Form1";
            this.Admin.ResumeLayout(false);
            this.horaire.ResumeLayout(false);
            this.panelCentral_Horaire.ResumeLayout(false);
            this.tabConflits.ResumeLayout(false);
            this.tab_Conflits.ResumeLayout(false);
            this.tabEmploye.ResumeLayout(false);
            this.tabPoste.ResumeLayout(false);
            this.tabEquipe.ResumeLayout(false);
            this.panelGauche_Horaire.ResumeLayout(false);
            this.panelGauche_Horaire.PerformLayout();
            this.Presets.ResumeLayout(false);
            this.tab_Presets.ResumeLayout(false);
            this.tab_Ressources.ResumeLayout(false);
            this.employe.ResumeLayout(false);
            this.panelCentral_Employe.ResumeLayout(false);
            this.panelCentral_Employe.PerformLayout();
            this.panelGauche_Employe.ResumeLayout(false);
            this.panelGauche_Employe.PerformLayout();
            this.parametre.ResumeLayout(false);
            this.panelCentral_Parametre.ResumeLayout(false);
            this.panelCentral_Parametre.PerformLayout();
            this.panelGauche_Parametre.ResumeLayout(false);
            this.panelGauche_Parametre.PerformLayout();
            this.admin_table.ResumeLayout(false);
            this.admin_central.ResumeLayout(false);
            this.admin_central.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.resultDataGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl Admin;
        private System.Windows.Forms.TabPage horaire;
        private System.Windows.Forms.TabPage employe;
        private System.Windows.Forms.TabPage parametre;
        private System.Windows.Forms.Panel panelCentral_Horaire;
        private System.Windows.Forms.Panel panelGauche_Horaire;
        private System.Windows.Forms.Panel panelCentral_Employe;
        private System.Windows.Forms.Panel panelGauche_Employe;
        private System.Windows.Forms.Panel panelCentral_Parametre;
        private System.Windows.Forms.Panel panelGauche_Parametre;
        private TabPage admin_table;
        private Panel admin_central;
        private Panel admin_gauche;
        private DataGridView resultDataGrid;
        private TextBox sqlTextBox;
        private Button bouton_requete;
        private Button bouton_connecter;
        private Button button_exporter;
        private Button button_imprime;
        private Button button_genere;
        private MonthCalendar monthCalendar1;
        private Label label_recherche;
        private TextBox textBox1;
        private TabControl Presets;
        private TabPage tab_Presets;
        private TabPage tab_Ressources;
        private TabControl tabConflits;
        private TabPage tab_Conflits;
        private RichTextBox text_Conflits;
        public Loader loader;
        private GrilleHoraire grille;
        private TreeView RessourceTree;
        private TreeView treeView_postdispo;
        private List<Ressource> profilCharge = new List<Ressource>();
        private List<Equipe> equipe = new List<Equipe>();
        public List<Poste> posteCharge = new List<Poste>();
        
        private Label label1;
        private Button ajouter_button;
        private Label ajprofemp_label;
        private Button supprimer_button;
        private Label infopers_label;
        private TextBox telephone_textbox;
        private TextBox courriel_textbox;
        private TextBox prenom_textbox;
        private TextBox nom_textbox;
        private TextBox numemp_textbox;
        private Label telephone_label;
        private Label courriel_label;
        private Label prenom_label;
        private Label nom_label;
        private Label nemp_label;
        private Button button1;
        private Label label2;
        private Label label_infoperss;
        private RichTextBox richTextBox1;
        private Button button_Valider;
        private Label postoccuper_label;
        private Button Sauvegarder_button;
        private Button buttondroit;
        private Label postchoisi_label;
        private Label postedisp_label;

        private TreeView treeView_postechoisi;
        private Button posteaoccuper_gauche;
        private Label parametre_label;
        private Button button_generaux;
        private Button button_ressource;
        private Button button_presets;
        private TextBox textBox_graduation;
        private TextBox textBox_quotasemaine;
        private TextBox textBox_qtheurejou;
        private Label label_graduation;
        private Label label_quotasemaine;
        private Label label_quotajour;
        private Label label_horaire;
        private Label label_heurest;
        private Label label_partexte;
        private Label label_postgeneral;
        private Label label_postspec;
        private TreeView treeView_postspec;
        private Button button_del_postspec;
        private Button button_aj_postspec;
        private Label label_equipes;
        private TreeView treeView_equipe;
        private Button button_del_equipe;
        private Button button_aj_equipe;
        private TreeView treeView_postgen;
        private Button button_supprimer;
        private Button button_ajouter_PG;
        private Label label_postaffect;
        private TreeView treeView_postaaffectgauche;
        private TreeView treeView_postaaffectdroite;
        private Button button_postaaffectgauche;
        private Button button_postaaffectdroit;
        private Button button_affecter;
        private TreeView treeView_postspec2;
        private Button modifier_button;
        private TabPage tabEmploye;
        private ListBox listEmploye;
        private TreeView treeView_modemploye;
        private TabPage tabPoste;
        private TabPage tabEquipe;
        private ListBox listPoste;
        private ListBox listEquipe;
        private ListBox listPreset;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private Button clear_button;


    }
}