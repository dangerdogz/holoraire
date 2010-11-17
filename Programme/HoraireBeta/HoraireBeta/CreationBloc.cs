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
        string hd;
        string hf;
        public CreationBloc(string hd, string hf)
        {
            InitializeComponent(hd,hf);
            
        }

        public void setHeures()
        {
            hd = textBox_hrdebut.Text;
            hf = textBox_hrfin.Text;
        }

        public string getHd()
        {
            return hd;
        }

        public string getHf()
        {
            return hf;
        }

        private void button_blocconfirm_Click(object sender, EventArgs e)
        {
            for (int i = 0; i <= textBox_hrdebut.Text.Length; i++)
            {
                
            }
            if (hf == "25")
                hf = "1";
            if (hd == "24")
                hd = "0";
            if (hf == "24")
                hf = "0";

            setHeures();
            //MessageBox.Show(this, "" + hd);
            this.Hide();
        }
    }
}
