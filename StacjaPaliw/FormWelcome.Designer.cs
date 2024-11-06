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
            toolStripStatusLabelTokens = new ToolStripStatusLabel();
            helpProvider1 = new HelpProvider();
            timerCurrentDateTime = new System.Windows.Forms.Timer(components);
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // buttonRefuel
            // 
            buttonRefuel.Location = new Point(46, 70);
            buttonRefuel.Name = "buttonRefuel";
            buttonRefuel.Size = new Size(75, 23);
            buttonRefuel.TabIndex = 0;
            buttonRefuel.Text = "Zatankuj";
            buttonRefuel.UseVisualStyleBackColor = true;
            buttonRefuel.Click += buttonRefuel_Click;
            // 
            // buttonShop
            // 
            buttonShop.Location = new Point(176, 70);
            buttonShop.Name = "buttonShop";
            buttonShop.Size = new Size(75, 23);
            buttonShop.TabIndex = 1;
            buttonShop.Text = "Sklep";
            buttonShop.UseVisualStyleBackColor = true;
            // 
            // labelWelcome
            // 
            labelWelcome.AutoSize = true;
            labelWelcome.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 238);
            labelWelcome.Location = new Point(80, 18);
            labelWelcome.Name = "labelWelcome";
            labelWelcome.Size = new Size(142, 30);
            labelWelcome.TabIndex = 2;
            labelWelcome.Text = "Witaj kliencie!";
            // 
            // statusStrip1
            // 
            statusStrip1.Items.AddRange(new ToolStripItem[] { toolStripStatusLabelCurrentDateTime, toolStripStatusLabelTokens });
            statusStrip1.Location = new Point(0, 130);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(296, 22);
            statusStrip1.TabIndex = 3;
            statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabelCurrentDateTime
            // 
            toolStripStatusLabelCurrentDateTime.Name = "toolStripStatusLabelCurrentDateTime";
            toolStripStatusLabelCurrentDateTime.Size = new Size(49, 17);
            toolStripStatusLabelCurrentDateTime.Text = "00:00:00";
            // 
            // toolStripStatusLabelTokens
            // 
            toolStripStatusLabelTokens.Name = "toolStripStatusLabelTokens";
            toolStripStatusLabelTokens.Size = new Size(74, 17);
            toolStripStatusLabelTokens.Text = "Żetony: 2137";
            // 
            // timerCurrentDateTime
            // 
            timerCurrentDateTime.Tick += timerCurrentDateTime_Tick;
            // 
            // FormWelcome
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(296, 152);
            Controls.Add(buttonRefuel);
            Controls.Add(statusStrip1);
            Controls.Add(labelWelcome);
            Controls.Add(buttonShop);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FormWelcome";
            Text = "Ekran powitalny";
            Load += FormWelcome_Load;
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
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
        private ToolStripStatusLabel toolStripStatusLabelTokens;
        private System.Windows.Forms.Timer timerCurrentDateTime;
    }
}
