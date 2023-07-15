namespace pwmanagerGUI
{
    partial class PWDisplay
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            PWTable = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)PWTable).BeginInit();
            SuspendLayout();
            // 
            // PWTable
            // 
            PWTable.AllowUserToAddRows = false;
            PWTable.AllowUserToDeleteRows = false;
            PWTable.AllowUserToOrderColumns = true;
            PWTable.AllowUserToResizeColumns = false;
            PWTable.BackgroundColor = Color.FromArgb(92, 88, 126);
            PWTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Window;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            PWTable.DefaultCellStyle = dataGridViewCellStyle1;
            PWTable.Dock = DockStyle.Fill;
            PWTable.GridColor = SystemColors.ControlDarkDark;
            PWTable.Location = new Point(0, 0);
            PWTable.Margin = new Padding(300, 3, 3, 3);
            PWTable.Name = "PWTable";
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            PWTable.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            PWTable.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            PWTable.RowTemplate.Height = 25;
            PWTable.RowTemplate.Resizable = DataGridViewTriState.True;
            PWTable.ShowEditingIcon = false;
            PWTable.ShowRowErrors = false;
            PWTable.Size = new Size(689, 374);
            PWTable.TabIndex = 1;
            PWTable.CellContentClick += PWTable_CellContentClick;
            // 
            // PWDisplay
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoValidate = AutoValidate.EnableAllowFocusChange;
            BackColor = Color.FromArgb(92, 88, 126);
            Controls.Add(PWTable);
            Name = "PWDisplay";
            Size = new Size(689, 374);
            Load += PWDisplay_Load;
            ((System.ComponentModel.ISupportInitialize)PWTable).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView PWTable;
    }
}
