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
    public partial class frmPurchaseOrderList : Form
    {
        SqlDataAdapter da;
        SqlCommand cmd;
        SqlConnection con;
        SqlDataReader rdr;
        ConnectionString cs = new ConnectionString();
        DataTable dt;
        DataSet ds;
        SqlCommandBuilder scbuild;

        public frmPurchaseOrderList()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void cboScategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboScategory.Text == "Complete")
            {
                con = new SqlConnection(cs.DBConn);
                da = new SqlDataAdapter("select * from DbNewSales where Status='Complete'", con);
                scbuild = new SqlCommandBuilder(da);

                dt = new DataTable();
                ds = new DataSet();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            else if (cboScategory.Text == "Incomplete")
            {
                con = new SqlConnection(cs.DBConn);
                da = new SqlDataAdapter("select * from DbNewSales where Status='Incomplete'", con);
                scbuild = new SqlCommandBuilder(da);

                dt = new DataTable();
                ds = new DataSet();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }
           
        }

        private void frmPurchaseOrderList_Load(object sender, EventArgs e)
        {
            con = new SqlConnection(cs.DBConn);
            cmd = new SqlCommand();
            cmd.Connection = con;
            string query = "Select * from DbNewSupplierOrder";
            cmd.CommandText = query;

            da = new SqlDataAdapter(cmd);
            dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }
    }
}
