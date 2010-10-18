using System.Windows.Forms;
using System.Drawing;
namespace HoraireAlpha
{
    partial class Horaire
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Horaire));
            this.buttonHoraire = new System.Windows.Forms.Button();
            this.panelGauche = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.panelCentral = new System.Windows.Forms.Panel();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.panelGauche.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonHoraire
            // 
            this.buttonHoraire.BackColor = System.Drawing.SystemColors.Control;
            this.buttonHoraire.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonHoraire.BackgroundImage")));
            this.buttonHoraire.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonHoraire.Location = new System.Drawing.Point(231, 0);
            this.buttonHoraire.Name = "buttonHoraire";
            this.buttonHoraire.Size = new System.Drawing.Size(120, 25);
            this.buttonHoraire.TabIndex = 0;
            this.buttonHoraire.Text = "Horaire";
            this.buttonHoraire.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.buttonHoraire.UseVisualStyleBackColor = false;
            this.buttonHoraire.Click += new System.EventHandler(this.buttonHoraire_Click);
            // 
            // panelGauche
            // 
            this.panelGauche.Controls.Add(this.monthCalendar1);
            this.panelGauche.Location = new System.Drawing.Point(0, 0);
            this.panelGauche.Name = "panelGauche";
            this.panelGauche.Size = new System.Drawing.Size(231, 545);
            this.panelGauche.TabIndex = 1;
            this.panelGauche.Paint += new System.Windows.Forms.PaintEventHandler(this.panelGauche_Paint);
            // 
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(346, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(125, 25);
            this.button1.TabIndex = 2;
            this.button1.Text = "Profil";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(468, 0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(125, 25);
            this.button2.TabIndex = 3;
            this.button2.Text = "Paramètre";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button3.BackgroundImage")));
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Location = new System.Drawing.Point(850, 0);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(28, 25);
            this.button3.TabIndex = 4;
            this.button3.Text = "?";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // panelCentral
            // 
            this.panelCentral.Location = new System.Drawing.Point(230, 25);
            this.panelCentral.Name = "panelCentral";
            this.panelCentral.Size = new System.Drawing.Size(648, 520);
            this.panelCentral.TabIndex = 5;
            this.panelCentral.Paint += new System.Windows.Forms.PaintEventHandler(this.panelCentral_Paint);
            this.panelCentral.MouseClick += new System.Windows.Forms.MouseEventHandler(this.OnMouseEvent);
            this.panelCentral.MouseMove += new System.Windows.Forms.MouseEventHandler(this.OnMouseEvent);
            // 
            // monthCalendar1 
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(0, 51);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 0;
            this.monthCalendar1.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateChanged);
            // 
            // Horaire
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(878, 545);
            this.Controls.Add(this.panelCentral);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panelGauche);
            this.Controls.Add(this.buttonHoraire);
            this.Name = "Horaire";
            this.Text = "Horaire";
            this.panelGauche.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonHoraire;
        private System.Windows.Forms.Panel panelGauche;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Panel panelCentral;
        private System.Windows.Forms.MonthCalendar monthCalendar1;

        private void OnMouseEvent(object sender, MouseEventArgs e) 
            {
                //Affiche les controles selon la couleur du BG (très fonctionnel)
                if (this.panelCentral.BackColor == Color.Blue)
                {
                    //Analyse les controles
                    switch (e.Button)
                    {
                        case MouseButtons.Left:
                            MessageBox.Show(this, "Vous avez appuyez sur gauche en : "+e.X+" , "+e.Y);
                            break;

                        case MouseButtons.Right:
                            MessageBox.Show(this, "Vous avez appuyez sur droite en : "+e.X+" , "+e.Y);
                            break;

                    }
                    //Analyse des X
                    if (e.X > 400)
                        MessageBox.Show(this, "Tu dépasse les 400 pixels en X");

                    //Le handler fonctionne en boucle

                }
            }
        
        }
}

