using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tickets.Domain.DomainModels;

namespace Tickets.Domain.DTO
{
    public class ShoppingCartDto
    {
        public List<TicketsInShopCard> Tikets{ get; set; }
        public double TotalPrice { get; set; }
    }
}
