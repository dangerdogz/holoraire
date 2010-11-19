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
        String nb;
        public NbPoste()
        {
            InitializeComponent();
        }
        public NbPoste(String nom, String nb)
        {
            setName(nom);
            setNb(nb);
        }

        public void setName(string pname)
        {
            this.pname = pname;
            //this.textBox_nomposte.Text = pname;
        }
        public void setNb(string nb)
        {
            this.nb = nb;
            //this.TextBox_nbPoste.Text = nb;
            
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
            pname = textBox_nomposte.Text;
            nb = TextBox_nbPoste.Text;
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
    }
}
