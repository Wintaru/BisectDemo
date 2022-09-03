using Microsoft.AspNetCore.Mvc;

namespace BisectDemo.Controllers;

[ApiController]
[Route("[controller]")]
public class ContactsController : ControllerBase
{
    private static readonly Contact[] ContactList = new[]
    {
        new Contact("Josh", "Donner", "2320 S Canterbury Lane", "", "Lincoln"),
        new Contact("Jacqui", "Donner", address1: "2320 S Canterbury Lane", "", "Lincoln"),
        new Contact("Ford", "Prefect", address1: "Surface of Magrathea", "", "Heart of Gold"),
        new Contact("Zaphod", "Beeblebrox", address1: "Surface of Magrathea", "", "Heart of Gold")
    };

    private readonly ILogger<ContactsController> _logger;

    public ContactsController(ILogger<ContactsController> logger)
    {
        _logger = logger;
    }

    [HttpGet]
    public IEnumerable<Contact> Get()
    {
        // return ContactList.ToArray();
        return new [] { new Contact("All", "Your", "Base are belong to us") }.ToArray();
    }
}