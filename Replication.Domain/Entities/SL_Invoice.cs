namespace Domain.Entities;

public class SL_Invoice
{

    public int SLInvoiceId { get; set; }
    public string InvoiceCode { get; set; } = string.Empty;
    public int StoreId { get; set; }
    public int CustomerId { get; set; }
    public DateTime InvoiceDate { get; set; }
    public string? Notes { get; set; }
    public decimal Expenses { get; set; }
    public decimal DiscountRatio { get; set; }
    public decimal DiscountValue { get; set; }
    public decimal Net { get; set; }
    public decimal Paid { get; set; }
    public decimal Remains { get; set; }
    public bool? PayMethod { get; set; }
    public int UserId { get; set; }
    public int JornalId { get; set; }
    public int? DrawerAccountId { get; set; }
    public decimal TaxValue { get; set; }
    public bool? IsArchived { get; set; }
    public int? SalesEmpId { get; set; }
    public int? PayAccountId2 { get; set; }
    public decimal? PayAcc2_Paid { get; set; }
    public DateTime? DeliverDate { get; set; }
    public string? Shipping { get; set; }
    public string? PurchaseOrderNo { get; set; }
    public DateTime? DueDate { get; set; }
    public string? AttnMr { get; set; }
    public decimal ExpensesRatio { get; set; }
    public decimal TotalCostPrice { get; set; }
    public bool? Is_OutTrans { get; set; }
    public int? JobOrderId { get; set; }
    public decimal DeductTaxRatio { get; set; }
    public decimal DeductTaxValue { get; set; }
    public int? InvoiceBookId { get; set; }
    public decimal AddTaxRatio { get; set; }
    public decimal AddTaxValue { get; set; }
    public int CrncId { get; set; }
    public decimal CrncRate { get; set; }
    public int? CostCenterId { get; set; }
    public int? ProcessId { get; set; }
    public int? SourceId { get; set; }
    public string? DriverName { get; set; }
    public string? VehicleNumber { get; set; }
    public string? Destination { get; set; }
    public int? LastUpdateUserId { get; set; }
    public DateTime? LastUpdateDate { get; set; }
    public string? ScaleWeightSerial { get; set; }
    public bool Is_Posted { get; set; }
    public DateTime? PostDate { get; set; }
    public bool? IsOffer { get; set; }
    public bool Is_StoreForEachRow { get; set; }
    public decimal CustomTaxValue { get; set; }
    public decimal CustomTaxRatio { get; set; }
    public decimal AdvancePaymentRatio { get; set; }
    public decimal AdvancePaymentValue { get; set; }
    public decimal RetentionRatio { get; set; }
    public decimal RetentionValue { get; set; }
    public decimal? HandingValue { get; set; }
    public decimal? TransportationValue { get; set; }
    public decimal? ShiftAdd { get; set; }
    public bool? Approved_Invoice { get; set; }
    public int? Approved_UserId { get; set; }
    public int? Delivery { get; set; }
    public int? ValidateUser { get; set; }
    public string? uuid { get; set; }
    public string? Estatus { get; set; }
    public string? issuerId { get; set; }
    public DateTime? lastSyncDate { get; set; }
    public DateTime? syncDate { get; set; }
    public byte? EstatusCode { get; set; }
    public string? longId { get; set; }
}

