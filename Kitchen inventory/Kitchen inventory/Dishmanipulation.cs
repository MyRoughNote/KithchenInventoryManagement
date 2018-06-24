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
    public partial class Dishmanipulation : Form
    {
        SqlConnection con = new SqlConnection("Data Source=ACER-PC;Initial Catalog=kitcheninventory;Integrated Security=True");
        SqlCommand cmd = new SqlCommand();
        SqlDataAdapter da = new SqlDataAdapter();
        DataTable dt = new DataTable();
        DataSet ds = new DataSet();

        public Dishmanipulation()
        {
            InitializeComponent();
        }

        private void Dishmanipulation_Load(object sender, EventArgs e)
        {
            txt_dishdate.Text = DateTime.Now.ToShortDateString();
            con.Open();
            da = new SqlDataAdapter("select * from dish", con);
            ds = new DataSet();
            da.Fill(ds, "dishdetail");
            con.Close();
            grd_dishedit.DataSource = ds;
            grd_dishedit.DataMember = "dishdetail";
            grd_dishedit.Refresh(); 
        }

        private void grd_dishedit_SelectionChanged(object sender, EventArgs e)
        {
            if (grd_dishedit.SelectedCells.Count > 0)
            {
                int selectedrowindex = grd_dishedit.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = grd_dishedit.Rows[selectedrowindex];
                txt_dishid.Text = Convert.ToString(selectedRow.Cells["dish_id"].Value);
                txt_dishname.Text = Convert.ToString(selectedRow.Cells["dish_name"].Value);
                txt_price.Text = Convert.ToString(selectedRow.Cells["priceplate"].Value);
                
            }
        }

        private void disheditrefresh()
        {
            SqlDataAdapter da = new SqlDataAdapter("select * from dish", con);
            DataSet ds = new DataSet();
            da.Fill(ds, "dishdetail");
            grd_dishedit.DataSource = ds;
            grd_dishedit.DataMember = "dishdetail";
            grd_dishedit.Refresh();
        }

        private void txt_dishdelete_Click(object sender, EventArgs e)
        {
            if ((txt_dishid.Text == "") || (txt_dishname.Text == "") || (txt_price.Text == ""))
            {
                MessageBox.Show("Please Fill All Records!");
            }
            else
            {
                con.Open();
                cmd = new SqlCommand("delete from dish where dish_id='" + txt_dishid.Text + "'", con);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Data Deleted!");
                disheditrefresh();
            }
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            txt_dishid.Text = "";
            txt_dishname.Text = "";
            txt_price.Text = "";
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            if ((txt_dishid.Text == "") || (txt_dishname.Text == "") || (txt_price.Text == ""))
            {
                MessageBox.Show("Please Fill All Fields!");
            }
            else
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("update dish set priceplate='"+txt_price.Text+ "',dish_name='"+txt_dishname.Text+"' where dish_id='" + txt_dishid.Text + "'", con);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Data Updated!");
                disheditrefresh();
            }
        }
    }
}
