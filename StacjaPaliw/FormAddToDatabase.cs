using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StacjaPaliwUI
{
    public partial class FormAddToDatabase : Form
    {
        List<Control> controls;
        int windowHeight;

        public void ReceiveFormElements(List<Control> _controls)
        {
            controls = _controls;
            foreach(Control control in controls)
            {
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
    }
}
