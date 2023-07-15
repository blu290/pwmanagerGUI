namespace pwmanagerGUI
{
    partial class Gui
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
            mainPanel = new Panel();
            sidebarPanel = new Panel();
            SuspendLayout();
            // 
            // mainPanel
            // 
            mainPanel.AutoSize = true;
            mainPanel.BackColor = SystemColors.GradientActiveCaption;
            mainPanel.Dock = DockStyle.Fill;
            mainPanel.Location = new Point(0, 0);
            mainPanel.MinimumSize = new Size(491, 379);
            mainPanel.Name = "mainPanel";
            mainPanel.Padding = new Padding(150, 0, 0, 0);
            mainPanel.Size = new Size(784, 461);
            mainPanel.TabIndex = 0;
            mainPanel.Paint += mainPanel_Paint;
            // 
            // sidebarPanel
            // 
            sidebarPanel.BackColor = Color.Black;
            sidebarPanel.Dock = DockStyle.Left;
            sidebarPanel.Location = new Point(0, 0);
            sidebarPanel.MinimumSize = new Size(150, 316);
            sidebarPanel.Name = "sidebarPanel";
            sidebarPanel.Size = new Size(150, 461);
            sidebarPanel.TabIndex = 0;
            sidebarPanel.Paint += sidebarPanel_Paint;
            // 
            // Gui
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(784, 461);
            Controls.Add(sidebarPanel);
            Controls.Add(mainPanel);
            MinimumSize = new Size(800, 500);
            Name = "Gui";
            Text = "Gui";
            Load += Gui_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel mainPanel;
        private Panel sidebarPanel;
    }
}