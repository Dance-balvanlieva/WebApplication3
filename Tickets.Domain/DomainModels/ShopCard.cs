using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tickets.Domain.Identity;

namespace Tickets.Domain.DomainModels
{
    public class ShopCard : BaseEntity
    {
        public readonly object TicketsInShopCards;

        //  public Guid Id { get; set; }
        public string OwnerId { get; set; }
        public TicketShopApplicationUser Owner { get; set; }
        public virtual ICollection<TicketsInShopCard> Tickets{ get; set; }
    }
}
