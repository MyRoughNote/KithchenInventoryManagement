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
    public partial class RecipesConfigure : Form
    {
        SqlConnection con = new SqlConnection("Data Source=ACER-PC;Initial Catalog=kitcheninventory;Integrated Security=True");
        SqlCommand cmd = new SqlCommand();
        SqlDataAdapter da = new SqlDataAdapter();
        DataTable dt = new DataTable();
        DataSet ds = new DataSet();

        public RecipesConfigure()
        {
            InitializeComponent();
        }

        private void RecipesConfigure_Load(object sender, EventArgs e)
        {
           txt_date.Text = DateTime.Now.ToShortDateString();
           con.Open();
           da = new SqlDataAdapter("select item_id,item_name from stockinventory", con);
           DataSet recipedt = new DataSet();
           da.Fill(recipedt, "recipedetails");
           con.Close();
           grd_recipedetails.DataSource = recipedt;
           grd_recipedetails.DataMember = "recipedetails";
           grd_recipedetails.Refresh();

           con.Open();
           da = new SqlDataAdapter("select dish_id,dish_name from dish", con);
           DataSet dishdt = new DataSet();
           da.Fill(dishdt, "dishdetails");
           con.Close();
           grd_dishdetails.DataSource = dishdt;
           grd_dishdetails.DataMember = "dishdetails";
           grd_dishdetails.Refresh();

           con.Open();
           cmd = new SqlCommand("select dish_id from dish", con);
           SqlDataReader dishdr = cmd.ExecuteReader();
           while (dishdr.Read())
           {
               cmb_dishid.Items.Add(dishdr.GetValue(0).ToString());
           }
           dishdr.Close();
           con.Close();
        }

        private void cmb_dishid_SelectedIndexChanged(object sender, EventArgs e)
        {
            con.Open();
            cmd = new SqlCommand("select dish_name from dish where dish_id='" + cmb_dishid.Text + "'", con);
            SqlDataReader reader = cmd.ExecuteReader();
            reader.Read();
            txt_dishname.Text = reader.GetValue(0).ToString();
            con.Close();
        }

        private void grd_recipedetails_SelectionChanged(object sender, EventArgs e)
        {
            if (grd_recipedetails.SelectedCells.Count > 0)
            {
                int selectedrowindex = grd_recipedetails.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = grd_recipedetails.Rows[selectedrowindex];
                txt_itemid.Text = Convert.ToString(selectedRow.Cells["item_id"].Value);
                
            }
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            try
            {
                if ((txt_dishname.Text == "") || (txt_needqty.Text == ""))
                {
                    MessageBox.Show("Please Fill All Fields!");
                }
                else
                {
                    con.Open();
                    SqlCommand rpcmd = new SqlCommand("insert into reciepeconfig (dates,dish_name,needqty,dish_id,item_id) values('" + txt_date.Text + "','" + txt_dishname.Text + "','" + txt_needqty.Text + "','" + cmb_dishid.Text + "','" + txt_itemid.Text + "')", con);
                    rpcmd.ExecuteNonQuery();
                    MessageBox.Show("Item Added!");
                    txt_itemid.Text = "";
                    txt_needqty.Text = "";
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Item Already Added");
            }
            con.Close();
        }

        private void btn_showitems_Click(object sender, EventArgs e)
        {
            con.Open();
            da = new SqlDataAdapter("select r.item_id,s.item_name,r.needqty from reciepeconfig r,stockinventory s where r.dish_id='" + cmb_dishid.Text + "'and s.item_id=r.item_id", con);
            DataSet recipeviewdt = new DataSet();
            da.Fill(recipeviewdt, "recipeupdate");
            con.Close();
            grd_recipeconfig.DataSource = recipeviewdt;
            grd_recipeconfig.DataMember = "recipeupdate";
            grd_recipeconfig.Show();
        }

        private void btn_stockmaintain_Click(object sender, EventArgs e)
        {
            stockmaintain stockobj = new stockmaintain();
            stockobj.Visible = true;
            
        }

        private void grd_dishdetails_SelectionChanged(object sender, EventArgs e)
        {
            if (grd_dishdetails.SelectedCells.Count > 0)
            {
                int selectedrowindex = grd_dishdetails.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = grd_dishdetails.Rows[selectedrowindex];
                cmb_dishid.Text= Convert.ToString(selectedRow.Cells["dish_id"].Value);
                txt_dishname.Text = Convert.ToString(selectedRow.Cells["dish_name"].Value);
                
            }
        }

       

       
    }
}
