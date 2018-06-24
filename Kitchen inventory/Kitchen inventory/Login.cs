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
    public partial class Login : Form
    {
        SqlConnection con = new SqlConnection("Data Source=ACER-PC;Initial Catalog=kitcheninventory;Integrated Security=True");
        SqlCommand cmd = new SqlCommand();
        SqlDataAdapter da = new SqlDataAdapter();
        int errcount;
        public Login()
        {
            InitializeComponent();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {

            if ((cmb_role.Text == "") || (txt_username.Text == "") || (txt_password.Text == ""))
            {
                MessageBox.Show("Please fill All fields!");
            }
            else
            {
                con.Open();
                da = new SqlDataAdapter("select role,username,passletter from logintable where role='" + cmb_role.Text + "' and username='" + txt_username.Text + "'and passletter='" + txt_password.Text + "'", con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                con.Close();
                if (dt.Rows.Count > 0)
                {
                    errcount = 0;
                    Login logobj = new Login();
                    this.Hide();
                    master masterobj = new master();
                    masterobj.Show();
                }
                else
                {
                    errcount = errcount + 1;
                    if (errcount > 3)
                    {
                        MessageBox.Show("Ask Administrator for Authentication");
                    }
                    else
                    {
                        MessageBox.Show("Invalid User!");
                    }
                }
            }
        }
            
        private void btn_cancel_Click(object sender, EventArgs e)
        {
            cmb_role.Text = "";
            txt_password.Text = "";
            txt_username.Text = "";
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

      }
}
