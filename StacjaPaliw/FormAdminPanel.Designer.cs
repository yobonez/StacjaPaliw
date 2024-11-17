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
            label1 = new Label();
            menuStrip1 = new MenuStrip();
            menuStrip2 = new MenuStrip();
            addToolStripMenuItem = new ToolStripMenuItem();
            anEmployeeToolStripMenuItem = new ToolStripMenuItem();
            aProductToolStripMenuItem = new ToolStripMenuItem();
            aDistributorToolStripMenuItem = new ToolStripMenuItem();
            anOfferToolStripMenuItem = new ToolStripMenuItem();
            anUnitToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem1 = new ToolStripMenuItem();
            menuStrip2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(23, 94);
            label1.Name = "label1";
            label1.Size = new Size(513, 32);
            label1.TabIndex = 0;
            label1.Text = "TODO: Jakieś info co by się przydało adminowi";
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(32, 32);
            menuStrip1.Location = new Point(0, 40);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(712, 24);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // menuStrip2
            // 
            menuStrip2.ImageScalingSize = new Size(32, 32);
            menuStrip2.Items.AddRange(new ToolStripItem[] { addToolStripMenuItem });
            menuStrip2.Location = new Point(0, 0);
            menuStrip2.Name = "menuStrip2";
            menuStrip2.Size = new Size(712, 40);
            menuStrip2.TabIndex = 2;
            menuStrip2.Text = "menuStrip2";
            // 
            // addToolStripMenuItem
            // 
            addToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { anOfferToolStripMenuItem, aProductToolStripMenuItem, anEmployeeToolStripMenuItem, aDistributorToolStripMenuItem, anUnitToolStripMenuItem, toolStripMenuItem1 });
            addToolStripMenuItem.Name = "addToolStripMenuItem";
            addToolStripMenuItem.Size = new Size(112, 38);
            addToolStripMenuItem.Text = "Dodaj...";
            // 
            // anEmployeeToolStripMenuItem
            // 
            anEmployeeToolStripMenuItem.Name = "anEmployeeToolStripMenuItem";
            anEmployeeToolStripMenuItem.Size = new Size(359, 44);
            anEmployeeToolStripMenuItem.Text = "Pracownika";
            anEmployeeToolStripMenuItem.Click += anEmployeeToolStripMenuItem_Click;
            // 
            // aProductToolStripMenuItem
            // 
            aProductToolStripMenuItem.Name = "aProductToolStripMenuItem";
            aProductToolStripMenuItem.Size = new Size(359, 44);
            aProductToolStripMenuItem.Text = "Produkt";
            // 
            // aDistributorToolStripMenuItem
            // 
            aDistributorToolStripMenuItem.Name = "aDistributorToolStripMenuItem";
            aDistributorToolStripMenuItem.Size = new Size(359, 44);
            aDistributorToolStripMenuItem.Text = "Dystrybutor";
            // 
            // anOfferToolStripMenuItem
            // 
            anOfferToolStripMenuItem.Name = "anOfferToolStripMenuItem";
            anOfferToolStripMenuItem.Size = new Size(359, 44);
            anOfferToolStripMenuItem.Text = "Ofertę";
            // 
            // anUnitToolStripMenuItem
            // 
            anUnitToolStripMenuItem.Name = "anUnitToolStripMenuItem";
            anUnitToolStripMenuItem.Size = new Size(359, 44);
            anUnitToolStripMenuItem.Text = "Jednostkę";
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(359, 44);
            // 
            // FormAdminPanel
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(712, 351);
            Controls.Add(label1);
            Controls.Add(menuStrip1);
            Controls.Add(menuStrip2);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MainMenuStrip = menuStrip1;
            Name = "FormAdminPanel";
            Text = "Panel administracyjny";
            menuStrip2.ResumeLayout(false);
            menuStrip2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private MenuStrip menuStrip1;
        private MenuStrip menuStrip2;
        private ToolStripMenuItem addToolStripMenuItem;
        private ToolStripMenuItem anEmployeeToolStripMenuItem;
        private ToolStripMenuItem aProductToolStripMenuItem;
        private ToolStripMenuItem aDistributorToolStripMenuItem;
        private ToolStripMenuItem anOfferToolStripMenuItem;
        private ToolStripMenuItem anUnitToolStripMenuItem;
        private ToolStripMenuItem toolStripMenuItem1;
    }
}