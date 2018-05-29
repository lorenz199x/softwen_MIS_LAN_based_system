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
    public partial class frmNewProduct : Form
    {
        SqlDataAdapter da;
        SqlCommand cmd;
        SqlConnection con;
        SqlDataReader rdr;
        ConnectionString cs = new ConnectionString();
        DataTable dt;
        DataSet ds;
        SqlCommandBuilder scbuild;


        /*private string pc; private string pc2; private string pc3; private string pc4; private string pc5; private string pc6; private string pc7; private string pc8;

        public string passv0
        {
            get { return pc; }
            set { pc = value; }
        }
        public string passv1
        {
            get { return pc2; }
            set { pc2 = value; }
        }
        public string passv2
        {
            get { return pc3; }
            set { pc3 = value; }
        }
        public string passv3
        {
            get { return pc4; }
            set { pc4 = value; }
        }
        public string passv4
        {
            get { return pc5; }
            set { pc5 = value; }
        }
        public string passv5
        {
            get { return pc6; }
            set { pc6 = value; }
        }
        public string passv6
        {
            get { return pc7; }
            set { pc7 = value; }
        }
        public string passv7
        {
            get { return pc8; }
            set { pc8 = value; }
        }*/

        public frmNewProduct()
        {
            InitializeComponent();
            timer1.Start();
        }

        public void executeQuery(string[] queries)
        {
            con.Open();

            cmd = new SqlCommand();
            cmd.Connection = con;
            foreach (string query in queries)
            {
                string aa = query;
                cmd.CommandText = aa;
                cmd.ExecuteNonQuery();
            }

            con.Close();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtProductCode.Text == "")
                {
                    MessageBox.Show("Please enter ProductCode", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtProductCode.Focus();
                    return;
                }
                if (txtProductName.Text == "")
                {
                    MessageBox.Show("Please enter ProductName", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtProductName.Focus();
                    return;
                }
                if (txtBrandName.Text == "")
                {
                    MessageBox.Show("Please enter BrandName", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtBrandName.Focus();
                    return;
                }
                if (cboCategory.Text == "")
                {
                    MessageBox.Show("Please enter Category", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    cboCategory.Focus();
                    return;
                }
                if (txtQty.Text == "")
                {
                    MessageBox.Show("Please enter Quantity", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtQty.Focus();
                    return;
                }
                if (txtPrice.Text == "")
                {
                    MessageBox.Show("Please enter txtUnitPrice", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtPrice.Focus();
                    return;
                }
                if (txtDescription.Text == "")
                {
                    MessageBox.Show("Please enter Description", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    con = new SqlConnection(cs.DBConn);
                    con.Open();
                    string aa = "insert into Dbinventory(ProductCode,ProductName,BrandName,Category,Quantity,UnitPrice,ReorderPoint,Critical,Description,Datetime,HideCategory,UserName) VALUES ('" + txtProductCode.Text + "','" + txtProductName.Text + "','" + txtBrandName.Text + "','" + cboCategory.Text + "','" + txtQty.Text + "','" + txtPrice.Text + "','" + txtReorder.Text + "','" + txtCritical.Text + "','" + txtDescription.Text + "','" + lblDateTime.Text + "','" + lblAll.Text + "','" + lblUserName.Text + "')";
                    cmd = new SqlCommand(aa);
                    cmd.Connection = con;
                    cmd.ExecuteNonQuery();
                }
                if (con.State == ConnectionState.Open)
                {
                    MessageBox.Show("Record Save");
                }

                else
                {
                    MessageBox.Show("Record Fail to Added");
                }

                dataGridView1.DataSource = null;
                dataGridView1.Rows.Clear();
                dataGridView1.Refresh();

                da = new SqlDataAdapter("select * from Dbinventory", con);
                scbuild = new SqlCommandBuilder(da);

                dt = new DataTable();
                ds = new DataSet();

                da.Fill(dt);

                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    dataGridView1.Rows.Add(dt.Rows[i][0], dt.Rows[i][1], dt.Rows[i][2], dt.Rows[i][3], dt.Rows[i][4], dt.Rows[i][5], dt.Rows[i][6], dt.Rows[i][7], dt.Rows[i][8], dt.Rows[i][9]);
                }
                

                con.Close();
                string inv = "select max(ProductCode) + 1 from Dbinventory";
                cmd = new SqlCommand(inv, con);

                con.Open();
                cmd.ExecuteNonQuery();

                rdr = cmd.ExecuteReader(0);

                while (rdr.Read())
                {
                    int n = rdr.GetInt32(0);
                    txtProductCode.Text = "00" + n.ToString();
                }
                con.Close();

                con = new SqlConnection(cs.DBConn);
                con.Open();
                string qw = "insert into DbUserLogs(UserName,UserType,DateTime,Activity) VALUES ('" + lblUserName.Text + "','" + lblUserType.Text + "','" + lblDateTime.Text + "','" + lblAddProduct.Text + "')";
                cmd = new SqlCommand(qw);
                cmd.Connection = con;
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtProductCode.Text = null;
            txtProductName.Text = null;
            txtBrandName.Text = null;
            cboCategory.Text = null;
            txtQty.Text = null;
            txtPrice.Text = null;
            txtDescription.Text = null;
            txtReorder.Text = null;
            txtCritical.Text = null;

            string inv = "select max(ProductCode) + 1 from Dbinventory";
            cmd = new SqlCommand(inv, con);

            con.Open();
            cmd.ExecuteNonQuery();

            rdr = cmd.ExecuteReader(0);

            while (rdr.Read())
            {
                int n = rdr.GetInt32(0);
                txtProductCode.Text = "00" + n.ToString();
            }
            con.Close();
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
                txtProductCode.Text = row.Cells[0].Value.ToString();
                txtProductName.Text = row.Cells[1].Value.ToString();
                txtBrandName.Text = row.Cells[2].Value.ToString();
                cboCategory.Text = row.Cells[3].Value.ToString();
                txtQty.Text = row.Cells[4].Value.ToString();
                txtPrice.Text = row.Cells[5].Value.ToString();
                txtReorder.Text = row.Cells[6].Value.ToString();
                txtCritical.Text = row.Cells[7].Value.ToString();
                txtDescription.Text = row.Cells[8].Value.ToString();
            }
        }

        private void frmNewProduct_Load(object sender, EventArgs e)
        {

            con = new SqlConnection(cs.DBConn);
            con.Open();
            dataGridView1.DataSource = null;
            dataGridView1.Rows.Clear();
            dataGridView1.Refresh();

            da = new SqlDataAdapter("select * from Dbinventory", con);
            scbuild = new SqlCommandBuilder(da);

            dt = new DataTable();
            ds = new DataSet();

            da.Fill(dt);

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                dataGridView1.Rows.Add(dt.Rows[i][0], dt.Rows[i][1], dt.Rows[i][2], dt.Rows[i][3], dt.Rows[i][4], dt.Rows[i][5], dt.Rows[i][6], dt.Rows[i][7], dt.Rows[i][8], dt.Rows[i][9]);
            }
            con.Close();


            //txtProductCode.Text = "" + pc;
            //txtProductName.Text = "" + pc2;
            //txtBrandName.Text = "" + pc3;
            //cboCategory.Text = "" + pc4;
            //txtQty.Text = "" + pc5;
            //txtPrice.Text = "" + pc6;
            //txtReorder.Text = "" + pc7;
            //txtDescription.Text = "" + pc8;
            string inv = "select max(ProductCode) + 1 from Dbinventory";
            cmd = new SqlCommand(inv, con);

            con.Open();
            cmd.ExecuteNonQuery();

            rdr = cmd.ExecuteReader(0);

            while (rdr.Read())
            {
                int n = rdr.GetInt32(0);
                txtProductCode.Text = "00" + n.ToString();
            }
            con.Close();

        }

        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtProductCode.Text == "")
                {
                    MessageBox.Show("Please enter ProductCode", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtProductCode.Focus();
                    return;
                }
                if (txtProductName.Text == "")
                {
                    MessageBox.Show("Please enter ProductName", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtProductName.Focus();
                    return;
                }
                if (txtBrandName.Text == "")
                {
                    MessageBox.Show("Please enter BrandName", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtBrandName.Focus();
                    return;
                }
                if (cboCategory.Text == "")
                {
                    MessageBox.Show("Please enter Category", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    cboCategory.Focus();
                    return;
                }
                if (txtQty.Text == "")
                {
                    MessageBox.Show("Please enter Quantity", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtQty.Focus();
                    return;
                }
                if (txtPrice.Text == "")
                {
                    MessageBox.Show("Please enter txtUnitPrice", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtPrice.Focus();
                    return;
                }
                if (txtDescription.Text == "")
                {
                    MessageBox.Show("Please enter Description", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    con = new SqlConnection(cs.DBConn);
                    string cb = "update Dbinventory set ProductCode='" + this.txtProductCode.Text + "',ProductName='" + this.txtProductName.Text + "',BrandName='" + this.txtBrandName.Text + "',Category='" + cboCategory.Text + "',Quantity='" + txtQty.Text + "',UnitPrice='" + txtPrice.Text + "',ReorderPoint='" + txtReorder.Text + "',Critical='" + txtCritical.Text + "',Description='" + txtDescription.Text + "' where ProductCode='" + txtProductCode.Text + "';";
                    cmd = new SqlCommand(cb, con);

                    con.Open();
                    rdr = cmd.ExecuteReader();
                    MessageBox.Show("Successfully Updated");
                    while (rdr.Read())
                    {
                    }
                    con.Close();
                }

                dataGridView1.DataSource = null;
                dataGridView1.Rows.Clear();
                dataGridView1.Refresh();

                da = new SqlDataAdapter("select * from Dbinventory", con);
                scbuild = new SqlCommandBuilder(da);

                dt = new DataTable();
                ds = new DataSet();

                da.Fill(dt);

                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    dataGridView1.Rows.Add(dt.Rows[i][0], dt.Rows[i][1], dt.Rows[i][2], dt.Rows[i][3], dt.Rows[i][4], dt.Rows[i][5], dt.Rows[i][6], dt.Rows[i][7], dt.Rows[i][8], dt.Rows[i][9]);
                }
                con.Close();

                con = new SqlConnection(cs.DBConn);
                con.Open();
                string aa = "insert into DbUserLogs(UserName,UserType,DateTime,Activity) VALUES ('" + lblUserName.Text + "','" + lblUserType.Text + "','" + lblDateTime.Text + "','" + lblUpdateProduct.Text + "')";
                cmd = new SqlCommand(aa);
                cmd.Connection = con;
                cmd.ExecuteNonQuery();
                con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtProductCode.Text == "")
                {
                    MessageBox.Show("Please enter ProductCode", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtProductCode.Focus();
                    return;
                }
                if (txtProductName.Text == "")
                {
                    MessageBox.Show("Please enter ProductName", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtProductName.Focus();
                    return;
                }
                if (txtBrandName.Text == "")
                {
                    MessageBox.Show("Please enter BrandName", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtBrandName.Focus();
                    return;
                }
                if (cboCategory.Text == "")
                {
                    MessageBox.Show("Please enter Category", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    cboCategory.Focus();
                    return;
                }
                if (txtQty.Text == "")
                {
                    MessageBox.Show("Please enter Quantity", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtQty.Focus();
                    return;
                }
                if (txtPrice.Text == "")
                {
                    MessageBox.Show("Please enter txtUnitPrice", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtPrice.Focus();
                    return;
                }
                if (txtDescription.Text == "")
                {
                    MessageBox.Show("Please enter Description", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                   
                    if (MessageBox.Show("Do you want to delete this record?", Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        if (MessageBox.Show("Are you sure?", Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            con = new SqlConnection(cs.DBConn);
                            con.Open();
                            cmd = new SqlCommand();
                            cmd.Connection = con;
                            string cb = "delete from Dbinventory where ProductCode = '" + txtProductCode.Text + "'";
                            cmd.CommandText = cb;
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Data Deleted");
                            con.Close();

                            txtProductCode.Text = null;
                            txtProductName.Text = null;
                            txtBrandName.Text = null;
                            cboCategory.Text = null;
                            txtQty.Text = null;
                            txtPrice.Text = null;
                            txtDescription.Text = null;
                            txtReorder.Text = null;
                            txtCritical.Text = null;

                        }
                    }
                }
                dataGridView1.DataSource = null;
                dataGridView1.Rows.Clear();
                dataGridView1.Refresh();

                da = new SqlDataAdapter("select * from Dbinventory", con);
                scbuild = new SqlCommandBuilder(da);

                dt = new DataTable();
                ds = new DataSet();

                da.Fill(dt);

                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    dataGridView1.Rows.Add(dt.Rows[i][0], dt.Rows[i][1], dt.Rows[i][2], dt.Rows[i][3], dt.Rows[i][4], dt.Rows[i][5], dt.Rows[i][6], dt.Rows[i][7], dt.Rows[i][8], dt.Rows[i][9]);
                }
                con.Close();

                con = new SqlConnection(cs.DBConn);
                con.Open();
                string kl = "insert into DbUserLogs(UserName,UserType,DateTime,Activity) VALUES ('" + lblUserName.Text + "','" + lblUserType.Text + "','" + lblDateTime.Text + "','" + lblDeleteProduct.Text + "')";
                cmd = new SqlCommand(kl);
                cmd.Connection = con;
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cancelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtProductCode.Text = null;
            txtProductName.Text = null;
            txtBrandName.Text = null;
            cboCategory.Text = null;
            txtQty.Text = null;
            txtPrice.Text = null;
            txtDescription.Text = null;
            txtReorder.Text = null;
            txtCritical.Text = null;
        }

        private void txtQty_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txtQty.Text, "[^0-9]"))
            {
                MessageBox.Show("Invalid Input, Numbers Only!");
                txtQty.Text.Remove(txtQty.Text.Length - 1);
                txtQty.Text = null;
            }
        }

        private void txtPrice_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txtPrice.Text, "[^0-9]"))
            {
                MessageBox.Show("Invalid Input, Numbers Only!");
                txtPrice.Text.Remove(txtPrice.Text.Length - 1);
                txtPrice.Text = null;
            }
        }

        private void txtReorder_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txtReorder.Text, "[^0-9]"))
            {
                MessageBox.Show("Invalid Input, Numbers Only!");
                txtReorder.Text.Remove(txtReorder.Text.Length - 1);
                txtReorder.Text = null;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblDateTime.Text = DateTime.Now.ToString();
        }

        private void dataGridView1_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
            {
                if (Convert.ToInt32(dataGridView1.Rows[i].Cells[4].Value) == Convert.ToInt32(dataGridView1.Rows[i].Cells[6].Value))
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

        private void txtCritical_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txtReorder.Text, "[^0-9]"))
            {
                MessageBox.Show("Invalid Input, Numbers Only!");
                txtReorder.Text.Remove(txtReorder.Text.Length - 1);
                txtCritical.Text = null;
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            con = new SqlConnection(cs.DBConn);
            dataGridView1.DataSource = null;
            dataGridView1.Rows.Clear();
            dataGridView1.Refresh();

            SqlDataAdapter da = new SqlDataAdapter("select * from Dbinventory where ProductName like '%" + txtSearch.Text + "%' ", con);
            SqlCommandBuilder scbuild = new SqlCommandBuilder(da);

            dt = new DataTable();
            ds = new DataSet();

            da.Fill(dt);

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                dataGridView1.Rows.Add(dt.Rows[i][0], dt.Rows[i][1], dt.Rows[i][2], dt.Rows[i][3], dt.Rows[i][4], dt.Rows[i][5], dt.Rows[i][6], dt.Rows[i][7], dt.Rows[i][8], dt.Rows[i][9]);
            }
        }

       

    }
}