namespace BisectDemo;

public class Contact
{
    public int ID { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    
    public string Address1 { get; set; }
    
    public string Address2 { get; set; }
    
    public string City { get; set; }
    
    public string State { get; set; }
    
    public string Zip { get; set; }
    
    public string Company { get; set; }

    public Contact(
        string firstName,
        string lastName,
        string address1 = "",
        string address2 = "",
        string city = "",
        string state = "",
        string zip = "",
        string company = "",
        int id = -1)
    {
        ID = id;
        FirstName = firstName;
        LastName = lastName;
        Address1 = address1;
        Address2 = address2;
        City = city;
        State = state;
        Zip = zip;
        Company = company;
    }
}