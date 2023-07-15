namespace pwmanagerGUI
{
    partial class ChangeMasterPassword
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
            NewPWTextbox = new TextBox();
            PWloginText = new Label();
            MasterPasswordText = new Label();
            MasterPasswordTextbox = new TextBox();
            LoginTItle = new Label();
            ShowMasterPassword = new Button();
            ShowNewMasterPassword = new Button();
            ChangePasswordButton = new Button();
            FailText = new Label();
            SuspendLayout();
            // 
            // NewPWTextbox
            // 
            NewPWTextbox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            NewPWTextbox.BackColor = Color.FromArgb(255, 192, 255);
            NewPWTextbox.BorderStyle = BorderStyle.None;
            NewPWTextbox.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            NewPWTextbox.Location = new Point(12, 250);
            NewPWTextbox.Name = "NewPWTextbox";
            NewPWTextbox.PasswordChar = '*';
            NewPWTextbox.PlaceholderText = "create new master password";
            NewPWTextbox.Size = new Size(408, 29);
            NewPWTextbox.TabIndex = 26;
            NewPWTextbox.TextChanged += NewPWTextbox_TextChanged;
            // 
            // PWloginText
            // 
            PWloginText.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            PWloginText.AutoSize = true;
            PWloginText.BackColor = Color.FromArgb(0, 0, 0, 1);
            PWloginText.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            PWloginText.ForeColor = Color.FromArgb(255, 192, 255);
            PWloginText.Location = new Point(12, 227);
            PWloginText.Name = "PWloginText";
            PWloginText.Size = new Size(185, 20);
            PWloginText.TabIndex = 25;
            PWloginText.Text = "New Master Password";
            // 
            // MasterPasswordText
            // 
            MasterPasswordText.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            MasterPasswordText.AutoSize = true;
            MasterPasswordText.BackColor = Color.FromArgb(0, 0, 0, 1);
            MasterPasswordText.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            MasterPasswordText.ForeColor = Color.FromArgb(255, 192, 255);
            MasterPasswordText.Location = new Point(12, 151);
            MasterPasswordText.Name = "MasterPasswordText";
            MasterPasswordText.Size = new Size(146, 20);
            MasterPasswordText.TabIndex = 24;
            MasterPasswordText.Text = "Master Password";
            // 
            // MasterPasswordTextbox
            // 
            MasterPasswordTextbox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            MasterPasswordTextbox.BackColor = Color.FromArgb(255, 192, 255);
            MasterPasswordTextbox.BorderStyle = BorderStyle.None;
            MasterPasswordTextbox.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            MasterPasswordTextbox.Location = new Point(12, 174);
            MasterPasswordTextbox.Name = "MasterPasswordTextbox";
            MasterPasswordTextbox.PasswordChar = '*';
            MasterPasswordTextbox.PlaceholderText = "enter master password";
            MasterPasswordTextbox.Size = new Size(408, 29);
            MasterPasswordTextbox.TabIndex = 23;
            MasterPasswordTextbox.TextChanged += MasterPasswordTextbox_TextChanged;
            // 
            // LoginTItle
            // 
            LoginTItle.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            LoginTItle.AutoSize = true;
            LoginTItle.BackColor = Color.FromArgb(0, 0, 0, 1);
            LoginTItle.Font = new Font("Microsoft Sans Serif", 27.75F, FontStyle.Bold, GraphicsUnit.Point);
            LoginTItle.ForeColor = Color.FromArgb(255, 192, 255);
            LoginTItle.Location = new Point(12, 71);
            LoginTItle.Name = "LoginTItle";
            LoginTItle.RightToLeft = RightToLeft.Yes;
            LoginTItle.Size = new Size(458, 42);
            LoginTItle.TabIndex = 27;
            LoginTItle.Text = "change master password";
            LoginTItle.Click += LoginTItle_Click;
            // 
            // ShowMasterPassword
            // 
            ShowMasterPassword.Anchor = AnchorStyles.Top;
            ShowMasterPassword.BackColor = Color.FromArgb(255, 128, 128);
            ShowMasterPassword.FlatAppearance.BorderSize = 0;
            ShowMasterPassword.FlatStyle = FlatStyle.Flat;
            ShowMasterPassword.Location = new Point(417, 174);
            ShowMasterPassword.Name = "ShowMasterPassword";
            ShowMasterPassword.Size = new Size(58, 29);
            ShowMasterPassword.TabIndex = 28;
            ShowMasterPassword.Text = "show";
            ShowMasterPassword.UseVisualStyleBackColor = false;
            ShowMasterPassword.Click += ShowMasterPassword_Click;
            // 
            // ShowNewMasterPassword
            // 
            ShowNewMasterPassword.Anchor = AnchorStyles.Top;
            ShowNewMasterPassword.BackColor = Color.FromArgb(255, 128, 128);
            ShowNewMasterPassword.FlatAppearance.BorderSize = 0;
            ShowNewMasterPassword.FlatStyle = FlatStyle.Flat;
            ShowNewMasterPassword.Location = new Point(417, 250);
            ShowNewMasterPassword.Name = "ShowNewMasterPassword";
            ShowNewMasterPassword.Size = new Size(58, 29);
            ShowNewMasterPassword.TabIndex = 29;
            ShowNewMasterPassword.Text = "show";
            ShowNewMasterPassword.UseVisualStyleBackColor = false;
            ShowNewMasterPassword.Click += ShowNewMasterPassword_Click;
            // 
            // ChangePasswordButton
            // 
            ChangePasswordButton.Anchor = AnchorStyles.Top;
            ChangePasswordButton.BackColor = Color.FromArgb(255, 192, 255);
            ChangePasswordButton.FlatAppearance.BorderSize = 0;
            ChangePasswordButton.FlatStyle = FlatStyle.Flat;
            ChangePasswordButton.Location = new Point(12, 316);
            ChangePasswordButton.Name = "ChangePasswordButton";
            ChangePasswordButton.Size = new Size(463, 39);
            ChangePasswordButton.TabIndex = 30;
            ChangePasswordButton.Text = "change master password";
            ChangePasswordButton.UseVisualStyleBackColor = false;
            ChangePasswordButton.Click += ChangePasswordButton_Click;
            // 
            // FailText
            // 
            FailText.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            FailText.AutoSize = true;
            FailText.BackColor = Color.FromArgb(0, 0, 0, 1);
            FailText.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            FailText.ForeColor = Color.DarkRed;
            FailText.Location = new Point(277, 151);
            FailText.Name = "FailText";
            FailText.RightToLeft = RightToLeft.Yes;
            FailText.Size = new Size(198, 20);
            FailText.TabIndex = 32;
            FailText.Text = "wrong master password";
            // 
            // ChangeMasterPassword
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(92, 88, 126);
            Controls.Add(FailText);
            Controls.Add(ChangePasswordButton);
            Controls.Add(ShowNewMasterPassword);
            Controls.Add(ShowMasterPassword);
            Controls.Add(LoginTItle);
            Controls.Add(NewPWTextbox);
            Controls.Add(PWloginText);
            Controls.Add(MasterPasswordText);
            Controls.Add(MasterPasswordTextbox);
            MinimumSize = new Size(491, 379);
            Name = "ChangeMasterPassword";
            Size = new Size(491, 443);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox NewPWTextbox;
        private Label PWloginText;
        private Label MasterPasswordText;
        private TextBox MasterPasswordTextbox;
        private Label LoginTItle;
        private Button ShowMasterPassword;
        private Button ShowNewMasterPassword;
        private Button ChangePasswordButton;
        private Label FailText;
    }
}
