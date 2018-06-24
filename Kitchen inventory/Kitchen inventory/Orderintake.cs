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

    public partial class Orderintake : Form
    {
        SqlConnection con = new SqlConnection("Data Source=ACER-PC;Initial Catalog=kitcheninventory;Integrated Security=True");
        SqlCommand cmd = new SqlCommand();
        int price;
        public Orderintake()
        {
            InitializeComponent();
        }

        private void Orderintake_Load(object sender, EventArgs e)
        {
            txt_date.Text = DateTime.Now.ToShortDateString();
            con.Open();
            SqlDataAdapter das = new SqlDataAdapter("select max(order_no)+1 from orderintake", con);
            DataTable dt = new DataTable();
            das.Fill(dt);
            con.Close();
            txt_orderno.Text = dt.Rows[0][0].ToString();
            das.Dispose();

            con.Open();
            SqlDataAdapter da = new SqlDataAdapter("select dish_id,dish_name,priceplate from dish", con);
            DataSet dish = new DataSet();
            da.Fill(dish, "dishdetail");
            con.Close();
            grd_dishdetails.DataSource = dish;
            grd_dishdetails.DataMember = "dishdetail";
            grd_dishdetails.Refresh();

        }

        private void grd_dishdetails_SelectionChanged(object sender, EventArgs e)
        {
            if (grd_dishdetails.SelectedCells.Count > 0)
            {
                int selectedrowindex = grd_dishdetails.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = grd_dishdetails.Rows[selectedrowindex];
                txt_dishid.Text = Convert.ToString(selectedRow.Cells["dish_id"].Value);
                txt_dishname.Text = Convert.ToString(selectedRow.Cells["dish_name"].Value);
                txt_price.Text = Convert.ToString(selectedRow.Cells["priceplate"].Value);
                price = Convert.ToInt32(selectedRow.Cells["priceplate"].Value);
            }
        }
        private void btn_clear_Click(object sender, EventArgs e)
        {
            txt_dishid.Text = "";
            txt_dishname.Text = "";
            txt_needqty.Text = "";
            txt_price.Text = "";
            txt_totprice.Text = "";
        }

        private void txt_needqty_Leave(object sender, EventArgs e)
        {
              
                int qty= Convert.ToInt32(txt_needqty.Text);
                int tot = price * qty;
                txt_totprice.Text = tot.ToString();
               
        }

       

        

        private void btn_itemadd_Click(object sender, EventArgs e)
        {
            try
            {
                if ((txt_dishid.Text == "") || (txt_dishname.Text == "") || (txt_needqty.Text == "") || (txt_price.Text == ""))
                {
                    MessageBox.Show("Please Fill all Fields!");
                }
                else
                {
                    con.Open();
                    cmd = new SqlCommand("insert into orderintake values('" + txt_date.Text + "','" + txt_orderno.Text + "','" + txt_dishid.Text + "','" + txt_dishname.Text + "','" + txt_needqty.Text + "','" + txt_totprice.Text + "')", con);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Item Added!");
                }

                //Reduce the items from the stockinventory as per the items needed in recipe config table code

                int noofitem = Convert.ToInt32(txt_needqty.Text);
                con.Open();
                SqlDataAdapter decstock = new SqlDataAdapter("select item_id,needqty from reciepeconfig where dish_id='" + txt_dishid.Text + "'", con);
                DataTable dtdec = new DataTable();
                decstock.Fill(dtdec);
                con.Close();
                for (int i = 0; i <= dtdec.Rows.Count - 1; i++)
                {
                    con.Open();
                    cmd = new SqlCommand("update stockinventory set availqty=availqty-'" + Convert.ToInt32(dtdec.Rows[i][1].ToString()) * (noofitem) + "'where item_id='" + Convert.ToInt32(dtdec.Rows[i][0].ToString()) + "'", con);
                    cmd.ExecuteNonQuery();
                    con.Close();
                }
                con.Open();
                SqlDataAdapter reorderitem = new SqlDataAdapter("select item_id,item_name,availqty from stockinventory where availqty<=thersold", con);
                DataSet redt = new DataSet();
                reorderitem.Fill(redt, "reordercheckitem");
                con.Close();
                grd_reorderitems.DataSource = redt;
                grd_reorderitems.DataMember = "reordercheckitem";
                grd_reorderitems.Refresh();
                //MessageBox.Show("Sorry These Items Don't have Sufficient stock!");
                txt_needqty.Text = "";
                txt_price.Text = "";
                txt_totprice.Text = "";
            }
            catch (Exception)
            {
                MessageBox.Show("Item Already Added");
            }
        }

        private void btn_neworder_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlDataAdapter das = new SqlDataAdapter("select max(order_no)+1 from orderintake", con);
            DataTable dt = new DataTable();
            das.Fill(dt);
            con.Close();
            txt_orderno.Text = dt.Rows[0][0].ToString();
            das.Dispose();
        }

        private void showOrdersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ordershow showorder = new Ordershow();
            showorder.Show();
        }

        

       
    }
}
