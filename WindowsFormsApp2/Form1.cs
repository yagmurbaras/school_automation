using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SqlCommand komut;
        SqlCommand komut2;
        SqlDataReader reader;
        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
      

        public void girisyap(string eposta, string sifre, Form1 frm)
        {


            SqlConnection con = new SqlConnection("Data Source=LAPTOP-9GT44D0T\\SQLEXPRESS;Initial Catalog=school1;Integrated Security=True");

            komut = new SqlCommand("select * from users where mail='" + eposta + "' and password='" + sifre + "'", con);
            komut2 = new SqlCommand("select * from users where mail='" + eposta + "' and password='" + sifre + "' and rolId=" + 0 + "", con);

            con.Open();
            reader = komut.ExecuteReader();

            if (reader.Read())
            {
                reader.Close();
                reader = komut2.ExecuteReader();

                if (reader.Read())
                {
                    Form2 frm2 = new Form2();
                    frm2.Show();
                }
                else
                {
                    Form3 frm3 = new Form3();
                    frm3.Show();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            

           string eposta = textBox1.Text;
            string password = textBox2.Text;
            girisyap(eposta, password, this);



        }
    }
}