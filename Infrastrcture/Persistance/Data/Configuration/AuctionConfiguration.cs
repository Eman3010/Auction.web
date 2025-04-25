using Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace Persistance.Data.Configuration
{
    public class Auctionconfiguration : IEntityTypeConfiguration<Auction>
    {
        public void Configure(EntityTypeBuilder<Auction> builder)
        {
            builder.HasOne(A => A.Item)
                  .WithOne(I => I.Auction)
                  .HasForeignKey<Auction>(A => A.ItemID);

            builder.HasOne(a => a.seller)
                  .WithMany(s => s.Auctions)
                  .HasForeignKey(a => a.sellerid);


            builder.HasOne(a => a.admin)
                   .WithMany(ad => ad.Auctions)
                   .HasForeignKey(a => a.adminid);



            builder.HasMany(a => a.Biddings)
              .WithOne(b => b.auction)
              .HasForeignKey(b => b.Auctionid);


            builder.Property(a => a.StartingPrice)
                   .HasColumnType("decimal(18,2)")
                   .IsRequired();

            builder.Property(a => a.CurrentPrice)
                   .HasColumnType("decimal(18,2)");
            



        }
    }
}
