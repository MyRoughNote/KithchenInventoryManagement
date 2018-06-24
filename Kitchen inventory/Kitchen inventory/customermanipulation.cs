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
    public partial class customermanipulation : Form
    {
        SqlConnection con = new SqlConnection("Data Source=ACER-PC;Initial Catalog=kitcheninventory;Integrated Security=True");
        SqlCommand cmd = new SqlCommand();
        SqlDataAdapter da = new SqlDataAdapter();
        DataTable dt = new DataTable();
        DataSet ds = new DataSet();
        public customermanipulation()
        {
            InitializeComponent();
        }

        private void grd_customeredit_SelectionChanged(object sender, EventArgs e)
        {
            if (grd_customeredit.SelectedCells.Count > 0)
            {
                int selectedrowindex = grd_customeredit.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = grd_customeredit.Rows[selectedrowindex];
                txt_cusid.Text = Convert.ToString(selectedRow.Cells["cus_id"].Value);
                txt_name.Text = Convert.ToString(selectedRow.Cells["cus_name"].Value);
                txt_phone.Text = Convert.ToString(selectedRow.Cells["cus_no"].Value);
                txt_address.Text = Convert.ToString(selectedRow.Cells["cus_address"].Value);
            }
        }

        private void customermanipulation_Load(object sender, EventArgs e)
        {
            txt_date.Text = DateTime.Now.ToShortDateString();
            con.Open();
            da = new SqlDataAdapter("select * from customer", con);
            ds = new DataSet();
            da.Fill(ds, "customer");
            con.Close();
            grd_customeredit.DataSource = ds;
            grd_customeredit.DataMember = "customer";
            grd_customeredit.Refresh();
        }
        private void customereditrefresh()
        {
            SqlDataAdapter da = new SqlDataAdapter("select * from customer", con);
            DataSet ds = new DataSet();
            da.Fill(ds, "customer");
            grd_customeredit.DataSource = ds;
            grd_customeredit.DataMember = "customer";
            grd_customeredit.Refresh();
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            txt_cusid.Text = "";
            txt_name.Text = "";
            txt_phone.Text = "";
            txt_address.Text = "";
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if ((txt_cusid.Text == "") || (txt_name.Text == "") || (txt_phone.Text == "") || (txt_address.Text == ""))
            {
                MessageBox.Show("Please Fill All Records!");
            }
            else
            {
                con.Open();
                cmd = new SqlCommand("delete from customer where cus_id='" + txt_cusid.Text + "'", con);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Data Deleted!");
                customereditrefresh();
            }


        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            if ((txt_cusid.Text == "") || (txt_name.Text == "") || (txt_phone.Text == "") || (txt_address.Text == ""))
            {
                MessageBox.Show("Please Fill All Fields!");
            }
            else
            {
            con.Open();
                SqlCommand cmd = new SqlCommand("update customer set cus_no='" + txt_phone.Text + "',cus_address='" + txt_address.Text + "',cus_name='"+txt_name.Text+"' where cus_id='" + txt_cusid.Text + "'", con);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Data Updated!");
                customereditrefresh();
            }
        }
    }
}
