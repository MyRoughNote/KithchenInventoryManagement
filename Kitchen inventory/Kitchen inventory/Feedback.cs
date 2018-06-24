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
    public partial class Feedback : Form
    {
        SqlConnection con = new SqlConnection("Data Source=ACER-PC;Initial Catalog=kitcheninventory;Integrated Security=True");
        SqlCommand cmd = new SqlCommand();
        SqlDataAdapter da = new SqlDataAdapter();
        public Feedback()
        {
            InitializeComponent();
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            txt_mail.Text= "";
            txt_name.Text = "";
            txt_phone.Text = "";
            cmb_cost.Text = "";
            cmb_hygen.Text = "";
            cmb_qty.Text = "";
            cmb_taste.Text = "";
            cmb_time.Text = "";
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            int phoneval = 0;
            string mailval="No Data";
            if ((txt_name.Text=="")||(cmb_time.Text == "") || (cmb_taste.Text == "") || (cmb_qty.Text == "") || (cmb_hygen.Text == "") || (cmb_cost.Text == ""))
            {
                MessageBox.Show("Please Select the Options & Save");
            }
            else
            {
                if ((txt_mail.Text == "") && (txt_phone.Text == ""))
                        {
                            con.Close();
                            con.Open();
                            cmd = new SqlCommand("insert into feedback(name,phoneno,mail,taste,quantity,Hygenic,responsetime,cost)values('" + txt_name.Text + "','"+phoneval+"','"+mailval+"','" + cmb_taste.Text + "','" + cmb_qty.SelectedItem.ToString() + "','" + cmb_hygen.SelectedItem.ToString() + "','" + cmb_time.SelectedItem.ToString() + "','" + cmb_cost.SelectedItem.ToString() + "')", con);
                            cmd.ExecuteNonQuery();
                            con.Close();
                            MessageBox.Show("Feedback Saved");
                            txt_mail.Text = "";
                            txt_name.Text = "";
                            txt_phone.Text = "";
                            cmb_cost.Text = "";
                            cmb_hygen.Text = "";
                            cmb_qty.Text = "";
                            cmb_taste.Text = "";
                            cmb_time.Text = "";
                }
                else
                {
                    if (txt_mail.Text == "")
                    {
                        con.Close();
                        con.Open();
                        cmd = new SqlCommand("insert into feedback(name,phoneno,mail,taste,quantity,Hygenic,responsetime,cost)values('" + txt_name.Text + "','" + txt_phone.Text + "','" + mailval + "','" + cmb_taste.Text + "','" + cmb_qty.SelectedItem.ToString() + "','" + cmb_hygen.SelectedItem.ToString() + "','" + cmb_time.SelectedItem.ToString() + "','" + cmb_cost.SelectedItem.ToString() + "')", con);
                        cmd.ExecuteNonQuery();
                        con.Close();
                        MessageBox.Show("Feedback Saved");
                        txt_mail.Text = "";
                        txt_name.Text = "";
                        txt_phone.Text = "";
                        cmb_cost.Text = "";
                        cmb_hygen.Text = "";
                        cmb_qty.Text = "";
                        cmb_taste.Text = "";
                        cmb_time.Text = "";
                    }
                    else
                        if (txt_phone.Text == "")
                {
                    con.Close();
                    con.Open();
                    cmd = new SqlCommand("insert into feedback(name,phoneno,mail,taste,quantity,Hygenic,responsetime,cost)values('" + txt_name.Text + "','" +phoneval+ "','" + txt_mail.Text + "','" + cmb_taste.Text + "','" + cmb_qty.SelectedItem.ToString() + "','" + cmb_hygen.SelectedItem.ToString() + "','" + cmb_time.SelectedItem.ToString() + "','" + cmb_cost.SelectedItem.ToString() + "')", con);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Feedback Saved");
                    txt_mail.Text = "";
                    txt_name.Text = "";
                    txt_phone.Text = "";
                    cmb_cost.Text = "";
                    cmb_hygen.Text = "";
                    cmb_qty.Text = "";
                    cmb_taste.Text = "";
                    cmb_time.Text = "";
                }
                        
                        else
                        {

                            con.Close();
                            con.Open();
                            cmd = new SqlCommand("insert into feedback(name,phoneno,mail,taste,quantity,Hygenic,responsetime,cost)values('" + txt_name.Text + "','" + txt_phone.Text + "','" + txt_mail.Text + "','" + cmb_taste.Text + "','" + cmb_qty.SelectedItem.ToString() + "','" + cmb_hygen.SelectedItem.ToString() + "','" + cmb_time.SelectedItem.ToString() + "','" + cmb_cost.SelectedItem.ToString() + "')", con);
                            cmd.ExecuteNonQuery();
                            con.Close();
                            MessageBox.Show("Feedback Saved");
                            txt_mail.Text = "";
                            txt_name.Text = "";
                            txt_phone.Text = "";
                            cmb_cost.Text = "";
                            cmb_hygen.Text = "";
                            cmb_qty.Text = "";
                            cmb_taste.Text = "";
                            cmb_time.Text = "";
                        }
                }
                da.Dispose();
                con.Open();
                da = new SqlDataAdapter("select * from feedback", con);
                DataSet ds = new DataSet();
                da.Fill(ds, "feed");
                con.Close();
                grd_feedback.DataSource = ds;
                grd_feedback.DataMember = "feed";
                grd_feedback.Refresh();
            }
        }

        private void Feedback_Load(object sender, EventArgs e)
        {
            con.Open();
            da = new SqlDataAdapter("select * from feedback", con);
            DataSet ds = new DataSet();
            da.Fill(ds, "feed");
            grd_feedback.DataSource = ds;
            grd_feedback.DataMember = "feed";
            grd_feedback.Refresh();
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
