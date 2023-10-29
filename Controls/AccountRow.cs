using Password_Manager.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.CodeAnalysis;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Password_Manager.Controls;

public partial class AccountRow : UserControl
{
    public delegate void onDeleteHandler();
    public event onDeleteHandler OnDelete;

    public delegate void onEditHandler();
    public event onDeleteHandler OnEdit;
    public Account Account { get; set; }

    public AccountRow(Account account)
    {
        InitializeComponent();
        Account = account;
        usernameLabel.Text = account.Username;
        siteNameLabel.Text = account.Address;
    }

    private void copyButton_Click(object sender, EventArgs e)
    {
        Clipboard.SetText(Account.Password);
        copiedToClipboardLabel.Visible = true;

        Task.Run(async () =>
        {
            await Task.Delay(3000);
            // Note(Pete): We may be on another thread here so we need to ask the UI thread to invoke the following.
            copiedToClipboardLabel.Invoke(() =>
            {
                copiedToClipboardLabel.Visible = false;
            });
        });
    }

    private void deleteButton_Click(object sender, EventArgs e)
    {
        OnDelete.Invoke();
    }

    private void editButton_Click(object sender, EventArgs e)
    {
        OnEdit.Invoke();
    }
}
