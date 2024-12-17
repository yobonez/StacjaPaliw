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
            // TODO: if its offer then add more stuff etc itk lol
            //int windowHeight = 0;

            int locX = 50;
            int locY = 150;

            controls = new List<Control>();
            controls.Add(new Label()
            {
                Text = windowName,
                Font = new Font("Segoe UI", 14),
                Location = new Point(50, 50),
                Size = new Size(500, 75),
                TabIndex = 0
            });

            int tabIndex = 1;
            foreach (var prop in propInfo)
            {
                if (prop.Name == "id") continue;

                if (prop.PropertyType.Name == "DateTime")
                {
                    controls.Add(new Label()
                    {
                        Text = prop.Name,
                        Location = new Point(locX, locY),
                        TabIndex = tabIndex,
                        Size = new Size(200, 50)
                    });
                    controls.Add(new DateTimePicker()
                    {
                        Text = DateTime.Now.ToString(),
                        Location = new Point(locX + 250, locY),
                        TabIndex = tabIndex,
                        Size = new Size(200, 50)
                    });
                    locY += 75;
                    tabIndex++;
                }
                else
                {
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
                        Size = new Size(200, 50),
                        Enabled = (prop.Name != "image")
                    });
                    locY += 75;
                    tabIndex++;
                }
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

        private void anOfferToolStripMenuItem_Click(object sender, EventArgs e)
        {
            windowName = "Dodaj ofertę";

            InitializeDbAddWindow(typeof(Offer), new Offer(), propInfo);
        }

        private void oznaczenieProduktuJakoPaliwoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            windowName = "Oznacz id produktu jako paliwo";

            InitializeDbAddWindow(typeof(FuelProduct), new FuelProduct(), propInfo);
        }

        private void anUnitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            windowName = "Dodaj jednostkę";

            InitializeDbAddWindow(typeof(Unit), new Unit(), propInfo);
        }
        private void kartęLojalnościowaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            windowName = "Dodaj kartę lojalnościową";

            InitializeDbAddWindow(typeof(LoyaltyCard), new LoyaltyCard(), propInfo);
        }
        private void ofertęToolStripMenuItem_Click(object sender, EventArgs e)
        {
            windowName = "Dodaj ofertę";

            InitializeDbAddWindow(typeof(Offer), new Offer(), propInfo);
        }
        private void warToolStripMenuItem_Click(object sender, EventArgs e)
        {
            windowName = "Dodaj warunek oferty";

            InitializeDbAddWindow(typeof(OfferChallenge), new OfferChallenge(), propInfo);
        }
        private void klientaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            windowName = "Dodaj klienta";

            InitializeDbAddWindow(typeof(Client), new Client(), propInfo);
        }

        private void placeTopProducts(List<ProductStatistic> selectedProducts)
        {
            panelProductStats.Controls.Clear();

            if (selectedProducts == null)
            {
                panelProductStats.Controls.Add(new Label()
                {
                    AutoSize = true,
                    Text = "Brak elementów do wyświetlenia.",
                    Location = new Point(10, 10)
                });
                return;
            }

            List<UCProductStatistic> topProducts = new List<UCProductStatistic>();

            int prodCap = 0;
            foreach (ProductStatistic prodStat in selectedProducts)
            {
                if (prodCap == 4) break;
                topProducts.Add(new UCProductStatistic()
                {
                    prodNo = prodCap + 1,
                    productStatistic = prodStat
                });
                prodCap++;
            }

            int x = 0, y = 0;

            int prodNo = 1;
            foreach (UCProductStatistic ps in topProducts)
            {
                panelProductStats.Controls.Add(ps);

                ps.prodNo = prodNo;
                ps.Location = new Point(x, y);
                y += 115;
                prodNo++;
            }
        }

        public void loadStats()
        {
            if (comboBoxDateRange.Text != "wybrany zakres...")
            {
                bool isPreviousRange = radioButtonPrevious.Checked;

                DataCruncher dc = new DataCruncher(comboBoxDateRange.Text, isPreviousRange);

                dateTimePickerTo.Value = dc.to;

                dateTimePickerFrom.Value = dc.from;
                labelIncome.Text = $"Przychód: {dc.salesTotal} zł";

                UCProductStatistic.total_amount_sold = dc.amountSoldTotal;
                UCProductStatistic.total_income = dc.salesTotal;

                if (comboBoxRankingBy.SelectedIndex == 0)
                {
                    dc.SetTopProducts(false);
                    UCProductStatistic.byIncomeBySold = false;
                }
                else
                {
                    dc.SetTopProducts(true);
                    UCProductStatistic.byIncomeBySold = true;
                }
                panelProductStats.Controls.Clear();

                placeTopProducts(dc.selectedProducts);
            }
            else
            {
                DataCruncher dc = new DataCruncher(dateTimePickerFrom.Value, dateTimePickerTo.Value);

                labelIncome.Text = $"Przychód: {dc.salesTotal} zł";

                if (comboBoxRankingBy.SelectedIndex == 0)
                {
                    dc.SetTopProducts(false);
                    UCProductStatistic.byIncomeBySold = false;
                }
                else
                {
                    dc.SetTopProducts(true);
                    UCProductStatistic.byIncomeBySold = true;
                }
                panelProductStats.Controls.Clear();

                placeTopProducts(dc.selectedProducts);
            }

            return;
        }

        private void comboBoxDateRange_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxDateRange.Text == "wybrany zakres...")
            {
                panelDatePicker.Enabled = true;
                panelPrevious.Enabled = false;
            }
            else
            {
                panelDatePicker.Enabled = false;
                panelPrevious.Enabled = true;
            }

            loadStats();
        }

        private void dateTimePickerFrom_ValueChanged(object sender, EventArgs e)
        {
            if (dateTimePickerFrom.Value > dateTimePickerTo.Value)
            {
                MessageBox.Show("Pole \"Od:\" nie może mieć daty większej niż \"Do:\"", "Uwaga", MessageBoxButtons.OK);
                return;
            }
            else if (!panelDatePicker.Enabled)
            {
                return;
            }
            else
            {
                loadStats();
            }
        }

        private void dateTimePickerTo_ValueChanged(object sender, EventArgs e)
        {
            if (panelDatePicker.Enabled && dateTimePickerTo.Value < dateTimePickerFrom.Value)
            {
                MessageBox.Show("Pole \"Do:\" nie może mieć daty mniejszej niż \"Od:\"", "Uwaga", MessageBoxButtons.OK);
                return;
            }
            else if (!panelDatePicker.Enabled)
            {
                return;
            }
            else
            {
                loadStats();
            }
        }

        private void radioButtonPrevious_CheckedChanged(object sender, EventArgs e)
        {
            if (comboBoxDateRange.SelectedIndex != -1)
                loadStats();
        }

        private void FormAdminPanel_Load(object sender, EventArgs e)
        {
            comboBoxRankingBy.SelectedIndex = 0;
        }

        private void comboBoxRankingBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxDateRange.SelectedIndex != -1)
                loadStats();
        }
    }
}
