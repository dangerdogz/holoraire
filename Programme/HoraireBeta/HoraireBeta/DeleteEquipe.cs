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
    public partial class DeleteEquipe : Form
    {
        String ename;
        int id;
        public DeleteEquipe()
        {
            InitializeComponent();
        }

        public void setName(String ename)
        {
            this.ename = ename;
        }

        public void setid(int id)
        {
            this.id = id;
        }

        private void button_OUI_equipe_Click(object sender, EventArgs e)
        {
            delete(ename);
            this.Hide();
        }

        private void button_NON_equipe_Click(object sender, EventArgs e)
        {
            DeleteEquipe.ActiveForm.Dispose();
        }

        public void delete(String equipe)
        {
            DBConnect proc = new DBConnect();
            proc.deleteTeam2(equipe);
        }
    }
}
