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
            splitContainer1 = new SplitContainer();
            panel2 = new Panel();
            addFoldersButton = new Button();
            panel3 = new Panel();
            foldersLabel = new Label();
            folderFlowPanel = new FlowLayoutPanel();
            button1 = new Button();
            button2 = new Button();
            panel1 = new Panel();
            binButton = new Button();
            allAccountsButton = new Button();
            label1 = new Label();
            accountRow1 = new Controls.AccountRow();
            panel4 = new Panel();
            addAccountButton = new Button();
            searchTextbox = new TextBox();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            folderFlowPanel.SuspendLayout();
            panel1.SuspendLayout();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.BackColor = Color.White;
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(panel2);
            splitContainer1.Panel1MinSize = 220;
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(accountRow1);
            splitContainer1.Panel2.Controls.Add(panel4);
            splitContainer1.Size = new Size(800, 450);
            splitContainer1.SplitterDistance = 220;
            splitContainer1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(addFoldersButton);
            panel2.Controls.Add(panel3);
            panel2.Controls.Add(panel1);
            panel2.Dock = DockStyle.Fill;
            panel2.ForeColor = SystemColors.ControlText;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(220, 450);
            panel2.TabIndex = 0;
            // 
            // addFoldersButton
            // 
            addFoldersButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            addFoldersButton.FlatStyle = FlatStyle.Flat;
            addFoldersButton.Location = new Point(-1, 417);
            addFoldersButton.Name = "addFoldersButton";
            addFoldersButton.Size = new Size(220, 32);
            addFoldersButton.TabIndex = 3;
            addFoldersButton.Text = "Add New Folder +";
            addFoldersButton.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel3.BackColor = Color.White;
            panel3.Controls.Add(foldersLabel);
            panel3.Controls.Add(folderFlowPanel);
            panel3.Location = new Point(-1, 130);
            panel3.Name = "panel3";
            panel3.Size = new Size(221, 281);
            panel3.TabIndex = 2;
            // 
            // foldersLabel
            // 
            foldersLabel.AutoSize = true;
            foldersLabel.Location = new Point(8, 6);
            foldersLabel.Name = "foldersLabel";
            foldersLabel.Size = new Size(45, 15);
            foldersLabel.TabIndex = 2;
            foldersLabel.Text = "Folders";
            // 
            // folderFlowPanel
            // 
            folderFlowPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            folderFlowPanel.AutoScroll = true;
            folderFlowPanel.BackColor = Color.White;
            folderFlowPanel.Controls.Add(button1);
            folderFlowPanel.Controls.Add(button2);
            folderFlowPanel.FlowDirection = FlowDirection.TopDown;
            folderFlowPanel.Location = new Point(0, 25);
            folderFlowPanel.Margin = new Padding(0, 3, 3, 3);
            folderFlowPanel.Name = "folderFlowPanel";
            folderFlowPanel.Size = new Size(221, 262);
            folderFlowPanel.TabIndex = 1;
            folderFlowPanel.WrapContents = false;
            folderFlowPanel.Layout += folderFlowPanel_Layout;
            // 
            // button1
            // 
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(0, 0);
            button1.Margin = new Padding(0);
            button1.Name = "button1";
            button1.Size = new Size(221, 32);
            button1.TabIndex = 0;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Dock = DockStyle.Top;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Location = new Point(0, 32);
            button2.Margin = new Padding(0);
            button2.Name = "button2";
            button2.Size = new Size(221, 32);
            button2.TabIndex = 1;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.White;
            panel1.Controls.Add(binButton);
            panel1.Controls.Add(allAccountsButton);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(220, 130);
            panel1.TabIndex = 0;
            // 
            // binButton
            // 
            binButton.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            binButton.FlatStyle = FlatStyle.Flat;
            binButton.Location = new Point(0, 92);
            binButton.Name = "binButton";
            binButton.Size = new Size(220, 32);
            binButton.TabIndex = 2;
            binButton.Text = "Bin";
            binButton.UseVisualStyleBackColor = true;
            // 
            // allAccountsButton
            // 
            allAccountsButton.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            allAccountsButton.FlatStyle = FlatStyle.Flat;
            allAccountsButton.Location = new Point(0, 63);
            allAccountsButton.Name = "allAccountsButton";
            allAccountsButton.Size = new Size(220, 32);
            allAccountsButton.TabIndex = 1;
            allAccountsButton.Text = "All";
            allAccountsButton.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.FlatStyle = FlatStyle.Flat;
            label1.Font = new Font("Consolas", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(11, 8);
            label1.Name = "label1";
            label1.Size = new Size(202, 24);
            label1.TabIndex = 0;
            label1.Text = "Password Manager";
            // 
            // accountRow1
            // 
            accountRow1.AutoSize = true;
            accountRow1.BackColor = SystemColors.AppWorkspace;
            accountRow1.Location = new Point(-30, 147);
            accountRow1.Name = "accountRow1";
            accountRow1.Size = new Size(656, 41);
            accountRow1.TabIndex = 1;
            // 
            // panel4
            // 
            panel4.Controls.Add(addAccountButton);
            panel4.Controls.Add(searchTextbox);
            panel4.Location = new Point(2, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(574, 96);
            panel4.TabIndex = 0;
            // 
            // addAccountButton
            // 
            addAccountButton.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            addAccountButton.FlatStyle = FlatStyle.Flat;
            addAccountButton.Location = new Point(31, 52);
            addAccountButton.Name = "addAccountButton";
            addAccountButton.Size = new Size(108, 32);
            addAccountButton.TabIndex = 3;
            addAccountButton.Text = "Add +";
            addAccountButton.UseVisualStyleBackColor = true;
            // 
            // searchTextbox
            // 
            searchTextbox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            searchTextbox.Location = new Point(31, 23);
            searchTextbox.MaximumSize = new Size(320, 0);
            searchTextbox.MinimumSize = new Size(120, 0);
            searchTextbox.Name = "searchTextbox";
            searchTextbox.PlaceholderText = "Search...";
            searchTextbox.Size = new Size(320, 23);
            searchTextbox.TabIndex = 0;
            // 
            // AccountsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 450);
            Controls.Add(splitContainer1);
            Name = "AccountsForm";
            Text = "Password Manager";
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            folderFlowPanel.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
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
        private Button addFoldersButton;
        private Label foldersLabel;
        private Panel panel4;
        private TextBox searchTextbox;
        private Button addAccountButton;
        private Button button1;
        private Button button2;
        private Controls.AccountRow accountRow1;
    }
}