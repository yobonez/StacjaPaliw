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
        string windowName;

        PropertyInfo[] propInfo;
        object model;

        List<Control> controls;
        FormAddToDatabase addToDatabase;

        bool formPopulated = false;

        public FormAdminPanel()
        {
            InitializeComponent();
        }

        private void populateFormElements(object? sender, EventArgs e)
        {
            if (formPopulated) { return; }
            //int windowHeight = 0;

            int locX = 50;
            int locY = 150;

            controls = new List<Control>();
            controls.Add(new Label()
            {
                Text = windowName,
                Font = new Font("Segoe UI", 16),
                Location = new Point(50, 50),
                Size = new Size(500, 75),
                TabIndex = 0
            });

            int tabIndex = 1;
            foreach (var prop in propInfo)
            {
                if (prop.Name == "id") continue;
                controls.Add(new Label()
                {
                    Text = prop.Name,
                    Location = new Point(locX, locY),
                    TabIndex = tabIndex,
                    Size = new Size(200, 50)
                });
                controls.Add(new TextBox()
                {
                    Location = new Point(locX + 250, locY),
                    TabIndex = tabIndex,
                    Size = new Size(200, 50)
                });
                locY += 75;
                tabIndex++;
            }
            formPopulated = true;
            addToDatabase.ReceiveFormElements(controls, model);
        }

        public void enablePopulating(object? sender, EventArgs e)
        {
            formPopulated = false;
        }

        private void InitializeDbAddWindow(Type _type, object _model, PropertyInfo[] propertyInfo)
        {
            model = _model;
            addToDatabase = new FormAddToDatabase();

            propInfo = _type.GetProperties();
            addToDatabase.Activated += populateFormElements;
            addToDatabase.FormClosed += enablePopulating;

            addToDatabase.ShowDialog();
        }

        private void anEmployeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            windowName = "Dodaj pracownika";

            InitializeDbAddWindow(typeof(Employee), new Employee(), propInfo);
        }

        private void aProductToolStripMenuItem_Click(object sender, EventArgs e)
        {
            windowName = "Dodaj produkt";

            InitializeDbAddWindow(typeof(Product), new Product(), propInfo);
        }

        private void loyaltyCardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            windowName = "Dodaj kartę lojalnościową";

            InitializeDbAddWindow(typeof(LoyaltyCard), new LoyaltyCard(), propInfo);
        }
    }
}
