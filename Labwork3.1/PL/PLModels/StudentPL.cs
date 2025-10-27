namespace PL.PLModels;

public class StudentPL: PersonPL
{
    public int Course { get; set; }
    public string StudId { get; set; }
    public DateTime DateOfBirth { get; set; }

    public StudentPL(): base() {}
    
    public StudentPL(string name, string lastName, int course, string studId, DateTime dateOfBirth) :
        base(name, lastName)
    {
        Course = course;
        StudId = studId;
        DateOfBirth = dateOfBirth;
    }

    public override string ToString()
    {
        return $"{Name} - {LastName}, {Course}";
    }
}