namespace DAL.Entities;
using MessagePack;


abstract public class PersonEntity
{
    [Key(0)]
    public string Name { get; set; }
    [Key(1)]
    public string LastName { get; set; }
    
    public PersonEntity(){}

    public PersonEntity(string name, string lastName)
    {
        Name = name;
        LastName = lastName;
    }
}