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
        public AjouterPoste(String nom, String desc)
        {
            setName(nom);
            setDesc(desc);
        }
        public AjouterPoste(int id, String nom, String desc)
        {
            setId(id);
            setName(nom);
            setDesc(desc);
        }
        public void setId(int id)
        {
            id = -1;
        }
        public void setName(string pname)
        {
            this.pname = pname;
        }
        public void setDesc(string pdesc)
        {
            this.pdesc = pdesc;
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
        public void save()
        {
            DBConnect proc = new DBConnect();
            int id = -1;
            if (id < 0)
            {
                proc.addPoste(pname, pdesc);
                id = Convert.ToInt32(proc.getLastStuff("Poste").Rows[0]["last_insert_rowid()"].ToString());
            }
            else
            {
                proc.modifyPoste(id, pname, pdesc);
            }
        }
    }
}
