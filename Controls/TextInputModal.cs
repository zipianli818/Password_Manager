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

        public static void ShowModal(string title, bool exclusive, Action<string> onConfirm, Action? onCancel = null)
        {
            var modal = new TextInputModal();
            modal.modalLabel.Text = title;
            modal.Text = title;
            modal.StartPosition = FormStartPosition.CenterParent;

            // Note(Pete): This is created as a delegate variable so that we can remove it from the FormClosed event when we press confirm.
            FormClosedEventHandler formClosedEventHandler = (_, _) =>
            {
                onCancel?.Invoke();
            };

            modal.confirmButton.Click += (_, _) =>
            {
                // Don't allow empty or whitespace strings as folder names.
                if (string.IsNullOrWhiteSpace(modal.nameTextBox.Text))
                {
                    MessageBox.Show("Cannot have a folder without a name");
                    return;
                }
                onConfirm.Invoke(modal.nameTextBox.Text);
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
