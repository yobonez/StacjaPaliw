﻿namespace StacjaPaliwUI
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
            components = new System.ComponentModel.Container();
            comboBoxFuelType = new ComboBox();
            productBindingSource = new BindingSource(components);
            labelWelcome = new Label();
            labelFuelType = new Label();
            statusStrip1 = new StatusStrip();
            groupBox1 = new GroupBox();
            labelLiters = new Label();
            groupBox2 = new GroupBox();
            labelValue = new Label();
            label1 = new Label();
            groupBoxPrice = new GroupBox();
            labelPrice = new Label();
            buttonRefuelling = new Button();
            bindingSourceRefuel = new BindingSource(components);
            timerFuelTick = new System.Windows.Forms.Timer(components);
            buttonPutBackPistol = new Button();
            buttonClose = new Button();
            ((System.ComponentModel.ISupportInitialize)productBindingSource).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBoxPrice.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)bindingSourceRefuel).BeginInit();
            SuspendLayout();
            // 
            // comboBoxFuelType
            // 
            comboBoxFuelType.DataBindings.Add(new Binding("Text", productBindingSource, "name", true, DataSourceUpdateMode.Never));
            comboBoxFuelType.FormattingEnabled = true;
            comboBoxFuelType.Location = new Point(149, 145);
            comboBoxFuelType.Margin = new Padding(6);
            comboBoxFuelType.Name = "comboBoxFuelType";
            comboBoxFuelType.Size = new Size(221, 40);
            comboBoxFuelType.TabIndex = 0;
            comboBoxFuelType.SelectedIndexChanged += comboBoxFuelType_SelectedIndexChanged;
            // 
            // productBindingSource
            // 
            productBindingSource.DataSource = typeof(StacjaPaliwLogic.Models.Product);
            // 
            // labelWelcome
            // 
            labelWelcome.AutoSize = true;
            labelWelcome.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 238);
            labelWelcome.Location = new Point(113, 19);
            labelWelcome.Margin = new Padding(6, 0, 6, 0);
            labelWelcome.Name = "labelWelcome";
            labelWelcome.Size = new Size(240, 57);
            labelWelcome.TabIndex = 3;
            labelWelcome.Text = "Tankowanie";
            // 
            // labelFuelType
            // 
            labelFuelType.AutoSize = true;
            labelFuelType.Location = new Point(22, 151);
            labelFuelType.Margin = new Padding(6, 0, 6, 0);
            labelFuelType.Name = "labelFuelType";
            labelFuelType.Size = new Size(126, 32);
            labelFuelType.TabIndex = 4;
            labelFuelType.Text = "Typ paliwa";
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new Size(32, 32);
            statusStrip1.Location = new Point(0, 732);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Padding = new Padding(2, 0, 26, 0);
            statusStrip1.Size = new Size(505, 22);
            statusStrip1.TabIndex = 5;
            statusStrip1.Text = "statusStrip1";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(labelLiters);
            groupBox1.Location = new Point(22, 267);
            groupBox1.Margin = new Padding(6);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(6);
            groupBox1.Size = new Size(279, 139);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = "dm^3/litry";
            // 
            // labelLiters
            // 
            labelLiters.AutoSize = true;
            labelLiters.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 238);
            labelLiters.Location = new Point(11, 41);
            labelLiters.Margin = new Padding(6, 0, 6, 0);
            labelLiters.Name = "labelLiters";
            labelLiters.Size = new Size(157, 72);
            labelLiters.TabIndex = 1;
            labelLiters.Text = "0,00 l";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(labelValue);
            groupBox2.Location = new Point(22, 420);
            groupBox2.Margin = new Padding(6);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(6);
            groupBox2.Size = new Size(279, 139);
            groupBox2.TabIndex = 7;
            groupBox2.TabStop = false;
            groupBox2.Text = "Należność (zł)";
            // 
            // labelValue
            // 
            labelValue.AutoSize = true;
            labelValue.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 238);
            labelValue.Location = new Point(11, 41);
            labelValue.Margin = new Padding(6, 0, 6, 0);
            labelValue.Name = "labelValue";
            labelValue.Size = new Size(183, 72);
            labelValue.TabIndex = 2;
            labelValue.Text = "0,00 zł";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(22, 228);
            label1.Margin = new Padding(6, 0, 6, 0);
            label1.Name = "label1";
            label1.Size = new Size(462, 32);
            label1.TabIndex = 8;
            label1.Text = "Liczydło zawsze powinno wskazywać zero!";
            // 
            // groupBoxPrice
            // 
            groupBoxPrice.Controls.Add(labelPrice);
            groupBoxPrice.Location = new Point(342, 369);
            groupBoxPrice.Margin = new Padding(6);
            groupBoxPrice.Name = "groupBoxPrice";
            groupBoxPrice.Padding = new Padding(6);
            groupBoxPrice.Size = new Size(126, 107);
            groupBoxPrice.TabIndex = 8;
            groupBoxPrice.TabStop = false;
            groupBoxPrice.Text = "Cena/litr";
            // 
            // labelPrice
            // 
            labelPrice.AutoSize = true;
            labelPrice.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 238);
            labelPrice.Location = new Point(11, 41);
            labelPrice.Margin = new Padding(6, 0, 6, 0);
            labelPrice.Name = "labelPrice";
            labelPrice.Size = new Size(110, 45);
            labelPrice.TabIndex = 0;
            labelPrice.Text = "0,00 zł";
            // 
            // buttonRefuelling
            // 
            buttonRefuelling.Location = new Point(22, 593);
            buttonRefuelling.Margin = new Padding(6);
            buttonRefuelling.Name = "buttonRefuelling";
            buttonRefuelling.Size = new Size(222, 49);
            buttonRefuelling.TabIndex = 9;
            buttonRefuelling.Text = "Podnieś pistolet";
            buttonRefuelling.UseVisualStyleBackColor = true;
            buttonRefuelling.Click += buttonRefuelling_Click;
            buttonRefuelling.MouseDown += buttonRefuelling_MouseDown;
            buttonRefuelling.MouseUp += buttonRefuelling_MouseUp;
            // 
            // buttonPutBackPistol
            // 
            buttonPutBackPistol.Location = new Point(264, 593);
            buttonPutBackPistol.Margin = new Padding(6);
            buttonPutBackPistol.Name = "buttonPutBackPistol";
            buttonPutBackPistol.Size = new Size(220, 49);
            buttonPutBackPistol.TabIndex = 10;
            buttonPutBackPistol.Text = "Odłóż pistolet";
            buttonPutBackPistol.UseVisualStyleBackColor = true;
            buttonPutBackPistol.Click += buttonPutBackPistol_Click;
            // 
            // buttonClose
            // 
            buttonClose.Location = new Point(22, 666);
            buttonClose.Name = "buttonClose";
            buttonClose.Size = new Size(462, 46);
            buttonClose.TabIndex = 11;
            buttonClose.Text = "Zamknij";
            buttonClose.UseVisualStyleBackColor = true;
            buttonClose.Click += buttonClose_Click;
            // 
            // FormRefuel
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(505, 754);
            Controls.Add(buttonClose);
            Controls.Add(buttonPutBackPistol);
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
            Margin = new Padding(6);
            Name = "FormRefuel";
            Text = "Tankowanie";
            Load += FormRefuel_Load;
            ((System.ComponentModel.ISupportInitialize)productBindingSource).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBoxPrice.ResumeLayout(false);
            groupBoxPrice.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)bindingSourceRefuel).EndInit();
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
        private Label labelLiters;
        private GroupBox groupBoxPrice;
        private Label labelPrice;
        private Label labelValue;
        private Button buttonRefuelling;
        private BindingSource bindingSourceRefuel;
        private BindingSource productBindingSource;
        private System.Windows.Forms.Timer timerFuelTick;
        private Button buttonPutBackPistol;
        private Button buttonClose;
    }
}