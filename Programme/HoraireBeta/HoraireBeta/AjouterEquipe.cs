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
        public AjouterEquipe(String name, String desc)
        {
            setName(name);
            setDesc(desc);
        }
        public AjouterEquipe(int id, String name, String desc)
        {
            setId(id);
            setName(name);
            setDesc(desc);
        }
        public void setId(int id)
        {
            id = -1;
        }
        public void setName(String ename)
        {
            this.ename = ename;
        }
        public void setDesc(String edesc)
        {
            this.edesc = edesc;
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
        public void save()
        {
            int id = -1;
            DBConnect proc = new DBConnect();
            if (id < 0)
            {
                proc.addTeam(ename, edesc);
                id = Convert.ToInt32(proc.getLastStuff("Team").Rows[0]["last_insert_rowid()"].ToString());
            }
            else
            {
                proc.modifyTeam(id, ename, edesc);

                proc.deleteTeamProfile(id);
            }
        }
    }
}
