namespace HoraireBeta
{
    partial class DeletePost
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
            this.label_delposte = new System.Windows.Forms.Label();
            this.button_OUI_poste = new System.Windows.Forms.Button();
            this.button_NON_poste = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_delposte
            // 
            this.label_delposte.AutoSize = true;
            this.label_delposte.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_delposte.Location = new System.Drawing.Point(12, 20);
            this.label_delposte.Name = "label_delposte";
            this.label_delposte.Size = new System.Drawing.Size(324, 20);
            this.label_delposte.TabIndex = 0;
            this.label_delposte.Text = "Êtes vous sûr de vouloir supprimer ce poste?";
            // 
            // button_OUI_poste
            // 
            this.button_OUI_poste.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_OUI_poste.Location = new System.Drawing.Point(245, 52);
            this.button_OUI_poste.Name = "button_OUI_poste";
            this.button_OUI_poste.Size = new System.Drawing.Size(91, 35);
            this.button_OUI_poste.TabIndex = 1;
            this.button_OUI_poste.Text = "Oui";
            this.button_OUI_poste.UseVisualStyleBackColor = true;
            this.button_OUI_poste.Click += new System.EventHandler(this.button_OUI_poste_Click);
            // 
            // button_NON_poste
            // 
            this.button_NON_poste.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_NON_poste.Location = new System.Drawing.Point(16, 52);
            this.button_NON_poste.Name = "button_NON_poste";
            this.button_NON_poste.Size = new System.Drawing.Size(91, 35);
            this.button_NON_poste.TabIndex = 2;
            this.button_NON_poste.Text = "Non";
            this.button_NON_poste.UseVisualStyleBackColor = true;
            this.button_NON_poste.Click += new System.EventHandler(this.button_NON_poste_Click);
            // 
            // DeletePost
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(352, 107);
            this.Controls.Add(this.button_NON_poste);
            this.Controls.Add(this.button_OUI_poste);
            this.Controls.Add(this.label_delposte);
            this.Name = "DeletePost";
            this.Text = "DeletePost";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_delposte;
        private System.Windows.Forms.Button button_OUI_poste;
        private System.Windows.Forms.Button button_NON_poste;
    }
}