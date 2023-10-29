namespace Password_Manager.Controls
{
    partial class AccountRow
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            panel3 = new Panel();
            panel4 = new Panel();
            copiedToClipboardLabel = new Label();
            usernameLabel = new Label();
            siteNameLabel = new Label();
            panel2 = new Panel();
            deleteButton = new Button();
            editButton = new Button();
            copyButton = new Button();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(714, 49);
            panel1.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel3.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panel3.BackColor = Color.Transparent;
            panel3.Controls.Add(panel4);
            panel3.Controls.Add(usernameLabel);
            panel3.Controls.Add(siteNameLabel);
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(547, 47);
            panel3.TabIndex = 2;
            // 
            // panel4
            // 
            panel4.BackColor = Color.Transparent;
            panel4.Controls.Add(copiedToClipboardLabel);
            panel4.Dock = DockStyle.Right;
            panel4.Location = new Point(406, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(141, 47);
            panel4.TabIndex = 3;
            // 
            // copiedToClipboardLabel
            // 
            copiedToClipboardLabel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            copiedToClipboardLabel.AutoSize = true;
            copiedToClipboardLabel.BackColor = Color.White;
            copiedToClipboardLabel.ForeColor = Color.RoyalBlue;
            copiedToClipboardLabel.Location = new Point(3, 17);
            copiedToClipboardLabel.Margin = new Padding(3, 25, 3, 25);
            copiedToClipboardLabel.Name = "copiedToClipboardLabel";
            copiedToClipboardLabel.Size = new Size(132, 15);
            copiedToClipboardLabel.TabIndex = 2;
            copiedToClipboardLabel.Text = "Copied to the clipboard";
            copiedToClipboardLabel.Visible = false;
            // 
            // usernameLabel
            // 
            usernameLabel.AutoSize = true;
            usernameLabel.Location = new Point(25, 22);
            usernameLabel.Name = "usernameLabel";
            usernameLabel.Size = new Size(60, 15);
            usernameLabel.TabIndex = 1;
            usernameLabel.Text = "Username";
            // 
            // siteNameLabel
            // 
            siteNameLabel.AutoSize = true;
            siteNameLabel.Location = new Point(5, 5);
            siteNameLabel.Name = "siteNameLabel";
            siteNameLabel.Size = new Size(59, 15);
            siteNameLabel.TabIndex = 0;
            siteNameLabel.Text = "Site name";
            // 
            // panel2
            // 
            panel2.Controls.Add(deleteButton);
            panel2.Controls.Add(editButton);
            panel2.Controls.Add(copyButton);
            panel2.Dock = DockStyle.Right;
            panel2.Location = new Point(553, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(159, 47);
            panel2.TabIndex = 1;
            // 
            // deleteButton
            // 
            deleteButton.AutoSize = true;
            deleteButton.FlatAppearance.BorderSize = 0;
            deleteButton.FlatStyle = FlatStyle.Flat;
            deleteButton.ForeColor = Color.Transparent;
            deleteButton.Image = Properties.Resources.trash_bin;
            deleteButton.Location = new Point(115, 0);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(32, 49);
            deleteButton.TabIndex = 2;
            deleteButton.UseVisualStyleBackColor = true;
            deleteButton.Click += deleteButton_Click;
            // 
            // editButton
            // 
            editButton.AutoSize = true;
            editButton.FlatAppearance.BorderSize = 0;
            editButton.FlatStyle = FlatStyle.Flat;
            editButton.ForeColor = Color.Transparent;
            editButton.Image = Properties.Resources.edit;
            editButton.Location = new Point(67, -1);
            editButton.Name = "editButton";
            editButton.Size = new Size(32, 49);
            editButton.TabIndex = 1;
            editButton.UseVisualStyleBackColor = true;
            // 
            // copyButton
            // 
            copyButton.AutoSize = true;
            copyButton.FlatAppearance.BorderSize = 0;
            copyButton.FlatStyle = FlatStyle.Flat;
            copyButton.ForeColor = Color.Transparent;
            copyButton.Image = Properties.Resources.copy__3_;
            copyButton.Location = new Point(17, 0);
            copyButton.Name = "copyButton";
            copyButton.Size = new Size(32, 49);
            copyButton.TabIndex = 0;
            copyButton.UseVisualStyleBackColor = true;
            copyButton.Click += copyButton_Click;
            // 
            // AccountRow
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.AppWorkspace;
            Controls.Add(panel1);
            Name = "AccountRow";
            Size = new Size(714, 49);
            panel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Label siteNameLabel;
        private Label usernameLabel;
        private Button copyButton;
        private Label copiedToClipboardLabel;
        private Button deleteButton;
        private Button editButton;
        private Panel panel4;
    }
}
