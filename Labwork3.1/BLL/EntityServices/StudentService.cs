using BLL.MappersBLLDAL;
using DAL.Entities;

namespace BLL.EntityServices;
using DAL;
using Models;

public class StudentService
{
    private EntityContext _context = new EntityContext();

    public void AddStudent(StudentModel model, string type, string path)
    {
        var students = _context.ReadAll<StudentEntity>(type, path) ?? new List<StudentEntity>();
        students.Add(model.ToDAL());
        _context.WriteAll(students, type, path);
    }

    public List<StudentModel> GetStudents(string type, string path)
    {
        var students = _context.ReadAll<StudentEntity>(type, path) ?? new List<StudentEntity>();
        List<StudentModel> models = new List<StudentModel>();
        foreach (var student in students)
        {
            models.Add(student.ToBLL());
        }

        return models;
    }

    public void DeleteStudent(string studId, string type, string path)
    {
        var students = _context.ReadAll<StudentEntity>(type, path) ?? new List<StudentEntity>();

        var ToRemove = students.FirstOrDefault(s => s.StudId == studId);

        if (ToRemove != null)
        {
            students.Remove(ToRemove);
            _context.WriteAll(students, type, path);
        }
        else
        {
            throw new Exception("Student not found");
        }
    }

    public List<StudentModel>? Task(string type, string path)
    {
        var students = _context.ReadAll<StudentEntity>(type, path) ?? new List<StudentEntity>();
        List<StudentModel> models = new List<StudentModel>();
        if (students != null)
        {
            foreach (var student in students)
            {
                if (student.Course == 4)
                {
                    if (student.DateOfBirth.Month == 3 ||
                        student.DateOfBirth.Month == 4 ||
                        student.DateOfBirth.Month == 5)
                    {
                        models.Add(student.ToBLL());
                    }
                }
            }
            return models;
        }

        return null;
    }
}