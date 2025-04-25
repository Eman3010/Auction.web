using Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistance.Data.Configuration
{
    public class BiddingConfiguration : IEntityTypeConfiguration<Bidding>
    {
        public void Configure(EntityTypeBuilder<Bidding> builder)
        {
            builder.Property(b => b.BidTime)
                     .HasDefaultValueSql("GETDATE()")
                      .IsRequired();

            builder.Property(b => b.Amount)
                   .HasColumnType("decimal(18,2)");
                  

        }
    }
}
