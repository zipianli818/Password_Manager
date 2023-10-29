using Password_Manager.Controls;
using Password_Manager.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Password_Manager
{
    public partial class PasswordsForm : Form
    {
        public PasswordPropertyTextAttribute CurrentPassword { get; set; }

        private DataContext dataContext = new DataContext();
        public PasswordsForm()
        {
            InitializeComponent();

        }

        private void PasswordsForm_Load(object sender, EventArgs e)
        {

        }

        private void PasswordsForm_Load_1(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void allAccountsButton_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void accountFlowPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void label6_Click_1(object sender, EventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            String passwordID = PasswordId.Text;
            String passwordName = PasswordName.Text;
            String password = RPassword.Text;

            MessageBox.Show("Password ID: " + PasswordId + " " +
                            "Password Name: " + PasswordName + " " +
                            "Password: " + RPassword + " " +
                            "have been saved!");
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void RPassword_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
