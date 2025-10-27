namespace PL.MappersBLLPL;
using PLModels;
using BLL.Models;

public static class BakerBLLPL
{
    public static BakerModel ToBLL(this BakerPL pl)
    {
        return new BakerModel
        {
            Name = pl.Name,
            LastName = pl.LastName,
            Age = pl.Age,
            IdCode = pl.IdCode
        };
    }

    public static BakerPL ToPL(this BakerModel bll)
    {
        return new BakerPL
        {
            Name = bll.Name,
            LastName = bll.LastName,
            Age = bll.Age,
            IdCode = bll.IdCode
        };
    }
}