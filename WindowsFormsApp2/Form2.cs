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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=LAPTOP-9GT44D0T\\SQLEXPRESS;Initial Catalog=school1;Integrated Security=True");

            string email = textBox3.Text;
            string password = textBox8.Text;
            string name = textBox1.Text;
            string surname = textBox2.Text;
            string telephonenumber = textBox4.Text;
            string department = textBox5.Text;
            string title = textBox6.Text;
            string role = textBox7.Text;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'school1DataSet1.users' table. You can move, or remove it, as needed.
            this.usersTableAdapter.Fill(this.school1DataSet1.users);

        }
    }
}
