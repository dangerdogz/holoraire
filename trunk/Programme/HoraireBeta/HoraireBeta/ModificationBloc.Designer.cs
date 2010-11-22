

namespace HoraireBeta
{
    partial class ModificationBloc
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
        private void InitializeComponent(string hd, string hf)
        {
            this.label_hrdebut = new System.Windows.Forms.Label();
            this.label_hrfin = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.modifier_bouton = new System.Windows.Forms.Button();
            this.supprimer_bouton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_hrdebut
            // 
            this.label_hrdebut.AutoSize = true;
            this.label_hrdebut.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_hrdebut.Location = new System.Drawing.Point(13, 13);
            this.label_hrdebut.Name = "label_hrdebut";
            this.label_hrdebut.Size = new System.Drawing.Size(108, 18);
            this.label_hrdebut.TabIndex = 0;
            this.label_hrdebut.Text = "Heure de début";
            // 
            // label_hrfin
            // 
            this.label_hrfin.AutoSize = true;
            this.label_hrfin.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_hrfin.Location = new System.Drawing.Point(13, 56);
            this.label_hrfin.Name = "label_hrfin";
            this.label_hrfin.Size = new System.Drawing.Size(87, 18);
            this.label_hrfin.TabIndex = 1;
            this.label_hrfin.Text = "Heure de fin";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(147, 14);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(147, 20);
            this.textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(147, 54);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(147, 20);
            this.textBox2.TabIndex = 3;
            // 
            // modifier_bouton
            // 
            this.modifier_bouton.Location = new System.Drawing.Point(162, 131);
            this.modifier_bouton.Name = "modifier_bouton";
            this.modifier_bouton.Size = new System.Drawing.Size(131, 23);
            this.modifier_bouton.TabIndex = 4;
            this.modifier_bouton.Text = "Modifier";
            this.modifier_bouton.UseVisualStyleBackColor = true;
            // 
            // supprimer_bouton
            // 
            this.supprimer_bouton.Location = new System.Drawing.Point(12, 131);
            this.supprimer_bouton.Name = "supprimer_bouton";
            this.supprimer_bouton.Size = new System.Drawing.Size(123, 23);
            this.supprimer_bouton.TabIndex = 5;
            this.supprimer_bouton.Text = "Supprimer";
            this.supprimer_bouton.UseVisualStyleBackColor = true;
            // 
            // ModificationBloc
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(312, 167);
            this.Controls.Add(this.supprimer_bouton);
            this.Controls.Add(this.modifier_bouton);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label_hrfin);
            this.Controls.Add(this.label_hrdebut);
            this.Name = "ModificationBloc";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_hrdebut;
        private System.Windows.Forms.TextBox textBox_hrfin;
        private System.Windows.Forms.Button button_blocconfirm;
        private System.Windows.Forms.Label label_hrdebut;
        private System.Windows.Forms.Label label_hrfin;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button modifier_bouton;
        private System.Windows.Forms.Button supprimer_bouton;
    }
}
