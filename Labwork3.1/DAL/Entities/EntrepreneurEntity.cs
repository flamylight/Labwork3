namespace DAL.Entities;
using MessagePack;

[MessagePackObject]
public class EntrepreneurEntity: PersonEntity, ISerializeUser
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
    
    public string SerializeData()
    {
        return $"{Name};{LastName};{Age};{IdCode}";
    }
    
    public void FromDataString(string line)
    {
        var parts = line.Split(';');
        Name = parts[0];
        LastName = parts[1];
        Age = int.Parse(parts[2]);
        IdCode = int.Parse(parts[3]);
    }
}