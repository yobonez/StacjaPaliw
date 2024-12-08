using StacjaPaliwLogic.DataAccess;
using StacjaPaliwLogic.Models;
using System.ComponentModel;

namespace StacjaPaliwUI
{
    public partial class FormShop : Form
    {
        IDataAccess<Transaction> transDA = new DataAccess<Transaction>();
        IDataAccess<TransactionItem> transItemDA = new DataAccess<TransactionItem>();
        IDataAccess<Product> prodDA = new DataAccess<Product>();
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

        private void loadCheckout()
        {
            dataGridViewTransactionItems.DataSource = StacjaPaliwStatus.checkoutItems;
            updateCheckoutValues();
        }

        private void updateCheckoutValuesEventHandler(object? sender, ListChangedEventArgs e)
        {
            updateCheckoutValues();
        }
        private void updateCheckoutValues()
        {
            Decimal value = 0;
            Decimal discountsValue = 0;
            
            foreach (TransactionItem item in StacjaPaliwStatus.transactionItems)
            {
                value += item.price_per_unit * item.unit_amount;
                discountsValue += item.discount * item.unit_amount;
            }
            StacjaPaliwStatus.transaction.value = value;
            StacjaPaliwStatus.transaction.discounts_value = discountsValue;

            labelCheckoutValue.Text = $"Wartość {StacjaPaliwStatus.transaction.value} zł";
            labelCheckoutDiscountsValue.Text = $"Zniżki: {StacjaPaliwStatus.transaction.discounts_value} zł";
        }
        private void FormShop_Load(object sender, EventArgs e)
        {
            StacjaPaliwStatus.checkoutItems.ListChanged += updateCheckoutValuesEventHandler;

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

        private void buttonPay_Click(object sender, EventArgs e)
        {
            transDA.AddRow(StacjaPaliwStatus.transaction);

            transItemDA.AddRows(StacjaPaliwStatus.transactionItems);

            transDA.Save();
            transItemDA.Save();

            StacjaPaliwStatus.resetStatus();

            MessageBox.Show("Transakcja przebiegła pomyślnie.", "Transakcja", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
