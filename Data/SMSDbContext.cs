using Microsoft.EntityFrameworkCore;
using TransactionTracker.Models;

namespace TransactionTracker.Data;

public class SMSDbContext : DbContext
{
    public DbSet<Message> Messages {  get; set; }
    public DbSet<Transaction> Transactions { get; set; }
    public DbSet<CreditCard> CreditCards { get; set; }
    public DbSet<Merchant> Merchants { get; set; }

    public SMSDbContext(DbContextOptions options) : base(options) { }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        // Configure the Message entity to allow identity insert
        modelBuilder.Entity<Message>()
            .Property(m => m.Id)
            .ValueGeneratedNever();

        base.OnModelCreating(modelBuilder);
    }
}
