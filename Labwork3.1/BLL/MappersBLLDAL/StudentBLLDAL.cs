namespace BLL.MappersBLLDAL;
using DAL.Entities;
using Models;

public static class StudentBLLDAL
{
    public static StudentEntity ToDAL(this StudentModel bll)
    {
        return new StudentEntity
        {
            Name = bll.Name,
            LastName = bll.LastName,
            Course = bll.Course,
            StudId = bll.StudId,
            DateOfBirth = bll.DateOfBirth
        };
    }

    public static StudentModel ToBLL(this StudentEntity entity)
    {
        return new StudentModel
        {
            Name = entity.Name,
            LastName = entity.LastName,
            Course = entity.Course,
            StudId = entity.StudId,
            DateOfBirth = entity.DateOfBirth
        };
    }
}