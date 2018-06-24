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
    public partial class stockmaintain : Form
    {
        SqlConnection con = new SqlConnection("Data Source=ACER-PC;Initial Catalog=kitcheninventory;Integrated Security=True");
        SqlCommand cmd = new SqlCommand();
        SqlDataAdapter da = new SqlDataAdapter();
        DataTable dt = new DataTable();
        DataSet ds = new DataSet();
        public stockmaintain()
        {
            InitializeComponent();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            try
            {
                if ((txt_stockdate.Text == "") || (txt_itemid.Text == "") || (txt_itemname.Text == "") || (txt_qty.Text == "") || (txt_limit.Text == ""))
                {
                    MessageBox.Show("Please fill all the fields!");
                }
                else
                {
                    con.Open();
                    SqlDataAdapter chkitem = new SqlDataAdapter("select item_name from stockinventory where item_name='" + txt_itemname.Text + "'", con);
                    DataTable chk = new DataTable();
                    chkitem.Fill(chk);
                    con.Close();
                    if (chk.Rows.Count != 0)
                    {
                        MessageBox.Show("Item Already Available");
                    }
                    else
                    {
                        con.Open();
                        cmd = new SqlCommand("insert into stockinventory values('" + txt_stockdate.Text + "','" + txt_itemname.Text + "','" + txt_qty.Text + "','" + txt_limit.Text + "')", con);
                        cmd.ExecuteNonQuery();
                        con.Close();
                        MessageBox.Show("your information Stored!");
                        stockmaintainrefresh();
                        txt_itemid.Text = "";
                        txt_itemname.Text = "";
                        txt_limit.Text = "";
                        txt_qty.Text = "";
                    }
                }
            }
            catch (Exception)
            {
               
            }
            finally
            {
                con.Close();
            }

        }

        private void stockmaintain_Load(object sender, EventArgs e)
        {
            txt_stockdate.Text = DateTime.Now.ToShortDateString();
            con.Open();
            da = new SqlDataAdapter("select max(item_id)+1 from stockinventory", con);
            dt = new DataTable();
            da.Fill(dt);
            con.Close();
            txt_itemid.Text = dt.Rows[0][0].ToString();
            da.Dispose();
           
            con.Open();
            da = new SqlDataAdapter("select * from stockinventory", con);
            ds = new DataSet();
            da.Fill(ds,"stockdetail");
            con.Close();
            grd_stockdetails.DataSource = ds;
            grd_stockdetails.DataMember = "stockdetail";
            grd_stockdetails.Refresh();
                    
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            txt_itemname.Text = "";
            txt_limit.Text = "";
            txt_qty.Text = "";
            txt_search.Text = "";
        }

       

        private void stockManipulationUpdateDeleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            stock_manipulation stockmanip = new stock_manipulation();
            stockmanip.Show();
        }

      
        private void stockmaintainrefresh()
        {

            SqlDataAdapter da = new SqlDataAdapter("select * from stockinventory", con);
            DataSet ds = new DataSet();
            da.Fill(ds, "stockdetail");
            grd_stockdetails.DataSource = ds;
            grd_stockdetails.DataMember = "stockdetail";
            grd_stockdetails.Refresh();
        }

        private void btn_newitem_Click(object sender, EventArgs e)
        {
            con.Open();
            da = new SqlDataAdapter("select max(item_id)+1 from stockinventory", con);
            dt = new DataTable();
            da.Fill(dt);
            con.Close();
            txt_itemid.Text = dt.Rows[0][0].ToString();
            da.Dispose();
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_search.Text == "")
                {
                    MessageBox.Show("Please fill search Box!");
                }
                else
                {

                    DataTable newdt = new DataTable();
                    con.Close();
                    con.Open();
                    da = new SqlDataAdapter("select dates,item_id,item_name,availqty,thersold from stockinventory where item_id='" + txt_search.Text + "'", con);
                    da.Fill(newdt);
                    da.Dispose();
                    con.Close();
                    if (newdt.Rows.Count != 0)
                    {
                        //txt_itemname.Text = dt.Rows[0][0].ToString();
                        //txt_qty.Text = dt.Rows[0][1].ToString();
                        //txt_limit.Text = dt.Rows[0][2].ToString();
                        grd_stockdetails.DataSource = newdt;
                        grd_stockdetails.Refresh();
                        txt_search.Text = "";
                    }
                    else
                    {
                        MessageBox.Show("Sorry Your Data is not Found!");
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Please Enter Number Only!");
                txt_search.Text = "";
            }
        }

        private void btn_showall_Click(object sender, EventArgs e)
        {
            con.Open();
            da = new SqlDataAdapter("select * from stockinventory", con);
            ds = new DataSet();
            da.Fill(ds, "stockdetail");
            con.Close();
            grd_stockdetails.DataSource = ds;
            grd_stockdetails.DataMember = "stockdetail";
            grd_stockdetails.Refresh();
        }

        private void itemsToBePurchasedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Purchase_Order itemsobj = new Purchase_Order();
            itemsobj.Show();
        }
               
    }
}
