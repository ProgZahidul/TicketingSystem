using CrystalDecisions.CrystalReports.Engine;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TicketingSystem.App_Data;

namespace TicketingSystem
{
    public partial class InvoiceListForm : Form
    {
        Repository repository = new Repository();
        public InvoiceListForm()
        {
            InitializeComponent();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
          var id = dataGridView1.SelectedRows[0].Cells["InvoiceId"].Value;

            if (Convert.ToInt32(id) > 0)
            {
                InvoiceEntryForm form = new InvoiceEntryForm();
                form.InvoiceId = Convert.ToInt32(id);

                form.Show();



            }
        }

        private void InvoiceListForm_Load(object sender, EventArgs e)
        {
            DataLoad();
        }

        private void DataLoad()
        {
            invoiceMasterBindingSource.DataSource = repository.GetInvoices();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnInvoiceListReport_Click(object sender, EventArgs e)
        {
            ReportDocument report = new ReportDocument();


            report.Load($"{Application.StartupPath}\\TicketInvoceReports\\CrystalReport1.rpt");

            if (report.IsLoaded)
            {


                report.SetDataSource(repository.GetReportData());

            }



            ReportViewForm form = new ReportViewForm();

            form.crystalReportViewer1.ReportSource = report;



            form.ShowDialog(this);
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            DataLoad();
        }
    }
}
