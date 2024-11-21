namespace StacjaPaliwUI
{
    partial class UCProduct
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
            pictureBoxProduct = new PictureBox();
            labelName = new Label();
            numericUpDownAmount = new NumericUpDown();
            labelPricePerUnit = new Label();
            panel1 = new Panel();
            buttonAddToCheckout = new Button();
            labelTimesEqualsValue = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBoxProduct).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownAmount).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBoxProduct
            // 
            pictureBoxProduct.BackgroundImage = Properties.Resources.NoImage;
            pictureBoxProduct.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBoxProduct.Location = new Point(75, 23);
            pictureBoxProduct.Name = "pictureBoxProduct";
            pictureBoxProduct.Size = new Size(150, 150);
            pictureBoxProduct.TabIndex = 0;
            pictureBoxProduct.TabStop = false;
            // 
            // labelName
            // 
            labelName.Font = new Font("Segoe UI", 11F);
            labelName.Location = new Point(3, 9);
            labelName.Name = "labelName";
            labelName.Size = new Size(254, 41);
            labelName.TabIndex = 1;
            labelName.Text = "ProductName";
            labelName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // numericUpDownAmount
            // 
            numericUpDownAmount.Location = new Point(26, 101);
            numericUpDownAmount.Maximum = new decimal(new int[] { 99, 0, 0, 0 });
            numericUpDownAmount.Name = "numericUpDownAmount";
            numericUpDownAmount.Size = new Size(93, 39);
            numericUpDownAmount.TabIndex = 2;
            numericUpDownAmount.UpDownAlign = LeftRightAlignment.Left;
            numericUpDownAmount.ValueChanged += numericUpDownAmount_ValueChanged;
            // 
            // labelPricePerUnit
            // 
            labelPricePerUnit.Anchor = AnchorStyles.None;
            labelPricePerUnit.Location = new Point(3, 50);
            labelPricePerUnit.Name = "labelPricePerUnit";
            labelPricePerUnit.Size = new Size(254, 32);
            labelPricePerUnit.TabIndex = 3;
            labelPricePerUnit.Text = "0,00 zł / szt.";
            labelPricePerUnit.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            panel1.Controls.Add(buttonAddToCheckout);
            panel1.Controls.Add(labelTimesEqualsValue);
            panel1.Controls.Add(labelName);
            panel1.Controls.Add(labelPricePerUnit);
            panel1.Controls.Add(numericUpDownAmount);
            panel1.Location = new Point(21, 179);
            panel1.Name = "panel1";
            panel1.Size = new Size(260, 203);
            panel1.TabIndex = 4;
            // 
            // buttonAddToCheckout
            // 
            buttonAddToCheckout.Location = new Point(49, 146);
            buttonAddToCheckout.Name = "buttonAddToCheckout";
            buttonAddToCheckout.Size = new Size(150, 46);
            buttonAddToCheckout.TabIndex = 5;
            buttonAddToCheckout.Text = "Dodaj";
            buttonAddToCheckout.UseVisualStyleBackColor = true;
            buttonAddToCheckout.Click += buttonAddToCheckout_Click;
            // 
            // labelTimesEqualsValue
            // 
            labelTimesEqualsValue.AutoSize = true;
            labelTimesEqualsValue.Font = new Font("Segoe UI", 9F);
            labelTimesEqualsValue.Location = new Point(125, 103);
            labelTimesEqualsValue.Name = "labelTimesEqualsValue";
            labelTimesEqualsValue.Size = new Size(124, 32);
            labelTimesEqualsValue.TabIndex = 4;
            labelTimesEqualsValue.Text = "x = 0,00 zł";
            // 
            // UCProduct
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Controls.Add(pictureBoxProduct);
            Name = "UCProduct";
            Size = new Size(300, 405);
            Load += UCProduct_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBoxProduct).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownAmount).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBoxProduct;
        private Label labelName;
        private NumericUpDown numericUpDownAmount;
        private Label labelPricePerUnit;
        private Panel panel1;
        private Label labelTimesEqualsValue;
        private Button buttonAddToCheckout;
    }
}
