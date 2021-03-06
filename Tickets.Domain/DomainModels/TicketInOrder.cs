using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Tickets.Domain.DomainModels
{
    public class TicketInOrder
    {
        public Guid TicketId { get; set; }

        public Tickets SelectedTicket { get; set; }

        public Guid OrderId { get; set; }

        public Order UserOrder { get; set; }
    }
}
