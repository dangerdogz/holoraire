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
            this.panelGauche_Horaire = new System.Windows.Forms.Panel();
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
            this.Admin.Size = new System.Drawing.Size(885, 561);
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
            this.horaire.Size = new System.Drawing.Size(877, 532);
            this.horaire.TabIndex = 0;
            this.horaire.Text = "Horaire";
            this.horaire.Click += new System.EventHandler(this.horaire_Click);
            // 
            // panelCentral_Horaire
            // 
            this.panelCentral_Horaire.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.panelCentral_Horaire.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelCentral_Horaire.Location = new System.Drawing.Point(203, 7);
            this.panelCentral_Horaire.Name = "panelCentral_Horaire";
            this.panelCentral_Horaire.Size = new System.Drawing.Size(665, 515);
            this.panelCentral_Horaire.TabIndex = 1;
            this.panelCentral_Horaire.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pCentral_Horaire_OnMouseEvent);
            this.panelCentral_Horaire.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pCentral_Horaire_OnMouseEvent);
            // 
            // panelGauche_Horaire
            // 
            this.panelGauche_Horaire.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.panelGauche_Horaire.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelGauche_Horaire.Location = new System.Drawing.Point(7, 7);
            this.panelGauche_Horaire.Name = "panelGauche_Horaire";
            this.panelGauche_Horaire.Size = new System.Drawing.Size(189, 515);
            this.panelGauche_Horaire.TabIndex = 0;
            this.panelGauche_Horaire.Paint += new System.Windows.Forms.PaintEventHandler(this.pCentral_Horaire_Paint);
            this.panelGauche_Horaire.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pGauche_Horaire_OnMouseEvent);
            this.panelGauche_Horaire.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pGauche_Horaire_OnMouseEvent);
            // 
            // employe
            // 
            this.employe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.employe.Controls.Add(this.panelCentral_Employe);
            this.employe.Controls.Add(this.panelGauche_Employe);
            this.employe.Location = new System.Drawing.Point(4, 25);
            this.employe.Name = "employe";
            this.employe.Padding = new System.Windows.Forms.Padding(3);
            this.employe.Size = new System.Drawing.Size(877, 532);
            this.employe.TabIndex = 1;
            this.employe.Text = "Employé";
            this.employe.Click += new System.EventHandler(this.employe_Click);
            // 
            // panelCentral_Employe
            // 
            this.panelCentral_Employe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.panelCentral_Employe.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelCentral_Employe.Location = new System.Drawing.Point(204, 8);
            this.panelCentral_Employe.Name = "panelCentral_Employe";
            this.panelCentral_Employe.Size = new System.Drawing.Size(664, 514);
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
            this.panelGauche_Employe.Size = new System.Drawing.Size(189, 514);
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
            this.parametre.Size = new System.Drawing.Size(877, 532);
            this.parametre.TabIndex = 2;
            this.parametre.Text = "Paramètre";
            // 
            // panelCentral_Parametre
            // 
            this.panelCentral_Parametre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.panelCentral_Parametre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelCentral_Parametre.Location = new System.Drawing.Point(204, 8);
            this.panelCentral_Parametre.Name = "panelCentral_Parametre";
            this.panelCentral_Parametre.Size = new System.Drawing.Size(664, 514);
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
            this.panelGauche_Parametre.Size = new System.Drawing.Size(189, 514);
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
            this.admin_table.Size = new System.Drawing.Size(877, 532);
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
            this.admin_central.Location = new System.Drawing.Point(204, 9);
            this.admin_central.Name = "admin_central";
            this.admin_central.Size = new System.Drawing.Size(664, 514);
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
            this.admin_gauche.Location = new System.Drawing.Point(8, 9);
            this.admin_gauche.Name = "admin_gauche";
            this.admin_gauche.Size = new System.Drawing.Size(189, 514);
            this.admin_gauche.TabIndex = 0;
            this.admin_gauche.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // HoraireBeta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 559);
            this.Controls.Add(this.Admin);
            this.Name = "HoraireBeta";
            this.Text = "Form1";
            this.Admin.ResumeLayout(false);
            this.horaire.ResumeLayout(false);
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
    }
}

