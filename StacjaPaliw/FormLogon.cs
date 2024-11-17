using StacjaPaliwLogic.DataAccess;
using StacjaPaliwLogic.Models;
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
    public partial class FormLogon : Form
    {
        public FormLogon()
        {
            //TODO: session mechanism
            InitializeComponent();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            bool success = false;

            IDataAccess<Employee> employeeDA = new DataAccess<Employee>();
            List<Employee> employees = employeeDA.GetAllRows();
            foreach (Employee employee in employees)
            {
                if(employee.nickname == textBoxLogin.Text &&
                   employee.password == textBoxPassword.Text)
                {
                    success = true;

                    FormAdminPanel adminPanel = new FormAdminPanel();
                    adminPanel.Activated += AdminPanel_Activated;
                    adminPanel.FormClosed += AdminPanel_FormClosed;
                    adminPanel.ShowDialog();
                }
            }
            if (!success)
            {
                MessageBox.Show("Wprowadzony login bądź hasło jest nieprawidłowe."
                              , "Błąd"
                              , MessageBoxButtons.OK
                              , MessageBoxIcon.Warning);
            }
        }

        private void AdminPanel_FormClosed(object? sender, FormClosedEventArgs e)
        {
            Close();
        }

        private void AdminPanel_Activated(object? sender, EventArgs e)
        {
            Hide();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
