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
    public partial class frmSalesOrderList : Form
    {
        SqlDataAdapter da;
        SqlCommand cmd;
        SqlConnection con;
        SqlDataReader rdr;
        ConnectionString cs = new ConnectionString();
        DataTable dt;
        DataSet ds;
        SqlCommandBuilder scbuild;

        public frmSalesOrderList()
        {
            InitializeComponent();
        }

        private void frmSalesOrderList_Load(object sender, EventArgs e)
        {
            con = new SqlConnection(cs.DBConn);
            cmd = new SqlCommand();
            cmd.Connection = con;
            string query = "Select * from DbNewSales";
            cmd.CommandText = query;

            da = new SqlDataAdapter(cmd);
            dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void cboScategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cboScategory.Text == "Complete")
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //frmNewSales ns = new frmNewSales();
            //DataGridViewCell cell = null;
            //foreach (DataGridViewCell selectedCell in dataGridView1.SelectedCells)
            //{
            //    cell = selectedCell;
            //    break;
            //}
            //if (cell != null)
            //{
            //    DataGridViewRow row = cell.OwningRow;
            //    ns.value1 = row.Cells[4].Value.ToString();
            //    ns.value2 = row.Cells[5].Value.ToString();
            //    ns.value3 = row.Cells[6].Value.ToString();
            //    ns.value4 = row.Cells[7].Value.ToString();
            //    ns.value5 = row.Cells[8].Value.ToString();
            //    ns.value6 = row.Cells[9].Value.ToString();
            //}
            //this.Hide();
        }
    }
}
