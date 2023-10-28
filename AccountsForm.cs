using Password_Manager.Controls;
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
        public AccountsForm()
        {
            InitializeComponent();

            // Note(Pete): This odd combination of commands will ensure the horizontal scroll 
            folderFlowPanel.AutoScroll = false;
            folderFlowPanel.HorizontalScroll.Maximum = 0;
            folderFlowPanel.AutoScroll = true;
        }

        /// <summary>
        /// Manually sets the first child's width to match the width of the flow panel because Winforms is incapable of doing this correctly.
        /// The first child will dictate the size of the subsequent children if they are set to DockMode.Top.
        /// </summary>
        private void resizeFolderPanelContents()
        {

            if (folderFlowPanel.Controls.Count == 0)
                return;

            var firstButton = folderFlowPanel.Controls[0];
            firstButton.Width = folderFlowPanel.Width;
        }


        // Events

        // Called everytime the folder panel needs to redraw itself
        private void folderFlowPanel_Layout(object sender, LayoutEventArgs e)
        {
            resizeFolderPanelContents();
        }

        private void addFolderButton_Click(object sender, EventArgs e)
        {
            TextInputModal.ShowModal("Add Folder", (string text) =>
            {
                var folderButton = new Button
                {
                    FlatStyle = FlatStyle.Flat,
                    Height = 32,
                    Margin = new Padding(0),
                    Text = text
                };

                // Add context menu to button
                var buttonContextMenu = new ContextMenuStrip();
                buttonContextMenu.Items.Add("Delete Folder");
                buttonContextMenu.Items[0].Click += (object? sender, EventArgs e) =>
                {
                    folderFlowPanel.Controls.Remove(folderButton);
                };

                folderButton.ContextMenuStrip = buttonContextMenu;

                // Note(Pete): All controls apart from the first control must be docked to the top so that they will
                // copy the width of the topmost control. Refer to resizeFolderPanelContents for more details.
                if (folderFlowPanel.Controls.Count != 0)
                    folderButton.Dock = DockStyle.Top;

                folderFlowPanel.Controls.Add(folderButton);
            }, null);
        }
    }
}
