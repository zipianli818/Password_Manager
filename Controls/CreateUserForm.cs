using Password_Manager.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Password_Manager.Controls
{
    public partial class CreateUserForm : Form, IModal<User>
    {
        public CreateUserForm()
        {
            InitializeComponent();
        }

        public static void ShowModal(string title, bool exclusive, Action<User> onConfirm, Action? onCancel = null)
        {
            var modal = new CreateUserForm();
            modal.Text = title;
            modal.StartPosition = FormStartPosition.CenterParent;

            // Note(Pete): This is created as a delegate variable so that we can remove it from the FormClosed event when we press confirm.
            FormClosedEventHandler formClosedEventHandler = (object? _, FormClosedEventArgs _) =>
            {
                onCancel?.Invoke();
            };

            modal.confirmButton.Click += (_, _) =>
            {
                if (string.IsNullOrWhiteSpace(modal.emailTextBox.Text))
                {
                    MessageBox.Show("Please enter an email.");
                    return;
                }
                if (string.IsNullOrWhiteSpace(modal.passwordTextBox.Text))
                {
                    MessageBox.Show("Please enter an password.");
                    return;
                }
                if (modal.passwordTextBox.Text != modal.confirmPasswordTextBox.Text)
                {
                    MessageBox.Show("The passwords entered do not match.");
                    return;
                }

                var newUser = new User
                {
                    Username = modal.emailTextBox.Text,
                    Password = modal.passwordTextBox.Text
                };
                onConfirm.Invoke(newUser);
                modal.FormClosed -= formClosedEventHandler;
                modal.Close();
            };

            modal.cancelButton.Click += (_, _) =>
            {
                modal.Close();
            };

            modal.FormClosed += formClosedEventHandler;

            if (exclusive)
                modal.ShowDialog();
            else
                modal.Show();
        }
    }
}
