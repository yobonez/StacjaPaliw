﻿using StacjaPaliwLogic.DataAccess;
using StacjaPaliwLogic.Models;
using System.Text.RegularExpressions;

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

            Regex usernameRegex = new Regex("^[a-z]{3,}$");
            if (!usernameRegex.IsMatch(textBoxLogin.Text))
            {
                MessageBox.Show("Nazwa użytkownika musi używać tylko i wyłącznie małych liter oraz mieć długość conajmniej 3 znaków.", "Uwaga", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            foreach (Employee employee in employees)
            {
                // to by można wcisnąć do jakiejś oddzielnej klasy itp
                // że jakiś Validator czy coś, ale to już końcówa projektu
                // komu by się chciało

                if (employee.nickname == textBoxLogin.Text &&
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
