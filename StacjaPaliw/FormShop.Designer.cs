namespace StacjaPaliwUI
{
    partial class FormShop
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
            dataGridViewTransactionItems = new DataGridView();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridViewTransactionItems).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewTransactionItems
            // 
            dataGridViewTransactionItems.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewTransactionItems.Location = new Point(642, 438);
            dataGridViewTransactionItems.Name = "dataGridViewTransactionItems";
            dataGridViewTransactionItems.RowHeadersWidth = 82;
            dataGridViewTransactionItems.RowTemplate.Height = 30;
            dataGridViewTransactionItems.Size = new Size(736, 275);
            dataGridViewTransactionItems.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 238);
            label1.Location = new Point(642, 726);
            label1.Margin = new Padding(6, 0, 6, 0);
            label1.Name = "label1";
            label1.Size = new Size(236, 45);
            label1.TabIndex = 0;
            label1.Text = "Podsumowanie";
            label1.TextAlign = ContentAlignment.BottomRight;
            // 
            // FormShop
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1390, 864);
            Controls.Add(dataGridViewTransactionItems);
            Controls.Add(label1);
            Margin = new Padding(6);
            Name = "FormShop";
            Text = "FormShop";
            Load += FormShop_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewTransactionItems).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DataGridView dataGridViewTransactionItems;
        private Label label1;
    }
}