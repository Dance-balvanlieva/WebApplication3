using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Tickets.Domain.DomainModels
{
    public class Tickets
    {
        public Guid Id { get; set; }
        [Required]
        public string TicketName { get; set; }
        [Required]

        public string TicketImage { get; set; }


        public string TicketDescription { get; set; }
        [Required]
        public int Price { get; set; }
        [Required]
        public int Rating { get; set; }
        public virtual ICollection<TicketsInShopCard> TicketsInShopCards { get; set; }
        public virtual IEnumerable<TicketInOrder> Orders { get; set; }
    }
}