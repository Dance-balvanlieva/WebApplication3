using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tickets.Domain.DomainModels;


namespace Tickets.Domain.DTO
{
    public class AddToShoppingCardDto
    {
        public TicketsInShopCard SelectedTicket { get; set; }
       
        public Guid TicketId { get; set; }
        public int Quantity { get; set; }
    }
}
