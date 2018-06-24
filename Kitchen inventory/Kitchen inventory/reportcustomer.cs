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
    public partial class reportcustomer : Form
    {
        public reportcustomer()
        {
            InitializeComponent();
        }

        private void reportcustomer_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'customerDataSet.customer' table. You can move, or remove it, as needed.
            this.customerTableAdapter.Fill(this.customerDataSet.customer);

            this.reportViewer1.RefreshReport();
        }
    }
}
