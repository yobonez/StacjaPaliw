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
            labelCartValue = new Label();
            buttonPay = new Button();
            panel1 = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // labelCartValue
            // 
            labelCartValue.AutoSize = true;
            labelCartValue.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 238);
            labelCartValue.Location = new Point(6, 15);
            labelCartValue.Margin = new Padding(6, 0, 6, 0);
            labelCartValue.Name = "labelCartValue";
            labelCartValue.Size = new Size(261, 45);
            labelCartValue.TabIndex = 0;
            labelCartValue.Text = "Wartość koszyka:";
            labelCartValue.TextAlign = ContentAlignment.BottomRight;
            // 
            // buttonPay
            // 
            buttonPay.Location = new Point(215, 171);
            buttonPay.Margin = new Padding(6);
            buttonPay.Name = "buttonPay";
            buttonPay.Size = new Size(286, 83);
            buttonPay.TabIndex = 1;
            buttonPay.Text = "Zapłać";
            buttonPay.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.Controls.Add(labelCartValue);
            panel1.Controls.Add(buttonPay);
            panel1.Location = new Point(672, 469);
            panel1.Name = "panel1";
            panel1.Size = new Size(545, 266);
            panel1.TabIndex = 2;
            // 
            // FormShop
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1229, 747);
            Controls.Add(panel1);
            Margin = new Padding(6);
            Name = "FormShop";
            Text = "FormShop";
            Load += FormShop_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label labelCartValue;
        private Button buttonPay;
        private Panel panel1;
    }
}