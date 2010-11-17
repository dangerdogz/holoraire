namespace HoraireBeta
{
    partial class DeleteEquipe
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button_NON_equipe = new System.Windows.Forms.Button();
            this.button_OUI_equipe = new System.Windows.Forms.Button();
            this.label_delequipe = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button_NON_equipe
            // 
            this.button_NON_equipe.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_NON_equipe.Location = new System.Drawing.Point(15, 52);
            this.button_NON_equipe.Name = "button_NON_equipe";
            this.button_NON_equipe.Size = new System.Drawing.Size(91, 35);
            this.button_NON_equipe.TabIndex = 5;
            this.button_NON_equipe.Text = "Non";
            this.button_NON_equipe.UseVisualStyleBackColor = true;
            // 
            // button_OUI_equipe
            // 
            this.button_OUI_equipe.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_OUI_equipe.Location = new System.Drawing.Point(249, 52);
            this.button_OUI_equipe.Name = "button_OUI_equipe";
            this.button_OUI_equipe.Size = new System.Drawing.Size(91, 35);
            this.button_OUI_equipe.TabIndex = 4;
            this.button_OUI_equipe.Text = "Oui";
            this.button_OUI_equipe.UseVisualStyleBackColor = true;
            // 
            // label_delequipe
            // 
            this.label_delequipe.AutoSize = true;
            this.label_delequipe.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_delequipe.Location = new System.Drawing.Point(12, 18);
            this.label_delequipe.Name = "label_delequipe";
            this.label_delequipe.Size = new System.Drawing.Size(328, 18);
            this.label_delequipe.TabIndex = 3;
            this.label_delequipe.Text = "Êtes vous sûr de vouloir supprimer cette équipe?";
            // 
            // DeleteEquipe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(352, 107);
            this.Controls.Add(this.button_NON_equipe);
            this.Controls.Add(this.button_OUI_equipe);
            this.Controls.Add(this.label_delequipe);
            this.Name = "DeleteEquipe";
            this.Text = "DeleteEquipe";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_NON_equipe;
        private System.Windows.Forms.Button button_OUI_equipe;
        private System.Windows.Forms.Label label_delequipe;
    }
}