namespace Password_Manager;

partial class MainForm
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
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
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        label1 = new Label();
        emailTextBox = new TextBox();
        signInButton = new Button();
        label2 = new Label();
        createAccountButton = new Button();
        passwordTextBox = new MaskedTextBox();
        label3 = new Label();
        label4 = new Label();
        panel1 = new Panel();
        panel1.SuspendLayout();
        SuspendLayout();
        // 
        // label1
        // 
        label1.Anchor = AnchorStyles.None;
        label1.AutoSize = true;
        label1.Font = new Font("Consolas", 26.25F, FontStyle.Regular, GraphicsUnit.Point);
        label1.Location = new Point(223, 83);
        label1.Name = "label1";
        label1.Size = new Size(322, 41);
        label1.TabIndex = 0;
        label1.Text = "Password Manager";
        // 
        // emailTextBox
        // 
        emailTextBox.Anchor = AnchorStyles.None;
        emailTextBox.Location = new Point(301, 221);
        emailTextBox.Name = "emailTextBox";
        emailTextBox.PlaceholderText = "Email";
        emailTextBox.Size = new Size(188, 23);
        emailTextBox.TabIndex = 1;
        // 
        // signInButton
        // 
        signInButton.Anchor = AnchorStyles.None;
        signInButton.Location = new Point(347, 299);
        signInButton.Name = "signInButton";
        signInButton.Size = new Size(75, 23);
        signInButton.TabIndex = 3;
        signInButton.Text = "Sign In";
        signInButton.UseVisualStyleBackColor = true;
        signInButton.Click += signInButton_Click;
        // 
        // label2
        // 
        label2.Anchor = AnchorStyles.None;
        label2.AutoSize = true;
        label2.Location = new Point(379, 325);
        label2.Name = "label2";
        label2.Size = new Size(18, 15);
        label2.TabIndex = 4;
        label2.Text = "or";
        // 
        // createAccountButton
        // 
        createAccountButton.Anchor = AnchorStyles.None;
        createAccountButton.Location = new Point(324, 343);
        createAccountButton.Name = "createAccountButton";
        createAccountButton.Size = new Size(125, 23);
        createAccountButton.TabIndex = 4;
        createAccountButton.Text = "Create Account";
        createAccountButton.UseVisualStyleBackColor = true;
        createAccountButton.Click += createAccountButton_Click;
        // 
        // passwordTextBox
        // 
        passwordTextBox.Anchor = AnchorStyles.None;
        passwordTextBox.Location = new Point(301, 258);
        passwordTextBox.Name = "passwordTextBox";
        passwordTextBox.PasswordChar = '●';
        passwordTextBox.Size = new Size(188, 23);
        passwordTextBox.TabIndex = 2;
        // 
        // label3
        // 
        label3.Anchor = AnchorStyles.None;
        label3.AutoSize = true;
        label3.Location = new Point(229, 261);
        label3.Name = "label3";
        label3.Size = new Size(57, 15);
        label3.TabIndex = 7;
        label3.Text = "Password";
        // 
        // label4
        // 
        label4.Anchor = AnchorStyles.None;
        label4.AutoSize = true;
        label4.Location = new Point(250, 224);
        label4.Name = "label4";
        label4.Size = new Size(36, 15);
        label4.TabIndex = 8;
        label4.Text = "Email";
        // 
        // panel1
        // 
        panel1.Anchor = AnchorStyles.None;
        panel1.BackColor = Color.White;
        panel1.Controls.Add(createAccountButton);
        panel1.Controls.Add(label3);
        panel1.Controls.Add(label2);
        panel1.Controls.Add(label4);
        panel1.Controls.Add(signInButton);
        panel1.Controls.Add(label1);
        panel1.Controls.Add(emailTextBox);
        panel1.Controls.Add(passwordTextBox);
        panel1.Location = new Point(0, 0);
        panel1.Name = "panel1";
        panel1.Size = new Size(800, 450);
        panel1.TabIndex = 9;
        // 
        // MainForm
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.White;
        ClientSize = new Size(800, 450);
        Controls.Add(panel1);
        Name = "MainForm";
        Text = "Password Manager";
        panel1.ResumeLayout(false);
        panel1.PerformLayout();
        ResumeLayout(false);
    }

    #endregion

    private Label label1;
    private TextBox emailTextBox;
    private Button signInButton;
    private Label label2;
    private Button createAccountButton;
    private MaskedTextBox passwordTextBox;
    private Label label3;
    private Label label4;
    private Panel panel1;
}
