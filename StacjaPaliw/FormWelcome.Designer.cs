namespace StacjaPaliw
{
    partial class FormWelcome
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            buttonRefuel = new Button();
            buttonShop = new Button();
            labelWelcome = new Label();
            statusStrip1 = new StatusStrip();
            toolStripStatusLabelCurrentDateTime = new ToolStripStatusLabel();
            helpProvider1 = new HelpProvider();
            timerCurrentDateTime = new System.Windows.Forms.Timer(components);
            menuStrip1 = new MenuStrip();
            optionsToolStripMenuItem = new ToolStripMenuItem();
            adminPanelToolStripMenuItem = new ToolStripMenuItem();
            statusStrip1.SuspendLayout();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // buttonRefuel
            // 
            buttonRefuel.Location = new Point(85, 149);
            buttonRefuel.Margin = new Padding(6);
            buttonRefuel.Name = "buttonRefuel";
            buttonRefuel.Size = new Size(139, 49);
            buttonRefuel.TabIndex = 0;
            buttonRefuel.Text = "Zatankuj";
            buttonRefuel.UseVisualStyleBackColor = true;
            buttonRefuel.Click += buttonRefuel_Click;
            // 
            // buttonShop
            // 
            buttonShop.Location = new Point(327, 149);
            buttonShop.Margin = new Padding(6);
            buttonShop.Name = "buttonShop";
            buttonShop.Size = new Size(139, 49);
            buttonShop.TabIndex = 1;
            buttonShop.Text = "Sklep";
            buttonShop.UseVisualStyleBackColor = true;
            // 
            // labelWelcome
            // 
            labelWelcome.AutoSize = true;
            labelWelcome.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 238);
            labelWelcome.Location = new Point(149, 38);
            labelWelcome.Margin = new Padding(6, 0, 6, 0);
            labelWelcome.Name = "labelWelcome";
            labelWelcome.Size = new Size(281, 57);
            labelWelcome.TabIndex = 2;
            labelWelcome.Text = "Witaj kliencie!";
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new Size(32, 32);
            statusStrip1.Items.AddRange(new ToolStripItem[] { toolStripStatusLabelCurrentDateTime });
            statusStrip1.Location = new Point(0, 282);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Padding = new Padding(2, 0, 26, 0);
            statusStrip1.Size = new Size(550, 42);
            statusStrip1.TabIndex = 3;
            statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabelCurrentDateTime
            // 
            toolStripStatusLabelCurrentDateTime.Name = "toolStripStatusLabelCurrentDateTime";
            toolStripStatusLabelCurrentDateTime.Size = new Size(102, 32);
            toolStripStatusLabelCurrentDateTime.Text = "00:00:00";
            // 
            // timerCurrentDateTime
            // 
            timerCurrentDateTime.Tick += timerCurrentDateTime_Tick;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(32, 32);
            menuStrip1.Items.AddRange(new ToolStripItem[] { optionsToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(550, 42);
            menuStrip1.TabIndex = 4;
            menuStrip1.Text = "menuStrip1";
            // 
            // optionsToolStripMenuItem
            // 
            optionsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { adminPanelToolStripMenuItem });
            optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            optionsToolStripMenuItem.Size = new Size(96, 38);
            optionsToolStripMenuItem.Text = "Opcje";
            // 
            // adminPanelToolStripMenuItem
            // 
            adminPanelToolStripMenuItem.Name = "adminPanelToolStripMenuItem";
            adminPanelToolStripMenuItem.Size = new Size(377, 44);
            adminPanelToolStripMenuItem.Text = "Panel administracyjny";
            adminPanelToolStripMenuItem.Click += adminPanelToolStripMenuItem_Click;
            // 
            // FormWelcome
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(550, 324);
            Controls.Add(buttonRefuel);
            Controls.Add(statusStrip1);
            Controls.Add(menuStrip1);
            Controls.Add(labelWelcome);
            Controls.Add(buttonShop);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MainMenuStrip = menuStrip1;
            Margin = new Padding(6);
            MaximizeBox = false;
            Name = "FormWelcome";
            Text = "Ekran powitalny";
            Load += FormWelcome_Load;
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonRefuel;
        private Button buttonShop;
        private Label labelWelcome;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel toolStripStatusLabelCurrentDateTime;
        private HelpProvider helpProvider1;
        private System.Windows.Forms.Timer timerCurrentDateTime;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem optionsToolStripMenuItem;
        private ToolStripMenuItem adminPanelToolStripMenuItem;
    }
}
