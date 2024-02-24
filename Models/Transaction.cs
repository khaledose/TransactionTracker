namespace TransactionTracker.Models;

public class Transaction
{
    public int Id { get; set; }
    public long MessageId { get; set; }
    public int CreditCardId { get; set; }
    public int MerchantId { get; set; }
    public double Amount { get; set; }
    public string Currency { get; set; }
    public string Status { get; set; }
    public DateTime Date { get; set; }
    public DateTime DueDate { get; set; }
    public bool IsInternational { get; set; }
    public Message Message { get; set; }
    public CreditCard CreditCart { get; set; }
    public Merchant Merchant { get; set; }
}
