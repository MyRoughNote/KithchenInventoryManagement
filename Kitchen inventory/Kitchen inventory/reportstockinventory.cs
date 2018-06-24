using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Kitchen_inventory
{
    public partial class reportstockinventory : Form
    {
        public reportstockinventory()
        {
            InitializeComponent();
        }

        private void reportstockinventory_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'stockinventoryDataSet.stockinventory' table. You can move, or remove it, as needed.
            this.stockinventoryTableAdapter.Fill(this.stockinventoryDataSet.stockinventory);

            this.rpt_stockinventory.RefreshReport();
        }
    }
}
