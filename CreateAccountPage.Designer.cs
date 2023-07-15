namespace pwmanagerGUI
{
    partial class CreateAccountPage
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
            accountPanel = new Panel();
            UNTaken = new Label();
            ShowPW = new Button();
            goback = new Button();
            CreateAccountButton = new Button();
            PWloginTextbox = new TextBox();
            PWloginText = new Label();
            UNLoginText = new Label();
            LoginUsernameTB = new TextBox();
            LoginTItle = new Label();
            accountPanel.SuspendLayout();
            SuspendLayout();
            // 
            // accountPanel
            // 
            accountPanel.BackColor = SystemColors.ActiveCaptionText;
            accountPanel.Controls.Add(UNTaken);
            accountPanel.Controls.Add(ShowPW);
            accountPanel.Controls.Add(goback);
            accountPanel.Controls.Add(CreateAccountButton);
            accountPanel.Controls.Add(PWloginTextbox);
            accountPanel.Controls.Add(PWloginText);
            accountPanel.Controls.Add(UNLoginText);
            accountPanel.Controls.Add(LoginUsernameTB);
            accountPanel.Controls.Add(LoginTItle);
            accountPanel.Dock = DockStyle.Fill;
            accountPanel.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            accountPanel.Location = new Point(0, 0);
            accountPanel.Name = "accountPanel";
            accountPanel.Size = new Size(942, 549);
            accountPanel.TabIndex = 0;
            // 
            // UNTaken
            // 
            UNTaken.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            UNTaken.AutoSize = true;
            UNTaken.BackColor = SystemColors.ActiveCaptionText;
            UNTaken.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            UNTaken.ForeColor = Color.Red;
            UNTaken.Location = new Point(533, 201);
            UNTaken.Name = "UNTaken";
            UNTaken.Size = new Size(138, 20);
            UNTaken.TabIndex = 17;
            UNTaken.Text = "username taken";
            UNTaken.Click += pwtxt_Click;
            // 
            // ShowPW
            // 
            ShowPW.Anchor = AnchorStyles.Top;
            ShowPW.BackColor = SystemColors.ActiveCaption;
            ShowPW.FlatStyle = FlatStyle.Flat;
            ShowPW.Location = new Point(544, 303);
            ShowPW.Name = "ShowPW";
            ShowPW.Size = new Size(127, 39);
            ShowPW.TabIndex = 16;
            ShowPW.Text = "show password";
            ShowPW.UseVisualStyleBackColor = false;
            ShowPW.Click += ShowPW_Click;
            // 
            // goback
            // 
            goback.Anchor = AnchorStyles.Top;
            goback.BackColor = SystemColors.ActiveCaption;
            goback.FlatStyle = FlatStyle.Flat;
            goback.Location = new Point(263, 303);
            goback.Name = "goback";
            goback.Size = new Size(135, 39);
            goback.TabIndex = 15;
            goback.Text = "go back";
            goback.UseVisualStyleBackColor = false;
            goback.Click += goback_Click;
            // 
            // CreateAccountButton
            // 
            CreateAccountButton.Anchor = AnchorStyles.Top;
            CreateAccountButton.BackColor = SystemColors.ActiveCaption;
            CreateAccountButton.FlatStyle = FlatStyle.Flat;
            CreateAccountButton.Location = new Point(404, 303);
            CreateAccountButton.Name = "CreateAccountButton";
            CreateAccountButton.Size = new Size(134, 39);
            CreateAccountButton.TabIndex = 14;
            CreateAccountButton.Text = "create account";
            CreateAccountButton.UseVisualStyleBackColor = false;
            CreateAccountButton.Click += loginButton_Click;
            // 
            // PWloginTextbox
            // 
            PWloginTextbox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            PWloginTextbox.BackColor = Color.LightSteelBlue;
            PWloginTextbox.BorderStyle = BorderStyle.None;
            PWloginTextbox.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            PWloginTextbox.Location = new Point(263, 234);
            PWloginTextbox.Name = "PWloginTextbox";
            PWloginTextbox.PasswordChar = '*';
            PWloginTextbox.PlaceholderText = "enter your password";
            PWloginTextbox.Size = new Size(408, 29);
            PWloginTextbox.TabIndex = 13;
            PWloginTextbox.TextChanged += PWloginTextbox_TextChanged;
            // 
            // PWloginText
            // 
            PWloginText.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            PWloginText.AutoSize = true;
            PWloginText.BackColor = SystemColors.ActiveCaptionText;
            PWloginText.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            PWloginText.ForeColor = SystemColors.ActiveCaption;
            PWloginText.Location = new Point(263, 211);
            PWloginText.Name = "PWloginText";
            PWloginText.Size = new Size(86, 20);
            PWloginText.TabIndex = 12;
            PWloginText.Text = "Password";
            PWloginText.Click += PWloginText_Click;
            // 
            // UNLoginText
            // 
            UNLoginText.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            UNLoginText.AutoSize = true;
            UNLoginText.BackColor = SystemColors.ActiveCaptionText;
            UNLoginText.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            UNLoginText.ForeColor = SystemColors.ActiveCaption;
            UNLoginText.Location = new Point(263, 135);
            UNLoginText.Name = "UNLoginText";
            UNLoginText.Size = new Size(91, 20);
            UNLoginText.TabIndex = 11;
            UNLoginText.Text = "Username";
            UNLoginText.Click += UNLoginText_Click;
            // 
            // LoginUsernameTB
            // 
            LoginUsernameTB.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            LoginUsernameTB.BackColor = Color.LightSteelBlue;
            LoginUsernameTB.BorderStyle = BorderStyle.None;
            LoginUsernameTB.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            LoginUsernameTB.Location = new Point(263, 158);
            LoginUsernameTB.Name = "LoginUsernameTB";
            LoginUsernameTB.PlaceholderText = "enter your username";
            LoginUsernameTB.Size = new Size(408, 29);
            LoginUsernameTB.TabIndex = 10;
            LoginUsernameTB.TextChanged += LoginUsernameTB_TextChanged;
            // 
            // LoginTItle
            // 
            LoginTItle.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            LoginTItle.AutoSize = true;
            LoginTItle.BackColor = SystemColors.ActiveCaptionText;
            LoginTItle.Font = new Font("Microsoft Sans Serif", 27.75F, FontStyle.Bold, GraphicsUnit.Point);
            LoginTItle.ForeColor = SystemColors.ActiveCaption;
            LoginTItle.Location = new Point(263, 70);
            LoginTItle.Name = "LoginTItle";
            LoginTItle.Size = new Size(341, 42);
            LoginTItle.TabIndex = 9;
            LoginTItle.Text = "Create an account";
            LoginTItle.Click += LoginTItle_Click;
            // 
            // CreateAccountPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(accountPanel);
            Name = "CreateAccountPage";
            Size = new Size(942, 549);
            accountPanel.ResumeLayout(false);
            accountPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel accountPanel;
        private Label UNTaken;
        private Button ShowPW;
        private Button goback;
        private Button CreateAccountButton;
        private TextBox PWloginTextbox;
        private Label PWloginText;
        private Label UNLoginText;
        private TextBox LoginUsernameTB;
        private Label LoginTItle;
    }
}
