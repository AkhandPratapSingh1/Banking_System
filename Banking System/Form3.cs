using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Banking_System
{
    public partial class addCustomer : Form
    {
        public addCustomer()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            Random slumpGenerator = new Random();
            // Or whatever limits you want... Next() returns a double
            int tal = slumpGenerator.Next(0, 100000);
            textBox1.Text = tal.ToString();

        }
        String Gender;

        private void C_Click(object sender, EventArgs e)
        {

        }

        private void name_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void hScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
                   }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            textBox4.ScrollBars = ScrollBars.Vertical;
            this.Controls.Add(textBox4);
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == string.Empty || textBox2.Text == string.Empty || textBox3.Text == String.Empty || genderGroup.Text == String.Empty || textBox4.Text == string.Empty | textBox5.Text == string.Empty || textBox6.Text == string.Empty || textBox7.Text == String.Empty || textBox8.Text == String.Empty || textBox9.Text == String.Empty)
            {
                MessageBox.Show("Empty Field", "MESSAGE:.......", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {

                string gender = "Male";
                if (femaleButton.Checked)
                {
                    gender = "Female";
                }
                /*DateTime theDate = DateTime.Now;
                theDate.ToString("yyyy-MM-dd H:mm:ss");*/
                MySqlConnection con = new MySqlConnection("datasource= localhost; database=bank_login;port=3306; username = root; password= Aps113322"); //open connection
                con.Open();
                MySqlCommand cmd = new MySqlCommand("insert into customer values('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + gender + "','" + textBox4.Text + " ','" + textBox5.Text + "','" + textBox6.Text + "','" + textBox7.Text + "','" + textBox8.Text + "','" + textBox9.Text + "','" + textBox10.Text +  "')", con);
        
                cmd.ExecuteNonQuery();

                cmd.Dispose();
                textBox2.Text = string.Empty;
                 
                con.Close();
                MessageBox.Show("Successfully Added", "SUCCESS::>>>>>", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Form4 acnt = new Form4();
                acnt.Show();
                this.Close();

            }





    }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void MaleButton_CheckedChanged(object sender, EventArgs e)
        {
            Gender = "Male";
        }

        private void femaleButton_CheckedChanged(object sender, EventArgs e)
        {
            Gender = "Female";
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
