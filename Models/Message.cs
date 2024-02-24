namespace TransactionTracker.Models;

public class Message
{
    public long Id { get; set; }
    public string Sender { get; set; }
    public string Body { get; set; }
    public DateTime Date { get; set; }
}
