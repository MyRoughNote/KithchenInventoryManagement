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
    public partial class reportRecipeconfig : Form
    {
        public reportRecipeconfig()
        {
            InitializeComponent();
        }

        private void reportRecipeconfig_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'recipeconfigDataSet.reciepeconfig' table. You can move, or remove it, as needed.
            this.reciepeconfigTableAdapter.Fill(this.recipeconfigDataSet.reciepeconfig);

            this.reportViewer1.RefreshReport();
        }
    }
}
