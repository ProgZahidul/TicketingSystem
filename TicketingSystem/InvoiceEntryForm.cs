using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using TicketingSystem.App_Data;

namespace TicketingSystem
{
    public partial class InvoiceEntryForm : Form
    {

        Repository repository = new Repository();
        public int InvoiceId { get; set; } = 0;
        public InvoiceEntryForm()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void InvoiceEntryForm_Load(object sender, EventArgs e)
        {
            DataLoad();
        }

        private void DataLoad()
        {
            if(InvoiceId > 0)
            {
                var invoice = repository.GetInvoice(InvoiceId);


                txtId.Text = invoice.InvoiceId.ToString();

                InvocieDate.Value = invoice.InvoiceDate;
                textPhoneNo.Text = invoice.PhonNo;
                textName.Text = invoice.PassengerName;
                txtAddress.Text = invoice.PassengerAddress;
                




                invoiceDetailsBindingSource.DataSource = invoice.ItemList;


            }
        }


        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {

                InvoiceMaster invoice = new InvoiceMaster();

                if (txtId.Text.Length > 0)
                    invoice.InvoiceId = Convert.ToInt32(txtId.Text);

                invoice.InvoiceDate = InvocieDate.Value;
                invoice.PhonNo = textPhoneNo.Text;
                invoice.PassengerName = textName.Text;
                invoice.PassengerAddress = txtAddress.Text;





                foreach (DataGridViewRow item in dataGridView1.Rows)
                {

                    if (item.IsNewRow) continue;

                    InvoiceDetails invoiceDetails = new InvoiceDetails();

                    invoiceDetails.ClassNmae = item.Cells[0].Value.ToString();
                    invoiceDetails.UnitPrice = Convert.ToDecimal(item.Cells[1].Value);
                    invoiceDetails.Quantity = Convert.ToInt32(item.Cells[2].Value);
                    invoice.ItemList.Add(invoiceDetails);
                }

                if (txtId.Text.Length > 0)
                {

                    int rw = repository.UpdateInvoice(invoice);


                    if (rw > 0)
                    {
                        MessageBox.Show("Data updated successfully");
                    }
                }
                else
                {
                    int rw = repository.SaveInvoice(invoice);


                    if (rw > 0)
                    {
                        MessageBox.Show("Data saved successfully");
                    }
                }


                ResetForm();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void AddressBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtId_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ResetForm();
        }

        private void ResetForm()
        {
            InvoiceId = 0;
            txtId.Text = null;
            InvocieDate.Value = DateTime.Today;
            txtAddress.Text = null;
            textName.Text = null;
            textPhoneNo.Text = null;
            invoiceDetailsBindingSource.DataSource = null;
            InvocieDate.Focus();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (txtId.Text.Length > 0)
            {

                var dialog = MessageBox.Show("Delete record", "Delete", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

                if (dialog == DialogResult.OK)
                {
                    int rw = repository.DeleteInvoice(txtId.Text);


                    if (rw > 0)
                    {
                        MessageBox.Show("Data deleted successfully");
                    }
                }

            }
        }

        private void textName_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_2(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
