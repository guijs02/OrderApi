using Microsoft.EntityFrameworkCore;
using OrderApi.Context;
using OrderApi.Core.Interfaces.Repositories;
using OrderApi.Core.Interfaces.Services;
using OrderApi.Repositories;
using OrderApi.Services;

namespace OrderApi.Extension
{
    public static class BuildExtension
    {
        public static void AddDocumentation(this WebApplicationBuilder builder)
        {
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen(s =>
            {
                s.CustomSchemaIds(n => n.FullName);
            });
        }
        public static void AddServices(this WebApplicationBuilder builder)
        {
            builder.Services.AddScoped<IOrderService, OrderService>();
            builder.Services.AddScoped<IOrderRepository, OrderRepository>();
        }
        public static void AddDataContexts(this WebApplicationBuilder builder)
        {
            builder
                .Services
                .AddDbContext<AppDbContext>(
                 options =>
                 {
                     options.UseSqlServer(builder.Configuration.GetConnectionString("Connection"));
                 });
        }
    }
}
