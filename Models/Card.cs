namespace TransactionTracker.Models;

public class CreditCard
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Bank { get; set; }
    public string Network { get; set; }
    public string Last4 { get; set; }
    public int InvoiceStartDay { get; set; }
    public int InvoiceDuration { get; set; }
    public double Limit { get; set; }
    public double InternationalLimit { get; set; }
    public double RemainingLimit { get; set; }
    public double RemainingInternationalLimit { get; set; }
}
