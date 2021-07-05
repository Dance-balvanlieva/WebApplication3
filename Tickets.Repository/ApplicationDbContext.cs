
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using Tickets.Domain.DomainModels;
using Tickets.Domain.Identity;

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
                .WithMany(m => m.TicketsInShopCards)
                .HasForeignKey(m => m.TicketID);

            builder.Entity<ShopCard>()
                .HasOne<TicketShopApplicationUser>(m => m.Owner)
                .WithOne(m => m.UserCard)
                .HasForeignKey<ShopCard>(m => m.OwnerId);
        }
    }
}
