namespace BisectDemo;

public class Contact
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    
    public string Address1 { get; set; }
    
    public string Address2 { get; set; }
    
    public string City { get; set; }

    public Contact(
        string firstName,
        string lastName,
        string address1 = "",
        string address2 = "",
        string city = "")
    {
        FirstName = firstName;
        LastName = lastName;
        Address1 = address1;
        Address2 = address2;
        City = city;
    }
}