namespace HoraireBeta
{
    partial class AjouterPoste
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
            this.label_ajouterposte = new System.Windows.Forms.Label();
            this.label_nomposte = new System.Windows.Forms.Label();
            this.textBox_nomposte = new System.Windows.Forms.TextBox();
            this.label_descripposte = new System.Windows.Forms.Label();
            this.richTextBox_descposte = new System.Windows.Forms.RichTextBox();
            this.button_aj_post_confirm = new System.Windows.Forms.Button();
            this.button_annul_aj_post = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_ajouterposte
            // 
            this.label_ajouterposte.AutoSize = true;
            this.label_ajouterposte.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_ajouterposte.Location = new System.Drawing.Point(106, 21);
            this.label_ajouterposte.Name = "label_ajouterposte";
            this.label_ajouterposte.Size = new System.Drawing.Size(154, 25);
            this.label_ajouterposte.TabIndex = 0;
            this.label_ajouterposte.Text = "Ajouter un poste";
            // 
            // label_nomposte
            // 
            this.label_nomposte.AutoSize = true;
            this.label_nomposte.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_nomposte.Location = new System.Drawing.Point(12, 76);
            this.label_nomposte.Name = "label_nomposte";
            this.label_nomposte.Size = new System.Drawing.Size(93, 15);
            this.label_nomposte.TabIndex = 1;
            this.label_nomposte.Text = "Nom du poste : ";
            // 
            // textBox_nomposte
            // 
            this.textBox_nomposte.Location = new System.Drawing.Point(111, 75);
            this.textBox_nomposte.Name = "textBox_nomposte";
            this.textBox_nomposte.Size = new System.Drawing.Size(221, 20);
            this.textBox_nomposte.TabIndex = 2;
            // 
            // label_descripposte
            // 
            this.label_descripposte.AutoSize = true;
            this.label_descripposte.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_descripposte.Location = new System.Drawing.Point(12, 123);
            this.label_descripposte.Name = "label_descripposte";
            this.label_descripposte.Size = new System.Drawing.Size(78, 15);
            this.label_descripposte.TabIndex = 3;
            this.label_descripposte.Text = "Description : ";
            // 
            // richTextBox_descposte
            // 
            this.richTextBox_descposte.Location = new System.Drawing.Point(111, 120);
            this.richTextBox_descposte.Name = "richTextBox_descposte";
            this.richTextBox_descposte.Size = new System.Drawing.Size(221, 84);
            this.richTextBox_descposte.TabIndex = 4;
            this.richTextBox_descposte.Text = "";
            // 
            // button_aj_post_confirm
            // 
            this.button_aj_post_confirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_aj_post_confirm.Location = new System.Drawing.Point(230, 215);
            this.button_aj_post_confirm.Name = "button_aj_post_confirm";
            this.button_aj_post_confirm.Size = new System.Drawing.Size(101, 36);
            this.button_aj_post_confirm.TabIndex = 5;
            this.button_aj_post_confirm.Text = "Ajouter";
            this.button_aj_post_confirm.UseVisualStyleBackColor = true;
            // 
            // button_annul_aj_post
            // 
            this.button_annul_aj_post.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_annul_aj_post.Location = new System.Drawing.Point(112, 215);
            this.button_annul_aj_post.Name = "button_annul_aj_post";
            this.button_annul_aj_post.Size = new System.Drawing.Size(101, 36);
            this.button_annul_aj_post.TabIndex = 6;
            this.button_annul_aj_post.Text = "Annuler";
            this.button_annul_aj_post.UseVisualStyleBackColor = true;
            this.button_annul_aj_post.Click += new System.EventHandler(this.button_annul_aj_post_Click);
            // 
            // AjouterPoste
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(344, 256);
            this.Controls.Add(this.button_annul_aj_post);
            this.Controls.Add(this.button_aj_post_confirm);
            this.Controls.Add(this.richTextBox_descposte);
            this.Controls.Add(this.label_descripposte);
            this.Controls.Add(this.textBox_nomposte);
            this.Controls.Add(this.label_nomposte);
            this.Controls.Add(this.label_ajouterposte);
            this.Name = "AjouterPoste";
            this.Text = "AjouterPoste";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_ajouterposte;
        private System.Windows.Forms.Label label_nomposte;
        private System.Windows.Forms.TextBox textBox_nomposte;
        private System.Windows.Forms.Label label_descripposte;
        private System.Windows.Forms.RichTextBox richTextBox_descposte;
        private System.Windows.Forms.Button button_aj_post_confirm;
        private System.Windows.Forms.Button button_annul_aj_post;
    }
}