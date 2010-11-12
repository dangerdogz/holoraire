using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace HoraireBeta
{
    public partial class AjouterEquipe : Form
    {
        String ename;
        String edesc;
        public AjouterEquipe()
        {
            InitializeComponent();
        }

        public void setEquipe()
        {
            ename = textBox_nomequipe.Text;
            edesc = richTextBox_descequipe.Text;
        }

        public String geteName()
        {
            return ename;
        }

        public String geteDesc()
        {
            return edesc;
        }

        private void button_annul_aj_equipe_Click(object sender, EventArgs e)
        {
            AjouterEquipe.ActiveForm.Dispose();
        }

        private void button_aj_equipe_confirm_Click(object sender, EventArgs e)
        {
            setEquipe();
            this.Hide();
        }
    }
}
