using Microsoft.EntityFrameworkCore;
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

        private DataContext _dataContext;
        private User _currentUser;
        private Account _currentAccount;

        public PasswordsForm(User currentUser, DataContext dataContext)
        {
            InitializeComponent();
            _dataContext = dataContext;
            _currentUser = currentUser;
            dataContext.Users.Attach(currentUser);
            _currentAccount = new Account();

            PopulateFolderComboBox();
            folderComboBox.SelectedIndex = 0;
        }

        public PasswordsForm(User currentUser, Account account, DataContext dataContext)
        {
            InitializeComponent();
            _dataContext = dataContext;
            accountNameTextBox.Text = account.Address;
            usernameTextBox.Text = account.Username;
            passwordTextBox.Text = account.Password;
            _currentUser = currentUser;
            _dataContext.Users.Attach(currentUser);
            _currentAccount = account;

            PopulateFolderComboBox();

            if (account.Folder is not null)
            {
                var folders = dataContext.Folders.ToArray();
                for (int i = 0; i < folders.Length; i++)
                {
                    if (account.Folder.Id == folders[i].Id)
                    {
                        folderComboBox.SelectedIndex = i + 1;
                        break;
                    }
                }
            }
            else
                folderComboBox.SelectedIndex = 0;
        }

        private void PopulateFolderComboBox()
        {
            var folderNames = _dataContext.Folders.Select(f => f.Name).ToArray();
            folderComboBox.Items.AddRange(folderNames);
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            _currentAccount.Address = accountNameTextBox.Text;
            _currentAccount.Username = usernameTextBox.Text;
            _currentAccount.Password = passwordTextBox.Text;
            _currentAccount.User = _currentUser;

            if (folderComboBox.SelectedIndex > 0)
            {
                var folder = _dataContext.Folders.AsEnumerable().ElementAt(folderComboBox.SelectedIndex - 1);
                _currentAccount.Folder = folder;
            }
            else
            {
                _currentAccount.Folder = null;
            }

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
    }
}
