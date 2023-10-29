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

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            String passwordID = PasswordId.Text;
            String passwordName = PasswordName.Text;
            String password = Password.Text;
            
            MessageBox.Show("Password ID: " + PasswordId + " " +
                            "Password Name: " + PasswordName + " " +
                            "Password: " + Password + " " +
                            "have been saved!");
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
