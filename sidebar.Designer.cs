namespace pwmanagerGUI
{
    partial class Sidebar
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
            LogOut = new Button();
            UserNameText = new Label();
            ViewEntries = new Button();
            CreateEntry = new Button();
            ChangeMasterPassword = new Button();
            EntryDeletButton = new Button();
            SuspendLayout();
            // 
            // LogOut
            // 
            LogOut.BackColor = Color.Pink;
            LogOut.FlatAppearance.BorderSize = 0;
            LogOut.FlatStyle = FlatStyle.Flat;
            LogOut.Location = new Point(0, 319);
            LogOut.Name = "LogOut";
            LogOut.Size = new Size(150, 68);
            LogOut.TabIndex = 0;
            LogOut.Text = "Log out";
            LogOut.UseVisualStyleBackColor = false;
            LogOut.Click += button1_Click;
            // 
            // UserNameText
            // 
            UserNameText.AutoSize = true;
            UserNameText.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            UserNameText.ForeColor = SystemColors.ButtonFace;
            UserNameText.Location = new Point(3, 0);
            UserNameText.Name = "UserNameText";
            UserNameText.Size = new Size(121, 20);
            UserNameText.TabIndex = 5;
            UserNameText.Text = "Your Username";
            UserNameText.Click += label1_Click;
            // 
            // ViewEntries
            // 
            ViewEntries.BackColor = Color.Pink;
            ViewEntries.FlatAppearance.BorderSize = 0;
            ViewEntries.FlatStyle = FlatStyle.Flat;
            ViewEntries.Location = new Point(0, 23);
            ViewEntries.Name = "ViewEntries";
            ViewEntries.Size = new Size(150, 68);
            ViewEntries.TabIndex = 6;
            ViewEntries.Text = "View Entries";
            ViewEntries.UseVisualStyleBackColor = false;
            ViewEntries.Click += button1_Click_1;
            // 
            // CreateEntry
            // 
            CreateEntry.BackColor = Color.Pink;
            CreateEntry.FlatAppearance.BorderSize = 0;
            CreateEntry.FlatStyle = FlatStyle.Flat;
            CreateEntry.Location = new Point(0, 97);
            CreateEntry.Name = "CreateEntry";
            CreateEntry.Size = new Size(150, 68);
            CreateEntry.TabIndex = 7;
            CreateEntry.Text = "Create Entry";
            CreateEntry.UseVisualStyleBackColor = false;
            CreateEntry.Click += CreateEntry_Click;
            // 
            // ChangeMasterPassword
            // 
            ChangeMasterPassword.BackColor = Color.Pink;
            ChangeMasterPassword.FlatAppearance.BorderSize = 0;
            ChangeMasterPassword.FlatStyle = FlatStyle.Flat;
            ChangeMasterPassword.Location = new Point(0, 171);
            ChangeMasterPassword.Name = "ChangeMasterPassword";
            ChangeMasterPassword.Size = new Size(150, 68);
            ChangeMasterPassword.TabIndex = 8;
            ChangeMasterPassword.Text = "Change Master password";
            ChangeMasterPassword.UseVisualStyleBackColor = false;
            ChangeMasterPassword.Click += button1_Click_2;
            // 
            // EntryDeletButton
            // 
            EntryDeletButton.BackColor = Color.Pink;
            EntryDeletButton.FlatAppearance.BorderSize = 0;
            EntryDeletButton.FlatStyle = FlatStyle.Flat;
            EntryDeletButton.Location = new Point(0, 245);
            EntryDeletButton.Name = "EntryDeletButton";
            EntryDeletButton.Size = new Size(150, 68);
            EntryDeletButton.TabIndex = 9;
            EntryDeletButton.Text = "Delete entry";
            EntryDeletButton.UseVisualStyleBackColor = false;
            // 
            // Sidebar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(183, 176, 247);
            BackgroundImageLayout = ImageLayout.None;
            Controls.Add(EntryDeletButton);
            Controls.Add(ChangeMasterPassword);
            Controls.Add(CreateEntry);
            Controls.Add(ViewEntries);
            Controls.Add(UserNameText);
            Controls.Add(LogOut);
            MinimumSize = new Size(150, 316);
            Name = "Sidebar";
            Size = new Size(150, 389);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button LogOut;
        private Button button2;
        private Label UserNameText;
        private Button ViewEntries;
        private Button CreateEntry;
        private Button ChangeMasterPassword;
        private Button EntryDeletButton;
    }
}
