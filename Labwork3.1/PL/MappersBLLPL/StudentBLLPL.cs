namespace PL.MappersBLLPL;
using PLModels;
using BLL.Models;

public static class StudentBLLPL
{
    public static StudentModel ToBLL(this StudentPL pl)
    {
        return new StudentModel(pl.Name, pl.LastName, pl.Course, pl.StudId, pl.DateOfBirth);

    }

    public static StudentPL ToPL(this StudentModel bll)
    {
        return new StudentPL
        {
            Name = bll.Name,
            LastName = bll.LastName,
            Course = bll.Course,
            StudId = bll.StudId,
            DateOfBirth = bll.DateOfBirth
        };
    }
}