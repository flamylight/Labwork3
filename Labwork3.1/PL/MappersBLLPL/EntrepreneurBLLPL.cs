namespace PL.MappersBLLPL;
using PLModels;
using BLL.Models;

public static class EntrepreneurBLLPL
{
    public static EntrepreneurModel ToBLL(this EntrepreneurPL pl)
    {
        return new EntrepreneurModel
        {
            Name = pl.Name,
            LastName = pl.LastName,
            Age = pl.Age,
            IdCode = pl.IdCode
        };
    }

    public static EntrepreneurPL ToPL(this EntrepreneurModel bll)
    {
        return new EntrepreneurPL
        {
            Name = bll.Name,
            LastName = bll.LastName,
            Age = bll.Age,
            IdCode = bll.IdCode
        };
    }
}