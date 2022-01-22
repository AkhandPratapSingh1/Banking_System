using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Banking_System
{
    public partial class Form1 : Form
    {
        public static string SetValueForText1 { get; internal set; }

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void UserId_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void imgbtn_Click(object sender, EventArgs e)
        {
           PwdText.UseSystemPasswordChar = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (UseridText.Text == string.Empty || PwdText.Text == string.Empty)
            {
            }
            else
            {
                MySqlConnection con = new MySqlConnection("datasource= localhost; database=Bank_login;port=3306; username = root; password= Aps113322"); //open connection
                con.Open();
                MySqlCommand cmd = new MySqlCommand("select * from login where UserID = '" + UseridText.Text + "' AND Password = '" + PwdText.Text + "'", con);
                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    MessageBox.Show("Welcome, You are Successfully logged in", "Login Succeed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Form2 menustrip = new Form2();
                    
                    menustrip.Show();
                  
                }
                else
                {
                    MessageBox.Show("Username And Password Not Match!", "Akhand", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                UseridText.Text = string.Empty;
                PwdText.Text = string.Empty;
                reader.Close();
                cmd.Dispose();
                con.Close(); // always close connection }
            }
            


        }

        private void UseridText_TextChanged(object sender, EventArgs e)
        {

        }

        private void PwdText_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
