using StacjaPaliwLogic.DataAccess;
using StacjaPaliwUI.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StacjaPaliwUI
{
    public partial class FormAddToDatabase : Form
    {
        List<Control> controls;
        int windowHeight;

        object model;

        public void ReceiveFormElements(List<Control> _controls, object _model)
        {
            model = _model;
            Type modelType = _model.GetType();

            controls = _controls;
            foreach (Control control in controls)
            {
                if (control.Text == "image") panelImage.Visible = true;

                Controls.Add(control);
                windowHeight += 50;
            }
            windowHeight += 200;
            Size = new Size(800, windowHeight);
            buttonAdd.Location = new Point(50, windowHeight - 150);
            buttonCancel.Location = new Point(250, windowHeight - 150);
        }
        public FormAddToDatabase()
        {
            InitializeComponent();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            Type modelType = model.GetType();
            PropertyInfo[] modelPropInfo = modelType.GetProperties();
            List<string> textBoxValues = new List<string>();

            IDataAccess<object> dataAccess = new DataAccess<object>(modelType);


            for (int i = 2; i < controls.Count; i += 2)
            {
                //string propLabelText = controls[i - 1].Text;
                string propTextBoxText = controls[i].Text;
                controls[i].Text = "";

                textBoxValues.Add(propTextBoxText);
            }

            modelPropInfo[0].SetValue(model, 0); // default id for every instance of some object
                                                 // the dataaccess sets the id anyway 
                                                 // i = 1 because skip id
            for (int i = 1; i < textBoxValues.Count + 1; i++)
            {
                PropertyInfo modelProperty = modelPropInfo[i];
                Type propertyType = modelProperty.PropertyType;

                object convertedValue = Convert.ChangeType(textBoxValues[i - 1], propertyType);
                modelProperty.SetValue(model, convertedValue);


            }
            dataAccess.AddRow(model);
            dataAccess.Save();

            pictureBoxProduct.BackgroundImage = Resources.NoImage;
            MessageBox.Show("Pomyślnie dodano.", "Sukces", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonAddBitmap_Click(object sender, EventArgs e)
        {
            if (openFileDialogProductBitmap.ShowDialog() == DialogResult.OK)
            {
                Bitmap bmp = new Bitmap(openFileDialogProductBitmap.FileName);
                ImageConverter converter = new ImageConverter();
                byte[] bytes = (byte[])converter.ConvertTo(bmp, typeof(byte[]));

                StringBuilder stringBuilder = new StringBuilder();

                stringBuilder.Append(BitConverter.ToString(bytes).Replace("-", String.Empty));


                for (int i = 0; i < controls.Count; i++) {
                    if (controls[i].Text == "image")
                    {
                        controls[i + 1].Text = stringBuilder.ToString();
                        break;
                    }
                }

                pictureBoxProduct.BackgroundImage = bmp;
            }
        }
    }
}
