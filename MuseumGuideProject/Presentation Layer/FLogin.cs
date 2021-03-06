﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;
using MuseumGuideProject;
using System.Security.Principal;

namespace MuseumGuideProject
{
    public partial class FLogin : Form
    {
        public FLogin()
        {
            InitializeComponent();
        }
        
      
        private void btnMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
           // FMenu fm = new FMenu();
            this.Close();
           // FMenu.Show();
        }
        
        private void btnLogin_Click(object sender, EventArgs e)
        {
            SqlConnection SqlCon = new SqlConnection();


            SqlCon.ConnectionString = ConfigurationManager.ConnectionStrings["MuseumConn"].ConnectionString;
            SqlCon.Open();

            string sql = "[GetUser]";
            SqlDataAdapter da = new SqlDataAdapter("[GetUser]", SqlCon);

            da.SelectCommand = new SqlCommand(sql, SqlCon);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            da.SelectCommand.Parameters.AddWithValue("@Username", tbUsername.Text);
            da.SelectCommand.Parameters.AddWithValue("@Password", tbPassword.Text);


            DataTable dt = new DataTable();
            da.Fill(dt);


            if (tbUsername.Text == "" || tbPassword.Text == "")
            {
                MessageBox.Show("Please Type Username and Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else if (dt.Rows.Count == 1)
            {
                SqlDataAdapter sqd = new SqlDataAdapter("[GetUserID]", SqlCon);
                sqd.SelectCommand.CommandType = CommandType.StoredProcedure;
                sqd.SelectCommand.Parameters.AddWithValue("@Username", tbUsername.Text);
                sqd.SelectCommand.Parameters.AddWithValue("@Password", tbPassword.Text);

                
                DataTable dtl = new DataTable();
                sqd.Fill(dtl);


                this.Hide();
                AdminForm af = new AdminForm();
                af.Show();
              //  User strUserName = WindowsIdentity.GetCurrent().User;


            }
            else
            {
                MessageBox.Show("Invalid Username and Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btnReset_Click_1(sender, e);
            }
            SqlCon.Close();
        }

        private void btnReset_Click_1(object sender, EventArgs e)
        {
            tbUsername.Text = "";
            tbPassword.Text = "";
        }
    }
}
