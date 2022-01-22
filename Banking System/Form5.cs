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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == string.Empty || textBox3.Text == String.Empty || groupBox1.Text == String.Empty || textBox4.Text == string.Empty | textBox5.Text == string.Empty || textBox6.Text == string.Empty || textBox7.Text == String.Empty || textBox8.Text == String.Empty || textBox9.Text == String.Empty)
            {
                MessageBox.Show("Empty Field", "\\Error:::...", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {

                string gender = "Male";
                if (radioButton1.Checked)
                {
                    gender = "Female";
                }

                MySqlConnection con = new MySqlConnection("datasource= localhost; database=bank_login;port=3306; username = root; password= Aps113322"); //open connection
                con.Open();
                MySqlCommand cmd2 = new MySqlCommand("update customer set UserId = '" + textBox2.Text + "', Name='" + textBox3.Text + "',  gender='" + gender + "', address='" + textBox4.Text + "',   city='" + textBox5.Text + "',  state = '" + textBox6.Text + "', pin='" + textBox7.Text + "', telephone='" + textBox8.Text + "', fax='" + textBox9.Text + "', Email='" + textBox10.Text + "'", con);
                cmd2.ExecuteNonQuery();

                cmd2.Dispose();
                con.Close();
                MessageBox.Show("Successfully update", "SUCCESSS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection("datasource= localhost; database=bank_login;port=3306; username = root; password= Aps113322"); //open connection
            con.Open();
            MySqlCommand cmd = new MySqlCommand("select * from customer where customerID= '" + textBox1.Text + "'", con);
            MySqlDataReader reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                textBox2.Text = reader.GetString("UserId");
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
