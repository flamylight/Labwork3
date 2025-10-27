namespace PL.PLModels;

public class EntrepreneurPL: PersonPL
{
    public int Age { get; set; }
    public int IdCode { get; set; }

    public EntrepreneurPL(): base() {}
    
    public EntrepreneurPL(string name, string lastName, int age, int idCode) :
        base(name, lastName)
    {
        Age = age;
        IdCode = idCode;
    }

    public override string ToString()
    {
        return $"{Name} - {LastName}, {IdCode}";
    }
}