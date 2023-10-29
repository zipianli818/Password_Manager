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
    public partial class AccountsForm : Form
    {
        public User CurrentUser { get; set; }

        private DataContext _dataContext = new DataContext();
        private AccountRow? _firstAccountRow;
        private VisibilityMode _visibilityMode = VisibilityMode.All;
        private Folder? _activeFolder;

        public AccountsForm()
        {
            InitializeComponent();

            // Debug
            CurrentUser = _dataContext.Users.First();

            PopulateFolderPanel();
            PopulateAccountPanel();

            // Note(Pete): This odd combination of commands will ensure the horizontal scroll 
            folderFlowPanel.AutoScroll = false;
            folderFlowPanel.HorizontalScroll.Maximum = 0;
            folderFlowPanel.AutoScroll = true;
        }

        /// <summary>
        /// Manually sets the first child's width to match the width of the flow panel because Winforms is incapable of doing this correctly.
        /// The first child will dictate the size of the subsequent children if they are set to DockMode.Top.
        /// </summary>
        private void ResizeFolderPanelContents()
        {

            if (folderFlowPanel.Controls.Count == 0)
                return;

            var firstButton = folderFlowPanel.Controls[0];
            firstButton.Width = folderFlowPanel.Width;
        }

        private void PopulateFolderPanel()
        {
            var folders = _dataContext.Folders.Where(f => f.User.Id == CurrentUser.Id).ToArray();
            foreach (var folder in folders)
            {
                CreateFolderButton(folder);
            }
        }

        private void CreateFolderButton(Folder folder)
        {
            var folderButton = new Button
            {
                FlatStyle = FlatStyle.Flat,
                Height = 32,
                Margin = new Padding(0),
                Text = folder.Name
            };

            // Add context menu to button
            var buttonContextMenu = new ContextMenuStrip();
            buttonContextMenu.Items.Add("Delete Folder");
            buttonContextMenu.Items[0].Click += (object? sender, EventArgs e) =>
            {
                folderFlowPanel.Controls.Remove(folderButton);
                _dataContext.Folders.Remove(folder);
                _dataContext.SaveChanges();
            };

            folderButton.ContextMenuStrip = buttonContextMenu;

            // Note(Pete): All controls apart from the first control must be docked to the top so that they will
            // copy the width of the topmost control. Refer to resizeFolderPanelContents for more details.
            if (folderFlowPanel.Controls.Count != 0)
                folderButton.Dock = DockStyle.Top;

            folderFlowPanel.Controls.Add(folderButton);
        }

        private void ResizeAccountPanelContents()
        {
            if (accountFlowPanel.Controls.Count == 0)
                return;

            if (_firstAccountRow != null)
                _firstAccountRow.Width = accountFlowPanel.Width;
        }
        private void PopulateAccountPanel()
        {
            var accounts = _dataContext.Accounts.Where(a => a.User.Id == CurrentUser.Id).ToArray();
            foreach (var account in accounts)
            {
                CreateAccountRow(account);
            }
        }

        private void CreateAccountRow(Account account)
        {
            var accountRow = new AccountRow(account);
            accountRow.Margin = new Padding(0);
            // Don't show the row if it's binned.
            accountRow.Visible = !account.Binned;

            accountRow.OnDelete += () =>
            {
                accountFlowPanel.Controls.Remove(accountRow);
                account.Binned = true;
                _dataContext.Accounts.Update(account);
                _dataContext.SaveChanges();
            };

            if (accountFlowPanel.Controls.Count != 0)
                accountRow.Dock = DockStyle.Top;

            accountFlowPanel.Controls.Add(accountRow);
            if (_firstAccountRow == null)
                _firstAccountRow = accountRow;
        }

        /// <summary>
        /// This is needed to correctly setup the required properties to allow for the rows to be formatted correctly.
        /// This should be called everytime the visibility of Account Rows is altered.
        /// </summary>
        private void FixAccountRowLayout()
        {
            var first = true;
            foreach (AccountRow accountRow in accountFlowPanel.Controls)
            {
                if (!accountRow.Visible) continue;
                if (first)
                {
                    accountRow.Dock = DockStyle.None;
                    accountRow.Width = accountFlowPanel.Width;
                    _firstAccountRow = accountRow;
                    first = false;
                }
                else
                    accountRow.Dock = DockStyle.Top;
            }
        }

        private void FilterAccountRows(Predicate<Account> visibilityPredicate)
        {
            foreach (AccountRow accountRow in accountFlowPanel.Controls)
                accountRow.Visible = visibilityPredicate.Invoke(accountRow.Account);
        }


        // Events

        // Called everytime the folder panel needs to redraw itself
        private void folderFlowPanel_Layout(object sender, LayoutEventArgs e)
        {
            ResizeFolderPanelContents();
        }

        private void accountFlowPanel_Layout(object sender, LayoutEventArgs e)
        {
            ResizeAccountPanelContents();
        }

        private void addFolderButton_Click(object sender, EventArgs e)
        {
            TextInputModal.ShowModal("Add Folder", true, (string text) =>
            {
                var newFolder = new Folder(text, CurrentUser);
                _dataContext.Folders.Add(newFolder);
                _dataContext.SaveChanges();

                CreateFolderButton(newFolder);
            });
        }

        private void addAccountButton_Click(object sender, EventArgs e)
        {
            PasswordsForm.ShowModal("Add new Account", true, (Account newAccount) =>
            {
                _dataContext.Accounts.Add(newAccount);
                _dataContext.SaveChanges();

                CreateAccountRow(newAccount);
            });
        }

        private void allAccountsButton_Click(object sender, EventArgs e)
        {
            _visibilityMode = VisibilityMode.All;
            FilterAccountRows((account) => !account.Binned);
            FixAccountRowLayout();
        }

        private void binButton_Click(object sender, EventArgs e)
        {
            _visibilityMode = VisibilityMode.Binned;
            FilterAccountRows((account) => account.Binned);
            FixAccountRowLayout();
        }

        private void searchTextbox_TextChanged(object sender, EventArgs e)
        {
            switch (_visibilityMode)
            {

                case VisibilityMode.All:
                    FilterAccountRows((account) => !account.Binned && account.Address.Contains(searchTextbox.Text));
                    break;
                case VisibilityMode.Binned:
                    FilterAccountRows((account) => account.Binned && account.Address.Contains(searchTextbox.Text));
                    break;
                case VisibilityMode.Folder:
                    if (_activeFolder is not null)
                        FilterAccountRows((account) => {
                            if (account.Binned) return false;
                            if (account.Folder is null) return false;
                            return account.Folder.Id == _activeFolder.Id && !account.Binned && account.Address.Contains(searchTextbox.Text);
                            });
                    break;
            }

            FixAccountRowLayout();
        }

        private void AccountsForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            // Show the Login Form if we close the Accounts form.
            // Note(Pete): We need to cast Owner here in order to use our own Show() method.
            (Owner as MainForm).Show();
        }
    }
}

enum VisibilityMode
{
    All,
    Binned,
    Folder,
}
