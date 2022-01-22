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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void sEPToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void maintenanceToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void newCustomerDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            addCustomer f1 = new addCustomer();
            f1.Show();
        }

        private void newAccountDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form4 newfrommenu = new Form4();
            newfrommenu.Show();
        }

        private void editCustomerDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form5 f3 = new Form5();
            f3.Show();
        }

        private void deleteCustomerDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form6 deletecst = new Form6();
            deletecst.Show();

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            frm.Close();
        }
    }
}
