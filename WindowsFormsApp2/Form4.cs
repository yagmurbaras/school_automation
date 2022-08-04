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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();

        }

        private void Form4_Load(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection();
            baglanti.ConnectionString = "Data Source=LAPTOP-9GT44D0T\\SQLEXPRESS;Initial Catalog=school1;Integrated Security=True";
            SqlCommand komut = new SqlCommand();
            komut.CommandText = "select*from Rols";
            komut.Connection = baglanti;
            komut.CommandType = CommandType.Text;
            SqlDataReader read;
            baglanti.Open();
            read = komut.ExecuteReader();
            while (read.Read())
            {
                comboBox1.Items.Add(read["rolName"]);
            }
            baglanti.Close();

            SqlConnection baglanti1 = new SqlConnection();
            baglanti1.ConnectionString = "Data Source=LAPTOP-9GT44D0T\\SQLEXPRESS;Initial Catalog=school1;Integrated Security=True";
            SqlCommand komut1 = new SqlCommand();
            komut1.CommandText = "select*from titles";
            komut1.Connection = baglanti1;
            komut1.CommandType = CommandType.Text;
            SqlDataReader read1;
            baglanti1.Open();
            read1 = komut1.ExecuteReader();
            while (read1.Read())
            {
                comboBox2.Items.Add(read1["titName"]);
            }
            baglanti1.Close();


            SqlConnection baglanti2 = new SqlConnection();
            baglanti2.ConnectionString = "Data Source=LAPTOP-9GT44D0T\\SQLEXPRESS;Initial Catalog=school1;Integrated Security=True";
            SqlCommand komut2 = new SqlCommand();
            komut2.CommandText = "select*from departmants";
            komut2.Connection = baglanti2;
            komut2.CommandType = CommandType.Text;
            SqlDataReader read2;
            baglanti2.Open();
            read2 = komut2.ExecuteReader();
            while (read2.Read())
            {
                comboBox3.Items.Add(read2["depName"]);
            }
            baglanti2.Close();


            SqlConnection baglanti3 = new SqlConnection();
            baglanti3.ConnectionString = "Data Source=LAPTOP-9GT44D0T\\SQLEXPRESS;Initial Catalog=school1;Integrated Security=True";
            SqlCommand komut3 = new SqlCommand();
            komut3.CommandText = "select*from actives";
            komut3.Connection = baglanti3;
            komut3.CommandType = CommandType.Text;
            SqlDataReader read3;
            baglanti3.Open();
            read3 = komut3.ExecuteReader();
            while (read3.Read())
            {
                comboBox4.Items.Add(read3["active"]);
            }
            baglanti3.Close();



        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 frm1 = new Form1();
            frm1.Show();

            SqlConnection con = new SqlConnection("Data Source=LAPTOP-9GT44D0T\\SQLEXPRESS;Initial Catalog=school1;Integrated Security=True");

            string email = textBox1.Text;
            string password = textBox2.Text;
            string name = textBox3.Text;
            string surname = textBox4.Text;
            string telephonenumber = textBox5.Text;
            string intNume = textBox6.Text;
            int role = comboBox1.SelectedIndex;
            int title = comboBox2.SelectedIndex;
            int department = comboBox3.SelectedIndex;
            int actId = comboBox4.SelectedIndex;



            con.Open();
            SqlCommand komutt = new SqlCommand("insert into users (mail,password,rolId,actId,titId,depId,name,surname,tel,intNum) values('"+textBox1.Text+"','"+textBox2.Text+"',"+comboBox1.SelectedIndex+","+comboBox4.SelectedIndex+","+comboBox2.SelectedIndex+","+comboBox3.SelectedIndex+",'"+textBox3.Text+"','"+textBox4.Text+"','"+textBox5.Text+"','"+textBox6.Text+"')", con);
            SqlDataReader dr = komutt.ExecuteReader();
            con.Close();
            




        }
    }
}
