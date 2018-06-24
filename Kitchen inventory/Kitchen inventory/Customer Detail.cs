using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Text.RegularExpressions;

namespace Kitchen_inventory
{
    public partial class CustomerDetail : Form
    {
        SqlConnection con = new SqlConnection("Data Source=ACER-PC;Initial Catalog=kitcheninventory;Integrated Security=True");
        SqlCommand cmd = new SqlCommand();
        SqlDataAdapter da = new SqlDataAdapter();
        DataTable dt = new DataTable();
        DataSet ds = new DataSet();
        public CustomerDetail()
        {
            InitializeComponent();
        }

        private void CustomerDetail_Load(object sender, EventArgs e)
        {
            txt_date.Text = DateTime.Now.ToShortDateString();
            con.Open();
            da = new SqlDataAdapter("select max(cus_id)+1 from customer", con);
            dt = new DataTable();
            da.Fill(dt);
            con.Close();
            txt_cusid.Text = dt.Rows[0][0].ToString();
            da.Dispose();

            con.Open();
            da = new SqlDataAdapter("select * from customer", con);
            ds = new DataSet();
            da.Fill(ds,"customer");
            con.Close();
            grd_customerdetail.DataSource = ds;
            grd_customerdetail.DataMember = "customer";
            grd_customerdetail.Refresh();
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            txt_cusid.Text = "";
            txt_name.Text = "";
            txt_phone.Text = "";
            txt_address.Text = "";
            txt_search.Text = "";
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            if ((txt_cusid.Text == "") || (txt_name.Text == "") || (txt_phone.Text == "") || (txt_address.Text == ""))
            {
                MessageBox.Show("Please Fill All Fields!");
            }
            else
            {
                con.Open();
                cmd = new SqlCommand("insert into customer values('" + txt_date.Text + "','" + txt_name.Text + "','" + txt_phone.Text + "','" + txt_address.Text + "')", con);
                cmd.ExecuteNonQuery();
                con.Close();
                customerrefresh();
                MessageBox.Show("your information Stored!");
                txt_cusid.Text = "";
                txt_name.Text = "";
                txt_phone.Text = "";
                txt_address.Text = "";
                txt_search.Text = "";
            }
        }

        private void btn_newitem_Click(object sender, EventArgs e)
        {
            con.Open();
            da = new SqlDataAdapter("select max(cus_id)+1 from customer", con);
            dt = new DataTable();
            da.Fill(dt);
            con.Close();
            txt_cusid.Text = dt.Rows[0][0].ToString();
            da.Dispose();
        }

        private void btn_showall_Click(object sender, EventArgs e)
        {
            con.Open();
            da = new SqlDataAdapter("select * from customer", con);
            ds = new DataSet();
            da.Fill(ds, "customer");
            con.Close();
            grd_customerdetail.DataSource = ds;
            grd_customerdetail.DataMember = "customer";
            grd_customerdetail.Refresh();
        }
        private void customerrefresh()
        {
            SqlDataAdapter da = new SqlDataAdapter("select * from customer", con);
            DataSet ds = new DataSet();
            da.Fill(ds, "customer");
            grd_customerdetail.DataSource = ds;
            grd_customerdetail.DataMember = "customer";
            grd_customerdetail.Refresh();
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
                con.Close();
                DataTable cusdt = new DataTable();
                con.Open();
                da = new SqlDataAdapter("select dates,cus_id,cus_name,cus_no,cus_address from customer where cus_id='" + txt_search.Text + "'", con);
                da.Fill(cusdt);
                con.Close();
                if (cusdt.Rows.Count!=0)
                {
                    //txt_itemname.Text = dt.Rows[0][0].ToString();
                    //txt_qty.Text = dt.Rows[0][1].ToString();
                    //txt_limit.Text = dt.Rows[0][2].ToString();
                    grd_customerdetail.DataSource = cusdt;
                    grd_customerdetail.Refresh();
                    txt_search.Text = "";

                }
                else
                {
                    MessageBox.Show("Sorry Your Data is not found!");
                }
            }
            }
            catch (Exception)
            {
                MessageBox.Show("Please Enter Number Only!");
                txt_search.Text = "";
            }
        }

        private void customerManipulationupdateDeleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            customermanipulation cusedit = new customermanipulation();
            cusedit.Show();
        }

        private void txt_phone_Validating(object sender, CancelEventArgs e)
        {
            Regex validator = new Regex("(7|8|9){1}[0-9]{9}");
            string match = validator.Match(txt_phone.Text).Value.ToString();
            if (match.Length != 10)
            {
                MessageBox.Show("Invalid Phone No.\n It Must have only Numeric Values with length 10", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

       
    }
}
