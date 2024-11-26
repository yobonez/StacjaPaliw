using StacjaPaliwLogic.DataAccess;
using StacjaPaliwLogic.Models;
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

namespace StacjaPaliwUI
{
    public partial class FormShop : Form
    {
        List<UCProduct> uiProducts = new List<UCProduct>();

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

        private void addProductToCheckout()
        {

        }

        private void FormShop_Load(object sender, EventArgs e)
        {
            IDataAccess<Product> prodDA = new DataAccess<Product>();
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

            //var transactionDetails = StacjaPaliwStatus.transactionItems.Join(
            //    prodDA.GetAllRows(),
            //    trans => trans.product_id,
            //    prod => prod.id,
            //    (trans, prod) => new
            //    {
            //        prod.name,
            //        trans.price_per_unit,
            //        trans.unit_amount,
            //        value = Math.Round(trans.price_per_unit * trans.unit_amount, 2)
            //    }).ToList();

            // ^^^ komplikowanie, zrób se normalnie stałe pola w databinding jakiś albo coś i essa
            //dataGridViewTransactionItems.DataSource = transactionDetails;

        }
    }
}
