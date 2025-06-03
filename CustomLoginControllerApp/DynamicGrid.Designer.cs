namespace CustomLoginControllerApp
{
    partial class DynamicGrid
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
            lblRows = new Label();
            label2 = new Label();
            txtRows = new TextBox();
            txtColumns = new TextBox();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // lblRows
            // 
            lblRows.AutoSize = true;
            lblRows.Location = new Point(196, 40);
            lblRows.Name = "lblRows";
            lblRows.Size = new Size(38, 15);
            lblRows.TabIndex = 0;
            lblRows.Text = "Rows:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(385, 40);
            label2.Name = "label2";
            label2.Size = new Size(58, 15);
            label2.TabIndex = 1;
            label2.Text = "Columns:";
            // 
            // txtRows
            // 
            txtRows.Location = new Point(255, 35);
            txtRows.Name = "txtRows";
            txtRows.Size = new Size(100, 23);
            txtRows.TabIndex = 2;
            txtRows.TextChanged += txtRows_TextChanged;
            // 
            // txtColumns
            // 
            txtColumns.Location = new Point(459, 37);
            txtColumns.Name = "txtColumns";
            txtColumns.Size = new Size(100, 23);
            txtColumns.TabIndex = 3;
            txtColumns.TextChanged += txtColumns_TextChanged;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(108, 104);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(579, 290);
            dataGridView1.TabIndex = 4;
            // 
            // DynamicGrid
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridView1);
            Controls.Add(txtColumns);
            Controls.Add(txtRows);
            Controls.Add(label2);
            Controls.Add(lblRows);
            Name = "DynamicGrid";
            Text = "DynamicGrid";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblRows;
        private Label label2;
        private TextBox txtRows;
        private TextBox txtColumns;
        private DataGridView dataGridView1;
    }
}