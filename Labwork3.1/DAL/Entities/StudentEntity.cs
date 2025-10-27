namespace DAL.Entities;
using MessagePack;

[MessagePackObject]
public class StudentEntity: PersonEntity
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
}