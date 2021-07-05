using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tickets.Domain.Identity;


namespace Tickets.Domain.DomainModels
{
    public class Order
    {
        public Guid Id { get; set; }

        public string UserId { get; set; }

        public TicketShopApplicationUser User { get; set; }

      //  public virtual ICollection<TicketInOrder> Tickets { get; set; }
        public virtual ICollection<TicketInOrder> Tickets { get; set; }
}
}
