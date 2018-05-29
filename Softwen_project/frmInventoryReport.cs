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
    public partial class frmInventoryReport : Form
    {
        SqlConnection con;
        ConnectionString cs = new ConnectionString();
        SqlCommand cmd;
        SqlDataAdapter myDA = new SqlDataAdapter();
        softwenDS myDS = new softwenDS();
        InventoryReport rpt = new InventoryReport();

        public frmInventoryReport()
        {
            InitializeComponent();
        }

        private void frmInventoryReport_Load(object sender, EventArgs e)
        {

        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            
            
            //The report you created.
            cmd = new SqlCommand();
            //The DataSet you created.
            con = new SqlConnection(cs.DBConn);
            cmd.Connection = con;
            cmd.CommandText = "SELECT * from Dbinventory where ProductCode='" + txtProductCode.Text + "'";
            cmd.CommandType = CommandType.Text;
            myDA.SelectCommand = cmd;
            myDA.Fill(myDS, "Dbinventory");
            rpt.SetDataSource(myDS);
            crystalReportViewer1.ReportSource = rpt;
        }
    }
}
