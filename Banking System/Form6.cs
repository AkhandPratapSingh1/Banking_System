using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Banking_System
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void Form6_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection("datasource= localhost; database=bank_login;port=3306; username = root; password= Aps113322"); //open connection
            con.Open();
            MySqlCommand cmd = new MySqlCommand("select * from customer where customerId= '" + textBox1.Text + "'", con);
            MySqlDataReader reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                textBox2.Text = reader.GetString("userId");
                textBox3.Text = reader.GetString("Name");
                groupBox1.Text = reader.GetString("gender");
                textBox4.Text = reader.GetString("address");
                textBox5.Text = reader.GetString("city");
                textBox6.Text = reader.GetString("state");
                textBox7.Text = reader.GetString("pin");
                textBox8.Text = reader.GetString("telephone");
                textBox9.Text = reader.GetString("fax");
                textBox10.Text = reader.GetString("Email");

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection("datasource= localhost; database=bank_login;port=3306; username = root; password= Aps113322"); //open connection
            con.Open();
            MySqlCommand cmd2 = new MySqlCommand("Delete from customer where customerId='" + textBox1.Text + "'", con);
            cmd2.ExecuteNonQuery();

            cmd2.Dispose();
            con.Close();
            MessageBox.Show("Successfully update", "pg", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
