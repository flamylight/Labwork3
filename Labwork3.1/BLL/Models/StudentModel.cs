using BLL.Exceptions;

namespace BLL.Models;
using DAL.Entities;

public class StudentModel: PersonModels
{
    public int Course { get; set; }
    public string StudId { get; set; }
    public DateTime DateOfBirth { get; set; }

    public StudentModel(): base() {}
    
    public StudentModel(string name, string lastName, int course, string studId, DateTime dateOfBirth) :
        base(name, lastName)
    {
        Course = course;
        if (studId.Length != 8)
        {
            throw new StudIdEx("Student ID must consist of 8 characters");
        }
        StudId = studId;
        DateOfBirth = dateOfBirth;
    }
    
}