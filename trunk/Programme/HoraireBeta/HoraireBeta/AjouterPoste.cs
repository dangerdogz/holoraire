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
    public partial class AjouterPoste : Form
    {
        String pname;
        String pdesc;
        public AjouterPoste()
        {
            InitializeComponent();
        }

        private void button_annul_aj_post_Click(object sender, EventArgs e)
        {
            AjouterPoste.ActiveForm.Dispose();
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
            pdesc = richTextBox_descposte.Text;
        }

        public String getpName()
        {
            return pname;
        }

        public String getpDesc()
        {
            return pdesc;
        }
    }
}
