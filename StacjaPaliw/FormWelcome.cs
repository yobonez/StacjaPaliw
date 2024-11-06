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
        }
    }
}
