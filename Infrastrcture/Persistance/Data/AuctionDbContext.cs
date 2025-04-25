using Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace Persistance.Data
{
    public class AuctionDbContext:DbContext
    {
        public AuctionDbContext (DbContextOptions options) : base(options) { }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

            

        }

        public DbSet<Admin> Admins { get; set; }
        public DbSet<Auction> Auctions { get; set; }
        public DbSet<Bidding> Bids { get; set; }
        public DbSet<Buyer> Buyer { get; set; }
        public DbSet<Category> Category { get; set; }
        public DbSet<Item> Item { get; set; }
        public DbSet<Seller> Seller { get; set; }

       public DbSet<BuyerPayment> buyerPayments { get; set; }
    }
}
