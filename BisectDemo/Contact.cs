namespace BisectDemo;

public class Contact
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    
    public string Address1 { get; set; }

    public Contact(
        string firstName,
        string lastName,
        string address1)
    {
        FirstName = firstName;
        LastName = lastName;
        Address1 = address1;
    }
}