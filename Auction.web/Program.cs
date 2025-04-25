
using Domain.Contracts;
using Microsoft.EntityFrameworkCore;
using Persistance.Data;

namespace Auction.web
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddAuthorization();

            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();
            builder.Services.AddDbContext<AuctionDbContext>(options =>
            {
             var ConnectionString = builder.Configuration.GetConnectionString("AuctionDbContext");
              options.UseSqlServer(ConnectionString);
            });
            builder.Services.AddScoped<IDbInializer, DbInializer>();
            var app = builder.Build();

            using var scope = app.Services.CreateScope();
            var dbInalizer = scope.ServiceProvider.GetRequiredService<IDbInializer>();
            await  dbInalizer.InializerAsync();
            

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();

           

            app.Run();
        }
    }
}
