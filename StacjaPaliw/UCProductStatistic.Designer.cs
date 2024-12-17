namespace StacjaPaliwUI
{
    partial class UCProductStatistic
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
            labelNo = new Label();
            pictureBoxProductImage = new PictureBox();
            progressBarValue = new ProgressBar();
            labelAmountSold = new Label();
            panel1 = new Panel();
            labelProductName = new Label();
            labelIncome = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBoxProductImage).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // labelNo
            // 
            labelNo.AutoSize = true;
            labelNo.Font = new Font("Segoe UI", 13F);
            labelNo.Location = new Point(18, 16);
            labelNo.Name = "labelNo";
            labelNo.Size = new Size(60, 47);
            labelNo.TabIndex = 20;
            labelNo.Text = "#1";
            // 
            // pictureBoxProductImage
            // 
            pictureBoxProductImage.Anchor = AnchorStyles.None;
            pictureBoxProductImage.BackgroundImage = Properties.Resources.NoImage;
            pictureBoxProductImage.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBoxProductImage.Location = new Point(174, 3);
            pictureBoxProductImage.Name = "pictureBoxProductImage";
            pictureBoxProductImage.Size = new Size(95, 95);
            pictureBoxProductImage.TabIndex = 18;
            pictureBoxProductImage.TabStop = false;
            // 
            // progressBarValue
            // 
            progressBarValue.Location = new Point(285, 3);
            progressBarValue.Name = "progressBarValue";
            progressBarValue.Size = new Size(171, 107);
            progressBarValue.TabIndex = 17;
            // 
            // labelAmountSold
            // 
            labelAmountSold.AutoSize = true;
            labelAmountSold.Location = new Point(472, 19);
            labelAmountSold.Name = "labelAmountSold";
            labelAmountSold.Size = new Size(107, 32);
            labelAmountSold.TabIndex = 21;
            labelAmountSold.Text = "2137 szt.";
            // 
            // panel1
            // 
            panel1.Controls.Add(pictureBoxProductImage);
            panel1.Controls.Add(labelProductName);
            panel1.Controls.Add(labelNo);
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(276, 107);
            panel1.TabIndex = 22;
            // 
            // labelProductName
            // 
            labelProductName.Font = new Font("Segoe UI", 8F);
            labelProductName.Location = new Point(6, 63);
            labelProductName.Name = "labelProductName";
            labelProductName.Size = new Size(143, 32);
            labelProductName.TabIndex = 19;
            labelProductName.Text = "Nazwa";
            // 
            // labelIncome
            // 
            labelIncome.AutoSize = true;
            labelIncome.Location = new Point(472, 54);
            labelIncome.Name = "labelIncome";
            labelIncome.Size = new Size(128, 32);
            labelIncome.TabIndex = 23;
            labelIncome.Text = "00000,00zł";
            // 
            // UCProductStatistic
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(labelIncome);
            Controls.Add(panel1);
            Controls.Add(labelAmountSold);
            Controls.Add(progressBarValue);
            Name = "UCProductStatistic";
            Size = new Size(610, 112);
            Load += UCProductStatistic_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBoxProductImage).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelNo;
        private PictureBox pictureBoxProductImage;
        private ProgressBar progressBarValue;
        private Label labelAmountSold;
        private Panel panel1;
        private Label labelIncome;
        private Label labelProductName;
    }
}
