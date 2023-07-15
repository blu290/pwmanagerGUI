namespace pwmanagerGUI
{
    partial class MakeNewPW
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
            ShowPW = new Button();
            generateRandomPWButton = new Button();
            CreateEntryButton = new Button();
            PWTextbox = new TextBox();
            PWloginText = new Label();
            UNLoginText = new Label();
            UNTextbox = new TextBox();
            LoginTItle = new Label();
            label1 = new Label();
            SNTextBox = new TextBox();
            OverwriteExisting = new CheckBox();
            SuspendLayout();
            // 
            // ShowPW
            // 
            ShowPW.Anchor = AnchorStyles.Top;
            ShowPW.BackColor = Color.FromArgb(255, 192, 255);
            ShowPW.FlatStyle = FlatStyle.Flat;
            ShowPW.Location = new Point(182, 334);
            ShowPW.Name = "ShowPW";
            ShowPW.Size = new Size(127, 39);
            ShowPW.TabIndex = 25;
            ShowPW.Text = "show password";
            ShowPW.UseVisualStyleBackColor = false;
            ShowPW.Click += ShowPW_Click;
            // 
            // generateRandomPWButton
            // 
            generateRandomPWButton.Anchor = AnchorStyles.Top;
            generateRandomPWButton.BackColor = Color.FromArgb(255, 192, 255);
            generateRandomPWButton.FlatStyle = FlatStyle.Flat;
            generateRandomPWButton.Location = new Point(41, 334);
            generateRandomPWButton.Name = "generateRandomPWButton";
            generateRandomPWButton.Size = new Size(135, 39);
            generateRandomPWButton.TabIndex = 24;
            generateRandomPWButton.Text = "generate random pw";
            generateRandomPWButton.UseVisualStyleBackColor = false;
            generateRandomPWButton.Click += generateRandomPWButton_Click;
            // 
            // CreateEntryButton
            // 
            CreateEntryButton.Anchor = AnchorStyles.Top;
            CreateEntryButton.BackColor = Color.FromArgb(255, 192, 255);
            CreateEntryButton.FlatStyle = FlatStyle.Flat;
            CreateEntryButton.Location = new Point(315, 334);
            CreateEntryButton.Name = "CreateEntryButton";
            CreateEntryButton.Size = new Size(134, 39);
            CreateEntryButton.TabIndex = 23;
            CreateEntryButton.Text = "create entry";
            CreateEntryButton.UseVisualStyleBackColor = false;
            CreateEntryButton.Click += CreateEntryButton_Click;
            // 
            // PWTextbox
            // 
            PWTextbox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            PWTextbox.BackColor = Color.FromArgb(255, 192, 255);
            PWTextbox.BorderStyle = BorderStyle.None;
            PWTextbox.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            PWTextbox.Location = new Point(41, 265);
            PWTextbox.Name = "PWTextbox";
            PWTextbox.PasswordChar = '*';
            PWTextbox.PlaceholderText = "enter your password";
            PWTextbox.Size = new Size(408, 29);
            PWTextbox.TabIndex = 22;
            // 
            // PWloginText
            // 
            PWloginText.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            PWloginText.AutoSize = true;
            PWloginText.BackColor = Color.FromArgb(0, 0, 0, 1);
            PWloginText.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            PWloginText.ForeColor = Color.FromArgb(255, 192, 255);
            PWloginText.Location = new Point(41, 242);
            PWloginText.Name = "PWloginText";
            PWloginText.Size = new Size(86, 20);
            PWloginText.TabIndex = 21;
            PWloginText.Text = "Password";
            // 
            // UNLoginText
            // 
            UNLoginText.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            UNLoginText.AutoSize = true;
            UNLoginText.BackColor = Color.FromArgb(0, 0, 0, 1);
            UNLoginText.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            UNLoginText.ForeColor = Color.FromArgb(255, 192, 255);
            UNLoginText.Location = new Point(41, 166);
            UNLoginText.Name = "UNLoginText";
            UNLoginText.Size = new Size(91, 20);
            UNLoginText.TabIndex = 20;
            UNLoginText.Text = "Username";
            // 
            // UNTextbox
            // 
            UNTextbox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            UNTextbox.BackColor = Color.FromArgb(255, 192, 255);
            UNTextbox.BorderStyle = BorderStyle.None;
            UNTextbox.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            UNTextbox.Location = new Point(41, 189);
            UNTextbox.Name = "UNTextbox";
            UNTextbox.PlaceholderText = "enter your username";
            UNTextbox.Size = new Size(408, 29);
            UNTextbox.TabIndex = 19;
            // 
            // LoginTItle
            // 
            LoginTItle.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            LoginTItle.AutoSize = true;
            LoginTItle.BackColor = Color.FromArgb(0, 0, 0, 1);
            LoginTItle.Font = new Font("Microsoft Sans Serif", 27.75F, FontStyle.Bold, GraphicsUnit.Point);
            LoginTItle.ForeColor = Color.FromArgb(255, 192, 255);
            LoginTItle.Location = new Point(5, 41);
            LoginTItle.Name = "LoginTItle";
            LoginTItle.RightToLeft = RightToLeft.Yes;
            LoginTItle.Size = new Size(490, 42);
            LoginTItle.TabIndex = 18;
            LoginTItle.Text = "create new password entry";
            LoginTItle.Click += LoginTItle_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(0, 0, 0, 1);
            label1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(255, 192, 255);
            label1.Location = new Point(41, 100);
            label1.Name = "label1";
            label1.Size = new Size(119, 20);
            label1.TabIndex = 27;
            label1.Text = "Service Name";
            // 
            // SNTextBox
            // 
            SNTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            SNTextBox.BackColor = Color.FromArgb(255, 192, 255);
            SNTextBox.BorderStyle = BorderStyle.None;
            SNTextBox.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            SNTextBox.Location = new Point(41, 123);
            SNTextBox.Name = "SNTextBox";
            SNTextBox.PlaceholderText = "enter the service name";
            SNTextBox.Size = new Size(408, 29);
            SNTextBox.TabIndex = 26;
            SNTextBox.TextChanged += textBox1_TextChanged;
            // 
            // OverwriteExisting
            // 
            OverwriteExisting.Anchor = AnchorStyles.Top;
            OverwriteExisting.AutoSize = true;
            OverwriteExisting.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            OverwriteExisting.ForeColor = Color.FromArgb(255, 192, 255);
            OverwriteExisting.Location = new Point(235, 158);
            OverwriteExisting.Name = "OverwriteExisting";
            OverwriteExisting.Size = new Size(214, 24);
            OverwriteExisting.TabIndex = 28;
            OverwriteExisting.Text = "Overwrite existing entry";
            OverwriteExisting.UseVisualStyleBackColor = true;
            OverwriteExisting.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // MakeNewPW
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(92, 88, 126);
            Controls.Add(OverwriteExisting);
            Controls.Add(label1);
            Controls.Add(SNTextBox);
            Controls.Add(ShowPW);
            Controls.Add(generateRandomPWButton);
            Controls.Add(CreateEntryButton);
            Controls.Add(PWTextbox);
            Controls.Add(PWloginText);
            Controls.Add(UNLoginText);
            Controls.Add(UNTextbox);
            Controls.Add(LoginTItle);
            MinimumSize = new Size(491, 379);
            Name = "MakeNewPW";
            Size = new Size(491, 379);
            Load += MakeNewPW_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button ShowPW;
        private Button generateRandomPWButton;
        private Button CreateEntryButton;
        private TextBox PWTextbox;
        private Label PWloginText;
        private Label UNLoginText;
        private TextBox UNTextbox;
        private Label LoginTItle;
        private Label label1;
        private TextBox SNTextBox;
        private CheckBox OverwriteExisting;
    }
}
