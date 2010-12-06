namespace HoraireBeta
{
    partial class ModificationBloc
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
        private void InitializeComponent(string hd, string hf, bool preset)
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label_Preset = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.modifier = new System.Windows.Forms.Button();
            this.supprimer = new System.Windows.Forms.Button();
            this.checkBox_Preset = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Heure de début";
            // 
            this.label_Preset.AutoSize = true;
            this.label_Preset.Location = new System.Drawing.Point(11, 95);
            this.label_Preset.Name = "label_Preset";
            this.label_Preset.Size = new System.Drawing.Size(40, 13);
            this.label_Preset.TabIndex = 4;
            this.label_Preset.Text = "Preset: ";
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Heure de fin";
            // 
            // textBox1

            this.checkBox_Preset.Location = new System.Drawing.Point(55, 95);
            this.checkBox_Preset.Name = "checkBox_Preset";
            this.checkBox_Preset.Size = new System.Drawing.Size(15, 15);
            this.checkBox_Preset.TabIndex = 4;
            if (preset)
            this.checkBox_Preset.CheckState = System.Windows.Forms.CheckState.Checked;

            this.textBox1.Location = new System.Drawing.Point(128, 19);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(144, 20);
            this.textBox1.TabIndex = 2;
            this.textBox1.Text = hd;
            tempHd = hd;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(128, 55);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(144, 20);
            this.textBox2.TabIndex = 3;
            this.textBox2.Text = hf;
            // 
            // modifier
            // 
            this.modifier.Location = new System.Drawing.Point(148, 136);
            this.modifier.Name = "modifier";
            this.modifier.Size = new System.Drawing.Size(123, 29);
            this.modifier.TabIndex = 4;
            this.modifier.Text = "Modifier";
            this.modifier.UseVisualStyleBackColor = true;
            this.modifier.Click += new System.EventHandler(this.modifierClick);
            // 
            // supprimer
            // 
            this.supprimer.Location = new System.Drawing.Point(13, 136);
            this.supprimer.Name = "supprimer";
            this.supprimer.Size = new System.Drawing.Size(108, 28);
            this.supprimer.TabIndex = 5;
            this.supprimer.Text = "Supprimer";
            this.supprimer.UseVisualStyleBackColor = true;
            this.supprimer.Click += new System.EventHandler(this.supprimerClick);
            // 
            // ModificationBloc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(284, 179);
            this.Controls.Add(this.supprimer);
            this.Controls.Add(this.label_Preset);
            this.Controls.Add(this.modifier);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.checkBox_Preset);
            this.Name = "ModificationBloc";
            this.Text = "ModificationBloc";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button modifier;
        private System.Windows.Forms.CheckBox checkBox_Preset;
        private System.Windows.Forms.Button supprimer;
        private System.Windows.Forms.Label label_Preset;
    }
}