﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Softwen_project
{
    public partial class frmRecovery : Form
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader dr;
        string sql = "";
        ConnectionString cs = new ConnectionString();

        public frmRecovery()
        {
            InitializeComponent();
        }

        private void btnconnect_Click(object sender, EventArgs e)
        {
            try
            {
                con = new SqlConnection(cs.DBConn);
                con.Open();
                //sql = "EXEC sp_databases";
                sql = "select * from sys.databases d where d.database_id>4";
                cmd = new SqlCommand(sql, con);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    cboDatabase.Items.Add(dr[0].ToString());
                }
                dr.Dispose();
                con.Dispose();
                con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnBrowse2_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "Backup Files(*.bak)|*.bak|All Files(*.*)|*.*";
            dlg.FilterIndex = 0;
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                txtBackupPath.Text = dlg.FileName;
            }
        }

        private void btnRestore_Click(object sender, EventArgs e)
        {
            try
            {
                if (cboDatabase.Text.CompareTo("") == 0)
                {
                    MessageBox.Show("Please select a Database");
                    return;
                }
                con = new SqlConnection(cs.DBConn);
                con.Open();

                string UseMaster = "USE master";
                SqlCommand UseMasterCommand = new SqlCommand(UseMaster, con);
                UseMasterCommand.ExecuteNonQuery();

                sql = "Alter Database dbsoftwen Set SINGLE_USER WITH ROLLBACK IMMEDIATE;";
                sql += "Restore Database dbsoftwen FROM DISK ='" + txtBackupPath.Text + "' WITH REPLACE;";
                cmd = new SqlCommand(sql, con);
                cmd.ExecuteNonQuery();
                con.Close();
                con.Dispose();
                MessageBox.Show("Succesfully Restore Completed");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
