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
        public AjouterPoste()
        {
            InitializeComponent();
        }

        private void button_annul_aj_post_Click(object sender, EventArgs e)
        {
            AjouterPoste.ActiveForm.Dispose();
        }
    }
}
