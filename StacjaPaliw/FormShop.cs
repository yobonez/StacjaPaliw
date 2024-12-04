using StacjaPaliwLogic.DataAccess;
using StacjaPaliwLogic.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StacjaPaliwUI
{
    public partial class FormShop : Form
    {
        IDataAccess<Product> prodDA = new DataAccess<Product>();
        IDataAccess<Unit> unitDA = new DataAccess<Unit>();
        List<UCProduct> uiProducts = new List<UCProduct>();

        List<CheckoutDisplayItem> checkoutItems = new List<CheckoutDisplayItem>();


        public FormShop()
        {
            InitializeComponent();
        }

        private void placeProducts()
        {
            int x = 10, y = 10;
            foreach (UCProduct product in uiProducts)
            {
                Controls.Add(product);
                product.Location = new Point(x, y);
                x += 325;
            }
        }

        private void loadCheckout()
        {
            //ELEGANCKO
            foreach (TransactionItem transItem in StacjaPaliwStatus.transactionItems)
            {
                Product currentProd = prodDA.ReadRow(transItem.product_id);
                Unit currentUnit = unitDA.ReadRow(currentProd.unit_id);

                checkoutItems.Add(new CheckoutDisplayItem
                {
                    name = currentProd.name,
                    price = Convert.ToString(currentProd.price) + " zł",
                    discountPerItem = Convert.ToString(transItem.discount) + " zł",
                    amount = Convert.ToString(transItem.unit_amount) + " " + currentUnit.name,
                    value = Convert.ToString(Math.Round(currentProd.price * transItem.unit_amount, 2)) + " zł"
                });
            }

            dataGridViewTransactionItems.DataSource = checkoutItems;
        }

        private void FormShop_Load(object sender, EventArgs e)
        {
            //IDataAccess<Product> prodDA = new DataAccess<Product>();
            List<Product> productsToAdd = prodDA.GetAllRows().ToList();

            IDataAccess<FuelProduct> fuelProdDA = new DataAccess<FuelProduct>();
            List<FuelProduct> fuelProducts = fuelProdDA.GetAllRows();

            // remove products that are fuels
            for (int i = 0; i < productsToAdd.Count; i++)
            {
                Product product = productsToAdd[i];
                foreach (FuelProduct fuelProd in fuelProducts)
                {
                    if (product.id == fuelProd.fuel_product_id)
                    {
                        productsToAdd.Remove(product);
                        i--;
                    }
                }
            }

            foreach (TransactionItem transactionItem in StacjaPaliwStatus.transactionItems)
            {
                foreach (FuelProduct fuelProd in fuelProducts)
                {
                    if (transactionItem.product_id == fuelProd.fuel_product_id)
                    {
                        UCProduct uiFuel = new UCProduct(transactionItem);
                        uiProducts.Add(uiFuel);
                    }
                }
            }

            foreach (Product product in productsToAdd)
            {
                UCProduct uiProduct = new UCProduct();
                uiProduct.product = product;

                uiProducts.Add(uiProduct);
            }

            placeProducts();

            loadCheckout();
        }
    }
}
