using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicketingSystem.App_Data
{
    internal class Repository
    {

        string connection = $"server=(Localdb)\\MSSQLlocaldb; AttachDbFilename= {Application.StartupPath}\\App_Data\\MyDatabase.mdf; trusted_connection=true;";
        public Repository()
        {


        }
        public List<InvoiceMaster> GetInvoices()
        {


            List<InvoiceMaster> invoices = new List<InvoiceMaster>();

            using (SqlConnection con = new SqlConnection(connection))
            {
                var cmd = con.CreateCommand();

                cmd.CommandText = "select * from InvoiceMaster";

                SqlDataAdapter sda = new SqlDataAdapter(cmd);

                DataSet ds = new DataSet();
                con.Open();
                sda.Fill(ds);


                if (ds.Tables.Count > 0)
                {



                    foreach (DataRow dr in ds.Tables[0].Rows)
                    {
                        InvoiceMaster invoice = new InvoiceMaster();
                        invoice.InvoiceId = Convert.ToInt32(dr["InvoiceId"]);
                        invoice.InvoiceDate = Convert.ToDateTime(dr["InvoiceDate"]);
                        invoice.PassengerName = dr["PassengerName"].ToString();
                        invoice.PhonNo = dr["PhonNo"].ToString();
                        invoice.PassengerAddress = dr["PassengerAddress"]?.ToString();
                        invoices.Add(invoice);
                    }

                }

            }

            return invoices;
        }
        public InvoiceMaster GetInvoice(int id)
        {


            InvoiceMaster invoice = new InvoiceMaster();

            using (SqlConnection con = new SqlConnection(connection))
            {
                var cmd = con.CreateCommand();

                cmd.CommandText = $"select * from InvoiceMaster where InvoiceId={id}; select * from InvoiceDetails where InvoiceId={id};";

                SqlDataAdapter sda = new SqlDataAdapter(cmd);

                DataSet ds = new DataSet();
                con.Open();
                sda.Fill(ds);


                if (ds.Tables.Count > 0)
                {

                    var row = ds.Tables[0].Rows[0];

                    invoice.InvoiceId = Convert.ToInt32(row["InvoiceId"]);
                    invoice.InvoiceDate = Convert.ToDateTime(row["InvoiceDate"]);
                    invoice.PassengerName = row["PassengerName"].ToString();
                    invoice.PhonNo = row["PhonNo"].ToString();
                    invoice.PassengerAddress = row["PassengerAddress"]?.ToString();




                    foreach (DataRow dr in ds.Tables[1].Rows)
                    {
                        InvoiceDetails item = new InvoiceDetails();
                        item.InvoiceId = Convert.ToInt32(row["InvoiceId"]);
                        item.ClassNmae = dr["ClassNmae"].ToString();
                        item.Quantity = Convert.ToInt32(dr["Quantity"]);
                        item.UnitPrice = Convert.ToDecimal(dr["UnitPrice"]);

                        invoice.ItemList.Add(item);
                    }

                }

            }

            return invoice;
        }
        public int SaveInvoice(InvoiceMaster Invoice)
        {
            int rowNo = 0;
            using (SqlConnection con = new SqlConnection(connection))
            {
                con.Open();
                var tran = con.BeginTransaction();
                var cmd = con.CreateCommand();

                cmd.Transaction = tran;



                try
                {


                    cmd.CommandText = "select isnull(max(invoiceid), 0) + 1 as InvoiceId from InvoiceMaster ";


                    string Invoiceid = cmd.ExecuteScalar()?.ToString();



                    cmd.CommandText = $"INSERT INTO [dbo].[InvoiceMaster]([InvoiceId],[InvoiceDate],[PassengerName],[PassengerAddress],[PhonNo]) VALUES (  {Invoiceid}, '{Invoice.InvoiceDate.ToString("dd-MMM-yyyy")}', '{Invoice.PassengerName}', '{Invoice.PassengerAddress}', '{Invoice.PhonNo}'   )";


                    rowNo = cmd.ExecuteNonQuery();


                    if (rowNo > 0)
                    {

                        foreach (var item in Invoice.ItemList)
                        {
                            cmd.CommandText = $"INSERT INTO [dbo].[InvoiceDetails] ([InvoiceId] ,[ClassNmae] ,[UnitPrice] ,[Quantity])  VALUES ({Invoiceid} ,'{item.ClassNmae}' , '{item.UnitPrice}' , '{item.Quantity}')";


                            int r1 = cmd.ExecuteNonQuery();
                        }

                    }

                    tran.Commit();
                }
                catch (SqlException e)
                {

                    tran.Rollback();
                    MessageBox.Show(e.Message);
                    return 0;
                }
            }
            return rowNo;
        }


        public int UpdateInvoice(InvoiceMaster Invoice)
        {
            int rowNo = 0;
            using (SqlConnection con = new SqlConnection(connection))
            {
                con.Open();
                var tran = con.BeginTransaction();
                var cmd = con.CreateCommand();

                cmd.Transaction = tran;



                try
                {

                    cmd.CommandText = $"UPDATE [dbo].[InvoiceMaster]   SET [InvoiceDate] =  '{Invoice.InvoiceDate.ToString("dd-MMM-yyyy")}', [PassengerName] = '{Invoice.PassengerName}',[PassengerAddress] = '{Invoice.PassengerAddress}',[PhonNo] = '{Invoice.PhonNo}' where InvoiceId = {Invoice.InvoiceId}";

                    rowNo = cmd.ExecuteNonQuery();

                    if (rowNo > 0)
                    {
                        cmd.CommandText = $"delete from [dbo].[InvoiceDetails] where InvoiceId = {Invoice.InvoiceId}";


                        if (cmd.ExecuteNonQuery() >= 0)
                        {
                            foreach (var item in Invoice.ItemList)
                            {
                                cmd.CommandText = $"INSERT INTO [dbo].[InvoiceDetails] ([InvoiceId] ,[ClassNmae] ,[UnitPrice] ,[Quantity])  VALUES ({Invoice.InvoiceId} ,'{item.ClassNmae}' , '{item.UnitPrice}' , '{item.Quantity}')";


                                cmd.ExecuteNonQuery();
                            }
                        }



                    }

                    tran.Commit();
                }
                catch (SqlException e)
                {

                    tran.Rollback();
                    MessageBox.Show(e.Message);
                    return 0;
                }
            }
            return rowNo;
        }

        public int DeleteInvoice(string InvoiceId)
        {
            int rowNo = 0;
            using (SqlConnection con = new SqlConnection(connection))
            {
                con.Open();
                var tran = con.BeginTransaction();
                var cmd = con.CreateCommand();

                cmd.Transaction = tran;




                try
                {

                    cmd.CommandText = $"delete from [dbo].[InvoiceMaster]   where InvoiceId = {InvoiceId}";

                    rowNo = cmd.ExecuteNonQuery();

                    tran.Commit();

                }
                catch (SqlException e)
                {
                    tran.Rollback();
                    MessageBox.Show(e.Message);
                    return 0;
                }
            }
            return rowNo;
        }

        internal List<VewDetails> GetReportData()
        {
            List<VewDetails> invoices = new List<VewDetails>();

            using (SqlConnection con = new SqlConnection(connection))
            {
                var cmd = con.CreateCommand();


                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * FROM [dbo].[View_1]";



                DataTable dt = new DataTable();
                con.Open();



                dt.Load(cmd.ExecuteReader());




                foreach (DataRow dr in dt.Rows)
                {
                    VewDetails invoice = new VewDetails();
                    invoice.InvoiceId = Convert.ToInt32(dr["InvoiceId"]);
                    invoice.InvoiceDate = Convert.ToDateTime(dr["InvoiceDate"]);
                    invoice.PassengerName = dr["PassengerName"].ToString();
                    invoice.PhonNo = dr["PhonNo"].ToString();
                    invoice.PassengerAddress = dr["PassengerAddress"]?.ToString();
                    invoice.ClassNmae = dr["ClassNmae"]?.ToString();
                    invoice.UnitPrice = Convert.ToDecimal(dr["UnitPrice"]);
                    invoice.Quantity = Convert.ToInt32(dr["Quantity"]);

                    invoices.Add(invoice);
                }



            }

            return invoices;
        }
    }
}
