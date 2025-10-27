namespace BLL.EntityServices;
using DAL;
using MappersBLLDAL;
using DAL.Entities;
using Models;

public class EntrepreneurService
{
    private EntityContext _context = new EntityContext();

    public void AddEntrepreneur(EntrepreneurModel model, string type, string path)
    {
        var entrepreneurs = _context.ReadAll<EntrepreneurEntity>(type, path) ?? new List<EntrepreneurEntity>();
        entrepreneurs.Add(model.ToDAL());
        _context.WriteAll(entrepreneurs, type, path);
    }

    public List<EntrepreneurModel> GetEntrepreneurs(string type, string path)
    {
        var entrepreneurs = _context.ReadAll<EntrepreneurEntity>(type, path) ?? new List<EntrepreneurEntity>();
        List<EntrepreneurModel> models = new List<EntrepreneurModel>();
        foreach (var entrepreneur in entrepreneurs)
        {
            models.Add(entrepreneur.ToBLL());
        }

        return models;
    }

    public void DeleteEntrepreneur(int idCode, string type, string path)
    {
        var entrepreneurs = _context.ReadAll<EntrepreneurEntity>(type, path) 
                            ?? new List<EntrepreneurEntity>();

        var ToRemove = entrepreneurs.FirstOrDefault(e => e.IdCode == idCode);

        if (ToRemove != null)
        {
            entrepreneurs.Remove(ToRemove);
            _context.WriteAll(entrepreneurs, type, path);
        }
        else
        {
            throw new Exception("Entrepreneur not found");
        }
    }
}