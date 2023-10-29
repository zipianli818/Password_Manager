namespace Password_Manager
{
    partial class AccountsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            splitContainer1 = new SplitContainer();
            panel2 = new Panel();
            addFolderButton = new Button();
            panel3 = new Panel();
            foldersLabel = new Label();
            folderFlowPanel = new FlowLayoutPanel();
            panel1 = new Panel();
            binButton = new Button();
            allAccountsButton = new Button();
            label1 = new Label();
            accountFlowPanel = new FlowLayoutPanel();
            panel4 = new Panel();
            contextMenuStrip1 = new ContextMenuStrip(components);
            item1ToolStripMenuItem = new ToolStripMenuItem();
            addAccountButton = new Button();
            searchTextbox = new TextBox();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel1.SuspendLayout();
            panel4.SuspendLayout();
            contextMenuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.BackColor = Color.White;
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Margin = new Padding(4, 5, 4, 5);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(panel2);
            splitContainer1.Panel1MinSize = 220;
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(accountFlowPanel);
            splitContainer1.Panel2.Controls.Add(panel4);
            splitContainer1.Size = new Size(1143, 750);
            splitContainer1.SplitterDistance = 314;
            splitContainer1.SplitterWidth = 6;
            splitContainer1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(addFolderButton);
            panel2.Controls.Add(panel3);
            panel2.Controls.Add(panel1);
            panel2.Dock = DockStyle.Fill;
            panel2.ForeColor = SystemColors.ControlText;
            panel2.Location = new Point(0, 0);
            panel2.Margin = new Padding(4, 5, 4, 5);
            panel2.Name = "panel2";
            panel2.Size = new Size(314, 750);
            panel2.TabIndex = 0;
            // 
            // addFolderButton
            // 
            addFolderButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            addFolderButton.FlatStyle = FlatStyle.Flat;
            addFolderButton.Location = new Point(-1, 696);
            addFolderButton.Margin = new Padding(4, 5, 4, 5);
            addFolderButton.Name = "addFolderButton";
            addFolderButton.Size = new Size(315, 53);
            addFolderButton.TabIndex = 3;
            addFolderButton.Text = "Add New Folder +";
            addFolderButton.UseVisualStyleBackColor = true;
            addFolderButton.Click += addFolderButton_Click;
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel3.BackColor = Color.White;
            panel3.Controls.Add(foldersLabel);
            panel3.Controls.Add(folderFlowPanel);
            panel3.Location = new Point(-1, 217);
            panel3.Margin = new Padding(4, 5, 4, 5);
            panel3.Name = "panel3";
            panel3.Size = new Size(317, 469);
            panel3.TabIndex = 2;
            // 
            // foldersLabel
            // 
            foldersLabel.AutoSize = true;
            foldersLabel.Location = new Point(11, 10);
            foldersLabel.Margin = new Padding(4, 0, 4, 0);
            foldersLabel.Name = "foldersLabel";
            foldersLabel.Size = new Size(70, 25);
            foldersLabel.TabIndex = 2;
            foldersLabel.Text = "Folders";
            // 
            // folderFlowPanel
            // 
            folderFlowPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            folderFlowPanel.AutoScroll = true;
            folderFlowPanel.BackColor = Color.White;
            folderFlowPanel.FlowDirection = FlowDirection.TopDown;
            folderFlowPanel.Location = new Point(0, 42);
            folderFlowPanel.Margin = new Padding(0, 5, 4, 5);
            folderFlowPanel.Name = "folderFlowPanel";
            folderFlowPanel.Size = new Size(317, 438);
            folderFlowPanel.TabIndex = 1;
            folderFlowPanel.WrapContents = false;
            folderFlowPanel.Layout += folderFlowPanel_Layout;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.White;
            panel1.Controls.Add(binButton);
            panel1.Controls.Add(allAccountsButton);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(4, 5, 4, 5);
            panel1.Name = "panel1";
            panel1.Size = new Size(315, 217);
            panel1.TabIndex = 0;
            // 
            // binButton
            // 
            binButton.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            binButton.FlatStyle = FlatStyle.Flat;
            binButton.Location = new Point(0, 153);
            binButton.Margin = new Padding(4, 5, 4, 5);
            binButton.Name = "binButton";
            binButton.Size = new Size(315, 53);
            binButton.TabIndex = 2;
            binButton.Text = "Bin";
            binButton.UseVisualStyleBackColor = true;
            binButton.Click += binButton_Click;
            // 
            // allAccountsButton
            // 
            allAccountsButton.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            allAccountsButton.FlatStyle = FlatStyle.Flat;
            allAccountsButton.Location = new Point(0, 105);
            allAccountsButton.Margin = new Padding(4, 5, 4, 5);
            allAccountsButton.Name = "allAccountsButton";
            allAccountsButton.Size = new Size(315, 53);
            allAccountsButton.TabIndex = 1;
            allAccountsButton.Text = "All";
            allAccountsButton.UseVisualStyleBackColor = true;
            allAccountsButton.Click += allAccountsButton_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.FlatStyle = FlatStyle.Flat;
            label1.Font = new Font("Consolas", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(16, 13);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(305, 37);
            label1.TabIndex = 0;
            label1.Text = "Password Manager";
            // 
            // accountFlowPanel
            // 
            accountFlowPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            accountFlowPanel.BackColor = Color.White;
            accountFlowPanel.BorderStyle = BorderStyle.FixedSingle;
            accountFlowPanel.FlowDirection = FlowDirection.TopDown;
            accountFlowPanel.Location = new Point(0, 155);
            accountFlowPanel.Margin = new Padding(4, 5, 4, 5);
            accountFlowPanel.Name = "accountFlowPanel";
            accountFlowPanel.Size = new Size(822, 594);
            accountFlowPanel.TabIndex = 1;
            accountFlowPanel.Paint += accountFlowPanel_Paint;
            accountFlowPanel.Layout += accountFlowPanel_Layout;
            // 
            // panel4
            // 
            panel4.ContextMenuStrip = contextMenuStrip1;
            panel4.Controls.Add(addAccountButton);
            panel4.Controls.Add(searchTextbox);
            panel4.Location = new Point(3, 0);
            panel4.Margin = new Padding(4, 5, 4, 5);
            panel4.Name = "panel4";
            panel4.Size = new Size(820, 160);
            panel4.TabIndex = 0;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(24, 24);
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { item1ToolStripMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(136, 36);
            // 
            // item1ToolStripMenuItem
            // 
            item1ToolStripMenuItem.Name = "item1ToolStripMenuItem";
            item1ToolStripMenuItem.Size = new Size(135, 32);
            item1ToolStripMenuItem.Text = "Item 1";
            // 
            // addAccountButton
            // 
            addAccountButton.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            addAccountButton.FlatStyle = FlatStyle.Flat;
            addAccountButton.Location = new Point(44, 87);
            addAccountButton.Margin = new Padding(4, 5, 4, 5);
            addAccountButton.Name = "addAccountButton";
            addAccountButton.Size = new Size(154, 53);
            addAccountButton.TabIndex = 3;
            addAccountButton.Text = "Add +";
            addAccountButton.UseVisualStyleBackColor = true;
            addAccountButton.Click += addAccountButton_Click;
            // 
            // searchTextbox
            // 
            searchTextbox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            searchTextbox.Location = new Point(44, 38);
            searchTextbox.Margin = new Padding(4, 5, 4, 5);
            searchTextbox.MaximumSize = new Size(455, 4);
            searchTextbox.MinimumSize = new Size(170, 4);
            searchTextbox.Name = "searchTextbox";
            searchTextbox.PlaceholderText = "Search...";
            searchTextbox.Size = new Size(455, 31);
            searchTextbox.TabIndex = 0;
            searchTextbox.TextChanged += searchTextbox_TextChanged;
            // 
            // AccountsForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1143, 750);
            Controls.Add(splitContainer1);
            Margin = new Padding(4, 5, 4, 5);
            MinimumSize = new Size(991, 629);
            Name = "AccountsForm";
            Text = "Password Manager";
            FormClosed += AccountsForm_FormClosed;
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            contextMenuStrip1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer1;
        private Panel panel1;
        private Label label1;
        private Button binButton;
        private Button allAccountsButton;
        private Panel panel2;
        private Panel panel3;
        private FlowLayoutPanel folderFlowPanel;
        private Button addFolderButton;
        private Label foldersLabel;
        private Panel panel4;
        private TextBox searchTextbox;
        private Button addAccountButton;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem item1ToolStripMenuItem;
        private FlowLayoutPanel accountFlowPanel;
    }
}