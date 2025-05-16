using Microsoft.EntityFrameworkCore;
using Domain.Entities;
using Infrastructure.Data.Configurations;

namespace Infrastructure.Data;

public class ReplicationDB : DbContext
{
    public ReplicationDB(DbContextOptions<ReplicationDB> options) : base(options)
    {
    }

    public DbSet<SL_Invoice> SLInvoices { get; set; } = default!;

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.ApplyConfigurationsFromAssembly(typeof(SL_InvoiceConfiguration).Assembly);
    }
}
