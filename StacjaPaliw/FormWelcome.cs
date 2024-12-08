using StacjaPaliwLogic.DataAccess;
using StacjaPaliwLogic.Models;
using StacjaPaliwUI;

namespace StacjaPaliw
{
    public partial class FormWelcome : Form
    {
        public FormWelcome()
        {
            InitializeComponent();
        }

        private void FormWelcome_Load(object sender, EventArgs e)
        {
            timerCurrentDateTime.Interval = 1000;
            timerCurrentDateTime.Enabled = true;

            // transaction id needs to be read later
            IDataAccess<Transaction> transTempDataAccess = new DataAccess<Transaction>();
            StacjaPaliwStatus.transaction.id = DataAccess<Transaction>._availableId;
        }

        private void buttonRefuel_Click(object sender, EventArgs e)
        {
            Form refuelForm = new FormRefuel();
            refuelForm.ShowDialog();
        }

        private void buttonVacuum_Click(object sender, EventArgs e)
        {

        }

        private void timerCurrentDateTime_Tick(object sender, EventArgs e)
        {
            toolStripStatusLabelCurrentDateTime.Text = DateTime.Now.ToLongTimeString();

            if (StacjaPaliwStatus.transaction.value > 0)
            {
                toolStripStatusLabelPaymentStatus.Text = "Transakcja oczekuje na realizacjê.";
                toolStripStatusLabelPaymentStatus.ForeColor = Color.Red;
            }
            else
            {
                toolStripStatusLabelPaymentStatus.Text = "Mi³ego dnia!";
                toolStripStatusLabelPaymentStatus.ForeColor = SystemColors.ControlText;
            }
        }

        private void adminPanelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormLogon logonForm = new FormLogon();
            logonForm.Show();
        }

        private void buttonShop_Click(object sender, EventArgs e)
        {
            FormShop shopForm = new FormShop();
            shopForm.Show();
        }
    }
}
