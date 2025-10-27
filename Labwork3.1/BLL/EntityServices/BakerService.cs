namespace BLL.EntityServices;
using DAL.Entities;
using MappersBLLDAL;
using DAL;
using Models;

public class BakerService
{
    private EntityContext _context = new EntityContext();

    public void AddBaker(BakerModel model, string type, string path)
    {
        var bakers = _context.ReadAll<BakerEntity>(type, path) ?? new List<BakerEntity>();
        bakers.Add(model.ToDAL());
        _context.WriteAll(bakers, type, path);
    }

    public List<BakerModel> GetBakers(string type, string path)
    {
        var bakers = _context.ReadAll<BakerEntity>(type, path) ?? new List<BakerEntity>();
        List<BakerModel> models = new List<BakerModel>();
        foreach (var baker in bakers)
        {
            models.Add(baker.ToBLL());
        }

        return models;
    }

    public void DeleteBaker(int idCode, string type, string path)
    {
        var bakers = _context.ReadAll<BakerEntity>(type, path) ?? new List<BakerEntity>();

        var ToRemove = bakers.FirstOrDefault(b => b.IdCode == idCode);

        if (ToRemove != null)
        {
            bakers.Remove(ToRemove);
            _context.WriteAll(bakers, type, path);
        }
        else
        {
            throw new Exception("Baker not found");
        }
    }
}