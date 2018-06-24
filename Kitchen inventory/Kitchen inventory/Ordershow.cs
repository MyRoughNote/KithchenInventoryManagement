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
    public partial class Ordershow : Form
    {
        SqlConnection con = new SqlConnection("Data Source=ACER-PC;Initial Catalog=kitcheninventory;Integrated Security=True");
        DataSet ordershow = new DataSet();
        SqlDataAdapter ordershowadapter = new SqlDataAdapter();
        SqlCommand cmd = new SqlCommand();
        int price;
        public Ordershow()
        {
            InitializeComponent();
        }

        private void Ordershow_Load(object sender, EventArgs e)
        {
            txt_datesearch.Text = DateTime.Now.ToShortDateString();
            con.Open();
            ordershowadapter = new SqlDataAdapter("select dates,order_no,dish_id,dish_name,cusneedqty,price from orderintake order by order_no", con);
            ordershowadapter.Fill(ordershow, "showorder");
            con.Close();
            grd_ordershow.DataSource = ordershow;
            grd_ordershow.DataMember = "showorder";
            grd_ordershow.Refresh();
        }

        

        private void monthCalendar1_DateSelected(object sender, DateRangeEventArgs e)
        {
            txt_datesearch.Text = monthCalendar1.SelectionRange.Start.ToShortDateString();

        }

        private void grd_ordershow_SelectionChanged(object sender, EventArgs e)
        {
            if (grd_ordershow.SelectedCells.Count > 0)
            {
                int selectedrowindex = grd_ordershow.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = grd_ordershow.Rows[selectedrowindex];
                txt_date.Text = Convert.ToString(selectedRow.Cells["dates"].Value);
                txt_orderno.Text = Convert.ToString(selectedRow.Cells["order_no"].Value);
                txt_dishid.Text = Convert.ToString(selectedRow.Cells["dish_id"].Value);
                txt_dishname.Text = Convert.ToString(selectedRow.Cells["dish_name"].Value);
                txt_needqty.Text = Convert.ToString(selectedRow.Cells["cusneedqty"].Value);
                txt_totprice.Text = Convert.ToString(selectedRow.Cells["price"].Value);
            }
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            con.Open();
            cmd = new SqlCommand("select priceplate from dish where dish_id='" + txt_dishid.Text + "'", con);
            SqlDataReader dr = cmd.ExecuteReader();
            dr.Read();
            price = Convert.ToInt32(dr.GetValue(0).ToString());
            con.Close();
            //update query
            con.Open();
            cmd = new SqlCommand("update orderintake set cusneedqty='" + txt_needqty.Text + "',price='" + (price) * (Convert.ToInt32(txt_needqty.Text)) + "' where order_no='" + txt_orderno.Text + "'and dish_id='" + txt_dishid.Text + "'", con);
            cmd.ExecuteNonQuery();
            con.Close();
            ordergridrefresh();
            MessageBox.Show("Data Updated!");
            
        }
        public void ordergridrefresh()
        {
            ordershow.Clear();
            con.Open();
            SqlDataAdapter refresh = new SqlDataAdapter("select dates,order_no,dish_id,dish_name,cusneedqty,price from orderintake order by order_no", con);
            DataSet ordergrid = new DataSet();
            refresh.Fill(ordergrid, "refreshorder");
            con.Close();
            grd_ordershow.DataSource = ordergrid;
            grd_ordershow.DataMember = "refreshorder";
            grd_ordershow.Refresh();
        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            txt_date.Text = "";
            txt_dishid.Text = "";
            txt_dishname.Text = "";
            txt_needqty.Text = "";
            txt_orderno.Text = "";
            txt_totprice.Text = "";
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_search.Text == "")
                {
                    MessageBox.Show("please fill search box");
                }
                else
                {
                    con.Close();
                    con.Open();
                    DataTable singleshow = new DataTable();
                    SqlDataAdapter singleorderda = new SqlDataAdapter("select dates,order_no,dish_id,dish_name,cusneedqty,price from orderintake where order_no='" + txt_search.Text + "' order by order_no", con);
                    singleorderda.Fill(singleshow);
                    singleorderda.Dispose();
                    con.Close();
                    if (singleshow.Rows.Count != 0)
                    {
                        grd_ordershow.DataSource = singleshow;
                        grd_ordershow.Refresh();
                        txt_search.Text = "";
                    }
                    else
                    {
                        MessageBox.Show("sorry No Data Available!");
                        txt_search.Text = "";
                    }
                    
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Enter Number Only!");
                txt_search.Text = "";
            }

        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            txt_datesearch.Text = monthCalendar1.SelectionRange.Start.ToShortDateString();
        }

        private void btn_datesearch_Click_1(object sender, EventArgs e)
        {
            try
            {
            if (txt_datesearch.Text == "")
            {
                MessageBox.Show("Please fill Search Box");
            }
            else
            {
                con.Open();
                DataTable show = new DataTable();
                SqlDataAdapter dateda = new SqlDataAdapter("select dates,order_no,dish_id,dish_name,cusneedqty,price from orderintake where dates='" + txt_datesearch.Text + "' order by order_no", con);
                dateda.Fill(show);
                dateda.Dispose();
                con.Close();
                if (show.Rows.Count != 0)
                {
                    grd_ordershow.DataSource = show;
                    grd_ordershow.Refresh();
                    txt_datesearch.Text = "";
                }
                else
                {
                    MessageBox.Show("sorry No Data Available!");
                    txt_datesearch.Text = "";
                }
            }
            }
            catch (Exception)
            {
                MessageBox.Show("Please enter Date Only!");
            }
        }

       
    }
}
