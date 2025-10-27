namespace BLL.MappersBLLDAL;
using DAL.Entities;
using Models;

public static class BakerBLLDAL
{
    public static BakerEntity ToDAL(this BakerModel bll)
    {
        return new BakerEntity
        {
            Name = bll.Name,
            LastName = bll.LastName,
            Age = bll.Age,
            IdCode = bll.IdCode
        };
    }

    public static BakerModel ToBLL(this BakerEntity entity)
    {
        return new BakerModel
        {
            Name = entity.Name,
            LastName = entity.LastName,
            Age = entity.Age,
            IdCode = entity.IdCode,
        };
    }
}