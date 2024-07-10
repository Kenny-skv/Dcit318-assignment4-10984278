namespace AddressBook
{
    partial class Form1
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
            name_label = new Label();
            nameTxtBox = new TextBox();
            email_label = new Label();
            email_box = new TextBox();
            contact_label = new Label();
            contactTextBox = new TextBox();
            saveBtn = new Button();
            SuspendLayout();
            // 
            // name_label
            // 
            name_label.AutoSize = true;
            name_label.Location = new Point(23, 26);
            name_label.Name = "name_label";
            name_label.Size = new Size(39, 15);
            name_label.TabIndex = 0;
            name_label.Text = "Name";
            // 
            // nameTxtBox
            // 
            nameTxtBox.Location = new Point(82, 23);
            nameTxtBox.Name = "nameTxtBox";
            nameTxtBox.Size = new Size(206, 23);
            nameTxtBox.TabIndex = 1;
            // 
            // email_label
            // 
            email_label.AutoSize = true;
            email_label.Location = new Point(23, 84);
            email_label.Name = "email_label";
            email_label.Size = new Size(36, 15);
            email_label.TabIndex = 2;
            email_label.Text = "Email";
            // 
            // email_box
            // 
            email_box.Location = new Point(82, 81);
            email_box.Name = "email_box";
            email_box.Size = new Size(206, 23);
            email_box.TabIndex = 3;
            // 
            // contact_label
            // 
            contact_label.AutoSize = true;
            contact_label.Location = new Point(23, 141);
            contact_label.Name = "contact_label";
            contact_label.Size = new Size(49, 15);
            contact_label.TabIndex = 4;
            contact_label.Text = "Contact";
            // 
            // contactTextBox
            // 
            contactTextBox.Location = new Point(82, 138);
            contactTextBox.Name = "contactTextBox";
            contactTextBox.Size = new Size(206, 23);
            contactTextBox.TabIndex = 5;
            // 
            // saveBtn
            // 
            saveBtn.BackColor = SystemColors.MenuHighlight;
            saveBtn.Location = new Point(116, 193);
            saveBtn.Name = "saveBtn";
            saveBtn.Size = new Size(129, 23);
            saveBtn.TabIndex = 6;
            saveBtn.Text = "SAVE";
            saveBtn.UseVisualStyleBackColor = false;
            saveBtn.Click += saveBtn_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(356, 250);
            Controls.Add(saveBtn);
            Controls.Add(contactTextBox);
            Controls.Add(contact_label);
            Controls.Add(email_box);
            Controls.Add(email_label);
            Controls.Add(nameTxtBox);
            Controls.Add(name_label);
            Name = "Form1";
            Text = "Address Book";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label name_label;
        private TextBox nameTxtBox;
        private Label email_label;
        private TextBox email_box;
        private Label contact_label;
        private TextBox contactTextBox;
        private Button saveBtn;
    }
}
