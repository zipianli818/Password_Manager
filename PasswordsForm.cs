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
        public delegate void OnConfirmHandler(Account account);
        public event OnConfirmHandler OnConfirm;

        private DataContext dataContext = new DataContext();
        private User _currentUser;
        private Account _currentAccount;
        public PasswordsForm(User currentUser)
        {
            InitializeComponent();
            _currentUser = currentUser;
            dataContext.Users.Attach(currentUser);
            _currentAccount = new Account();
        }

        public PasswordsForm(User currentUser, Account account)
        {
            InitializeComponent();
            accountNameTextBox.Text = account.Address;
            usernameTextBox.Text = account.Username;
            passwordTextBox.Text = account.Password;
            _currentUser = currentUser;
            dataContext.Users.Attach(currentUser);
            _currentAccount = account;
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            _currentAccount.Address = accountNameTextBox.Text;
            _currentAccount.Username = usernameTextBox.Text;
            _currentAccount.Password = passwordTextBox.Text;
            _currentAccount.User = _currentUser;
            // Let the AccountsForm handle what to do with the new/edited account.
            OnConfirm.Invoke(_currentAccount);
            Close();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void generatePasswordButton_Click(object sender, EventArgs e)
        {
            // Generate a value for the passwordTextBox here.
            // Use includeNumberCheckbox.Checked and includeSpecialCharsCheckbox.Checked to determine how to generate the password.

            RandomNumberGenerator rng = new RandomNumberGenerator();

            bool includeNumbers = includeNumberCheckbox.Checked;
            bool includeSpecialChars = includeSpecialCharsCheckbox.Checked;

            StringBuilder password = new StringBuilder();
            password.Append(rng.RandomString(10, true)); // Generate a random lowercase string.

            if (includeNumbers)
            {
                password.Append(rng.RandomNumber(1000, 10000)); // Generate a random 4-digit number.
            }

            if (includeSpecialChars)
            {
                password.Append(rng.RandomCharacter()); // Add a random special character.
            }

            password.Append(rng.RandomString(1, false).First()); // Add an uppercase letter.

            // Set the generated password in the passwordTextBox.
            passwordTextBox.Text = password.ToString();

            MessageBox.Show("Password: " + password + " " +
                            "have been generated!");

        }

        private void PasswordsForm_Load(object sender, EventArgs e)
        {

        }

        private void accountNameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        //private void button3_Click(object sender, EventArgs e)
        //{
        //    String passwordID = accountNameTextBox.Text;
        //    String passwordName = usernameTextBox.Text;
        //    String password = passwordTextBox.Text;

        //    MessageBox.Show("Password ID: " + accountNameTextBox + " " +
        //                    "Password Name: " + usernameTextBox + " " +
        //                    "Password: " + passwordTextBox + " " +
        //                    "have been saved!");
        //}
    }
}
