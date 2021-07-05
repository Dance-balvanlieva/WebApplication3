using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using WebApplication3.Models.Domain;
using WebApplication3.Models.Identity;

namespace WebApplication3.Data
{
    public class ApplicationDbContext : IdentityDbContext<TicketShopApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public virtual DbSet<Tickets> Tikets { get; set; }
        public virtual DbSet<ShopCard> ShopCards { get; set; }
        public virtual DbSet<TicketsInShopCard> GetTicketsInShopCards { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<Tickets>()
                .Property(m => m.Id)
                .ValueGeneratedOnAdd();

            builder.Entity<ShopCard>()
                .Property(m => m.Id)
                .ValueGeneratedOnAdd();

            builder.Entity<TicketsInShopCard>()
                .HasKey(m => new { m.TicketID, m.ShopCardID });

            builder.Entity<TicketsInShopCard>()
                .HasOne(m => m.Tiket)
                .WithMany(m => m.TicketsInShopCards)
                .HasForeignKey(m => m.ShopCardID);

            builder.Entity<TicketsInShopCard>()
                .HasOne(m => m.shoppingcard)
                .WithMany(m => m.Tickets)
                .HasForeignKey(m => m.TicketID);

            builder.Entity<ShopCard>()
                .HasOne<TicketShopApplicationUser>(m => m.Owner)
                .WithOne(m => m.UserCard)
                .HasForeignKey<ShopCard>(m => m.OwnerId);


            builder.Entity<TicketInOrder>()
                 .HasKey(z => new { z.TicketId, z.OrderId });

            builder.Entity<TicketInOrder>()
                .HasOne(z => z.SelectedTicket)
                .WithMany(z => z.Orders)
                .HasForeignKey(z => z.TicketId);

            builder.Entity<TicketInOrder>()
                .HasOne(z => z.UserOrder)
                .WithMany(z => z.Tickets)
                .HasForeignKey(z => z.OrderId);
        }
    }
}
