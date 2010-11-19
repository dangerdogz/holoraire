using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using HoraireBeta;

namespace HoraireBeta
{
    public partial class NbPoste : Form
    {
        String pname;
        private Button confirmer;
        private Button annuler;
        private TextBox nombre;
        private TextBox textBox2;
        private Label nPoste;
        private Label nNb;
        private Label titre;
        String nb;

        public NbPoste()
        {
            InitializeComponent();
        }

        public NbPoste(String nom, String nb)
        {
            InitializeComponent(); 
            setName(nom);
            setNb(nb);
        }

        public void setName(string pname)
        {
            this.pname = pname;
            this.textBox2.Text = pname;
        }

        public void setNb(string nb)
        {
            this.nb = nb;
            this.nombre.Text = nb;
        }

        private void button_annul_aj_post_Click(object sender, EventArgs e)
        {
            NbPoste.ActiveForm.Dispose();
        }

        private void button_aj_post_confirm_Click(object sender, EventArgs e)
        {
            setPoste();
            this.Hide();
        }

        private void textBox_nomposte_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox_descposte_TextChanged(object sender, EventArgs e)
        {

        }

        public void setPoste()
        {
            pname = textBox2.Text;
            nb = nombre.Text;
        }

        public String getpName()
        {
            return pname;
        }

        public String getNb()
        {
            return nb;
        }

        private void label_descripposte_Click(object sender, EventArgs e)
        {

        }

        private void InitializeComponent()
        {
            this.confirmer = new System.Windows.Forms.Button();
            this.annuler = new System.Windows.Forms.Button();
            this.nombre = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.nPoste = new System.Windows.Forms.Label();
            this.nNb = new System.Windows.Forms.Label();
            this.titre = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // confirmer
            // 
            this.confirmer.Location = new System.Drawing.Point(168, 192);
            this.confirmer.Name = "confirmer";
            this.confirmer.Size = new System.Drawing.Size(75, 23);
            this.confirmer.TabIndex = 0;
            this.confirmer.Text = "Confirmer";
            this.confirmer.UseVisualStyleBackColor = true;
            this.confirmer.Click += new System.EventHandler(this.button1_Click);
            // 
            // annuler
            // 
            this.annuler.Location = new System.Drawing.Point(30, 192);
            this.annuler.Name = "annuler";
            this.annuler.Size = new System.Drawing.Size(75, 23);
            this.annuler.TabIndex = 1;
            this.annuler.Text = "Annuler";
            this.annuler.UseVisualStyleBackColor = true;
            this.annuler.Click += new System.EventHandler(this.annuler_Click);
            // 
            // nombre
            // 
            this.nombre.Location = new System.Drawing.Point(127, 117);
            this.nombre.Name = "nombre";
            this.nombre.Size = new System.Drawing.Size(34, 20);
            this.nombre.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Location = new System.Drawing.Point(143, 83);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(100, 13);
            this.textBox2.TabIndex = 3;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // nPoste
            // 
            this.nPoste.AutoSize = true;
            this.nPoste.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.nPoste.Location = new System.Drawing.Point(27, 79);
            this.nPoste.Name = "nPoste";
            this.nPoste.Size = new System.Drawing.Size(96, 17);
            this.nPoste.TabIndex = 4;
            this.nPoste.Text = "Nom du poste";
            this.nPoste.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // nNb
            // 
            this.nNb.AutoSize = true;
            this.nNb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nNb.Location = new System.Drawing.Point(27, 121);
            this.nNb.Name = "nNb";
            this.nNb.Size = new System.Drawing.Size(57, 16);
            this.nNb.TabIndex = 5;
            this.nNb.Text = "Nombre";
            this.nNb.Click += new System.EventHandler(this.label2_Click);
            // 
            // titre
            // 
            this.titre.AutoSize = true;
            this.titre.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.titre.Location = new System.Drawing.Point(55, 9);
            this.titre.Name = "titre";
            this.titre.Size = new System.Drawing.Size(169, 25);
            this.titre.TabIndex = 6;
            this.titre.Text = "Ajouter un poste";
            this.titre.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.titre.Click += new System.EventHandler(this.label3_Click);
            // 
            // NbPoste
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(284, 264);
            this.Controls.Add(this.titre);
            this.Controls.Add(this.nNb);
            this.Controls.Add(this.nPoste);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.nombre);
            this.Controls.Add(this.annuler);
            this.Controls.Add(this.confirmer);
            this.Name = "NbPoste";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            setPoste();
            this.Hide();
        }

        private void annuler_Click(object sender, EventArgs e)
        {
            //Hommage à Johnny
            MessageBox.Show("Pèse pas la dessus, le programme plante");
            this.Hide();
        }
    }
}
