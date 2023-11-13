using Tmds.DBus.Protocol;

namespace TextInput.Models;

public class Person
{
    public string FirstName { get; set; }
    public string SecondName{ get; set; }
    public string Adress { get; set; }
    

    public Person(string firstName, string secondName, string adress)
    {
        FirstName = firstName;
        SecondName = secondName;
        Adress = adress;
    }
}