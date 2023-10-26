using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketingSystem.App_Data
{
    internal class InvoiceMaster
    {
        public int InvoiceId { get; set; }
        public DateTime InvoiceDate { get; set; }
        public string PassengerName { get; set; }
        public string PassengerAddress { get; set; }
        public string PhonNo { get; set; }
        public List<InvoiceDetails> ItemList { get; set; } = new List<InvoiceDetails>();


    }
}
