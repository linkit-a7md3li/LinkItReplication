using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Configurations;

public class SL_InvoiceConfiguration : IEntityTypeConfiguration<SL_Invoice>
{
    public void Configure(EntityTypeBuilder<SL_Invoice> builder)
    {
        builder.ToTable("SL_Invoice");

        builder.HasKey(x => x.SLInvoiceId);

        builder.Property(x => x.InvoiceCode)
            .HasMaxLength(20)
            .IsRequired();

        builder.Property(x => x.Notes).HasColumnType("nvarchar(max)");
        builder.Property(x => x.Shipping).HasColumnType("nvarchar(max)");
        builder.Property(x => x.PurchaseOrderNo).HasColumnType("nvarchar(max)");
        builder.Property(x => x.AttnMr).HasMaxLength(200);
        builder.Property(x => x.DriverName).HasMaxLength(100);
        builder.Property(x => x.VehicleNumber).HasMaxLength(100);
        builder.Property(x => x.Destination).HasMaxLength(100);
        builder.Property(x => x.ScaleWeightSerial).HasMaxLength(50);
        builder.Property(x => x.uuid).HasMaxLength(50);
        builder.Property(x => x.Estatus).HasMaxLength(50);
        builder.Property(x => x.issuerId).HasColumnType("nvarchar(max)");
        builder.Property(x => x.longId).HasColumnType("nvarchar(max)");
        builder.Property(x => x.Expenses).HasColumnType("decimal(20,6)");
        builder.Property(x => x.DiscountRatio).HasColumnType("decimal(20,6)");
        builder.Property(x => x.DiscountValue).HasColumnType("decimal(20,6)");
        builder.Property(x => x.Net).HasColumnType("decimal(20,6)");
        builder.Property(x => x.Paid).HasColumnType("decimal(20,6)");
        builder.Property(x => x.Remains).HasColumnType("decimal(20,6)");
        builder.Property(x => x.PayAcc2_Paid).HasColumnType("decimal(20,6)");
        builder.Property(x => x.ExpensesRatio).HasColumnType("decimal(20,6)");
        builder.Property(x => x.TotalCostPrice).HasColumnType("decimal(20,6)");
        builder.Property(x => x.DeductTaxRatio).HasColumnType("decimal(20,6)");
        builder.Property(x => x.DeductTaxValue).HasColumnType("decimal(20,6)");
        builder.Property(x => x.AddTaxRatio).HasColumnType("decimal(20,6)");
        builder.Property(x => x.AddTaxValue).HasColumnType("decimal(20,6)");
        builder.Property(x => x.CrncRate).HasColumnType("decimal(20,6)");
        builder.Property(x => x.CustomTaxValue).HasColumnType("decimal(20,6)");
        builder.Property(x => x.CustomTaxRatio).HasColumnType("decimal(20,6)");
        builder.Property(x => x.AdvancePaymentRatio).HasColumnType("decimal(20,6)");
        builder.Property(x => x.AdvancePaymentValue).HasColumnType("decimal(20,6)");
        builder.Property(x => x.RetentionRatio).HasColumnType("decimal(20,6)");
        builder.Property(x => x.RetentionValue).HasColumnType("decimal(20,6)");
        builder.Property(x => x.ShiftAdd).HasColumnType("decimal(20,6)");
        builder.Property(x => x.HandingValue).HasColumnType("decimal(18,8)");
        builder.Property(x => x.TransportationValue).HasColumnType("decimal(18,8)");
    }
}
