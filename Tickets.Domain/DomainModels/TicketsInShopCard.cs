    using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Tickets.Domain.DomainModels
{
    public class TicketsInShopCard
    {
        public Guid TicketID { get; set; }
        public Tickets Tiket { get; set; }

        public Guid ShopCardID { get; set; }
        public ShopCard shoppingcard { get; set; }
        public int Quantity { get; set; }
    }
}
