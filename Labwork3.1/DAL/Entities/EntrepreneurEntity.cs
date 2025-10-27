namespace DAL.Entities;
using MessagePack;

[MessagePackObject]
public class EntrepreneurEntity: PersonEntity
{
    [Key(2)]
    public int Age { get; set; }
    [Key(3)]
    public int IdCode { get; set; }
    
    public EntrepreneurEntity():base(){}

    public EntrepreneurEntity(string name, string lastName, int age, int idCode) : base(name, lastName)
    {
        Age = age;
        IdCode = idCode;
    }
}