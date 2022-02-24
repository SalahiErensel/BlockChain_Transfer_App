using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;


namespace SALAHİ_LOGİN_PAGE
{
    public partial class Form1 : Form

    {
        SqlConnection con;
        SqlDataReader dr;
        SqlCommand com;

        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string user = txtAD.Text;
            string password = txtSİFRE.Text;
            con = new SqlConnection("Data Source=DESKTOP-98PTLBC;Initial Catalog=BLEGEND;Integrated Security=True");
            com = new SqlCommand();
            con.Open();
            com.Connection = con;
            com.CommandText = "Select *from onay where kullanıcı_adı='" + txtAD.Text + " 'And sifre='" + txtSİFRE.Text + "'";
            dr = com.ExecuteReader();
            if (dr.Read())
            {
                MessageBox.Show("LOGIN SUCCESSFUL!!");
                Form2 f2 = new Form2();
                f2.Show();
                
            }

            else
            {
                MessageBox.Show("WRONG USER OR PASSWORD!!");

            }
            con.Close();





        }
    }
    }

