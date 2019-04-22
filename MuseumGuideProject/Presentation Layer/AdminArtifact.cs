using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MuseumGuideProject
{
    public partial class AdminArtifact : Form
    {
        public AdminArtifact()
        {
            InitializeComponent();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminForm af = new AdminForm();
            af.Show();
        }

        private void btnAddUtem_Click(object sender, EventArgs e)
        {
            SqlConnection SqlCon = new SqlConnection();

            SqlCon.ConnectionString = ConfigurationManager.ConnectionStrings["MuseumConn"].ConnectionString;
            SqlCon.Open();

            string sql = "[ItemCreate]";
            SqlDataAdapter da = new SqlDataAdapter("[ItemCreate]", SqlCon);

            da.SelectCommand = new SqlCommand(sql, SqlCon);

            //da.SelectCommand.CommandType = CommandType.StoredProcedure;
            //da.SelectCommand.Parameters.AddWithValue("@ItemID", tbUsername.Text);
            //da.SelectCommand.Parameters.AddWithValue("@Name", tbPassword.Text);
            //da.SelectCommand.Parameters.AddWithValue("@Description", tbPassword.Text);
            //da.SelectCommand.Parameters.AddWithValue("@@CategoryID", tbPassword.Text);
            //da.SelectCommand.Parameters.AddWithValue("@Price", tbPassword.Text);
            //da.SelectCommand.Parameters.AddWithValue("@Priority", tbPassword.Text);
            //da.SelectCommand.Parameters.AddWithValue("@Floor", tbPassword.Text);
            //da.SelectCommand.Parameters.AddWithValue("@Sector", tbPassword.Text);
            //da.SelectCommand.Parameters.AddWithValue("@LUB", tbPassword.Text);
            //da.SelectCommand.Parameters.AddWithValue("@LUN", tbPassword.Text);
            //da.SelectCommand.Parameters.AddWithValue("@LUD", tbPassword.Text);


            SqlCon.Open();

        }


        private void AdminArtifact_Load(object sender, EventArgs e)
        {
            //    SqlConnection SqlCon = new SqlConnection();

            //    SqlCon.ConnectionString = ConfigurationManager.ConnectionStrings["MuseumConn"].ConnectionString;
            //    SqlCon.Open();

            //    SqlCommand categorycom = new SqlCommand("", sqlCon);
            //    SqlCommand colorcom = new SqlCommand("USE [HomeSweetHome] Select  [ColorName]  FROM[dbo].[Color]", sqlCon);
            //    if (sqlCon.State == ConnectionState.Closed)
            //        sqlCon.Open();
            //    if (!IsPostBack)
            //    {
            //        SqlDataReader category = categorycom.ExecuteReader();

            //        dlCategoryName.Items.Clear();
            //        while (category.Read())
            //        {
            //            dlCategoryName.Items.Add(new ListItem(category[0].ToString(), category[0].ToString()));

            //            dlSearch.Items.Add(new ListItem(category[0].ToString(), category[0].ToString()));

            //        }

            //        category.Close();
            //        category = colorcom.ExecuteReader();

            //        while (category.Read())
            //        {

            //            dlColorName.Items.Add(new ListItem(category[0].ToString(), category[0].ToString()));

            //        }
            //        btnDelete.Enabled = false;
            //    }

            //    sqlCon.Close();
            //}
        }
    }
}
