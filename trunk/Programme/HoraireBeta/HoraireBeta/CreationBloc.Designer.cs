

namespace HoraireBeta
{
    partial class CreationBloc
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
            this.textBox_hrdebut = new System.Windows.Forms.TextBox();
            this.textBox_hrfin = new System.Windows.Forms.TextBox();
            this.button_blocconfirm = new System.Windows.Forms.Button();
            this.label_hrdebut = new System.Windows.Forms.Label();
            this.label_hrfin = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox_hrdebut
            // 
            this.textBox_hrdebut.Location = new System.Drawing.Point(110, 23);
            this.textBox_hrdebut.Name = "textBox_hrdebut";
            this.textBox_hrdebut.Size = new System.Drawing.Size(85, 20);
            this.textBox_hrdebut.TabIndex = 0;
            this.textBox_hrdebut.Text = hd;

            // 
            // textBox_hrfin
            // 
            this.textBox_hrfin.Location = new System.Drawing.Point(109, 66);
            this.textBox_hrfin.Name = "textBox_hrfin";
            this.textBox_hrfin.Size = new System.Drawing.Size(86, 20);
            this.textBox_hrfin.TabIndex = 1;
            this.textBox_hrfin.Text = hf;
            // 
            // button_blocconfirm
            // 
            this.button_blocconfirm.Location = new System.Drawing.Point(226, 82);
            this.button_blocconfirm.Name = "button_blocconfirm";
            this.button_blocconfirm.Size = new System.Drawing.Size(91, 28);
            this.button_blocconfirm.TabIndex = 2;
            this.button_blocconfirm.Text = "Confirmer";
            this.button_blocconfirm.UseVisualStyleBackColor = true;
            this.button_blocconfirm.Click += new System.EventHandler(this.button_blocconfirm_Click);
            // 
            // label_hrdebut
            // 
            this.label_hrdebut.AutoSize = true;
            this.label_hrdebut.Location = new System.Drawing.Point(14, 26);
            this.label_hrdebut.Name = "label_hrdebut";
            this.label_hrdebut.Size = new System.Drawing.Size(90, 13);
            this.label_hrdebut.TabIndex = 3;
            this.label_hrdebut.Text = "Heure de debut : ";
            // 
            // label_hrfin
            // 
            this.label_hrfin.AutoSize = true;
            this.label_hrfin.Location = new System.Drawing.Point(11, 66);
            this.label_hrfin.Name = "label_hrfin";
            this.label_hrfin.Size = new System.Drawing.Size(71, 13);
            this.label_hrfin.TabIndex = 4;
            this.label_hrfin.Text = "Heure de fin :";
            // 
            // CreationBloc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(329, 122);
            this.Controls.Add(this.label_hrfin);
            this.Controls.Add(this.label_hrdebut);
            this.Controls.Add(this.button_blocconfirm);
            this.Controls.Add(this.textBox_hrfin);
            this.Controls.Add(this.textBox_hrdebut);
            this.Name = "CreationBloc";
            this.Text = "Création d\'un bloc";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_hrdebut;
        private System.Windows.Forms.TextBox textBox_hrfin;
        private System.Windows.Forms.Button button_blocconfirm;
        private System.Windows.Forms.Label label_hrdebut;
        private System.Windows.Forms.Label label_hrfin;
    }
}
