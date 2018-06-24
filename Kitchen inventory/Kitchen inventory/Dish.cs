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
    public partial class Dish : Form
    {
        SqlConnection con = new SqlConnection("Data Source=ACER-PC;Initial Catalog=kitcheninventory;Integrated Security=True");
        SqlCommand cmd = new SqlCommand();
        SqlDataAdapter da = new SqlDataAdapter();
        DataTable dt = new DataTable();
        DataSet ds = new DataSet();
        public Dish()
        {
            InitializeComponent();
        }

        private void Dish_Load(object sender, EventArgs e)
        {
            txt_dishdate.Text = DateTime.Now.ToShortDateString();
            con.Open();
            da = new SqlDataAdapter("select max(dish_id)+1 from dish", con);
            dt = new DataTable();
            da.Fill(dt);
            con.Close();
            txt_dishid.Text = dt.Rows[0][0].ToString();
            da.Dispose();

            con.Open();
            da = new SqlDataAdapter("select * from dish", con);
            ds = new DataSet();
            da.Fill(ds, "dishdetail");
            con.Close();
            grd_dishdetail.DataSource = ds;
            grd_dishdetail.DataMember = "dishdetail";
            grd_dishdetail.Refresh();

        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            try
            {
                if ((txt_dishdate.Text == "") || (txt_dishid.Text == "") || (txt_dishname.Text == "") || (txt_price.Text == ""))
                {
                    MessageBox.Show("Please Fill All the Fields!");
                }
                else
                {
                    con.Open();
                    cmd = new SqlCommand("insert into dish values('" + txt_dishdate.Text + "','" + txt_dishname.Text + "','" + txt_price.Text + "')", con);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Your Information Stored!");
                    dishrefresh();
                    txt_dishid.Text = "";
                    txt_dishname.Text = "";
                    txt_price.Text = "";
                }
            }
            catch (Exception)
            {
                MessageBox.Show("ID Already Available!Press New Item");
            }
        }
            private void dishrefresh()
            {
            SqlDataAdapter da = new SqlDataAdapter("select * from dish", con);
            DataSet ds = new DataSet();
            da.Fill(ds, "dishdetail");
            grd_dishdetail.DataSource = ds;
            grd_dishdetail.DataMember = "dishdetail";
            grd_dishdetail.Refresh();
            }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            txt_dishid.Text="";
            txt_dishname.Text="";
            txt_price.Text="";
            txt_dishsearch.Text = "";

        }

        private void btn_showdish_Click(object sender, EventArgs e)
        {
            con.Open();
            da = new SqlDataAdapter("select * from dish", con);
            ds = new DataSet();
            da.Fill(ds, "dishdetail");
            con.Close();
            grd_dishdetail.DataSource = ds;
            grd_dishdetail.DataMember = "dishdetail";
            grd_dishdetail.Refresh();
        }

        private void btn_newitem_Click(object sender, EventArgs e)
        {
            con.Open();
            da = new SqlDataAdapter("select max(dish_id)+1 from dish", con);
            dt = new DataTable();
            da.Fill(dt);
            con.Close();
            txt_dishid.Text = dt.Rows[0][0].ToString();
            da.Dispose();
        }

        private void btn_searchdish_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_dishsearch.Text == "")
                {
                    MessageBox.Show("Please fill search Box!");
                }
                else
                {
                    con.Close();
                    DataTable dishdt = new DataTable();
                    dishdt.Clear();
                    con.Open();
                    da = new SqlDataAdapter("select dates,dish_id,dish_name,priceplate from dish where dish_id='" + txt_dishsearch.Text + "'", con);
                    da.Fill(dishdt);
                    con.Close();
                    if (dishdt.Rows.Count != 0)
                    {
                        grd_dishdetail.DataSource = dishdt;
                        grd_dishdetail.Refresh();
                        txt_dishsearch.Text = "";
                    }
                    else
                    {
                        MessageBox.Show("Your Data is Not Found!");
                    }
                }
            }
             catch (Exception)
            {
                MessageBox.Show("Please Enter Number Only!");
                txt_dishsearch.Text = "";
            }
        }

        private void dishRecipeManipulationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Dishmanipulation dishmanip = new Dishmanipulation();
            dishmanip.Show();
        }

       
    }
}
