using StacjaPaliwLogic.Models;
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
    public partial class FormAdminPanel : Form
    {
        PropertyInfo[] propInfo;
        List<Label> labels;
        List<TextBox> textBoxes;

        public FormAdminPanel()
        {
            InitializeComponent();
        }

        private void populateProperties(object? sender, EventArgs e)
        {
            foreach (var prop in propInfo) 
            { 
            
            }
        }

        private void anEmployeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAddToDatabase addToDatabase = new FormAddToDatabase();
            propInfo = typeof(Employee).GetProperties();
            addToDatabase.ShowDialog();
        }
    }
}
