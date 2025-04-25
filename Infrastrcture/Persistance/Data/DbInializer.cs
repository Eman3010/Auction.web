using Domain.Contracts;
using Domain.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Persistance.Data
{
    public class DbInializer(AuctionDbContext context) : IDbInializer
    {
        public async Task InializerAsync()
        {
            if ((await context.Database.GetAppliedMigrationsAsync()).Any())
            {
                await context.Database.MigrateAsync();
            }


            if (!context.Set<Buyer>().Any()) 
            {
               var data = await File.ReadAllTextAsync(@"D:\projectc#\Auction.web\Infrastrcture\Persistance\Data\Seeds\buyer.json");
                var objects=JsonSerializer.Deserialize<List<Buyer>>(data);
               
                if (objects is not null && objects.Any())
                {
                    context.Set<Buyer>().AddRange(objects);
                    await context.SaveChangesAsync();
                }

            }

            if (!context.Set<Admin>().Any())
            {
                var data = await File.ReadAllTextAsync(@"..\Infrastructure\Persistance\Data\Seeds\Admin.json");
                var objects = JsonSerializer.Deserialize<List<Admin>>(data);


                if (objects is not null && objects.Any())
                {
                    context.Set<Admin>().AddRange(objects);
                    await context.SaveChangesAsync();
                }

            }


            if (!context.Set<Seller>().Any())
            {
                var data = await File.ReadAllTextAsync(@"..\Persistance\Data\Seeds\Seller.json");
                var objects = JsonSerializer.Deserialize<List<Seller>>(data);


                if (objects is not null && objects.Any())
                {
                    context.Set<Seller>().AddRange(objects);
                    await context.SaveChangesAsync();
                }

            }

            if (!context.Set<Category>().Any())
            {
                var data = await File.ReadAllTextAsync(@"..\Infrastructure\Persistance\Data\Seeds\Category.json");
                var objects = JsonSerializer.Deserialize<List<Category>>(data);


                if (objects is not null && objects.Any())
                {
                    context.Set<Category>().AddRange(objects);
                    await context.SaveChangesAsync();
                }

            }

            if (!context.Set<Item>().Any())
            {
                var data = await File.ReadAllTextAsync(@"..\Infrastructure\Persistance\Data\Seeds\Item.json");
                var objects = JsonSerializer.Deserialize<List<Item>>(data);


                if (objects is not null && objects.Any())
                {
                    context.Set<Item>().AddRange(objects);
                    await context.SaveChangesAsync();
                }

            }

            if (!context.Set<Auction>().Any())
            {
                var data = await File.ReadAllTextAsync(@"..\Infrastructure\Persistance\Data\Seeds\Auction.json");
                var objects = JsonSerializer.Deserialize<List<Auction>>(data);


                if (objects is not null && objects.Any())
                {
                    context.Set<Auction>().AddRange(objects);
                    await context.SaveChangesAsync();
                }

            }

            if (!context.Set<Bidding>().Any())
            {
                var data = await File.ReadAllTextAsync(@"..\Infrastructure\Persistance\Data\Seeds\Bidding.json");
                var objects = JsonSerializer.Deserialize<List<Bidding>>(data);


                if (objects is not null && objects.Any())
                {
                    context.Set<Bidding>().AddRange(objects);
                    await context.SaveChangesAsync();
                }

            }

            if (!context.Set<BuyerPayment>().Any())
            {
                var data = await File.ReadAllTextAsync(@"..\Infrastructure\Persistance\Data\Seeds\buyerpayment.json");
                var objects = JsonSerializer.Deserialize<List<BuyerPayment>>(data);


                if (objects is not null && objects.Any())
                {
                    context.Set<BuyerPayment>().AddRange(objects);
                    await context.SaveChangesAsync();
                }

            }






        }
    }
}
