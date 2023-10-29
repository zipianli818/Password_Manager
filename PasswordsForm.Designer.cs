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
            SuspendLayout();
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.Location = new Point(251, 213);
            label4.Name = "label4";
            label4.Size = new Size(95, 25);
            label4.TabIndex = 8;
            label4.Text = "Username:";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.None;
            label5.AutoSize = true;
            label5.Location = new Point(257, 298);
            label5.Name = "label5";
            label5.Size = new Size(96, 25);
            label5.TabIndex = 9;
            label5.Text = "Password: ";
            // 
            // includeNumberCheckbox
            // 
            includeNumberCheckbox.Anchor = AnchorStyles.None;
            includeNumberCheckbox.AutoSize = true;
            includeNumberCheckbox.Location = new Point(257, 397);
            includeNumberCheckbox.Name = "includeNumberCheckbox";
            includeNumberCheckbox.Size = new Size(173, 29);
            includeNumberCheckbox.TabIndex = 10;
            includeNumberCheckbox.Text = "Include Numbers";
            includeNumberCheckbox.UseVisualStyleBackColor = true;
            // 
            // includeSpecialCharsCheckbox
            // 
            includeSpecialCharsCheckbox.Anchor = AnchorStyles.None;
            includeSpecialCharsCheckbox.AutoSize = true;
            includeSpecialCharsCheckbox.Location = new Point(487, 397);
            includeSpecialCharsCheckbox.Name = "includeSpecialCharsCheckbox";
            includeSpecialCharsCheckbox.Size = new Size(242, 29);
            includeSpecialCharsCheckbox.TabIndex = 11;
            includeSpecialCharsCheckbox.Text = "Include Special Characters";
            includeSpecialCharsCheckbox.UseVisualStyleBackColor = true;
            // 
            // accountNameTextBox
            // 
            accountNameTextBox.Anchor = AnchorStyles.None;
            accountNameTextBox.Location = new Point(257, 168);
            accountNameTextBox.Name = "accountNameTextBox";
            accountNameTextBox.Size = new Size(287, 31);
            accountNameTextBox.TabIndex = 12;
            accountNameTextBox.TextChanged += accountNameTextBox_TextChanged;
            // 
            // usernameTextBox
            // 
            usernameTextBox.Anchor = AnchorStyles.None;
            usernameTextBox.Location = new Point(257, 250);
            usernameTextBox.Name = "usernameTextBox";
            usernameTextBox.Size = new Size(287, 31);
            usernameTextBox.TabIndex = 13;
            // 
            // passwordTextBox
            // 
            passwordTextBox.Anchor = AnchorStyles.None;
            passwordTextBox.Location = new Point(257, 332);
            passwordTextBox.Name = "passwordTextBox";
            passwordTextBox.Size = new Size(287, 31);
            passwordTextBox.TabIndex = 14;
            // 
            // saveButton
            // 
            saveButton.Anchor = AnchorStyles.None;
            saveButton.Location = new Point(410, 487);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(111, 33);
            saveButton.TabIndex = 17;
            saveButton.Text = "Save";
            saveButton.UseVisualStyleBackColor = true;
            saveButton.Click += saveButton_Click;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.None;
            label6.AutoSize = true;
            label6.Location = new Point(259, 132);
            label6.Name = "label6";
            label6.Size = new Size(213, 25);
            label6.TabIndex = 18;
            label6.Text = "Account Name / Website:";
            // 
            // cancelButton
            // 
            cancelButton.Anchor = AnchorStyles.None;
            cancelButton.Location = new Point(250, 487);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(111, 33);
            cancelButton.TabIndex = 19;
            cancelButton.Text = "Cancel";
            cancelButton.UseVisualStyleBackColor = true;
            cancelButton.Click += cancelButton_Click;
            // 
            // generatePasswordButton
            // 
            generatePasswordButton.Anchor = AnchorStyles.None;
            generatePasswordButton.Location = new Point(577, 337);
            generatePasswordButton.Name = "generatePasswordButton";
            generatePasswordButton.Size = new Size(171, 33);
            generatePasswordButton.TabIndex = 20;
            generatePasswordButton.Text = "Generate Password";
            generatePasswordButton.UseVisualStyleBackColor = true;
            generatePasswordButton.Click += generatePasswordButton_Click;
            // 
            // PasswordsForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1004, 655);
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
    }
}
