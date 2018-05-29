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
    public partial class frmCustomerList : Form
    {
        SqlDataAdapter da;
        SqlCommand cmd;
        SqlConnection con;
        SqlDataReader rdr;
        ConnectionString cs = new ConnectionString();
        DataTable dt;
        DataSet ds;
        SqlCommandBuilder scbuild;
        frmNewSales newsales = new frmNewSales();

        public frmCustomerList()
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
            da = new SqlDataAdapter("select * from DbNewCustomer where Company like '%" + txtSearch.Text + "%' ", con);
            scbuild = new SqlCommandBuilder(da);

            dt = new DataTable();
            ds = new DataSet();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void txtContactPerson_TextChanged(object sender, EventArgs e)
        {
            con = new SqlConnection(cs.DBConn);
            da = new SqlDataAdapter("select * from DbNewCustomer where ContactPerson like '%" + txtContactPerson.Text + "%' ", con);
            scbuild = new SqlCommandBuilder(da);

            dt = new DataTable();
            ds = new DataSet();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void frmCustomerList_Load(object sender, EventArgs e)
        {
            con = new SqlConnection(cs.DBConn);
            cmd = new SqlCommand();
            cmd.Connection = con;
            string query = "Select * from DbNewCustomer";
            cmd.CommandText = query;

            da = new SqlDataAdapter(cmd);
            dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewCell cell = null;
            foreach (DataGridViewCell selectedCell in dataGridView1.SelectedCells)
            {
                cell = selectedCell;
                break;
            }
            if (cell != null)
            {
                DataGridViewRow row = cell.OwningRow;
                newsales.passv1 = row.Cells[0].Value.ToString();
                newsales.passv2 = row.Cells[1].Value.ToString();
                newsales.passv3 = row.Cells[2].Value.ToString();
                newsales.passv4 = row.Cells[3].Value.ToString();
                newsales.passv5 = row.Cells[4].Value.ToString();
                newsales.passv6 = row.Cells[5].Value.ToString();

            }

            this.Hide();
            newsales.lblUserName.Text = lblUserName.Text;
            newsales.lblUserType.Text = lblUserType.Text;
            newsales.ShowDialog();
        }
    }
}
