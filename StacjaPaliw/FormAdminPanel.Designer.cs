namespace StacjaPaliwUI
{
    partial class FormAdminPanel
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
            menuStrip1 = new MenuStrip();
            menuStrip2 = new MenuStrip();
            addToolStripMenuItem = new ToolStripMenuItem();
            anOfferToolStripMenuItem = new ToolStripMenuItem();
            aProductToolStripMenuItem = new ToolStripMenuItem();
            anEmployeeToolStripMenuItem = new ToolStripMenuItem();
            aDistributorToolStripMenuItem = new ToolStripMenuItem();
            anUnitToolStripMenuItem = new ToolStripMenuItem();
            loyaltyCardToolStripMenuItem = new ToolStripMenuItem();
            oznaczenieProduktuJakoPaliwoToolStripMenuItem = new ToolStripMenuItem();
            label2 = new Label();
            comboBoxDateRange = new ComboBox();
            radioButtonCurrent = new RadioButton();
            radioButtonPrevious = new RadioButton();
            dateTimePickerFrom = new DateTimePicker();
            panelDatePicker = new Panel();
            dateTimePickerTo = new DateTimePicker();
            label3 = new Label();
            label1 = new Label();
            panelPrevious = new Panel();
            labelIncome = new Label();
            menuStrip2.SuspendLayout();
            panelDatePicker.SuspendLayout();
            panelPrevious.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(32, 32);
            menuStrip1.Location = new Point(0, 40);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1086, 24);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // menuStrip2
            // 
            menuStrip2.ImageScalingSize = new Size(32, 32);
            menuStrip2.Items.AddRange(new ToolStripItem[] { addToolStripMenuItem });
            menuStrip2.Location = new Point(0, 0);
            menuStrip2.Name = "menuStrip2";
            menuStrip2.Size = new Size(1086, 40);
            menuStrip2.TabIndex = 2;
            menuStrip2.Text = "menuStrip2";
            // 
            // addToolStripMenuItem
            // 
            addToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { anOfferToolStripMenuItem, aProductToolStripMenuItem, anEmployeeToolStripMenuItem, aDistributorToolStripMenuItem, anUnitToolStripMenuItem, loyaltyCardToolStripMenuItem, oznaczenieProduktuJakoPaliwoToolStripMenuItem });
            addToolStripMenuItem.Name = "addToolStripMenuItem";
            addToolStripMenuItem.Size = new Size(112, 36);
            addToolStripMenuItem.Text = "Dodaj...";
            // 
            // anOfferToolStripMenuItem
            // 
            anOfferToolStripMenuItem.Name = "anOfferToolStripMenuItem";
            anOfferToolStripMenuItem.Size = new Size(502, 44);
            anOfferToolStripMenuItem.Text = "Ofertę";
            anOfferToolStripMenuItem.Click += anOfferToolStripMenuItem_Click;
            // 
            // aProductToolStripMenuItem
            // 
            aProductToolStripMenuItem.Name = "aProductToolStripMenuItem";
            aProductToolStripMenuItem.Size = new Size(502, 44);
            aProductToolStripMenuItem.Text = "Produkt";
            aProductToolStripMenuItem.Click += aProductToolStripMenuItem_Click;
            // 
            // anEmployeeToolStripMenuItem
            // 
            anEmployeeToolStripMenuItem.Name = "anEmployeeToolStripMenuItem";
            anEmployeeToolStripMenuItem.Size = new Size(502, 44);
            anEmployeeToolStripMenuItem.Text = "Pracownika";
            anEmployeeToolStripMenuItem.Click += anEmployeeToolStripMenuItem_Click;
            // 
            // aDistributorToolStripMenuItem
            // 
            aDistributorToolStripMenuItem.Name = "aDistributorToolStripMenuItem";
            aDistributorToolStripMenuItem.Size = new Size(502, 44);
            aDistributorToolStripMenuItem.Text = "Dystrybutor";
            // 
            // anUnitToolStripMenuItem
            // 
            anUnitToolStripMenuItem.Name = "anUnitToolStripMenuItem";
            anUnitToolStripMenuItem.Size = new Size(502, 44);
            anUnitToolStripMenuItem.Text = "Jednostkę";
            anUnitToolStripMenuItem.Click += anUnitToolStripMenuItem_Click;
            // 
            // loyaltyCardToolStripMenuItem
            // 
            loyaltyCardToolStripMenuItem.Name = "loyaltyCardToolStripMenuItem";
            loyaltyCardToolStripMenuItem.Size = new Size(502, 44);
            loyaltyCardToolStripMenuItem.Text = "Kartę lojalnościową";
            loyaltyCardToolStripMenuItem.Click += loyaltyCardToolStripMenuItem_Click;
            // 
            // oznaczenieProduktuJakoPaliwoToolStripMenuItem
            // 
            oznaczenieProduktuJakoPaliwoToolStripMenuItem.Name = "oznaczenieProduktuJakoPaliwoToolStripMenuItem";
            oznaczenieProduktuJakoPaliwoToolStripMenuItem.Size = new Size(502, 44);
            oznaczenieProduktuJakoPaliwoToolStripMenuItem.Text = "Oznaczenie produktu jako paliwo";
            oznaczenieProduktuJakoPaliwoToolStripMenuItem.Click += oznaczenieProduktuJakoPaliwoToolStripMenuItem_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(12, 64);
            label2.Name = "label2";
            label2.Size = new Size(243, 45);
            label2.TabIndex = 3;
            label2.Text = "Podsumowanie:";
            // 
            // comboBoxDateRange
            // 
            comboBoxDateRange.FormattingEnabled = true;
            comboBoxDateRange.Items.AddRange(new object[] { "dzień", "tydzień", "miesiąc", "rok", "wybrany zakres..." });
            comboBoxDateRange.Location = new Point(308, 124);
            comboBoxDateRange.Name = "comboBoxDateRange";
            comboBoxDateRange.Size = new Size(242, 40);
            comboBoxDateRange.TabIndex = 4;
            comboBoxDateRange.Text = "Wybierz zakres";
            comboBoxDateRange.SelectedIndexChanged += comboBoxDateRange_SelectedIndexChanged;
            // 
            // radioButtonCurrent
            // 
            radioButtonCurrent.AutoSize = true;
            radioButtonCurrent.Checked = true;
            radioButtonCurrent.Location = new Point(3, 3);
            radioButtonCurrent.Name = "radioButtonCurrent";
            radioButtonCurrent.Size = new Size(127, 36);
            radioButtonCurrent.TabIndex = 5;
            radioButtonCurrent.TabStop = true;
            radioButtonCurrent.Text = "Obecny";
            radioButtonCurrent.UseVisualStyleBackColor = true;
            // 
            // radioButtonPrevious
            // 
            radioButtonPrevious.AutoSize = true;
            radioButtonPrevious.Location = new Point(136, 3);
            radioButtonPrevious.Name = "radioButtonPrevious";
            radioButtonPrevious.Size = new Size(151, 36);
            radioButtonPrevious.TabIndex = 6;
            radioButtonPrevious.TabStop = true;
            radioButtonPrevious.Text = "Poprzedni";
            radioButtonPrevious.UseVisualStyleBackColor = true;
            radioButtonPrevious.CheckedChanged += radioButtonPrevious_CheckedChanged;
            // 
            // dateTimePickerFrom
            // 
            dateTimePickerFrom.Location = new Point(71, 8);
            dateTimePickerFrom.Name = "dateTimePickerFrom";
            dateTimePickerFrom.Size = new Size(409, 39);
            dateTimePickerFrom.TabIndex = 7;
            dateTimePickerFrom.ValueChanged += dateTimePickerFrom_ValueChanged;
            // 
            // panelDatePicker
            // 
            panelDatePicker.Controls.Add(dateTimePickerTo);
            panelDatePicker.Controls.Add(label3);
            panelDatePicker.Controls.Add(label1);
            panelDatePicker.Controls.Add(dateTimePickerFrom);
            panelDatePicker.Enabled = false;
            panelDatePicker.Location = new Point(556, 98);
            panelDatePicker.Name = "panelDatePicker";
            panelDatePicker.Size = new Size(496, 101);
            panelDatePicker.TabIndex = 8;
            // 
            // dateTimePickerTo
            // 
            dateTimePickerTo.Location = new Point(71, 53);
            dateTimePickerTo.Name = "dateTimePickerTo";
            dateTimePickerTo.Size = new Size(409, 39);
            dateTimePickerTo.TabIndex = 10;
            dateTimePickerTo.ValueChanged += dateTimePickerTo_ValueChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(15, 53);
            label3.Name = "label3";
            label3.Size = new Size(50, 32);
            label3.TabIndex = 9;
            label3.Text = "Do:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(14, 8);
            label1.Name = "label1";
            label1.Size = new Size(51, 32);
            label1.TabIndex = 8;
            label1.Text = "Od:";
            // 
            // panelPrevious
            // 
            panelPrevious.Controls.Add(radioButtonCurrent);
            panelPrevious.Controls.Add(radioButtonPrevious);
            panelPrevious.Location = new Point(12, 122);
            panelPrevious.Name = "panelPrevious";
            panelPrevious.Size = new Size(290, 45);
            panelPrevious.TabIndex = 9;
            // 
            // labelIncome
            // 
            labelIncome.AutoSize = true;
            labelIncome.Location = new Point(12, 292);
            labelIncome.Name = "labelIncome";
            labelIncome.Size = new Size(192, 32);
            labelIncome.TabIndex = 11;
            labelIncome.Text = "Przychód: 0,00 zł";
            // 
            // FormAdminPanel
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1086, 890);
            Controls.Add(labelIncome);
            Controls.Add(panelPrevious);
            Controls.Add(comboBoxDateRange);
            Controls.Add(panelDatePicker);
            Controls.Add(label2);
            Controls.Add(menuStrip1);
            Controls.Add(menuStrip2);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MainMenuStrip = menuStrip1;
            Name = "FormAdminPanel";
            Text = "Panel administracyjny";
            menuStrip2.ResumeLayout(false);
            menuStrip2.PerformLayout();
            panelDatePicker.ResumeLayout(false);
            panelDatePicker.PerformLayout();
            panelPrevious.ResumeLayout(false);
            panelPrevious.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private MenuStrip menuStrip1;
        private MenuStrip menuStrip2;
        private ToolStripMenuItem addToolStripMenuItem;
        private ToolStripMenuItem anEmployeeToolStripMenuItem;
        private ToolStripMenuItem aProductToolStripMenuItem;
        private ToolStripMenuItem aDistributorToolStripMenuItem;
        private ToolStripMenuItem anOfferToolStripMenuItem;
        private ToolStripMenuItem anUnitToolStripMenuItem;
        private ToolStripMenuItem loyaltyCardToolStripMenuItem;
        private ToolStripMenuItem oznaczenieProduktuJakoPaliwoToolStripMenuItem;
        private Label label2;
        private ComboBox comboBoxDateRange;
        private RadioButton radioButtonCurrent;
        private RadioButton radioButtonPrevious;
        private DateTimePicker dateTimePickerFrom;
        private Panel panelDatePicker;
        private Label label1;
        private DateTimePicker dateTimePickerTo;
        private Label label3;
        private Panel panelPrevious;
        private Label labelIncome;
    }
}