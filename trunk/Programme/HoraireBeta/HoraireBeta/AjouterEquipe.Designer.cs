namespace HoraireBeta
{
    partial class AjouterEquipe
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
            this.button_annul_aj_equipe = new System.Windows.Forms.Button();
            this.button_aj_equipe_confirm = new System.Windows.Forms.Button();
            this.richTextBox_descequipe = new System.Windows.Forms.RichTextBox();
            this.label_descripequipe = new System.Windows.Forms.Label();
            this.textBox_nomequipe = new System.Windows.Forms.TextBox();
            this.label_nomequipe = new System.Windows.Forms.Label();
            this.label_ajouterequipe = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button_annul_aj_equipe
            // 
            this.button_annul_aj_equipe.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_annul_aj_equipe.Location = new System.Drawing.Point(112, 207);
            this.button_annul_aj_equipe.Name = "button_annul_aj_equipe";
            this.button_annul_aj_equipe.Size = new System.Drawing.Size(101, 36);
            this.button_annul_aj_equipe.TabIndex = 13;
            this.button_annul_aj_equipe.Text = "Annuler";
            this.button_annul_aj_equipe.UseVisualStyleBackColor = true;
            this.button_annul_aj_equipe.Click += new System.EventHandler(this.button_annul_aj_equipe_Click);
            // 
            // button_aj_equipe_confirm
            // 
            this.button_aj_equipe_confirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_aj_equipe_confirm.Location = new System.Drawing.Point(230, 207);
            this.button_aj_equipe_confirm.Name = "button_aj_equipe_confirm";
            this.button_aj_equipe_confirm.Size = new System.Drawing.Size(101, 36);
            this.button_aj_equipe_confirm.TabIndex = 12;
            this.button_aj_equipe_confirm.Text = "Ajouter";
            this.button_aj_equipe_confirm.UseVisualStyleBackColor = true;
            this.button_aj_equipe_confirm.Click += new System.EventHandler(this.button_aj_equipe_confirm_Click);
            // 
            // richTextBox_descequipe
            // 
            this.richTextBox_descequipe.Location = new System.Drawing.Point(111, 112);
            this.richTextBox_descequipe.Name = "richTextBox_descequipe";
            this.richTextBox_descequipe.Size = new System.Drawing.Size(221, 84);
            this.richTextBox_descequipe.TabIndex = 11;
            this.richTextBox_descequipe.Text = "";
            // 
            // label_descripequipe
            // 
            this.label_descripequipe.AutoSize = true;
            this.label_descripequipe.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_descripequipe.Location = new System.Drawing.Point(12, 115);
            this.label_descripequipe.Name = "label_descripequipe";
            this.label_descripequipe.Size = new System.Drawing.Size(78, 15);
            this.label_descripequipe.TabIndex = 10;
            this.label_descripequipe.Text = "Description : ";
            // 
            // textBox_nomequipe
            // 
            this.textBox_nomequipe.Location = new System.Drawing.Point(111, 67);
            this.textBox_nomequipe.Name = "textBox_nomequipe";
            this.textBox_nomequipe.Size = new System.Drawing.Size(221, 20);
            this.textBox_nomequipe.TabIndex = 9;
            this.textBox_nomequipe.TextChanged += new System.EventHandler(this.textBox_nomequipe_TextChanged);
            // 
            // label_nomequipe
            // 
            this.label_nomequipe.AutoSize = true;
            this.label_nomequipe.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_nomequipe.Location = new System.Drawing.Point(12, 68);
            this.label_nomequipe.Name = "label_nomequipe";
            this.label_nomequipe.Size = new System.Drawing.Size(107, 15);
            this.label_nomequipe.TabIndex = 8;
            this.label_nomequipe.Text = "Nom de l\'équipe : ";
            // 
            // label_ajouterequipe
            // 
            this.label_ajouterequipe.AutoSize = true;
            this.label_ajouterequipe.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_ajouterequipe.Location = new System.Drawing.Point(106, 13);
            this.label_ajouterequipe.Name = "label_ajouterequipe";
            this.label_ajouterequipe.Size = new System.Drawing.Size(165, 25);
            this.label_ajouterequipe.TabIndex = 7;
            this.label_ajouterequipe.Text = "Ajouter un équipe";
            // 
            // AjouterEquipe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(344, 256);
            this.Controls.Add(this.button_annul_aj_equipe);
            this.Controls.Add(this.button_aj_equipe_confirm);
            this.Controls.Add(this.richTextBox_descequipe);
            this.Controls.Add(this.label_descripequipe);
            this.Controls.Add(this.textBox_nomequipe);
            this.Controls.Add(this.label_nomequipe);
            this.Controls.Add(this.label_ajouterequipe);
            this.Name = "AjouterEquipe";
            this.Text = "AjouterEquipe";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_annul_aj_equipe;
        private System.Windows.Forms.Button button_aj_equipe_confirm;
        private System.Windows.Forms.RichTextBox richTextBox_descequipe;
        private System.Windows.Forms.Label label_descripequipe;
        private System.Windows.Forms.TextBox textBox_nomequipe;
        private System.Windows.Forms.Label label_nomequipe;
        private System.Windows.Forms.Label label_ajouterequipe;
    }
}