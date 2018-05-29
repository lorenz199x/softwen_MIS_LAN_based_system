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
    public partial class frmProductPriceListReport : Form
    {
        

        public frmProductPriceListReport()
        {
            InitializeComponent();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            SqlConnection con;
            ConnectionString cs = new ConnectionString();
            SqlCommand cmd;
            //frmProductPriceListReport sr = new frmProductPriceListReport();
            PPLReport rpt = new PPLReport();
            SqlDataAdapter myDA = new SqlDataAdapter();
            softwenDS myDS = new softwenDS();

            //The report you created.
            cmd = new SqlCommand();
            //The DataSet you created.
            con = new SqlConnection(cs.DBConn);
            cmd.Connection = con;
            cmd.CommandText = "SELECT * from Dbinventory where Category='" + cboScategory.Text + "'";
            cmd.CommandType = CommandType.Text;
            myDA.SelectCommand = cmd;
            myDA.Fill(myDS, "Dbinventory");
            // myDA.Fill(myDS, "ProductCode");
            rpt.SetDataSource(myDS);
            crystalReportViewer1.ReportSource = rpt;
            //sr.Show();
        }
    }
}
