using Infrastructure;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.OpenApi.Models;
//using Replication.Application.Common.Interfaces;
//using Replication.Application.Services;
namespace Replication;
    public static class StartupExtensions
    {
    public static WebApplication ConfigureServices(this WebApplicationBuilder builder)
    {

        builder.Services.AddControllers();
        builder.Services.AddEndpointsApiExplorer();
        builder.Services.AddSwaggerGen();

        builder.Services.AddDbContext<ReplicationDB>(options =>
        {
            options.UseSqlServer(builder.Configuration.GetConnectionString("ReplicationDB"));
        });

        builder.Services.AddInfrastructureServices(builder.Configuration);

        return builder.Build();
    }
}
