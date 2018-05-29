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
    public partial class frmProductList : Form
    {
        SqlDataAdapter da;
        SqlCommand cmd;
        SqlConnection con;
        SqlDataReader rdr;
        ConnectionString cs = new ConnectionString();
        DataTable dt;
        DataSet ds;
        SqlCommandBuilder scbuild;

        public frmProductList()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            
            con = new SqlConnection(cs.DBConn);
            da = new SqlDataAdapter("select ProductCode,ProductName,BrandName,Category,Quantity,UnitPrice,ReorderPoint,Critical,Description,Datetime from Dbinventory where ProductName like '%" + txtSearch.Text + "%' ", con);
            scbuild = new SqlCommandBuilder(da);

            dt = new DataTable();
            ds = new DataSet();
            da.Fill(dt);
            dataGridView1.DataSource = dt;

        }

        private void cboScategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboScategory.Text == "All Items")
            {
                con = new SqlConnection(cs.DBConn);
                da = new SqlDataAdapter("select ProductCode,ProductName,BrandName,Category,Quantity,UnitPrice,ReorderPoint,Critical,Description,Datetime from Dbinventory where HideCategory='All Items'", con);
                scbuild = new SqlCommandBuilder(da);

                dt = new DataTable();
                ds = new DataSet();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            else if (cboScategory.Text == "Lights")
            {
                con = new SqlConnection(cs.DBConn);
                da = new SqlDataAdapter("select ProductCode,ProductName,BrandName,Category,Quantity,UnitPrice,ReorderPoint,Critical,Description,Datetime from Dbinventory where Category='Lights'", con);
                scbuild = new SqlCommandBuilder(da);

                dt = new DataTable();
                ds = new DataSet();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            else if (cboScategory.Text == "Switchs")
            {
                con = new SqlConnection(cs.DBConn);
                da = new SqlDataAdapter("select ProductCode,ProductName,BrandName,Category,Quantity,UnitPrice,ReorderPoint,Critical,Description,Datetime from Dbinventory where Category='Switchs' ", con);
                scbuild = new SqlCommandBuilder(da);

                dt = new DataTable();
                ds = new DataSet();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            else if (cboScategory.Text == "Wiring Devices")
            {
                con = new SqlConnection(cs.DBConn);
                da = new SqlDataAdapter("select ProductCode,ProductName,BrandName,Category,Quantity,UnitPrice,ReorderPoint,Critical,Description,Datetime from Dbinventory where Category='Wiring Devices'", con);
                scbuild = new SqlCommandBuilder(da);

                dt = new DataTable();
                ds = new DataSet();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //frmNewProduct newproduct = new frmNewProduct();
            //con = new SqlConnection(cs.DBConn);
            //DataGridViewCell cell = null;
            //foreach (DataGridViewCell selectedCell in dataGridView1.SelectedCells)
            //{
            //    cell = selectedCell;
            //    break;
            //}
            //if (cell != null)
            //{
            //    DataGridViewRow row = cell.OwningRow;
            //    newproduct.passv0 = row.Cells[0].Value.ToString();
            //    newproduct.passv1 = row.Cells[1].Value.ToString();
            //    newproduct.passv2 = row.Cells[2].Value.ToString();
            //    newproduct.passv3 = row.Cells[3].Value.ToString();
            //    newproduct.passv4 = row.Cells[4].Value.ToString();
            //    newproduct.passv5 = row.Cells[5].Value.ToString();
            //    newproduct.passv6 = row.Cells[6].Value.ToString();
            //    newproduct.passv7 = row.Cells[7].Value.ToString();

            //}
            //newproduct.ShowDialog();
        }

        private void frmProductList_Load(object sender, EventArgs e)
        {
            //con = new SqlConnection(cs.DBConn);
            //cmd = new SqlCommand();
            //cmd.Connection = con;
            //string query = "Select * from DbInventory Order by DateTime DESC";
            //cmd.CommandText = query;
            //cmd = new SqlCommand("Select ProductName, Date from tbltest Order by Date DESC", scn);
            //da = new SqlDataAdapter(cmd);
            //dt = new DataTable();
            //da.Fill(dt);
            //dataGridView1.DataSource = dt;
        }

        private void dataGridView1_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
            {
                if (Convert.ToInt32(dataGridView1.Rows[i].Cells[4].Value) <= Convert.ToInt32(dataGridView1.Rows[i].Cells[6].Value))
                {
                    dataGridView1.Rows[i].Cells[4].Style.BackColor = Color.Orange;
                }
                if (Convert.ToInt32(dataGridView1.Rows[i].Cells[4].Value) <= Convert.ToInt32(dataGridView1.Rows[i].Cells[7].Value))
                {
                    dataGridView1.Rows[i].Cells[4].Style.BackColor = Color.Red;
                }
                else
                {
                    dataGridView1.Rows[i].Cells[4].Style.ForeColor = Color.Black;

                }
            }
        }
    }
}
