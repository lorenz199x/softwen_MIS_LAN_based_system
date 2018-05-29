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
    public partial class frmSupplierList : Form
    {
        SqlDataAdapter da;
        SqlCommand cmd;
        SqlConnection con;
        SqlDataReader rdr;
        ConnectionString cs = new ConnectionString();
        DataTable dt;
        DataSet ds;
        SqlCommandBuilder scbuild;
        frmNewPurchase np = new frmNewPurchase();

        public frmSupplierList()
        {
            InitializeComponent();
        }

        private void frmSupplierList_Load(object sender, EventArgs e)
        {

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
                np.passv1 = row.Cells[0].Value.ToString();
                np.passv2 = row.Cells[1].Value.ToString();
                np.passv3 = row.Cells[2].Value.ToString();
                np.passv4 = row.Cells[3].Value.ToString();
                np.passv6 = row.Cells[4].Value.ToString();
                np.passv5 = row.Cells[5].Value.ToString();

            }

            this.Hide();
            np.ShowDialog();
        }

        private void txtContactPerson_TextChanged(object sender, EventArgs e)
        {
            con = new SqlConnection(cs.DBConn);
            da = new SqlDataAdapter("select * from DbNewSupplier where ContactPerson like '%" + txtContactPerson.Text + "%' ", con);
            scbuild = new SqlCommandBuilder(da);

            dt = new DataTable();
            ds = new DataSet();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
