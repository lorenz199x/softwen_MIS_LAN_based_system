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
    public partial class frmCreateAccount : Form
    {
        SqlDataAdapter da;
        SqlCommand cmd;
        SqlConnection con;
        SqlDataReader rdr;
        ConnectionString cs = new ConnectionString();
        DataTable dt;
        DataSet ds;
        SqlCommandBuilder scbuild;

        public frmCreateAccount()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtName.Text == "")
                {
                    MessageBox.Show("Please enter Name", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtName.Focus();
                    return;
                }
                if (txtContact.Text == "")
                {
                    MessageBox.Show("Please enter Contact", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtContact.Focus();
                    return;
                }
                if (txtAddress.Text == "")
                {
                    MessageBox.Show("Please enter Address", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtAddress.Focus();
                    return;
                }
                if (txtUserName.Text == "")
                {
                    MessageBox.Show("Please enter UserName", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtUserName.Focus();
                    return;
                }
                if (cboUserType.Text == "")
                {
                    MessageBox.Show("Please choose UserType", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtUserName.Focus();
                    return;
                }
                if (txtPassword.Text == "")
                {
                    MessageBox.Show("Please enter Password", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtPassword.Focus();
                    return;
                }
                if ((txtPassword.TextLength < 5))
                {
                    MessageBox.Show("The New Password Should be of Atleast 5 Characters", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtPassword.Focus();
                    return;
                }
                else if ((txtPassword.Text != txtConfirmPassword.Text))
                {
                    MessageBox.Show("Password do not match", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtPassword.Text = "";
                    txtConfirmPassword.Text = "";
                    txtPassword.Focus();
                    return;
                }
                else if (txtEmail.Text == "")
                {
                    MessageBox.Show("Please enter Email", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtEmail.Focus();
                    return;
                }

                else
                {
                    
                    con = new SqlConnection(cs.DBConn);
                    con.Open();
                    string cb = "insert Into DbLogin(Name,Contact,Address,Email,UserName,Password,UserType) VALUES ('" + txtName.Text + "','"+ txtContact.Text + "','" + txtAddress.Text + "','" + txtEmail.Text + "','" + txtUserName.Text + "','" + txtPassword.Text + "','" + cboUserType.Text + "')";
                    cmd = new SqlCommand(cb);
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

                txtUserName.Text = null;
                txtPassword.Text = null;
                txtConfirmPassword.Text = null;
                txtEmail.Text = null;
                txtName.Text = null;
                txtContact.Text = null;
                txtAddress.Text = null;
                cboUserType.Text = null;

                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmMain main = new frmMain();
            main.ShowDialog();
        }

        private void txtContact_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txtContact.Text, "[^0-9]"))
            {
                MessageBox.Show("Invalid Input, Numbers Only!");
                txtContact.Text.Remove(txtContact.Text.Length - 1);
                txtContact.Text = null;
            }
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
            //if (System.Text.RegularExpressions.Regex.IsMatch(txtEmail.Text.ToString(), "[a-z0-9A-z]@[a-zA-z0-9 ]*[.]"))
            //{
            //    MessageBox.Show("Invalid Email Format");
            //    txtEmail.Text.Remove(txtEmail.Text.Length - 1);
            //    //txtEmail.Text = null;
            //}

            //string s = "[a-z0-9A-z]@[a-zA-z0-9 ]*[.]";
            //string s1 = txtEmail.Text.ToString();
            //Match aa = Regex.Match(s1, s);
            //if (aa.Success)
            //{
            //    errorProvider1.SetError(textBox4, "");
            //}
            //else
            //{
            //    errorProvider1.SetError(textBox4, "mail id not in correct format");
            //}

            //if (txtEmail.Text.Contains("@"))
            //{
                
            //}
            //else if (txtEmail.Text.Contains(".com"))
            //{
            //    MessageBox.Show("Valid Email");
            //}
            //else
            //{
            //    //MessageBox.Show("Invalid Email Format");
            //    //txtEmail.Text = null;
            //}
        }

        private void frmCreateAccount_Load(object sender, EventArgs e)
        {

        }
    }
}
