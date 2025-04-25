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
    public class BuyerPaymentConfiguration : IEntityTypeConfiguration<BuyerPayment>
    {
        public void Configure(EntityTypeBuilder<BuyerPayment> builder)
        {
            builder.HasKey(Bp => new { Bp.BuyerId, Bp.BiddingID });
        }
    }
}
