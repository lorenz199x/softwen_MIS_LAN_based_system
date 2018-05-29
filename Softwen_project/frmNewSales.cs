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
    public partial class frmNewSales : Form
    {
        SqlDataAdapter da;
        SqlCommand cmd;
        SqlConnection con;
        SqlDataReader rdr;
        ConnectionString cs = new ConnectionString();
        DataTable dt;
        DataSet ds;
        SqlCommandBuilder scbuild;

        // CUSTOMER LIST
        private string nm; private string nm2; private string nm3; private string nm4; private string nm5; private string nm6;

        public string passv1
        {
            get { return nm; }
            set { nm = value; }
        }
        public string passv2
        {
            get { return nm2; }
            set { nm2 = value; }
        }
        public string passv3
        {
            get { return nm3; }
            set { nm3 = value; }
        }
        public string passv4
        {
            get { return nm4; }
            set { nm4 = value; }
        }
        public string passv5
        {
            get { return nm5; }
            set { nm5 = value; }
        }
        public string passv6
        {
            get { return nm6; }
            set { nm6 = value; }
        }

       

        public frmNewSales()
        {
            InitializeComponent();
            timer1.Start();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtCustomerID.Text = null;
            txtCompany.Text = null;
            txtContactPerson.Text = null;
            txtPhone.Text = null;
            txtFaxNo.Text = null;

            txtProductCode.Text = null;
            txtProductName.Text = null;
            txtBrandName.Text = null;
            txtAddQty.Text = null;
            txtPrice.Text = null;
            txtDescription.Text = null;

            txtSalesRep.Text = null;
            dateTimePicker2.Text = null;
            txtBusAdd.Text = null;
            txtOrderNo.Text = null;
            dateTimePicker1.Text = null;
            cboStatus.Text = null;
            dateTimePicker3.Text = null;

            txtSubTotal.Text = null;
            txtTotal.Text = null;
            txtBalance.Text = null;
            //txtPaid.Text = null;

            dataGridView2.Rows.Clear();

            con = new SqlConnection(cs.DBConn);
            string inv = "select max(Orderno) + 1 from DbNewSales";
            cmd = new SqlCommand(inv, con);

            con.Open();
            cmd.ExecuteNonQuery();

            rdr = cmd.ExecuteReader(0);

            while (rdr.Read())
            {
                int n = rdr.GetInt32(0);
                txtOrderNo.Text = "" + n.ToString();
            }
            con.Close();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //try
            //{
                for (int i = 0; i < dataGridView2.Rows.Count - 1; i++)
                {
                    con = new SqlConnection(cs.DBConn);
                    con.Open();
                    string aa = "insert into DbNewSales(Orderno,OrderDate,ShipDate,DueDate,CustomerID,Company,ContactPerson,Phone,BusinessAdd,Fax,ProductCode,ProductName,BrandName,Quantity,UnitPrice,Description,TotalAmt,SalesRep,Status,Subtotal,Total,Paid,Balance,Datetime,UserName) VALUES ('" + txtOrderNo.Text + "','" + dateTimePicker1.Value + "','" + dateTimePicker2.Value + "','" + dateTimePicker3.Value + "','" + txtCustomerID.Text + "','" + txtCompany.Text + "','" + txtContactPerson.Text + "','" + txtPhone.Text + "','" + txtBusAdd.Text + "','" + txtFaxNo.Text + "','" + dataGridView2.Rows[i].Cells[0].Value + "','" + dataGridView2.Rows[i].Cells[1].Value + "','" + dataGridView2.Rows[i].Cells[2].Value + "','" + dataGridView2.Rows[i].Cells[3].Value + "','" + dataGridView2.Rows[i].Cells[4].Value + "','" + dataGridView2.Rows[i].Cells[5].Value + "','" + dataGridView2.Rows[i].Cells[6].Value + "','" + txtSalesRep.Text + "','" + cboStatus.Text + "','" + txtSubTotal.Text + "','" + txtTotal.Text + "','" + txtBalance.Text + "','" + txtPaid.Text + "','" + lblDateTime.Text + "','" + lblUserName.Text + "')";
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

                for (int i = 0; i <= dataGridView2.Rows.Count - 1; i++)
                {
                    ////if (Convert.ToInt32(dataGridView1.Rows[i].Cells[4].Value) == Convert.ToInt32(dataGridView1.Rows[i].Cells[6].Value))
                    ////{
                    ////    dataGridView1.Rows[i].Cells[4].Style.BackColor = Color.Orange;
                    ////}
                    //if (Convert.ToInt32(dataGridView1.Rows[i].Cells[4].Value) <= 0)
                    //{
                    //    MessageBox.Show("bawal");
                    //}
                    //else
                    //{
                        con = new SqlConnection(cs.DBConn);
                        con.Open(); ;
                        string cb1 = "update Dbinventory set [Quantity] = Quantity - '" + dataGridView2.Rows[i].Cells[3].Value + "' where ProductCode= '" + dataGridView2.Rows[i].Cells[0].Value + "'";
                        cmd = new SqlCommand(cb1);
                        cmd.Connection = con;
                        cmd.ExecuteNonQuery();
                        con.Close();
                    //}
                }

                con = new SqlConnection(cs.DBConn);
                con.Open();
                string bb = "insert into DbUserLogs(UserName,UserType,DateTime,Activity) VALUES ('" + lblUserName.Text + "','" + lblUserType.Text + "','" + lblDateTime.Text + "','" + lblAddNewTran.Text + "')";
                cmd = new SqlCommand(bb);
                cmd.Connection = con;
                cmd.ExecuteNonQuery();
                con.Close();
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
        }

        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSalesOrderList sol = new frmSalesOrderList();
            sol.ShowDialog();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            txtCustomerID.Text = null;
            txtCompany.Text = null;
            txtContactPerson.Text = null;
            txtPhone.Text = null;
            txtFaxNo.Text = null;

            txtProductCode.Text = null;
            txtProductName.Text = null;
            txtBrandName.Text = null;
            txtAddQty.Text = null;
            txtPrice.Text = null;
            txtDescription.Text = null;

            txtSalesRep.Text = null;
            dateTimePicker2.Text = null;
            txtBusAdd.Text = null;
            txtOrderNo.Text = null;
            dateTimePicker1.Text = null;
            cboStatus.Text = null;
            dateTimePicker3.Text = null;

            txtSubTotal.Text = null;
            txtTotal.Text = null;
            txtBalance.Text = null;
            //txtPaid.Text = null;

            dataGridView2.Rows.Clear();
        }

        private void SearchCustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCustomerList clist = new frmCustomerList();
            this.Hide();
            clist.lblUserName.Text = lblUserName.Text;
            clist.lblUserType.Text = lblUserType.Text;
            clist.ShowDialog();
        }

        private void frmNewSales_Load(object sender, EventArgs e)
        {
            con = new SqlConnection(cs.DBConn);
            string inv = "select max(Orderno) + 1 from DbNewSales";
            cmd = new SqlCommand(inv, con);

            con.Open();
            cmd.ExecuteNonQuery();

            rdr = cmd.ExecuteReader(0);

            while (rdr.Read())
            {
                int n = rdr.GetInt32(0);
                txtOrderNo.Text = "" + n.ToString();
            }
            con.Close();
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

            txtCustomerID.Text = "" + nm;
            txtCompany.Text = "" + nm2;
            txtContactPerson.Text = "" + nm3;
            txtPhone.Text = "" + nm4;
            txtBusAdd.Text = "" + nm5;
            txtFaxNo.Text = "" + nm6;

           

            con.Close();

        }

        private void txtPaid_TextChanged(object sender, EventArgs e)
        {
            //try
            //{
                double Total = Int32.Parse(txtTotal.Text);
                double Cash = Int32.Parse(txtPaid.Text);
                txtBalance.Text = Math.Abs(Cash - Total).ToString();

                double balance = Int32.Parse(txtTotal.Text);
                txtChange.Text = (Cash - Total).ToString();



                if (System.Text.RegularExpressions.Regex.IsMatch(txtPaid.Text, "[^0-9]"))
                {
                    MessageBox.Show("Invalid Input, numbers only!");
                    txtPaid.Text.Remove(txtPaid.Text.Length - 1);
                    txtPaid.Text = null;
                }
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
            //int counter = 0;
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
                txtQty.Text = row.Cells[6].Value.ToString();
                txtPrice.Text = row.Cells[5].Value.ToString();
                txtDescription.Text = row.Cells[8].Value.ToString();
                txtQuan.Text = row.Cells[4].Value.ToString();
            }
            //if (dataGridView2.Rows.Count > 1)
            //{
            //    while (counter != dataGridView2.Rows.Count - 1)
            //    {
            //        if (dataGridView2.Rows[counter].Cells[0].Value.ToString() == txtProductCode.Text)
            //        {
            //            MessageBox.Show("The Product is already in the list!");
            //            return;
            //        }
            //        counter++;
            //    }
            //}

            //if (txtProductCode.Text == "")
            //{
            //    MessageBox.Show("Please enter ProductNo", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    txtProductCode.Focus();
            //    return;
            //}
            //if (txtProductName.Text == "")
            //{
            //    MessageBox.Show("Please enter ProductName", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    txtProductName.Focus();
            //    return;
            //}
            //if (txtBrandName.Text == "")
            //{
            //    MessageBox.Show("Please enter BrandName", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    txtBrandName.Focus();
            //    return;
            //}
            //if (txtDescription.Text == "")
            //{
            //    MessageBox.Show("Please enter Description", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    txtDescription.Focus();
            //    return;
            //}

            //if (txtAddQty.Text == "")
            //{
            //    MessageBox.Show("Please enter Quantity", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    txtAddQty.Focus();
            //    return;
            //}

            //if (txtPrice.Text == "")
            //{
            //    MessageBox.Show("Please enter UnitPrice", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    txtPrice.Focus();
            //    return;
            //}
            //else
            //{
            //    dataGridView2.Rows.Add(txtProductCode.Text, txtProductName.Text, txtBrandName.Text, txtAddQty.Text, txtPrice.Text, txtDescription.Text);
            //}

            //    for (int i = 0; i < dataGridView2.Rows.Count - 1; i++)
            //    {
            //        int Quantity = Convert.ToInt32(dataGridView2.Rows[i].Cells[3].Value.ToString());
            //        int UnitPrice = Convert.ToInt32(dataGridView2.Rows[i].Cells[4].Value.ToString());
            //        int total = Quantity * UnitPrice;

            //        total = Convert.ToInt32(dataGridView2.Rows[i].Cells[6].Value = total.ToString());
            //    }
            //    int sum = 0;
            //    for (int k = 0; k < dataGridView2.Rows.Count; k++)
            //    {
            //        sum += Convert.ToInt32(dataGridView2.Rows[k].Cells[6].Value);
            //    }
            //    txtTotal.Text = (sum.ToString());

            //    double Total = Double.Parse(txtTotal.Text);
            //    txtSubTotal.Text = (Total - (Total * .12)).ToString();

            //    txtProductCode.Text = "";
            //    txtProductName.Text = "";
            //    txtBrandName.Text = "";
            //    txtDescription.Text = "";
            //    txtAddQty.Text = "";
            //    txtPrice.Text = "";

            //}
        }
        private void btnReturnItems_Click(object sender, EventArgs e)
        {
            if (dataGridView2.Rows.Count > 1)
            {
                if (dataGridView2.CurrentRow.Index == dataGridView2.Rows.Count - 1)
                {
                    MessageBox.Show("Please re-select rows.");
                }
                else
                {
                    dataGridView2.Rows.RemoveAt(dataGridView2.CurrentRow.Index);
                }
            }
            else
            {
                MessageBox.Show("No Record to delete.");
            }
        }

        private void dataGridView1_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
            {
                if (Convert.ToInt32(dataGridView1.Rows[i].Cells[4].Value) == Convert.ToInt32(dataGridView1.Rows[i].Cells[6].Value))
                {
                    dataGridView1.Rows[i].Cells[4].Style.BackColor = Color.Orange;
                }
                if (Convert.ToInt32(dataGridView1.Rows[i].Cells[4].Value) == Convert.ToInt32(dataGridView1.Rows[i].Cells[7].Value))
                {
                    dataGridView1.Rows[i].Cells[4].Style.BackColor = Color.Red;
                }
                else
                {
                    dataGridView1.Rows[i].Cells[4].Style.ForeColor = Color.Black;

                }
            }
        }

        private void txtChange_TextChanged(object sender, EventArgs e)
        {
            if (txtChange.Text.Length >= 2)
            {
                int acceptednumber = Convert.ToInt32(txtChange.Text);
                if (acceptednumber < 0)
                {
                    txtChange.Text = "0";

                }
                else
                {
                    txtChange.Text = txtBalance.Text;
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblDateTime.Text = DateTime.Now.ToString();
        }

        private void txtAddQty_TextChanged(object sender, EventArgs e)
        {
            
            if (System.Text.RegularExpressions.Regex.IsMatch(txtAddQty.Text, "[^0-9]"))
            {
                MessageBox.Show("Invalid Input, Numbers Only!");
                txtAddQty.Text.Remove(txtAddQty.Text.Length - 1);
                txtAddQty.Text = null;
            }
        }

        private void txtPhone_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txtPhone.Text, "[^0-9]"))
            {
                MessageBox.Show("Invalid Input, Numbers Only!");
                txtPhone.Text.Remove(txtPhone.Text.Length - 1);
                txtPhone.Text = null;
            }
        }

        private void txtFaxNo_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txtFaxNo.Text, "[^0-9]"))
            {
                MessageBox.Show("Invalid Input, Numbers Only!");
                txtFaxNo.Text.Remove(txtFaxNo.Text.Length - 1);
                txtFaxNo.Text = null;
            }
        }

        private void btnAddItems_Click(object sender, EventArgs e)
        {
            if (txtAddQty.Text == "")
            {
                MessageBox.Show("Please enter Quantity", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtAddQty.Focus();
                return;
            }
            if (Convert.ToInt32(txtAddQty.Text) <= Convert.ToInt32(txtQty.Text))
            {
                MessageBox.Show("The Quantity is Lower than the ReorderPoint");
            }
            else if (Convert.ToInt32(txtAddQty.Text) >= Convert.ToInt32(txtQuan.Text))
            {
                MessageBox.Show("Higher than Quantity");
            }
            else
            {
                int counter = 0;
                if (dataGridView2.Rows.Count > 1)
                {
                    while (counter != dataGridView2.Rows.Count - 1)
                    {
                        if (dataGridView2.Rows[counter].Cells[0].Value.ToString() == txtProductCode.Text)
                        {
                            MessageBox.Show("The Product is already in the list!");
                            return;
                        }
                        counter++;
                    }
                }
                if (txtProductCode.Text == "")
                {
                    MessageBox.Show("Please enter ProductNo", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                if (txtDescription.Text == "")
                {
                    MessageBox.Show("Please enter Description", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtDescription.Focus();
                    return;
                }
                if (txtPrice.Text == "")
                {
                    MessageBox.Show("Please enter UnitPrice", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtPrice.Focus();
                    return;
                }
                else
                {
                    dataGridView2.Rows.Add(txtProductCode.Text, txtProductName.Text, txtBrandName.Text, txtAddQty.Text, txtPrice.Text, txtDescription.Text);
                }

                for (int i = 0; i < dataGridView2.Rows.Count - 1; i++)
                {
                    int Quantity = Convert.ToInt32(dataGridView2.Rows[i].Cells[3].Value.ToString());
                    int UnitPrice = Convert.ToInt32(dataGridView2.Rows[i].Cells[4].Value.ToString());
                    int total = Quantity * UnitPrice;

                    total = Convert.ToInt32(dataGridView2.Rows[i].Cells[6].Value = total.ToString());
                }
                int sum = 0;
                for (int k = 0; k < dataGridView2.Rows.Count; k++)
                {
                    sum += Convert.ToInt32(dataGridView2.Rows[k].Cells[6].Value);
                }
                txtTotal.Text = (sum.ToString());

                double Total = Double.Parse(txtTotal.Text);
                txtSubTotal.Text = (Total - (Total * .12)).ToString();

                txtProductCode.Text = "";
                txtProductName.Text = "";
                txtBrandName.Text = "";
                txtDescription.Text = "";
                txtAddQty.Text = "";
                txtPrice.Text = "";
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

        private void txtSearch_TextChanged_1(object sender, EventArgs e)
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