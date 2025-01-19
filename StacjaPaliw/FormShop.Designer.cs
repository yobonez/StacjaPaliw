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
            buttonPay = new Button();
            labelCheckoutValue = new Label();
            groupBox1 = new GroupBox();
            labelCheckoutDiscountsValue = new Label();
            buttonClose = new Button();
            statusStrip1 = new StatusStrip();
            toolStripStatusLabel1 = new ToolStripStatusLabel();
            ((System.ComponentModel.ISupportInitialize)dataGridViewTransactionItems).BeginInit();
            groupBox1.SuspendLayout();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridViewTransactionItems
            // 
            dataGridViewTransactionItems.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewTransactionItems.Location = new Point(779, 461);
            dataGridViewTransactionItems.Name = "dataGridViewTransactionItems";
            dataGridViewTransactionItems.RowHeadersWidth = 82;
            dataGridViewTransactionItems.RowTemplate.Height = 30;
            dataGridViewTransactionItems.Size = new Size(736, 275);
            dataGridViewTransactionItems.TabIndex = 3;
            // 
            // buttonPay
            // 
            buttonPay.Location = new Point(1365, 881);
            buttonPay.Name = "buttonPay";
            buttonPay.Size = new Size(150, 46);
            buttonPay.TabIndex = 4;
            buttonPay.Text = "Zapłać";
            buttonPay.UseVisualStyleBackColor = true;
            buttonPay.Click += buttonPay_Click;
            // 
            // labelCheckoutValue
            // 
            labelCheckoutValue.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            labelCheckoutValue.Font = new Font("Segoe UI", 10.125F, FontStyle.Regular, GraphicsUnit.Point, 238);
            labelCheckoutValue.Location = new Point(45, 35);
            labelCheckoutValue.Name = "labelCheckoutValue";
            labelCheckoutValue.Size = new Size(685, 35);
            labelCheckoutValue.TabIndex = 5;
            labelCheckoutValue.Text = "Wartość: 0,00 zł";
            labelCheckoutValue.TextAlign = ContentAlignment.TopRight;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(labelCheckoutDiscountsValue);
            groupBox1.Controls.Add(labelCheckoutValue);
            groupBox1.Font = new Font("Segoe UI", 10.875F, FontStyle.Regular, GraphicsUnit.Point, 238);
            groupBox1.Location = new Point(779, 749);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(736, 126);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = "Podsumowanie";
            // 
            // labelCheckoutDiscountsValue
            // 
            labelCheckoutDiscountsValue.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            labelCheckoutDiscountsValue.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 238);
            labelCheckoutDiscountsValue.ForeColor = Color.Green;
            labelCheckoutDiscountsValue.Location = new Point(45, 70);
            labelCheckoutDiscountsValue.Name = "labelCheckoutDiscountsValue";
            labelCheckoutDiscountsValue.Size = new Size(685, 32);
            labelCheckoutDiscountsValue.TabIndex = 6;
            labelCheckoutDiscountsValue.Text = "Zniżki: 0,00 zł";
            labelCheckoutDiscountsValue.TextAlign = ContentAlignment.TopRight;
            // 
            // buttonClose
            // 
            buttonClose.Location = new Point(1209, 881);
            buttonClose.Name = "buttonClose";
            buttonClose.Size = new Size(150, 46);
            buttonClose.TabIndex = 7;
            buttonClose.Text = "Zamknij";
            buttonClose.UseVisualStyleBackColor = true;
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new Size(32, 32);
            statusStrip1.Items.AddRange(new ToolStripItem[] { toolStripStatusLabel1 });
            statusStrip1.Location = new Point(0, 942);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(1539, 42);
            statusStrip1.TabIndex = 8;
            statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            toolStripStatusLabel1.Size = new Size(95, 32);
            toolStripStatusLabel1.Text = "Gotowy";
            // 
            // FormShop
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1539, 984);
            Controls.Add(statusStrip1);
            Controls.Add(buttonClose);
            Controls.Add(groupBox1);
            Controls.Add(buttonPay);
            Controls.Add(dataGridViewTransactionItems);
            Margin = new Padding(6);
            Name = "FormShop";
            Text = "FormShop";
            Load += FormShop_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewTransactionItems).EndInit();
            groupBox1.ResumeLayout(false);
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DataGridView dataGridViewTransactionItems;
        private Button buttonPay;
        private Label labelCheckoutValue;
        private GroupBox groupBox1;
        private Label labelCheckoutDiscountsValue;
        private Button buttonClose;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel toolStripStatusLabel1;
    }
}