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
    public partial class master : Form
    {
        public master()
        {
            InitializeComponent();
        }

       
        private void btn_stockmaintanence_Click(object sender, EventArgs e)
        {
            stockmaintain stockobj = new stockmaintain();
            stockobj.Visible = true;
        }

       
        private void btn_dish_Click(object sender, EventArgs e)
        {
            Dish dishobj = new Dish();
            dishobj.Show();
        }

        private void btn_loginedit_Click(object sender, EventArgs e)
        {
            Loginmanipulation loginobj = new Loginmanipulation();
            loginobj.Show();
        }

        private void btn_customer_Click(object sender, EventArgs e)
        {
            CustomerDetail customer = new CustomerDetail();
            customer.Show();
        }

        private void btn_reorder_Click(object sender, EventArgs e)
        {
            Reorder_analyser reorder = new Reorder_analyser();
            reorder.Show();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_reports_Click(object sender, EventArgs e)
        {
            Reportmaster rptmaster = new Reportmaster();
            rptmaster.Show();
        }

        private void btn_recipeconfig_Click(object sender, EventArgs e)
        {
            RecipesConfigure recipeobj = new RecipesConfigure();
            recipeobj.Show();
        }

        private void btn_purchase_Click(object sender, EventArgs e)
        {
            Purchase_Order purchaseobj = new Purchase_Order();
            purchaseobj.Show();
        }

        private void btn_orders_Click(object sender, EventArgs e)
        {
            Orderintake orderobj = new Orderintake();
            orderobj.Show();
        }

        private void btn_feedback_Click(object sender, EventArgs e)
        {
            Feedback feedobj = new Feedback();
            feedobj.Show();
        }

       
    }
}
