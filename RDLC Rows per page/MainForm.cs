using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RDLC_Rows_per_page
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'solveEverythingDBDataSet.tblItems' table. You can move, or remove it, as needed.
            this.tblItemsTableAdapter.Fill(this.solveEverythingDBDataSet.tblItems);
            reportViewer1.ProcessingMode = Microsoft.Reporting.WinForms.ProcessingMode.Local;
            reportViewer1.LocalReport.ReportPath = Application.StartupPath + @"\Items Printout.rdlc";
            reportViewer1.LocalReport.DataSources.Add(new Microsoft.Reporting.WinForms.ReportDataSource("ItemsDataset", solveEverythingDBDataSet.Tables[0]));
            reportViewer1.RefreshReport();
        }
    }
}
