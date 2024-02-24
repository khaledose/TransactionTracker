using TransactionTracker.Models;

namespace TransactionTracker.Data.Repositories;

public class MessagesRepository
{
    private SMSDbContext _dbContext;

    public MessagesRepository(SMSDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public async void SaveMessages(List<Message> messages)
    {
        await _dbContext.Messages.AddRangeAsync(messages);
        _dbContext.SaveChanges();
    }
}
