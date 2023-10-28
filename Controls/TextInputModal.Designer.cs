namespace Password_Manager.Controls
{
    partial class TextInputModal
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
            modalLabel = new Label();
            nameTextBox = new TextBox();
            cancelButton = new Button();
            confirmButton = new Button();
            SuspendLayout();
            // 
            // modalLabel
            // 
            modalLabel.AutoSize = true;
            modalLabel.Location = new Point(10, 6);
            modalLabel.Name = "modalLabel";
            modalLabel.Size = new Size(29, 15);
            modalLabel.TabIndex = 0;
            modalLabel.Text = "Title";
            // 
            // nameTextBox
            // 
            nameTextBox.Location = new Point(12, 24);
            nameTextBox.Name = "nameTextBox";
            nameTextBox.PlaceholderText = "Name";
            nameTextBox.Size = new Size(224, 23);
            nameTextBox.TabIndex = 1;
            // 
            // cancelButton
            // 
            cancelButton.BackColor = Color.White;
            cancelButton.FlatStyle = FlatStyle.Flat;
            cancelButton.Location = new Point(10, 63);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(75, 23);
            cancelButton.TabIndex = 2;
            cancelButton.Text = "Cancel";
            cancelButton.UseVisualStyleBackColor = false;
            // 
            // confirmButton
            // 
            confirmButton.FlatStyle = FlatStyle.Flat;
            confirmButton.Location = new Point(103, 63);
            confirmButton.Name = "confirmButton";
            confirmButton.Size = new Size(75, 23);
            confirmButton.TabIndex = 3;
            confirmButton.Text = "Confirm";
            confirmButton.UseVisualStyleBackColor = true;
            // 
            // TextInputModal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(272, 101);
            Controls.Add(confirmButton);
            Controls.Add(cancelButton);
            Controls.Add(nameTextBox);
            Controls.Add(modalLabel);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "TextInputModal";
            Text = "TextInputModal";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label modalLabel;
        private TextBox nameTextBox;
        private Button cancelButton;
        private Button confirmButton;
    }
}