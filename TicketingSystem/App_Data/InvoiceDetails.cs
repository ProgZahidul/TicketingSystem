using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketingSystem.App_Data
{
    internal class InvoiceDetails
    {
        public int InvoiceId { get; set; }
        public string ClassNmae { get; set; }
        public string RouteName { get; set; }
        public decimal UnitPrice { get; set; }
        public int Quantity { get; set; }
        public decimal ItemTotal => UnitPrice * Quantity;

    }
}
