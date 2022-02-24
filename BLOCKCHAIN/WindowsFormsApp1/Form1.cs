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

namespace WindowsFormsApp1
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

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string user = txtAD.Text;
            string password = txtSİFRE.Text;
            con = new SqlConnection("Data Source=BLEGEND\\SQLEXPRESS;Initial Catalog=BLEGEND;Integrated Security=True");
            com = new SqlCommand();
            con.Open();
            com.Connection = con;
            com.CommandText = "Select *from onay where kullanıcı_adı='" + txtAD.Text + " 'And sifre='" + txtSİFRE.Text + "'";
            dr = com.ExecuteReader();
            if (dr.Read())
            {
                MessageBox.Show("LOGIN SUCCESFULL!!");
                Form1 gecis = new Form1();
                gecis.Show();
                this.Hide();
            }

            else
            {
                MessageBox.Show("WRONG USERNAME OR PASSWORD!!");

            }
            con.Close();





        
    }
    }
}
