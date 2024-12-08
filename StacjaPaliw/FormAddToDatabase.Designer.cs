namespace StacjaPaliwUI
{
    partial class FormAddToDatabase
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
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            buttonAdd = new Button();
            buttonCancel = new Button();
            openFileDialogProductBitmap = new OpenFileDialog();
            buttonAddBitmap = new Button();
            pictureBoxProduct = new PictureBox();
            panelImage = new Panel();
            ((System.ComponentModel.ISupportInitialize)pictureBoxProduct).BeginInit();
            panelImage.SuspendLayout();
            SuspendLayout();
            // 
            // buttonAdd
            // 
            buttonAdd.Location = new Point(40, 379);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(150, 46);
            buttonAdd.TabIndex = 0;
            buttonAdd.Text = "Dodaj";
            buttonAdd.UseVisualStyleBackColor = true;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // buttonCancel
            // 
            buttonCancel.Location = new Point(206, 379);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(150, 46);
            buttonCancel.TabIndex = 1;
            buttonCancel.Text = "Anuluj";
            buttonCancel.UseVisualStyleBackColor = true;
            // 
            // buttonAddBitmap
            // 
            buttonAddBitmap.Location = new Point(19, 199);
            buttonAddBitmap.Name = "buttonAddBitmap";
            buttonAddBitmap.Size = new Size(241, 49);
            buttonAddBitmap.TabIndex = 2;
            buttonAddBitmap.Text = "Dodaj obrazek";
            buttonAddBitmap.UseVisualStyleBackColor = true;
            buttonAddBitmap.Click += buttonAddBitmap_Click;
            // 
            // pictureBoxProduct
            // 
            pictureBoxProduct.BackColor = SystemColors.ButtonHighlight;
            pictureBoxProduct.BackgroundImage = Properties.Resources.NoImage;
            pictureBoxProduct.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBoxProduct.InitialImage = Properties.Resources.NoImage;
            pictureBoxProduct.Location = new Point(61, 21);
            pictureBoxProduct.Name = "pictureBoxProduct";
            pictureBoxProduct.Size = new Size(150, 150);
            pictureBoxProduct.TabIndex = 3;
            pictureBoxProduct.TabStop = false;
            // 
            // panelImage
            // 
            panelImage.Controls.Add(pictureBoxProduct);
            panelImage.Controls.Add(buttonAddBitmap);
            panelImage.Location = new Point(509, 171);
            panelImage.Name = "panelImage";
            panelImage.Size = new Size(279, 267);
            panelImage.TabIndex = 4;
            panelImage.Visible = false;
            // 
            // FormAddToDatabase
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1163, 591);
            Controls.Add(panelImage);
            Controls.Add(buttonCancel);
            Controls.Add(buttonAdd);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "FormAddToDatabase";
            Text = "Dodaj [coś]";
            ((System.ComponentModel.ISupportInitialize)pictureBoxProduct).EndInit();
            panelImage.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Button buttonAdd;
        private Button buttonCancel;
        private OpenFileDialog openFileDialogProductBitmap;
        private Button buttonAddBitmap;
        private PictureBox pictureBoxProduct;
        private Panel panelImage;
    }
}