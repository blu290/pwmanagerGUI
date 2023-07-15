namespace pwmanagerGUI
{
    partial class HomeScreen
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
            label1 = new Label();
            mainPagePanel = new Panel();
            mainLogin = new Button();
            mainCreateAccount = new Button();
            mainPageTitle = new Label();
            mainPagePanel.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(225, 0);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 0;
            label1.Text = "label1";
            label1.Click += label1_Click;
            // 
            // mainPagePanel
            // 
            mainPagePanel.AutoSize = true;
            mainPagePanel.BackColor = SystemColors.WindowText;
            mainPagePanel.Controls.Add(mainLogin);
            mainPagePanel.Controls.Add(mainCreateAccount);
            mainPagePanel.Controls.Add(mainPageTitle);
            mainPagePanel.Dock = DockStyle.Fill;
            mainPagePanel.Location = new Point(0, 0);
            mainPagePanel.Name = "mainPagePanel";
            mainPagePanel.Size = new Size(1110, 581);
            mainPagePanel.TabIndex = 1;
            mainPagePanel.Paint += mainPagePanel_Paint;
            // 
            // mainLogin
            // 
            mainLogin.Anchor = AnchorStyles.Top;
            mainLogin.BackColor = Color.Crimson;
            mainLogin.FlatStyle = FlatStyle.Flat;
            mainLogin.Location = new Point(295, 258);
            mainLogin.Name = "mainLogin";
            mainLogin.Size = new Size(514, 147);
            mainLogin.TabIndex = 2;
            mainLogin.Text = "Log in";
            mainLogin.UseVisualStyleBackColor = false;
            mainLogin.Click += mainLogin_Click;
            // 
            // mainCreateAccount
            // 
            mainCreateAccount.Anchor = AnchorStyles.Top;
            mainCreateAccount.BackColor = Color.SlateBlue;
            mainCreateAccount.FlatStyle = FlatStyle.Flat;
            mainCreateAccount.Location = new Point(295, 85);
            mainCreateAccount.Name = "mainCreateAccount";
            mainCreateAccount.Size = new Size(514, 147);
            mainCreateAccount.TabIndex = 1;
            mainCreateAccount.Text = "Create Account";
            mainCreateAccount.UseVisualStyleBackColor = false;
            mainCreateAccount.Click += mainCreateAccount_Click;
            // 
            // mainPageTitle
            // 
            mainPageTitle.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            mainPageTitle.AutoSize = true;
            mainPageTitle.Font = new Font("Microsoft Sans Serif", 27.75F, FontStyle.Bold, GraphicsUnit.Point);
            mainPageTitle.ForeColor = SystemColors.InactiveCaption;
            mainPageTitle.Location = new Point(295, 9);
            mainPageTitle.Name = "mainPageTitle";
            mainPageTitle.Size = new Size(514, 42);
            mainPageTitle.TabIndex = 0;
            mainPageTitle.Text = "Welcome to program :DDDD";
            mainPageTitle.TextAlign = ContentAlignment.MiddleCenter;
            mainPageTitle.Click += mainPageTitle_Click;
            // 
            // HomeScreen
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(mainPagePanel);
            Controls.Add(label1);
            Name = "HomeScreen";
            Size = new Size(1110, 581);
            Load += CreateAccount_Load;
            mainPagePanel.ResumeLayout(false);
            mainPagePanel.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button mainLogin;
        private Button mainCreateAccount;
        private Label mainPageTitle;
        public Panel mainPagePanel;
    }
}
