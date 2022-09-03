using Microsoft.AspNetCore.Mvc;

namespace BisectDemo.Controllers;

[ApiController]
[Route("[controller]")]
public class ContactsController : ControllerBase
{
    private static readonly Contact[] ContactList = new[]
    {
        new Contact("Josh", "Donner"),
        new Contact("Jacqui", "Donner"),
        new Contact("Ford", "Prefect"),
        new Contact("Zaphod", "Beeblebrox")
    };

    private readonly ILogger<ContactsController> _logger;

    public ContactsController(ILogger<ContactsController> logger)
    {
        _logger = logger;
    }

    [HttpGet]
    public IEnumerable<Contact> Get()
    {
        return ContactList.ToArray();
    }
}