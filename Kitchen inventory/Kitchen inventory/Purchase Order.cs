using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Kitchen_inventory
{
    public partial class Purchase_Order : Form
    {
        SqlConnection con = new SqlConnection("Data Source=ACER-PC;Initial Catalog=kitcheninventory;Integrated Security=True");
        SqlCommand cmd = new SqlCommand();
        public Purchase_Order()
        {
            InitializeComponent();
        }

        private void btn_purchasedetails_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter("select item_id,item_name,availqty from stockinventory where availqty<=thersold", con);
            DataSet purchaseds = new DataSet();
            da.Fill(purchaseds, "purchase order");
            con.Close();
            grd_purchaseorder.DataSource = purchaseds;
            grd_purchaseorder.DataMember = "purchase order";
            grd_purchaseorder.Refresh();
            
        }

        private void Purchase_Order_Load(object sender, EventArgs e)
        {
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter("select item_id,item_name,availqty from stockinventory where availqty<=thersold", con);
            DataSet purchaseds = new DataSet();
            da.Fill(purchaseds, "purchase order");
            con.Close();
            grd_purchaseorder.DataSource = purchaseds;
            grd_purchaseorder.DataMember = "purchase order";
            grd_purchaseorder.Refresh();
        }

       
        
    }
}
