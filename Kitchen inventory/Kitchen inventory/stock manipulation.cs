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
    public partial class stock_manipulation : Form
    {
        SqlConnection con = new SqlConnection("Data Source=ACER-PC;Initial Catalog=kitcheninventory;Integrated Security=True");
        SqlCommand cmd = new SqlCommand();
        SqlDataAdapter da = new SqlDataAdapter();
        DataTable dt = new DataTable();
        DataSet ds = new DataSet();
         public stock_manipulation()
        {
            InitializeComponent();
        }

        private void stock_manipulation_Load(object sender, EventArgs e)
        {
            txt_stockdate.Text = DateTime.Now.ToShortDateString();
            con.Open();
            da = new SqlDataAdapter("select * from stockinventory", con);
            ds = new DataSet();
            da.Fill(ds,"stockdetail");
            con.Close();
            grd_stockedit.DataSource = ds;
            grd_stockedit.DataMember = "stockdetail";
            grd_stockedit.Refresh();            
        //to read itemid in combobox
        //    con.Open();
        //    cmd=new SqlCommand("select item_id from stockinventory", con);
        //    SqlDataReader reader = cmd.ExecuteReader();
        //    while (reader.Read())
        //    {
        //        cmb_itemid.Items.Add(reader.GetValue(0).ToString());
        //    }
        //    reader.Close();
        //    con.Close();
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            txt_itemname.Text = "";
            txt_limit.Text = "";
            txt_qty.Text = "";
            txt_itemid.Text = "";

        }

       
        private void btn_delete_Click(object sender, EventArgs e)
        {
            if ((txt_itemid.Text == "") || (txt_itemname.Text == "") || (txt_qty.Text == "") || (txt_limit.Text == ""))
            {
                MessageBox.Show("Please Fill All the Fields!");
            }
            else
            {
                con.Open();
                cmd = new SqlCommand("delete from stockinventory where item_id='" + txt_itemid.Text + "'", con);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Data Deleted!");
                gridrefresh();
            }
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (grd_stockedit.SelectedCells.Count > 0)
            {
                int selectedrowindex = grd_stockedit.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = grd_stockedit.Rows[selectedrowindex];
                txt_itemid.Text= Convert.ToString(selectedRow.Cells["item_id"].Value);
                txt_itemname.Text = Convert.ToString(selectedRow.Cells["item_name"].Value);
                txt_qty.Text = Convert.ToString(selectedRow.Cells["availqty"].Value);
                txt_limit.Text = Convert.ToString(selectedRow.Cells["thersold"].Value);
            }
        }

        private void btn_update_Click(object sender, EventArgs e)

        {
            int needquandity;
            if (txt_needqty.Text == "")
            {
                needquandity = 0;
            }
            else
            {
                needquandity = Convert.ToInt32(txt_needqty.Text);

            }
            
            if ((txt_itemid.Text == "") || (txt_itemname.Text == "") || (txt_qty.Text == "") || (txt_limit.Text == ""))
            {
                MessageBox.Show("Please Fill All the Fields!");
            }
            else
            {
                int sum = Convert.ToInt32(txt_qty.Text) + needquandity;
                txt_qty.Text = sum.ToString();
                
                con.Open();
                SqlCommand cmd = new SqlCommand("update stockinventory set availqty='" + txt_qty.Text + "',thersold='" + txt_limit.Text + "',item_name='"+txt_itemname.Text+"'where item_id='" + txt_itemid.Text + "'", con);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Data Updated!");
                gridrefresh();
                txt_needqty.Text = "";
            }
           
        }
        private void gridrefresh()
        {
            SqlDataAdapter da = new SqlDataAdapter("select * from stockinventory", con);
            DataSet ds = new DataSet();
            da.Fill(ds,"stockdetail");
            grd_stockedit.DataSource = ds;
            grd_stockedit.DataMember = "stockdetail";
            grd_stockedit.Refresh();
        }

        private void btn_purchase_Click(object sender, EventArgs e)
        {
            Purchase_Order pobj = new Purchase_Order();
            pobj.Show();
        }




      

       

       
    }
}
