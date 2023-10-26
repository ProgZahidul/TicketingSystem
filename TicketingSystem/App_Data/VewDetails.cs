using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketingSystem.App_Data
{
    internal class VewDetails
    {

        public int InvoiceId { get; set; }
        public DateTime InvoiceDate { get; set; }
        public string PassengerName { get; set; }
        public string PassengerAddress { get; set; }
        public string PhonNo { get; set; }
        public string ClassNmae { get; set; }
        public string RouteName { get; set; }
        public decimal UnitPrice { get; set; }
        public int Quantity { get; set; }
        public decimal ItemTotal => UnitPrice * Quantity;
    }
}
