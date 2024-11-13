using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
        public FormRefuel()
        {
            InitializeComponent();
        }

        private void FormRefuel_Load(object sender, EventArgs e)
        {
            //IDataAccess<Offer> offerDataAccess = new OfferDataAccess();
            //List<Offer> offers = offerDataAccess.Load();
            //offerDataAccess.Add(new Offer());

        }
    }
}
