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
    public partial class Loginmanipulation : Form
    {
        SqlConnection con = new SqlConnection("Data Source=ACER-PC;Initial Catalog=kitcheninventory;Integrated Security=True");
        SqlCommand cmd = new SqlCommand();
        SqlDataAdapter da = new SqlDataAdapter();
        DataTable dt = new DataTable();
        DataSet ds = new DataSet();
        public Loginmanipulation()
        {
            InitializeComponent();
        }

        private void Loginmanipulation_Load(object sender, EventArgs e)
        {
            txt_date.Text = DateTime.Now.ToShortDateString();
            con.Open();
            da = new SqlDataAdapter("select * from logintable", con);
            ds = new DataSet();
            da.Fill(ds, "logindetail");
            con.Close();
            grd_logindetail.DataSource = ds;
            grd_logindetail.DataMember = "logindetail";
            grd_logindetail.Refresh();

        }

        private void grd_logindetail_SelectionChanged(object sender, EventArgs e)
        {
            if (grd_logindetail.SelectedCells.Count > 0)
            {
                int selectedrowindex = grd_logindetail.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = grd_logindetail.Rows[selectedrowindex];
                txt_username.Text = Convert.ToString(selectedRow.Cells["username"].Value);
                txt_password.Text = Convert.ToString(selectedRow.Cells["passletter"].Value);
                txt_role.Text = Convert.ToString(selectedRow.Cells["role"].Value);

            }
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            txt_username.Text = "";
            txt_password.Text = "";
            txt_role.Text = "";
        }

       
            //if ((txt_username.Text == "") || (txt_password.Text == "") || (txt_role.Text == ""))
            //{
            //    MessageBox.Show("Please Fill All Fields!");
            //}
            //else
            //{
            //    con.Open();
            //    cmd = new SqlCommand("delete from logintable where username='" + txt_username.Text + "'", con);
            //    cmd.ExecuteNonQuery();
            //    con.Close();
            //    MessageBox.Show("Data Deleted!");
            //    loginrefresh();
            //}
         

        private void loginrefresh()
        {
            SqlDataAdapter da = new SqlDataAdapter("select * from logintable", con);
            DataSet ds = new DataSet();
            da.Fill(ds, "logindetail");
            grd_logindetail.DataSource = ds;
            grd_logindetail.DataMember = "logindetail";
            grd_logindetail.Refresh();
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            if ((txt_username.Text == "") || (txt_password.Text == "") || (txt_role.Text == ""))
            {
                MessageBox.Show("Please Fill All Fields!");
            }
            else
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("update logintable set passletter='" + txt_password.Text + "',role='" + txt_role.Text + "'where username='" + txt_username.Text + "'", con);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Data Updated!");
                loginrefresh();
            }
        }

       
    }
}
