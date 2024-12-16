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
            progressBarAmountSold = new ProgressBar();
            labelProductName = new Label();
            labelAmountSold = new Label();
            panel1 = new Panel();
            labelIncome = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBoxProductImage).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // labelNo
            // 
            labelNo.AutoSize = true;
            labelNo.Font = new Font("Segoe UI", 16F);
            labelNo.Location = new Point(15, 46);
            labelNo.Name = "labelNo";
            labelNo.Size = new Size(73, 59);
            labelNo.TabIndex = 20;
            labelNo.Text = "#1";
            // 
            // pictureBoxProductImage
            // 
            pictureBoxProductImage.Anchor = AnchorStyles.None;
            pictureBoxProductImage.Location = new Point(55, 9);
            pictureBoxProductImage.Name = "pictureBoxProductImage";
            pictureBoxProductImage.Size = new Size(100, 98);
            pictureBoxProductImage.TabIndex = 18;
            pictureBoxProductImage.TabStop = false;
            // 
            // progressBarAmountSold
            // 
            progressBarAmountSold.Location = new Point(317, 3);
            progressBarAmountSold.Name = "progressBarAmountSold";
            progressBarAmountSold.Size = new Size(412, 159);
            progressBarAmountSold.TabIndex = 17;
            // 
            // labelProductName
            // 
            labelProductName.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            labelProductName.Location = new Point(3, 111);
            labelProductName.Name = "labelProductName";
            labelProductName.Size = new Size(209, 32);
            labelProductName.TabIndex = 19;
            labelProductName.Text = "Nazwa";
            labelProductName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelAmountSold
            // 
            labelAmountSold.AutoSize = true;
            labelAmountSold.Location = new Point(735, 46);
            labelAmountSold.Name = "labelAmountSold";
            labelAmountSold.Size = new Size(107, 32);
            labelAmountSold.TabIndex = 21;
            labelAmountSold.Text = "2137 szt.";
            // 
            // panel1
            // 
            panel1.Controls.Add(pictureBoxProductImage);
            panel1.Controls.Add(labelProductName);
            panel1.Location = new Point(94, 6);
            panel1.Name = "panel1";
            panel1.Size = new Size(217, 153);
            panel1.TabIndex = 22;
            // 
            // labelIncome
            // 
            labelIncome.AutoSize = true;
            labelIncome.Location = new Point(735, 81);
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
            Controls.Add(labelNo);
            Controls.Add(progressBarAmountSold);
            Name = "UCProductStatistic";
            Size = new Size(866, 165);
            ((System.ComponentModel.ISupportInitialize)pictureBoxProductImage).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelNo;
        private PictureBox pictureBoxProductImage;
        private ProgressBar progressBarAmountSold;
        private Label labelProductName;
        private Label labelAmountSold;
        private Panel panel1;
        private Label labelIncome;
    }
}
