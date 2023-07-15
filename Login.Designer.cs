namespace pwmanagerGUI
{
    partial class Login
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
            loginPanel = new Panel();
            pwtxt = new Label();
            ShowPW = new Button();
            goback = new Button();
            loginButton = new Button();
            PWloginTextbox = new TextBox();
            PWloginText = new Label();
            UNLoginText = new Label();
            LoginUsernameTB = new TextBox();
            LoginTItle = new Label();
            loginPanel.SuspendLayout();
            SuspendLayout();
            // 
            // loginPanel
            // 
            loginPanel.AutoSize = true;
            loginPanel.BackColor = SystemColors.ActiveCaptionText;
            loginPanel.Controls.Add(pwtxt);
            loginPanel.Controls.Add(ShowPW);
            loginPanel.Controls.Add(goback);
            loginPanel.Controls.Add(loginButton);
            loginPanel.Controls.Add(PWloginTextbox);
            loginPanel.Controls.Add(PWloginText);
            loginPanel.Controls.Add(UNLoginText);
            loginPanel.Controls.Add(LoginUsernameTB);
            loginPanel.Controls.Add(LoginTItle);
            loginPanel.Dock = DockStyle.Fill;
            loginPanel.Location = new Point(0, 0);
            loginPanel.Name = "loginPanel";
            loginPanel.Size = new Size(848, 553);
            loginPanel.TabIndex = 0;
            // 
            // pwtxt
            // 
            pwtxt.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            pwtxt.AutoSize = true;
            pwtxt.BackColor = SystemColors.ActiveCaptionText;
            pwtxt.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            pwtxt.ForeColor = Color.Red;
            pwtxt.Location = new Point(464, 155);
            pwtxt.Name = "pwtxt";
            pwtxt.Size = new Size(154, 20);
            pwtxt.TabIndex = 8;
            pwtxt.Text = "Invalid credentials";
            pwtxt.Click += pwtxt_Click;
            // 
            // ShowPW
            // 
            ShowPW.Anchor = AnchorStyles.Top;
            ShowPW.BackColor = SystemColors.ActiveCaption;
            ShowPW.FlatStyle = FlatStyle.Flat;
            ShowPW.Location = new Point(491, 264);
            ShowPW.Name = "ShowPW";
            ShowPW.Size = new Size(127, 39);
            ShowPW.TabIndex = 7;
            ShowPW.Text = "show password";
            ShowPW.UseVisualStyleBackColor = false;
            ShowPW.Click += ShowPW_Click;
            // 
            // goback
            // 
            goback.Anchor = AnchorStyles.Top;
            goback.BackColor = SystemColors.ActiveCaption;
            goback.FlatStyle = FlatStyle.Flat;
            goback.Location = new Point(210, 264);
            goback.Name = "goback";
            goback.Size = new Size(135, 39);
            goback.TabIndex = 6;
            goback.Text = "go back";
            goback.UseVisualStyleBackColor = false;
            goback.Click += LoginToCreateAccount_Click;
            // 
            // loginButton
            // 
            loginButton.Anchor = AnchorStyles.Top;
            loginButton.BackColor = SystemColors.ActiveCaption;
            loginButton.FlatStyle = FlatStyle.Flat;
            loginButton.Location = new Point(351, 264);
            loginButton.Name = "loginButton";
            loginButton.Size = new Size(134, 39);
            loginButton.TabIndex = 5;
            loginButton.Text = "log in";
            loginButton.UseVisualStyleBackColor = false;
            loginButton.Click += loginButton_Click;
            // 
            // PWloginTextbox
            // 
            PWloginTextbox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            PWloginTextbox.BackColor = Color.LightSteelBlue;
            PWloginTextbox.BorderStyle = BorderStyle.None;
            PWloginTextbox.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            PWloginTextbox.Location = new Point(210, 195);
            PWloginTextbox.Name = "PWloginTextbox";
            PWloginTextbox.PasswordChar = '*';
            PWloginTextbox.PlaceholderText = "enter your password";
            PWloginTextbox.Size = new Size(408, 29);
            PWloginTextbox.TabIndex = 4;
            PWloginTextbox.TextChanged += PWloginTextbox_TextChanged;
            // 
            // PWloginText
            // 
            PWloginText.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            PWloginText.AutoSize = true;
            PWloginText.BackColor = SystemColors.ActiveCaptionText;
            PWloginText.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            PWloginText.ForeColor = SystemColors.ActiveCaption;
            PWloginText.Location = new Point(210, 172);
            PWloginText.Name = "PWloginText";
            PWloginText.Size = new Size(86, 20);
            PWloginText.TabIndex = 3;
            PWloginText.Text = "Password";
            PWloginText.Click += label1_Click;
            // 
            // UNLoginText
            // 
            UNLoginText.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            UNLoginText.AutoSize = true;
            UNLoginText.BackColor = SystemColors.ActiveCaptionText;
            UNLoginText.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            UNLoginText.ForeColor = SystemColors.ActiveCaption;
            UNLoginText.Location = new Point(210, 96);
            UNLoginText.Name = "UNLoginText";
            UNLoginText.Size = new Size(91, 20);
            UNLoginText.TabIndex = 2;
            UNLoginText.Text = "Username";
            UNLoginText.Click += UNLoginText_Click;
            // 
            // LoginUsernameTB
            // 
            LoginUsernameTB.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            LoginUsernameTB.BackColor = Color.LightSteelBlue;
            LoginUsernameTB.BorderStyle = BorderStyle.None;
            LoginUsernameTB.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            LoginUsernameTB.Location = new Point(210, 119);
            LoginUsernameTB.Name = "LoginUsernameTB";
            LoginUsernameTB.PlaceholderText = "enter your username";
            LoginUsernameTB.Size = new Size(408, 29);
            LoginUsernameTB.TabIndex = 1;
            LoginUsernameTB.TextChanged += LoginUsernameTB_TextChanged;
            // 
            // LoginTItle
            // 
            LoginTItle.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            LoginTItle.AutoSize = true;
            LoginTItle.BackColor = SystemColors.ActiveCaptionText;
            LoginTItle.Font = new Font("Microsoft Sans Serif", 27.75F, FontStyle.Bold, GraphicsUnit.Point);
            LoginTItle.ForeColor = SystemColors.ActiveCaption;
            LoginTItle.Location = new Point(210, 42);
            LoginTItle.Name = "LoginTItle";
            LoginTItle.Size = new Size(408, 42);
            LoginTItle.TabIndex = 0;
            LoginTItle.Text = "Log in to your account";
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonFace;
            Controls.Add(loginPanel);
            Name = "Login";
            Size = new Size(848, 553);
            loginPanel.ResumeLayout(false);
            loginPanel.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel loginPanel;
        private Label LoginTItle;
        private TextBox LoginUsernameTB;
        private Label UNLoginText;
        private Label PWloginText;
        private TextBox PWloginTextbox;
        private Button goback;
        private Button loginButton;
        private Button ShowPW;
        private Label pwtxt;
    }
}
