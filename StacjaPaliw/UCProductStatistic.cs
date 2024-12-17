using StacjaPaliwUI.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StacjaPaliwUI
{
    public partial class UCProductStatistic : UserControl
    {
        internal int prodNo = 0;
        public ProductStatistic productStatistic { get; set; }
        public static Decimal total_income { get; set; }
        public static Decimal total_amount_sold { get; set; }
        public static bool byIncomeBySold { get; set; }

        public UCProductStatistic()
        {
            InitializeComponent();
        }

        private Bitmap getImage(string imageData)
        {
            if (imageData != "")
            {
                if (imageData.Length % 2 != 0)
                {
                    throw new ArgumentException(String.Format(CultureInfo.InvariantCulture, "The binary key cannot have an odd number of digits: {0}", imageData));
                }

                byte[] data = new byte[imageData.Length / 2];
                for (int index = 0; index < data.Length; index++)
                {
                    string byteValue = imageData.Substring(index * 2, 2);
                    data[index] = byte.Parse(byteValue, NumberStyles.HexNumber, CultureInfo.InvariantCulture);
                }

                MemoryStream ms = new MemoryStream(data);
                return new Bitmap(ms);
            }
            else
            {
                return new Bitmap(Resources.NoImage);
            }
        }

        private void UCProductStatistic_Load(object sender, EventArgs e)
        {
            labelNo.Text = $"#{prodNo}";
            pictureBoxProductImage.BackgroundImage = getImage(productStatistic.image);
            labelProductName.Text = productStatistic.name;
            labelAmountSold.Text = $"{productStatistic.amount_sold} {productStatistic.unit}";
            labelIncome.Text = $"{productStatistic.income} zł";
            progressBarValue.Value = (byIncomeBySold) ? (int)((productStatistic.income / total_income)*100) : (int)((productStatistic.amount_sold / total_amount_sold) * 100);

        }
    }
}
