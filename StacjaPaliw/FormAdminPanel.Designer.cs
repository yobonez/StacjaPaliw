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
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            dateTimePicker1 = new DateTimePicker();
            panelDatePicker = new Panel();
            dateTimePicker2 = new DateTimePicker();
            label3 = new Label();
            label1 = new Label();
            panel2 = new Panel();
            button1 = new Button();
            menuStrip2.SuspendLayout();
            panelDatePicker.SuspendLayout();
            panel2.SuspendLayout();
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
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(3, 3);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(127, 36);
            radioButton1.TabIndex = 5;
            radioButton1.TabStop = true;
            radioButton1.Text = "Obecny";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(136, 3);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(151, 36);
            radioButton2.TabIndex = 6;
            radioButton2.TabStop = true;
            radioButton2.Text = "Poprzedni";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(71, 8);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(409, 39);
            dateTimePicker1.TabIndex = 7;
            // 
            // panelDatePicker
            // 
            panelDatePicker.Controls.Add(dateTimePicker2);
            panelDatePicker.Controls.Add(label3);
            panelDatePicker.Controls.Add(label1);
            panelDatePicker.Controls.Add(dateTimePicker1);
            panelDatePicker.Enabled = false;
            panelDatePicker.Location = new Point(556, 98);
            panelDatePicker.Name = "panelDatePicker";
            panelDatePicker.Size = new Size(496, 101);
            panelDatePicker.TabIndex = 8;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Location = new Point(71, 53);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(409, 39);
            dateTimePicker2.TabIndex = 10;
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
            // panel2
            // 
            panel2.Controls.Add(radioButton1);
            panel2.Controls.Add(radioButton2);
            panel2.Location = new Point(12, 122);
            panel2.Name = "panel2";
            panel2.Size = new Size(290, 45);
            panel2.TabIndex = 9;
            // 
            // button1
            // 
            button1.Location = new Point(886, 221);
            button1.Name = "button1";
            button1.Size = new Size(150, 46);
            button1.TabIndex = 10;
            button1.Text = "fire";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // FormAdminPanel
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1086, 890);
            Controls.Add(button1);
            Controls.Add(panel2);
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
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
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
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private DateTimePicker dateTimePicker1;
        private Panel panelDatePicker;
        private Label label1;
        private DateTimePicker dateTimePicker2;
        private Label label3;
        private Panel panel2;
        private Button button1;
    }
}