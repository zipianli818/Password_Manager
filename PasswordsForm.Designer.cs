namespace Password_Manager
{
    partial class PasswordsForm
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
            label4 = new Label();
            label5 = new Label();
            includeNumberCheckbox = new CheckBox();
            includeSpecialCharsCheckbox = new CheckBox();
            accountNameTextBox = new TextBox();
            usernameTextBox = new TextBox();
            passwordTextBox = new TextBox();
            saveButton = new Button();
            label6 = new Label();
            cancelButton = new Button();
            generatePasswordButton = new Button();
            folderComboBox = new ComboBox();
            label3 = new Label();
            SuspendLayout();
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.Location = new Point(176, 128);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(63, 15);
            label4.TabIndex = 8;
            label4.Text = "Username:";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.None;
            label5.AutoSize = true;
            label5.Location = new Point(180, 179);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(63, 15);
            label5.TabIndex = 9;
            label5.Text = "Password: ";
            // 
            // includeNumberCheckbox
            // 
            includeNumberCheckbox.Anchor = AnchorStyles.None;
            includeNumberCheckbox.AutoSize = true;
            includeNumberCheckbox.Location = new Point(180, 238);
            includeNumberCheckbox.Margin = new Padding(2);
            includeNumberCheckbox.Name = "includeNumberCheckbox";
            includeNumberCheckbox.Size = new Size(117, 19);
            includeNumberCheckbox.TabIndex = 4;
            includeNumberCheckbox.Text = "Include Numbers";
            includeNumberCheckbox.UseVisualStyleBackColor = true;
            // 
            // includeSpecialCharsCheckbox
            // 
            includeSpecialCharsCheckbox.Anchor = AnchorStyles.None;
            includeSpecialCharsCheckbox.AutoSize = true;
            includeSpecialCharsCheckbox.Location = new Point(341, 238);
            includeSpecialCharsCheckbox.Margin = new Padding(2);
            includeSpecialCharsCheckbox.Name = "includeSpecialCharsCheckbox";
            includeSpecialCharsCheckbox.Size = new Size(164, 19);
            includeSpecialCharsCheckbox.TabIndex = 5;
            includeSpecialCharsCheckbox.Text = "Include Special Characters";
            includeSpecialCharsCheckbox.UseVisualStyleBackColor = true;
            // 
            // accountNameTextBox
            // 
            accountNameTextBox.Anchor = AnchorStyles.None;
            accountNameTextBox.Location = new Point(180, 101);
            accountNameTextBox.Margin = new Padding(2);
            accountNameTextBox.Name = "accountNameTextBox";
            accountNameTextBox.Size = new Size(202, 23);
            accountNameTextBox.TabIndex = 1;
            accountNameTextBox.TextChanged += accountNameTextBox_TextChanged;
            // 
            // usernameTextBox
            // 
            usernameTextBox.Anchor = AnchorStyles.None;
            usernameTextBox.Location = new Point(180, 150);
            usernameTextBox.Margin = new Padding(2);
            usernameTextBox.Name = "usernameTextBox";
            usernameTextBox.Size = new Size(202, 23);
            usernameTextBox.TabIndex = 2;
            // 
            // passwordTextBox
            // 
            passwordTextBox.Anchor = AnchorStyles.None;
            passwordTextBox.Location = new Point(180, 199);
            passwordTextBox.Margin = new Padding(2);
            passwordTextBox.Name = "passwordTextBox";
            passwordTextBox.Size = new Size(202, 23);
            passwordTextBox.TabIndex = 3;
            // 
            // saveButton
            // 
            saveButton.Anchor = AnchorStyles.None;
            saveButton.Location = new Point(285, 334);
            saveButton.Margin = new Padding(2);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(78, 20);
            saveButton.TabIndex = 8;
            saveButton.Text = "Save";
            saveButton.UseVisualStyleBackColor = true;
            saveButton.Click += saveButton_Click;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.None;
            label6.AutoSize = true;
            label6.Location = new Point(181, 79);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(143, 15);
            label6.TabIndex = 18;
            label6.Text = "Account Name / Website:";
            // 
            // cancelButton
            // 
            cancelButton.Anchor = AnchorStyles.None;
            cancelButton.Location = new Point(173, 334);
            cancelButton.Margin = new Padding(2);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(78, 20);
            cancelButton.TabIndex = 9;
            cancelButton.Text = "Cancel";
            cancelButton.UseVisualStyleBackColor = true;
            cancelButton.Click += cancelButton_Click;
            // 
            // generatePasswordButton
            // 
            generatePasswordButton.Anchor = AnchorStyles.None;
            generatePasswordButton.Location = new Point(404, 202);
            generatePasswordButton.Margin = new Padding(2);
            generatePasswordButton.Name = "generatePasswordButton";
            generatePasswordButton.Size = new Size(120, 20);
            generatePasswordButton.TabIndex = 6;
            generatePasswordButton.Text = "Generate Password";
            generatePasswordButton.UseVisualStyleBackColor = true;
            generatePasswordButton.Click += generatePasswordButton_Click;
            // 
            // folderComboBox
            // 
            folderComboBox.FormattingEnabled = true;
            folderComboBox.Items.AddRange(new object[] { "None" });
            folderComboBox.Location = new Point(173, 288);
            folderComboBox.Name = "folderComboBox";
            folderComboBox.Size = new Size(121, 23);
            folderComboBox.TabIndex = 7;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Location = new Point(173, 270);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(43, 15);
            label3.TabIndex = 22;
            label3.Text = "Folder:";
            // 
            // PasswordsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(703, 393);
            Controls.Add(label3);
            Controls.Add(folderComboBox);
            Controls.Add(generatePasswordButton);
            Controls.Add(cancelButton);
            Controls.Add(label6);
            Controls.Add(saveButton);
            Controls.Add(passwordTextBox);
            Controls.Add(usernameTextBox);
            Controls.Add(accountNameTextBox);
            Controls.Add(includeSpecialCharsCheckbox);
            Controls.Add(includeNumberCheckbox);
            Controls.Add(label5);
            Controls.Add(label4);
            Margin = new Padding(2);
            Name = "PasswordsForm";
            Text = "Password Manager";
            Load += PasswordsForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label2;
        private Panel panel3;
        private Label foldersLabel;
        private Button addFolderButton;
        private Panel panel1;
        private Button binButton;
        private Button allAccountsButton;
        private Label label1;
        private Label label4;
        private Label label5;
        private CheckBox includeNumberCheckbox;
        private CheckBox includeSpecialCharsCheckbox;
        private TextBox accountNameTextBox;
        private TextBox usernameTextBox;
        private TextBox passwordTextBox;
        private Button saveButton;
        private FlowLayoutPanel folderFlowPanel;
        private Label label6;
        private Button cancelButton;
        private Button generatePasswordButton;
        private ComboBox folderComboBox;
        private Label label3;
    }
}
