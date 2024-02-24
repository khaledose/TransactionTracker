using Microsoft.AspNetCore.Mvc;
using TransactionTracker.Data.Repositories;
using TransactionTracker.Models;

namespace TransactionTracker.Controllers;

[ApiController]
[Route("[controller]")]
public class MessagesController : ControllerBase
{
    private MessagesRepository _messageRepository;

    public MessagesController(MessagesRepository messageRepository)
    {
        _messageRepository = messageRepository;
    }

    [HttpPost]
    public IActionResult SaveMessages(List<Message> messages)
    {
        _messageRepository.SaveMessages(messages);
        return Ok("Messages received successfully");
    }

    [HttpGet]
    public int Test()
    {
        return 1;
    }
}
