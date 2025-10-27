namespace DAL.Entities;
using MessagePack;

[MessagePackObject]
public class BakerEntity: PersonEntity
{
    [Key(2)]
    public int Age { get; set; }
    [Key(3)]
    public int IdCode { get; set; }

    public BakerEntity():base(){}
    
    public BakerEntity(string name, string lastName, int age, int idCode) : base(name, lastName)
    {
        Age = age;
        IdCode = idCode;
    }
}