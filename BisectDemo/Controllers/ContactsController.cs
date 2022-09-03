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
            "Don't Panic Labs"),
        new Contact(
            "Jacqui",
            "Donner",
            "2320 S Canterbury Lane",
            "",
            "Lincoln",
            "NE",
            "68512",
            "TELCOR"),
        new Contact(
            "Ford",
            "Prefect",
            "Surface of Magrathea",
            "",
            "Heart of Gold",
            "N/A",
            "N/A",
            "?"),
        new Contact(
            "Zaphod",
            "Beeblebrox",
            "Surface of Magrathea",
            "",
            "Heart of Gold",
            "N/A",
            "N/A",
            "President")
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