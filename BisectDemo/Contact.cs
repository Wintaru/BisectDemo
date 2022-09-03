namespace BisectDemo;

public class Contact
{
    public string FirstName { get; set; }
    public string LastName { get; set; }

    public Contact(
        string firstName,
        string lastName)
    {
        FirstName = firstName;
        LastName = lastName;
    }
}