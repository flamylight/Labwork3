namespace PL.PLModels;

public class BakerPL: PersonPL
{
    public int Age { get; set; }
    public int IdCode { get; set; }

    public BakerPL(): base(){}

    public BakerPL(string name, string lastName, int age, int idCode) :
        base(name, lastName)
    {
        Age = age;
        IdCode = idCode;
    }

    public override string ToString()
    {
        return $"{Name} - {LastName}, {Age}";
    }
}