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
    public partial class frmNewSupplier : Form
    {
        SqlDataAdapter da;
        SqlCommand cmd;
        SqlConnection con;
        SqlDataReader rdr;
        ConnectionString cs = new ConnectionString();
        DataTable dt;
        DataSet ds;

        public frmNewSupplier()
        {
            InitializeComponent();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtSupplierID.Text == "")
                {
                    MessageBox.Show("Please enter SupplierID", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtSupplierID.Focus();
                    return;
                }
                if (txtCompany.Text == "")
                {
                    MessageBox.Show("Please enter Company", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtCompany.Focus();
                    return;
                }
                if (txtContactPerson.Text == "")
                {
                    MessageBox.Show("Please enter ContactPerson", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtContactPerson.Focus();
                    return;
                }
                if (txtPhone.Text == "")
                {
                    MessageBox.Show("Please enter Phone.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtPhone.Focus();
                    return;
                }
                if (txtBusAdd.Text == "")
                {
                    MessageBox.Show("Please enter BusAdd", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtBusAdd.Focus();
                    return;
                }
                if (txtFaxNo.Text == "")
                {
                    MessageBox.Show("Please enter FaxNo", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtFaxNo.Focus();
                    return;
                }
                else
                {
                    con = new SqlConnection(cs.DBConn);
                    con.Open();
                    string aa = "insert into DbNewSupplier (SupplierID, Company, ContactPerson, Phone,FaxNo , BusAdd) VALUES ('" + txtSupplierID.Text + "','" + txtCompany.Text + "','" + txtContactPerson.Text + "','" + txtPhone.Text + "','" + txtFaxNo.Text + "','" + txtBusAdd.Text + "')";
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

                cmd = new SqlCommand();
                cmd.Connection = con;
                string query = "Select * from DbNewSupplier";
                cmd.CommandText = query;

                da = new SqlDataAdapter(cmd);
                dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtSupplierID.Text = null;
            txtCompany.Text = null;
            txtContactPerson.Text = null;
            txtPhone.Text = null;
            txtBusAdd.Text = null;
            txtFaxNo.Text = null;

            con = new SqlConnection(cs.DBConn);
            string inv = "select max(SupplierID) + 1 from DbNewSupplier";
            cmd = new SqlCommand(inv, con);

            con.Open();
            cmd.ExecuteNonQuery();

            rdr = cmd.ExecuteReader(0);

            while (rdr.Read())
            {
                int n = rdr.GetInt32(0);
                txtSupplierID.Text = "0" + n.ToString();
            }
            con.Close();
        }

        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //try
            //{
                if (txtSupplierID.Text == "")
                {
                    MessageBox.Show("Please enter SupplierID", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtSupplierID.Focus();
                    return;
                }
                if (txtCompany.Text == "")
                {
                    MessageBox.Show("Please enter Company", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtCompany.Focus();
                    return;
                }
                if (txtContactPerson.Text == "")
                {
                    MessageBox.Show("Please enter ContactPerson", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtContactPerson.Focus();
                    return;
                }
                if (txtPhone.Text == "")
                {
                    MessageBox.Show("Please enter Phone.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtPhone.Focus();
                    return;
                }
                if (txtBusAdd.Text == "")
                {
                    MessageBox.Show("Please enter BusAdd", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtBusAdd.Focus();
                    return;
                }
                if (txtFaxNo.Text == "")
                {
                    MessageBox.Show("Please enter FaxNo", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtFaxNo.Focus();
                    return;
                }
                else
                {
                    con = new SqlConnection(cs.DBConn);
                    string cb = "update DbNewSupplier set SupplierID='" + txtSupplierID.Text + "', Company='" + txtCompany.Text + "', ContactPerson='" + txtContactPerson.Text + "', Phone='" + txtPhone.Text + "', FaxNo='" + txtFaxNo.Text + "', BusAdd='" + txtBusAdd.Text + "'where SupplierID='" + txtSupplierID.Text + "';";
                    cmd = new SqlCommand(cb, con);

                    con.Open();
                    rdr = cmd.ExecuteReader();
                    MessageBox.Show("Successfully Updated");
                    while (rdr.Read())
                    {
                    }
                }
                txtSupplierID.Text = null;
                txtCompany.Text = null;
                txtContactPerson.Text = null;
                txtPhone.Text = null;
                txtFaxNo.Text = null;
                txtBusAdd.Text = null;
                con.Close();

                cmd = new SqlCommand();
                cmd.Connection = con;
                string query = "Select * from DbNewSupplier";
                cmd.CommandText = query;

                da = new SqlDataAdapter(cmd);
                dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;

                con.Close();
           // }
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                
                if (MessageBox.Show("Do you want to delete this record?", Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (MessageBox.Show("Are you sure?", Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        con = new SqlConnection(cs.DBConn);
                        con.Open();
                        cmd = new SqlCommand();
                        cmd.Connection = con;
                        string cb = "delete from DbNewSupplier where SupplierID = '" + txtSupplierID.Text + "'";
                        cmd.CommandText = cb;
                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Data Deleted");
                        con.Close();

                        txtSupplierID.Text = null;
                        txtCompany.Text = null;
                        txtContactPerson.Text = null;
                        txtPhone.Text = null;
                        txtFaxNo.Text = null;
                        txtBusAdd.Text = null;
                    }
                }
                cmd = new SqlCommand();
                cmd.Connection = con;
                string query = "Select * from DbNewSupplier";
                cmd.CommandText = query;

                da = new SqlDataAdapter(cmd);
                dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;

                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cancelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtSupplierID.Text = null;
            txtCompany.Text = null;
            txtContactPerson.Text = null;
            txtPhone.Text = null;
            txtFaxNo.Text = null;
            txtBusAdd.Text = null;
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
                txtSupplierID.Text = row.Cells[0].Value.ToString();
                txtCompany.Text = row.Cells[1].Value.ToString();
                txtContactPerson.Text = row.Cells[2].Value.ToString();
                txtPhone.Text = row.Cells[3].Value.ToString();
                txtFaxNo.Text = row.Cells[4].Value.ToString();
                txtBusAdd.Text = row.Cells[5].Value.ToString();
            }
        }

        private void frmNewSupplier_Load(object sender, EventArgs e)
        {
            con = new SqlConnection(cs.DBConn);
            string inv = "select max(SupplierID) + 1 from DbNewSupplier";
            cmd = new SqlCommand(inv, con);

            con.Open();
            cmd.ExecuteNonQuery();

            rdr = cmd.ExecuteReader(0);

            while (rdr.Read())
            {
                int n = rdr.GetInt32(0);
                txtSupplierID.Text = "0" + n.ToString();
            }
            con.Close();

            cmd = new SqlCommand();
            cmd.Connection = con;
            string query = "Select * from DbNewSupplier";
            cmd.CommandText = query;

            da = new SqlDataAdapter(cmd);
            dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
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

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Hide();
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

       
    }
}
