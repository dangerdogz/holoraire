using System.Windows.Forms;
using System.Drawing;

namespace HoraireBeta
{
    partial class HoraireBeta
    {
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
        private void InitializeComponent()
        {
            this.Admin = new System.Windows.Forms.TabControl();
            this.horaire = new System.Windows.Forms.TabPage();
            this.panelCentral_Horaire = new System.Windows.Forms.Panel();
            this.tabConflits = new System.Windows.Forms.TabControl();
            this.tab_Conflits = new System.Windows.Forms.TabPage();
            this.text_Conflits = new System.Windows.Forms.RichTextBox();
            this.panelGauche_Horaire = new System.Windows.Forms.Panel();
            this.Presets = new System.Windows.Forms.TabControl();
            this.tab_Presets = new System.Windows.Forms.TabPage();
            this.tab_Ressources = new System.Windows.Forms.TabPage();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label_recherche = new System.Windows.Forms.Label();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.button_exporter = new System.Windows.Forms.Button();
            this.button_imprime = new System.Windows.Forms.Button();
            this.button_genere = new System.Windows.Forms.Button();
            this.employe = new System.Windows.Forms.TabPage();
            this.panelCentral_Employe = new System.Windows.Forms.Panel();
            this.panelGauche_Employe = new System.Windows.Forms.Panel();
            this.parametre = new System.Windows.Forms.TabPage();
            this.panelCentral_Parametre = new System.Windows.Forms.Panel();
            this.panelGauche_Parametre = new System.Windows.Forms.Panel();
            this.admin_table = new System.Windows.Forms.TabPage();
            this.admin_central = new System.Windows.Forms.Panel();
            this.resultDataGrid = new System.Windows.Forms.DataGridView();
            this.sqlTextBox = new System.Windows.Forms.TextBox();
            this.bouton_requete = new System.Windows.Forms.Button();
            this.bouton_connecter = new System.Windows.Forms.Button();
            this.admin_gauche = new System.Windows.Forms.Panel();
            this.Admin.SuspendLayout();
            this.horaire.SuspendLayout();
            this.panelCentral_Horaire.SuspendLayout();
            this.tabConflits.SuspendLayout();
            this.tab_Conflits.SuspendLayout();
            this.panelGauche_Horaire.SuspendLayout();
            this.Presets.SuspendLayout();
            this.employe.SuspendLayout();
            this.parametre.SuspendLayout();
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
            this.panelCentral_Horaire.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pCentral_Horaire_OnMouseEvent);
            this.panelCentral_Horaire.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pCentral_Horaire_OnMouseEvent);
            // 
            // tabConflits
            // 
            this.tabConflits.Controls.Add(this.tab_Conflits);
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
            this.panelGauche_Horaire.Paint += new System.Windows.Forms.PaintEventHandler(this.pCentral_Horaire_Paint);
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
            this.tab_Presets.Location = new System.Drawing.Point(4, 22);
            this.tab_Presets.Name = "tab_Presets";
            this.tab_Presets.Padding = new System.Windows.Forms.Padding(3);
            this.tab_Presets.Size = new System.Drawing.Size(221, 328);
            this.tab_Presets.TabIndex = 0;
            this.tab_Presets.Text = "Presets";
            this.tab_Presets.UseVisualStyleBackColor = true;
            // 
            // tab_Ressources
            // 
            this.tab_Ressources.Location = new System.Drawing.Point(4, 22);
            this.tab_Ressources.Name = "tab_Ressources";
            this.tab_Ressources.Padding = new System.Windows.Forms.Padding(3);
            this.tab_Ressources.Size = new System.Drawing.Size(221, 328);
            this.tab_Ressources.TabIndex = 1;
            this.tab_Ressources.Text = "Ressources";
            this.tab_Ressources.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(6, 305);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(227, 20);
            this.textBox1.TabIndex = 5;
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
            this.label_recherche.Click += new System.EventHandler(this.label1_Click);
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
            // 
            // button_imprime
            // 
            this.button_imprime.Location = new System.Drawing.Point(3, 38);
            this.button_imprime.Name = "button_imprime";
            this.button_imprime.Size = new System.Drawing.Size(230, 29);
            this.button_imprime.TabIndex = 1;
            this.button_imprime.Text = "Imprimer";
            this.button_imprime.UseVisualStyleBackColor = true;
            // 
            // button_genere
            // 
            this.button_genere.Location = new System.Drawing.Point(3, 3);
            this.button_genere.Name = "button_genere";
            this.button_genere.Size = new System.Drawing.Size(230, 29);
            this.button_genere.TabIndex = 0;
            this.button_genere.Text = "Générer";
            this.button_genere.UseVisualStyleBackColor = true;
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
            this.panelCentral_Employe.Location = new System.Drawing.Point(253, 7);
            this.panelCentral_Employe.Name = "panelCentral_Employe";
            this.panelCentral_Employe.Size = new System.Drawing.Size(746, 694);
            this.panelCentral_Employe.TabIndex = 3;
            this.panelCentral_Employe.Paint += new System.Windows.Forms.PaintEventHandler(this.pCentral_Employe_Paint);
            this.panelCentral_Employe.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pCentral_Employe_OnMouseEvent);
            this.panelCentral_Employe.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pCentral_Employe_OnMouseEvent);
            // 
            // panelGauche_Employe
            // 
            this.panelGauche_Employe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.panelGauche_Employe.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelGauche_Employe.Location = new System.Drawing.Point(8, 8);
            this.panelGauche_Employe.Name = "panelGauche_Employe";
            this.panelGauche_Employe.Size = new System.Drawing.Size(240, 694);
            this.panelGauche_Employe.TabIndex = 2;
            this.panelGauche_Employe.Paint += new System.Windows.Forms.PaintEventHandler(this.pGauche_Employe_Paint);
            this.panelGauche_Employe.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pGauche_Employe_OnMouseEvent);
            this.panelGauche_Employe.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pGauche_Employe_OnMouseEvent);
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
            this.panelCentral_Parametre.Location = new System.Drawing.Point(253, 7);
            this.panelCentral_Parametre.Name = "panelCentral_Parametre";
            this.panelCentral_Parametre.Size = new System.Drawing.Size(746, 694);
            this.panelCentral_Parametre.TabIndex = 3;
            this.panelCentral_Parametre.Paint += new System.Windows.Forms.PaintEventHandler(this.parametre_Paint);
            this.panelCentral_Parametre.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pCentral_Parametre_OnMouseEvent);
            this.panelCentral_Parametre.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pCentral_Parametre_OnMouseEvent);
            // 
            // panelGauche_Parametre
            // 
            this.panelGauche_Parametre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.panelGauche_Parametre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelGauche_Parametre.Location = new System.Drawing.Point(8, 8);
            this.panelGauche_Parametre.Name = "panelGauche_Parametre";
            this.panelGauche_Parametre.Size = new System.Drawing.Size(240, 694);
            this.panelGauche_Parametre.TabIndex = 2;
            this.panelGauche_Parametre.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pGauche_Parametre_OnMouseEvent);
            this.panelGauche_Parametre.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pGauche_Parametre_OnMouseEvent);
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
            this.admin_gauche.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
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
            this.panelGauche_Horaire.ResumeLayout(false);
            this.panelGauche_Horaire.PerformLayout();
            this.Presets.ResumeLayout(false);
            this.employe.ResumeLayout(false);
            this.parametre.ResumeLayout(false);
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
    }
}

