﻿using StacjaPaliwLogic.DataAccess;
using StacjaPaliwLogic.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StacjaPaliwUI
{
    public partial class UCProduct : UserControl
    {
        public Product product 
        { get; set; }
        public Unit unit { get; set; }

        public event EventHandler productChanged;
        public Decimal amount { get; set; }
        public Decimal price { get; set; }
        private TransactionItem? existingTransactionItem;

        IDataAccess<Product> prodDA = new DataAccess<Product>();
        IDataAccess<Unit> unitDA = new DataAccess<Unit>();

        //private string description;
        public UCProduct(TransactionItem? existingItem = null)
        {
            existingTransactionItem = existingItem;
            InitializeComponent();
        }

        private void lockFillControlsProductAlreadyInCheckout(Unit unit)
        {
            labelName.Text = product.name;
            labelPricePerUnit.Text = $"{product.price} zł / {unit.name}";
            numericUpDownAmount.Value = existingTransactionItem.unit_amount;
            numericUpDownAmount.Enabled = false;
            buttonAddToCheckout.Enabled = false;
            buttonAddToCheckout.Text = "W koszyku";
        }
        private void UCProduct_Load(object sender, EventArgs e)
        {
            
            if (existingTransactionItem != null)
            {
                product = prodDA.ReadRow(existingTransactionItem.product_id);

                lockFillControlsProductAlreadyInCheckout(unitDA.ReadRow(product.unit_id));
                return;
            }

            if (product != null)
            {
                // TODO: Relations class for DataAccess to make sure all modifications/deletions are safe
                // and there are no leftovers 
                unit = unitDA.ReadRow(product.unit_id);

                labelName.Text = product.name;
                labelPricePerUnit.Text = $"{product.price} zł / {unit.name}";
            }
        }


        private void numericUpDownAmount_ValueChanged(object sender, EventArgs e)
        {
            amount = numericUpDownAmount.Value;
            price = product.price;
            labelTimesEqualsValue.Text = $"x = {Math.Round(price * amount, 2)} zł";
        }

        private void buttonAddToCheckout_Click(object sender, EventArgs e)
        {
            int transaction_id = StacjaPaliwStatus.transaction.id;
                                                                                  // TODO: the whole LoyaltyCard functionality
                                                                                  // here: discount
            TransactionItem transactionItem = new TransactionItem(product.id, transaction_id, price, amount, 0m);
            StacjaPaliwStatus.transactionItems.Add(transactionItem);

            
            StacjaPaliwStatus.checkoutItems.Add(new CheckoutDisplayItem()
            {
                name = product.name,
                price = Convert.ToString(product.price) + " zł",
                discountPerItem = Convert.ToString(transactionItem.discount) + " zł",
                amount = Convert.ToString(transactionItem.unit_amount) + " " + unit.name,
                value = Convert.ToString(Math.Round(product.price * transactionItem.unit_amount, 2)) + " zł"
            });
        }
    }
}
