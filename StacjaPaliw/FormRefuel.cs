using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using StacjaPaliwLogic.DataAccess;
using StacjaPaliwLogic.Models;

namespace StacjaPaliwUI
{
    public partial class FormRefuel : Form
    {
        Decimal fuelAmount = Decimal.Zero;
        Decimal fuelValue = Decimal.Zero;
        Product selectedFuel = new Product();

        bool fuelLock = false;

        public FormRefuel()
        {
            InitializeComponent();
        }

        private void FormRefuel_Load(object sender, EventArgs e)
        {
            IDataAccess<FuelProduct> fuelProdDA = new DataAccess<FuelProduct>();
            IDataAccess<Product> prodDA = new DataAccess<Product>();

            comboBoxFuelType.DisplayMember = "name";
            comboBoxFuelType.ValueMember = "id";
            foreach (FuelProduct fuelprod in fuelProdDA.GetAllRows())
            {
                Product fuelToAdd = prodDA.ReadRow(fuelprod.id);
                comboBoxFuelType.Items.Add(fuelToAdd);
            }

            timerFuelTick.Tick += fuelEventHandler;
        }

        private void doFuel(Decimal byWhatAmount)
        {
            if (ActiveForm == this && fuelLock)
            {
                fuelAmount += byWhatAmount;
                labelLiters.Text = fuelAmount.ToString() + " zł";

                fuelValue = Math.Round(fuelAmount * selectedFuel.price, 2);
                labelValue.Text = fuelValue.ToString() + " zł";
            }
        }
        private void fuelEventHandler(object? sender, EventArgs e)
        { doFuel(0.17m); }

        //private void clearDistributorDisplay() 
        //{
        //    comboBoxFuelType.SelectedIndex = -1;
        //    labelLiters.Text = "0,00 zł";
        //    labelPrice.Text = "0,00 zł";
        //    labelValue.Text = "0,00 zł";
        //}
        private void lockOrUnlockFuelControls()
        {
            Thread.Sleep(200);
            if (fuelLock)
            {
                comboBoxFuelType.Enabled = false;
            }
            else
            {
                //comboBoxFuelType.Enabled = true; - only after payment
                buttonRefuelling.Text = "Podnieś pistolet";
                buttonRefuelling.Enabled = false;
                buttonPutBackPistol.Enabled = false;
                //clearDistributorDisplay(); - only after payment
            }
        }
        private void buttonRefuelling_Click(object sender, EventArgs e)
        {
            //doFuel(0.03m); 

            if (comboBoxFuelType.SelectedIndex == -1)
            {
                MessageBox.Show("Wybierz rodzaj paliwa.",
                                "Hola hola",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return;
            }

            if (fuelLock)
                return;

            fuelLock = true;
            lockOrUnlockFuelControls();
            buttonRefuelling.Text = "Tankuj (trzymaj)";
        }
        private void comboBoxFuelType_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedFuel = (Product)comboBoxFuelType.Items[comboBoxFuelType.SelectedIndex];
            labelPrice.Text = selectedFuel.price.ToString() + " zł";
        }
        private async void buttonRefuelling_MouseDown(object sender, MouseEventArgs e)
        {
            timerFuelTick.Interval = 240;
            timerFuelTick.Enabled = true;
        }

        private void buttonRefuelling_MouseUp(object sender, MouseEventArgs e)
        {
            timerFuelTick.Enabled = false;
        }

        private void buttonPutBackPistol_Click(object sender, EventArgs e)
        {
            fuelLock = false;
            lockOrUnlockFuelControls();

            // TODO: STACJA STATUS - hold the checkout here and all its products
            // add this fuel stuff to checkout
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Hide();
        }
    }
}
