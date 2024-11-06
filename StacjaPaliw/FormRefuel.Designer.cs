namespace StacjaPaliwUI
{
    partial class FormRefuel
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
            comboBoxFuelType = new ComboBox();
            labelWelcome = new Label();
            labelFuelType = new Label();
            statusStrip1 = new StatusStrip();
            groupBox1 = new GroupBox();
            label2 = new Label();
            groupBox2 = new GroupBox();
            label3 = new Label();
            label1 = new Label();
            groupBoxPrice = new GroupBox();
            labelPrice = new Label();
            buttonRefuelling = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBoxPrice.SuspendLayout();
            SuspendLayout();
            // 
            // comboBoxFuelType
            // 
            comboBoxFuelType.FormattingEnabled = true;
            comboBoxFuelType.Location = new Point(80, 68);
            comboBoxFuelType.Name = "comboBoxFuelType";
            comboBoxFuelType.Size = new Size(121, 23);
            comboBoxFuelType.TabIndex = 0;
            // 
            // labelWelcome
            // 
            labelWelcome.AutoSize = true;
            labelWelcome.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 238);
            labelWelcome.Location = new Point(61, 9);
            labelWelcome.Name = "labelWelcome";
            labelWelcome.Size = new Size(121, 30);
            labelWelcome.TabIndex = 3;
            labelWelcome.Text = "Tankowanie";
            // 
            // labelFuelType
            // 
            labelFuelType.AutoSize = true;
            labelFuelType.Location = new Point(12, 71);
            labelFuelType.Name = "labelFuelType";
            labelFuelType.Size = new Size(62, 15);
            labelFuelType.TabIndex = 4;
            labelFuelType.Text = "Typ paliwa";
            // 
            // statusStrip1
            // 
            statusStrip1.Location = new Point(0, 322);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(272, 22);
            statusStrip1.TabIndex = 5;
            statusStrip1.Text = "statusStrip1";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(12, 125);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(150, 65);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = "dm^3/litry";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 238);
            label2.Location = new Point(6, 19);
            label2.Name = "label2";
            label2.Size = new Size(94, 37);
            label2.TabIndex = 1;
            label2.Text = "0,00 zł";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label3);
            groupBox2.Location = new Point(12, 197);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(150, 65);
            groupBox2.TabIndex = 7;
            groupBox2.TabStop = false;
            groupBox2.Text = "Należność (zł)";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 238);
            label3.Location = new Point(6, 19);
            label3.Name = "label3";
            label3.Size = new Size(94, 37);
            label3.TabIndex = 2;
            label3.Text = "0,00 zł";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 107);
            label1.Name = "label1";
            label1.Size = new Size(228, 15);
            label1.TabIndex = 8;
            label1.Text = "Liczydło zawsze powinno wskazywać zero!";
            // 
            // groupBoxPrice
            // 
            groupBoxPrice.Controls.Add(labelPrice);
            groupBoxPrice.Location = new Point(184, 173);
            groupBoxPrice.Name = "groupBoxPrice";
            groupBoxPrice.Size = new Size(68, 50);
            groupBoxPrice.TabIndex = 8;
            groupBoxPrice.TabStop = false;
            groupBoxPrice.Text = "Cena/litr";
            // 
            // labelPrice
            // 
            labelPrice.AutoSize = true;
            labelPrice.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 238);
            labelPrice.Location = new Point(6, 19);
            labelPrice.Name = "labelPrice";
            labelPrice.Size = new Size(55, 21);
            labelPrice.TabIndex = 0;
            labelPrice.Text = "0,00 zł";
            // 
            // buttonRefuelling
            // 
            buttonRefuelling.Location = new Point(12, 278);
            buttonRefuelling.Name = "buttonRefuelling";
            buttonRefuelling.Size = new Size(125, 23);
            buttonRefuelling.TabIndex = 9;
            buttonRefuelling.Text = "Tankuj (trzymaj)";
            buttonRefuelling.UseVisualStyleBackColor = true;
            // 
            // FormRefuel
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(272, 344);
            Controls.Add(buttonRefuelling);
            Controls.Add(groupBoxPrice);
            Controls.Add(label1);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(statusStrip1);
            Controls.Add(labelFuelType);
            Controls.Add(labelWelcome);
            Controls.Add(comboBoxFuelType);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "FormRefuel";
            Text = "Tankowanie";
            Load += FormRefuel_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBoxPrice.ResumeLayout(false);
            groupBoxPrice.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBoxFuelType;
        private Label labelWelcome;
        private Label labelFuelType;
        private StatusStrip statusStrip1;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Label label1;
        private Label label2;
        private GroupBox groupBoxPrice;
        private Label labelPrice;
        private Label label3;
        private Button buttonRefuelling;
    }
}