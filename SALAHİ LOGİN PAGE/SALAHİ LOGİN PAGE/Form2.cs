using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SALAHİ_LOGİN_PAGE
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)

        {
           
            {
                double para;
                para = double.Parse(txtBITCOIN.Text);

                txtDOLLAR.Text = (para * 50000).ToString();
            }
           

        }

        private void button2_Click(object sender, EventArgs e)

        {
            double bıtcoın;
            bıtcoın = double.Parse(txtDOLLAR1.Text);

            txtBITCOIN1.Text = (bıtcoın / 50000).ToString();
        }
    }
}
