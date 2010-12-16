namespace HoraireBeta
{
    partial class Aide
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
            this.treeAide = new System.Windows.Forms.TreeView();
            this.textBox = new System.Windows.Forms.RichTextBox();
            this.labelSujet = new System.Windows.Forms.Label();
            this.labelInfo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // treeAide
            // 
            this.treeAide.Location = new System.Drawing.Point(13, 30);
            this.treeAide.Name = "treeAide";
            this.treeAide.Size = new System.Drawing.Size(234, 522);
            this.treeAide.TabIndex = 0;
            this.treeAide.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeAide_AfterSelect);
            // 
            // textBox
            // 
            this.textBox.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.textBox.Location = new System.Drawing.Point(253, 30);
            this.textBox.Margin = new System.Windows.Forms.Padding(5, 3, 3, 3);
            this.textBox.Name = "textBox";
            this.textBox.ReadOnly = true;
            this.textBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.textBox.Size = new System.Drawing.Size(539, 522);
            this.textBox.TabIndex = 1;
            this.textBox.Text = "";
            // 
            // labelSujet
            // 
            this.labelSujet.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.labelSujet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.labelSujet.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelSujet.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.labelSujet.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSujet.Location = new System.Drawing.Point(13, 9);
            this.labelSujet.Name = "labelSujet";
            this.labelSujet.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.labelSujet.Size = new System.Drawing.Size(234, 18);
            this.labelSujet.TabIndex = 2;
            this.labelSujet.Text = "Sujet";
            // 
            // labelInfo
            // 
            this.labelInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.labelInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.labelInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelInfo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.labelInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelInfo.Location = new System.Drawing.Point(253, 9);
            this.labelInfo.Name = "labelInfo";
            this.labelInfo.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.labelInfo.Size = new System.Drawing.Size(539, 18);
            this.labelInfo.TabIndex = 3;
            this.labelInfo.Text = "Informations";
            // 
            // Aide
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(804, 564);
            this.Controls.Add(this.labelInfo);
            this.Controls.Add(this.labelSujet);
            this.Controls.Add(this.textBox);
            this.Controls.Add(this.treeAide);
            this.Name = "Aide";
            this.Text = "Aide";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView treeAide;
        private System.Windows.Forms.RichTextBox textBox;
        private System.Windows.Forms.Label labelSujet;
        private System.Windows.Forms.Label labelInfo;

    }
}