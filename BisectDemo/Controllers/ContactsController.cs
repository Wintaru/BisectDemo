using Microsoft.AspNetCore.Mvc;

namespace BisectDemo.Controllers;

[ApiController]
[Route("[controller]")]
public class ContactsController : ControllerBase
{
    private static readonly Contact[] ContactList = new[]
    {
        new Contact(
            "Josh",
            "Donner",
            "2320 S Canterbury Lane",
            "",
            "Lincoln",
            "NE",
            "68512",
            "Don't Panic Labs",
            0),
        new Contact(
            "Jacqui",
            "Donner",
            "2320 S Canterbury Lane",
            "",
            "Lincoln",
            "NE",
            "68512",
            "TELCOR",
            1),
        new Contact(
            "Ford",
            "Prefect",
            "Surface of Magrathea",
            "",
            "Heart of Gold",
            "N/A",
            "N/A",
            "?",
            2),
        new Contact(
            "Zaphod",
            "Beeblebrox",
            "Surface of Magrathea",
            "",
            "Heart of Gold",
            "N/A",
            "N/A",
            "President",
            3)
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