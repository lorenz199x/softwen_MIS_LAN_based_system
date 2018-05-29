using System;
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
    public partial class frmBackup : Form
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader dr;
        string sql = "";
        ConnectionString cs = new ConnectionString();

        public frmBackup()
        {
            InitializeComponent();
        }

        private void frmBackup_Load(object sender, EventArgs e)
        {

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

        private void btnbrowse_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dlg = new FolderBrowserDialog();
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                txtLocation.Text = dlg.SelectedPath;
            }
        }

        private void btnbackup_Click(object sender, EventArgs e)
        {
            try
            {

                if (cboDatabase.Text.CompareTo("") == 0)
                {
                    MessageBox.Show("Please Select a Database.");
                    return;
                }
                con = new SqlConnection(cs.DBConn);
                con.Open();
                sql = "BACKUP DATABASE dbsoftwen TO DISK='" + txtLocation.Text + "\\" + cboDatabase.Text + "-" + DateTime.Now.Ticks.ToString() + ".bak'";
                cmd = new SqlCommand(sql, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Succesfully Database Backup Completed.");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
