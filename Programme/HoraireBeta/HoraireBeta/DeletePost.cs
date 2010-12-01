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
    public partial class DeletePost : Form
    {
        String pname;
        public DeletePost()
        {
            InitializeComponent();
        }

        public void setName(String pname)
        {
            this.pname = pname;
        }

        private void button_OUI_poste_Click(object sender, EventArgs e)
        {
            delete(pname);
            this.Hide();
        }

        private void button_NON_poste_Click(object sender, EventArgs e)
        {
            DeletePost.ActiveForm.Dispose();
        }

        public void delete(String poste)
        {
            DBConnect proc = new DBConnect();
            proc.deletePoste2(poste);
        }
    }
}
