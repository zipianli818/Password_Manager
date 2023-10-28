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
    public partial class TextInputModal : Form, IModal<string>
    {
        public TextInputModal()
        {
            InitializeComponent();
        }

        public static void ShowModal(string title, Action<string> onConfirm)
        {
            ShowModal(title, onConfirm, null);
        }

        public static void ShowModal(string title, Action<string> onConfirm, Action? onCancel)
        {
            var modal = new TextInputModal();
            modal.modalLabel.Text = title;
            modal.Text = title;
            modal.StartPosition = FormStartPosition.CenterParent;

            modal.confirmButton.Click += (object? _, EventArgs _) =>
            {
                // Don't allow empty or whitespace strings as folder names.
                if (string.IsNullOrWhiteSpace( modal.nameTextBox.Text))
                {
                    MessageBox.Show("Cannot have a folder without a name");
                    return;
                }
                onConfirm.Invoke(modal.nameTextBox.Text);
                modal.Close();
            };

            modal.cancelButton.Click += (object? _, EventArgs _) =>
            {
                onCancel?.Invoke();
                modal.Close();
            };

            modal.ShowDialog();
        }
    }
}
