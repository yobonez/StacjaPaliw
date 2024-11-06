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
            SuspendLayout();
            // 
            // labelCartValue
            // 
            labelCartValue.AutoSize = true;
            labelCartValue.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 238);
            labelCartValue.Location = new Point(439, 275);
            labelCartValue.Name = "labelCartValue";
            labelCartValue.Size = new Size(128, 21);
            labelCartValue.TabIndex = 0;
            labelCartValue.Text = "Wartość koszyka:";
            labelCartValue.TextAlign = ContentAlignment.BottomRight;
            // 
            // buttonPay
            // 
            buttonPay.Location = new Point(496, 299);
            buttonPay.Name = "buttonPay";
            buttonPay.Size = new Size(154, 39);
            buttonPay.TabIndex = 1;
            buttonPay.Text = "Zapłać";
            buttonPay.UseVisualStyleBackColor = true;
            // 
            // FormShop
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(662, 350);
            Controls.Add(buttonPay);
            Controls.Add(labelCartValue);
            Name = "FormShop";
            Text = "FormShop";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelCartValue;
        private Button buttonPay;
    }
}