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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=LAPTOP-9GT44D0T\\SQLEXPRESS;Initial Catalog=school1;Integrated Security=True");

            string name = textBox1.Text;
            string surname = textBox2.Text;
            string mail = textBox3.Text;
            string telephonenumber = textBox4.Text;
            string department = textBox5.Text;
            string title = textBox6.Text;
            string role = textBox7.Text;
        }
    }
}
