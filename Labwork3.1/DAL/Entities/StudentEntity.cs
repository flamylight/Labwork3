namespace DAL.Entities;
using MessagePack;

[MessagePackObject]
public class StudentEntity: PersonEntity, ISerializeUser
{
    [Key(2)]
    public int Course { get; set; }
    [Key(3)]
    public string StudId { get; set; }
    [Key(4)]
    public DateTime DateOfBirth { get; set; }
    
    public StudentEntity():base(){}

    public StudentEntity(string name, string lastName, int course, string studId, DateTime dateOfBirth) :
        base(name, lastName)
    {
        Course = course;
        StudId = studId;
        DateOfBirth = dateOfBirth;
    }
    
    public string SerializeData()
    {
        return $"{Name};{LastName};{Course};{StudId};{DateOfBirth}";
    }
    
    public void FromDataString(string line)
    {
        var parts = line.Split(';');
        Name = parts[0];
        LastName = parts[1];
        Course = int.Parse(parts[2]);
        StudId = parts[3];
        DateOfBirth = DateTime.Parse(parts[4]);
    }
}