namespace BLL.MappersBLLDAL;
using Models;
using DAL.Entities;

public static class EnterpreneurBLLDAL
{
    public static EntrepreneurEntity ToDAL(this EntrepreneurModel bll)
    {
        return new EntrepreneurEntity
        {
            Name = bll.Name,
            LastName = bll.LastName,
            Age = bll.Age,
            IdCode = bll.IdCode
        };
    }

    public static EntrepreneurModel ToBLL(this EntrepreneurEntity entity)
    {
        return new EntrepreneurModel
        {
            Name = entity.Name,
            LastName = entity.LastName,
            Age = entity.Age,
            IdCode = entity.IdCode
        };
    }
}