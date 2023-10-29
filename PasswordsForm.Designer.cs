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
            label2 = new Label();
            panel3 = new Panel();
            foldersLabel = new Label();
            folderFlowPanel = new FlowLayoutPanel();
            addFolderButton = new Button();
            panel1 = new Panel();
            binButton = new Button();
            allAccountsButton = new Button();
            label1 = new Label();
            label4 = new Label();
            label5 = new Label();
            checkBox1 = new CheckBox();
            checkBox2 = new CheckBox();
            PasswordId = new TextBox();
            PasswordName = new TextBox();
            RPassword = new TextBox();
            button3 = new Button();
            label6 = new Label();
            button1 = new Button();
            panel3.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(38, 60);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(0, 15);
            label2.TabIndex = 1;
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel3.BackColor = Color.White;
            panel3.Controls.Add(foldersLabel);
            panel3.Controls.Add(folderFlowPanel);
            panel3.Location = new Point(7, 154);
            panel3.Name = "panel3";
            panel3.Size = new Size(222, 238);
            panel3.TabIndex = 4;
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
            folderFlowPanel.FlowDirection = FlowDirection.TopDown;
            folderFlowPanel.Location = new Point(0, 24);
            folderFlowPanel.Margin = new Padding(0, 3, 3, 3);
            folderFlowPanel.Name = "folderFlowPanel";
            folderFlowPanel.Size = new Size(222, 214);
            folderFlowPanel.TabIndex = 3;
            folderFlowPanel.WrapContents = false;
            // 
            // addFolderButton
            // 
            addFolderButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            addFolderButton.FlatStyle = FlatStyle.Flat;
            addFolderButton.Location = new Point(8, 391);
            addFolderButton.Name = "addFolderButton";
            addFolderButton.Size = new Size(220, 32);
            addFolderButton.TabIndex = 5;
            addFolderButton.Text = "Add New Folder +";
            addFolderButton.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.White;
            panel1.Controls.Add(binButton);
            panel1.Controls.Add(allAccountsButton);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(7, 25);
            panel1.Name = "panel1";
            panel1.Size = new Size(222, 124);
            panel1.TabIndex = 6;
            // 
            // binButton
            // 
            binButton.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            binButton.FlatStyle = FlatStyle.Flat;
            binButton.Location = new Point(0, 92);
            binButton.Name = "binButton";
            binButton.Size = new Size(219, 32);
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
            allAccountsButton.Size = new Size(219, 32);
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
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(202, 24);
            label1.TabIndex = 0;
            label1.Text = "Password Manager";
            label1.Click += label1_Click_2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(265, 143);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(98, 15);
            label4.TabIndex = 8;
            label4.Text = "Password Name: ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(269, 193);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(63, 15);
            label5.TabIndex = 9;
            label5.Text = "Password: ";
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(269, 255);
            checkBox1.Margin = new Padding(2);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(117, 19);
            checkBox1.TabIndex = 10;
            checkBox1.Text = "Include Numbers";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Location = new Point(430, 255);
            checkBox2.Margin = new Padding(2);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(164, 19);
            checkBox2.TabIndex = 11;
            checkBox2.Text = "Include Special Characters";
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // PasswordId
            // 
            PasswordId.Location = new Point(269, 118);
            PasswordId.Margin = new Padding(2);
            PasswordId.Name = "PasswordId";
            PasswordId.Size = new Size(159, 23);
            PasswordId.TabIndex = 12;
            PasswordId.TextChanged += textBox1_TextChanged_1;
            // 
            // PasswordName
            // 
            PasswordName.Location = new Point(269, 167);
            PasswordName.Margin = new Padding(2);
            PasswordName.Name = "PasswordName";
            PasswordName.Size = new Size(159, 23);
            PasswordName.TabIndex = 13;
            // 
            // RPassword
            // 
            RPassword.Location = new Point(269, 216);
            RPassword.Margin = new Padding(2);
            RPassword.Name = "RPassword";
            RPassword.Size = new Size(159, 23);
            RPassword.TabIndex = 14;
            RPassword.TextChanged += RPassword_TextChanged;
            // 
            // button3
            // 
            button3.Location = new Point(522, 319);
            button3.Margin = new Padding(2);
            button3.Name = "button3";
            button3.Size = new Size(78, 20);
            button3.TabIndex = 17;
            button3.Text = "Save";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(270, 96);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(77, 15);
            label6.TabIndex = 18;
            label6.Text = "Password ID: ";
            label6.Click += label6_Click_1;
            // 
            // button1
            // 
            button1.Location = new Point(410, 319);
            button1.Margin = new Padding(2);
            button1.Name = "button1";
            button1.Size = new Size(78, 20);
            button1.TabIndex = 19;
            button1.Text = "Cancel";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // PasswordsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(797, 443);
            Controls.Add(button1);
            Controls.Add(label6);
            Controls.Add(button3);
            Controls.Add(RPassword);
            Controls.Add(PasswordName);
            Controls.Add(PasswordId);
            Controls.Add(checkBox2);
            Controls.Add(checkBox1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(panel1);
            Controls.Add(addFolderButton);
            Controls.Add(panel3);
            Controls.Add(label2);
            Margin = new Padding(2);
            Name = "PasswordsForm";
            Text = "Password Manager";
            Load += PasswordsForm_Load_1;
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
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
        private CheckBox checkBox1;
        private CheckBox checkBox2;
        private TextBox PasswordId;
        private TextBox PasswordName;
        private TextBox RPassword;
        private Button button3;
        private FlowLayoutPanel folderFlowPanel;
        private Label label6;
        private Button button1;
    }
}
