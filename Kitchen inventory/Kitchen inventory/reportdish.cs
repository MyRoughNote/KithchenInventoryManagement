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
    public partial class reportdish : Form
    {
        public reportdish()
        {
            InitializeComponent();
        }

        private void reportdish_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dishDataSet.dish' table. You can move, or remove it, as needed.
            this.dishTableAdapter.Fill(this.dishDataSet.dish);

            this.reportViewer1.RefreshReport();
        }
    }
}
