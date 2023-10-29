namespace Password_Manager.Controls
{
    partial class CreateUserForm
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
            emailLabel = new Label();
            label2 = new Label();
            emailTextBox = new TextBox();
            cancelButton = new Button();
            confirmButton = new Button();
            label1 = new Label();
            passwordTextBox = new MaskedTextBox();
            confirmPasswordTextBox = new MaskedTextBox();
            SuspendLayout();
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Location = new Point(29, 30);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new Size(36, 15);
            emailLabel.TabIndex = 0;
            emailLabel.Text = "Email";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(29, 70);
            label2.Name = "label2";
            label2.Size = new Size(57, 15);
            label2.TabIndex = 1;
            label2.Text = "Password";
            // 
            // emailTextBox
            // 
            emailTextBox.Location = new Point(139, 30);
            emailTextBox.Name = "emailTextBox";
            emailTextBox.PlaceholderText = "Email";
            emailTextBox.Size = new Size(160, 23);
            emailTextBox.TabIndex = 1;
            // 
            // cancelButton
            // 
            cancelButton.FlatStyle = FlatStyle.Flat;
            cancelButton.Location = new Point(139, 145);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(75, 23);
            cancelButton.TabIndex = 5;
            cancelButton.Text = "Cancel";
            cancelButton.UseVisualStyleBackColor = true;
            // 
            // confirmButton
            // 
            confirmButton.FlatStyle = FlatStyle.Flat;
            confirmButton.Location = new Point(224, 145);
            confirmButton.Name = "confirmButton";
            confirmButton.Size = new Size(75, 23);
            confirmButton.TabIndex = 4;
            confirmButton.Text = "Confirm";
            confirmButton.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(29, 105);
            label1.Name = "label1";
            label1.Size = new Size(104, 15);
            label1.TabIndex = 6;
            label1.Text = "Confirm Password";
            // 
            // passwordTextBox
            // 
            passwordTextBox.Location = new Point(139, 67);
            passwordTextBox.Name = "passwordTextBox";
            passwordTextBox.PasswordChar = '●';
            passwordTextBox.Size = new Size(160, 23);
            passwordTextBox.TabIndex = 2;
            // 
            // confirmPasswordTextBox
            // 
            confirmPasswordTextBox.Location = new Point(139, 97);
            confirmPasswordTextBox.Name = "confirmPasswordTextBox";
            confirmPasswordTextBox.PasswordChar = '●';
            confirmPasswordTextBox.Size = new Size(160, 23);
            confirmPasswordTextBox.TabIndex = 3;
            // 
            // CreateUserForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(358, 191);
            Controls.Add(confirmPasswordTextBox);
            Controls.Add(passwordTextBox);
            Controls.Add(label1);
            Controls.Add(confirmButton);
            Controls.Add(cancelButton);
            Controls.Add(emailTextBox);
            Controls.Add(label2);
            Controls.Add(emailLabel);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "CreateUserForm";
            Text = "CreateUserForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label emailLabel;
        private Label label2;
        private TextBox emailTextBox;
        private Button cancelButton;
        private Button confirmButton;
        private Label label1;
        private MaskedTextBox passwordTextBox;
        private MaskedTextBox confirmPasswordTextBox;
    }
}