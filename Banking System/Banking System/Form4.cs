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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
           
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged_1(object sender, EventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == string.Empty || textBox3.Text == String.Empty || comboBox1.Text == String.Empty)
            {
                MessageBox.Show("Empty Field", "//error::", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                int number;
                if (int.TryParse(textBox3.Text, out number))
                {
                    if (number < 500)
                    {
                        MessageBox.Show("Current Amount Should not be less than 500", "\\ERROR:", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                    else
                    {
                        string status = "Functional";
                        if (radioButton2.Checked)
                        {
                            status = "Closed";
                        }
                        object sel = comboBox1.SelectedValue;
                        /*DateTime theDate = DateTime.Now;
                        theDate.ToString("yyyy-MM-dd H:mm:ss");*/
                        MySqlConnection con = new MySqlConnection("datasource= localhost; database=bank_login;port=3306; username = root; password= Aps113322"); //open connection
                        con.Open();
                        MySqlCommand cmd = new MySqlCommand("insert into account values('" + comboBox1.GetItemText(comboBox1.SelectedItem) + "','" + textBox3.Text + "','" + status + "')", con);
                        cmd.ExecuteNonQuery();

                        cmd.Dispose();
                        textBox2.Text = string.Empty;

                        con.Close();
                        MessageBox.Show("Successfully Added", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                }
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
