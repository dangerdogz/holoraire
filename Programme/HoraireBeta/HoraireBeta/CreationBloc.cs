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
    public partial class CreationBloc : Form
    {
        String hd;
        String hf;
        public CreationBloc(/*double* hd, double* hf*/)
        {
            InitializeComponent();
        }

        public void setHeures()
        {
            hd = textBox_hrdebut.Text;
            hf = textBox_hrfin.Text;
        }

        public String getHd()
        {
            return hd;
        }

        public String getHf()
        {
            return hf;
        }

        private void button_blocconfirm_Click(object sender, EventArgs e)
        {

            setHeures();
            //MessageBox.Show(this, "" + hd);
            this.Hide();
        }
    }
}
