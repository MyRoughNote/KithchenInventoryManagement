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
    public partial class Reorder_analyser : Form
    {
        SqlConnection con = new SqlConnection("Data Source=ACER-PC;Initial Catalog=kitcheninventory;Integrated Security=True");
        SqlCommand cmd = new SqlCommand();
        SqlDataAdapter da = new SqlDataAdapter();
        DataTable dt = new DataTable();
        DataSet ds = new DataSet();
        public Reorder_analyser()
        {
            InitializeComponent();
        }

        private void Reorder_analyser_Load(object sender, EventArgs e)
        {
            con.Open();
            da = new SqlDataAdapter("select * from stockinventory", con);
            da.Fill(ds, "reorder");
            con.Close();
            grd_reorder.DataSource = ds;
            grd_reorder.DataMember = "reorder";
            grd_reorder.Refresh();
        }

        private void btn_checkall_Click(object sender, EventArgs e)
        {
            ds.Clear();
            con.Open();
            da = new SqlDataAdapter("select item_id,item_name,availqty from stockinventory where availqty<=thersold", con);
            da.Fill(ds, "reordercheck");
            con.Close();
            grd_reorder.DataSource = ds;
            grd_reorder.DataMember = "reordercheck";
            grd_reorder.Refresh();
            MessageBox.Show("Sorry These Items Don't have Sufficient stock!");
            
        }

        private void btn_showall_Click(object sender, EventArgs e)
        {
            ds.Clear();
            con.Open();
            da = new SqlDataAdapter("select * from stockinventory", con);
            da.Fill(ds, "reorder");
            con.Close();
            grd_reorder.DataSource = ds;
            grd_reorder.DataMember = "reorder";
            grd_reorder.Refresh();
        }

        private void btn_check_Click(object sender, EventArgs e)
        {
            try
            {
            if (txt_reordersearch.Text == "")
            {
                MessageBox.Show("Please fill SearchBox!");
            }
            else
            {
                DataTable reorderdt = new DataTable();
                con.Open();
                da = new SqlDataAdapter("select item_id,item_name,availqty from stockinventory where availqty<=thersold and item_id='" + txt_reordersearch.Text+ "'", con);
                da.Fill(reorderdt);
                con.Close();
                if (reorderdt.Rows.Count !=0)
                {
                    grd_reorder.DataSource = reorderdt;
                    grd_reorder.Refresh();
                    MessageBox.Show("Sorry Dont Have Sufficient Stock!");
                    txt_reordersearch.Text = "";
                }
                else
                {
                    DataTable reorderitemavail = new DataTable();
                    con.Open();
                    da = new SqlDataAdapter("select * from stockinventory where item_id='" + txt_reordersearch.Text + "'", con);
                    da.Fill(reorderitemavail);
                    con.Close();
                    if (reorderitemavail.Rows.Count != 0)
                    {
                        MessageBox.Show("It has Sufficient Stock!");
                    }
                    else
                    {
                        MessageBox.Show("Sorry Data Not Found!");
                    }
                }
                
                }
            }
             catch (Exception)
            {
             MessageBox.Show("Enter Item ID Only");
            }
        }
       
    }
    
  }

