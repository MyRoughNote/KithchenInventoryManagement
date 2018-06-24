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
    public partial class Reportmaster : Form
    {
        public Reportmaster()
        {
            InitializeComponent();
        }

        private void btn_stockreport_Click(object sender, EventArgs e)
        {
            reportstockinventory stockrptobj = new reportstockinventory();
            stockrptobj.Show();
        }

        private void btn_dishreport_Click(object sender, EventArgs e)
        {
            reportdish rptdishobj = new reportdish();
            rptdishobj.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            reportcustomer rptcustomerobj = new reportcustomer();
            rptcustomerobj.Show();
        }

        private void btn_purchasereport_Click(object sender, EventArgs e)
        {
            reportPurchase rptpurchase = new reportPurchase();
            rptpurchase.Show();
        }

        private void btn_recipesconfigreport_Click(object sender, EventArgs e)
        {
            reportRecipeconfig rptrecipeconfig = new reportRecipeconfig();
            rptrecipeconfig.Show();
        }
    }
}
