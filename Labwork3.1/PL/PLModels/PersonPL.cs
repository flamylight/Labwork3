namespace PL.PLModels;

public class PersonPL
{
    public string Name { get; set; }
    public string LastName { get; set; }

    public PersonPL() {}
   
    public PersonPL(string name, string lastName)
    {
        Name = name;
        LastName = lastName;
    }
}