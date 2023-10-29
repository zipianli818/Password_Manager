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

        public AccountsForm(User currentUser)
        {
            InitializeComponent();

            CurrentUser = currentUser;
            // Note(Pete): We have to tell EF to keep track of the current user because we've initialised a new DataContext for this Form.
            _dataContext.Users.Attach(currentUser);


            PopulateFolderPanel();
            PopulateAccountPanel();

            // Note(Pete): This odd combination of commands will ensure the horizontal scroll doesn't appear for the corresponding panels
            folderFlowPanel.AutoScroll = false;
            folderFlowPanel.HorizontalScroll.Maximum = 0;
            folderFlowPanel.AutoScroll = true;

            accountFlowPanel.AutoScroll = false;
            accountFlowPanel.HorizontalScroll.Maximum = 0;
            accountFlowPanel.AutoScroll = true;
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

            folderButton.Click += (sender, e) =>
            {
                folderLabel.Text = folder.Name;
                _activeFolder = folder;
                _visibilityMode = VisibilityMode.Folder;
                FilterAccountRows((account) =>
                {
                    if (account.Folder is null) return false;
                    return account.Folder.Id == _activeFolder.Id;
                });
                FixAccountRowLayout();
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
            var accountRow = new AccountRow(account)
            {
                Margin = new Padding(0),
                // Don't show the row if it's binned.
                Visible = !account.Binned
            };

            accountRow.OnDelete += () =>
            {
                accountFlowPanel.Controls.Remove(accountRow);
                account.Binned = true;
                _dataContext.Accounts.Update(account);
                _dataContext.SaveChanges();
            };

            accountRow.OnEdit += () =>
            {
                //var editAccountForm = new PasswordsForm(account);
                //editAccountForm.ShowDialog();
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
            //var newAccountForm = new PasswordsForm();
            // newAccountForm.OnConfirm += (account) =>
            //{
            //    _dataContext.Accounts.Add(newAccount);
            //    _dataContext.SaveChanges();

            //    CreateAccountRow(newAccount);
            //});
        }

        private void allAccountsButton_Click(object sender, EventArgs e)
        {
            folderLabel.Text = "All";
            _visibilityMode = VisibilityMode.All;
            FilterAccountRows((account) => !account.Binned);
            FixAccountRowLayout();
        }

        private void binButton_Click(object sender, EventArgs e)
        {
            folderLabel.Text = "Bin";
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
                        FilterAccountRows((account) =>
                        {
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

        private void accountFlowPanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

enum VisibilityMode
{
    All,
    Binned,
    Folder,
}
