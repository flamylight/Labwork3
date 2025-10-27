using DAL.DataProvider;

namespace DAL;

public class EntityContext
{
    public EntityContext(){}
    
    private JSONProvider _jp = new JSONProvider();
    private XMLProvider _xml = new XMLProvider();
    private BinaryProvider _binary = new BinaryProvider();

    
    public List<T> ReadAll<T>(string type, string path) where T : class
    {
        
        switch (type.ToLower())
        {
            case "json":
                var resultJ = _jp.Deserialize<T>(path);
                return resultJ;
            case "xml":
                var resultX = _xml.Deserialize<T>(path);
                return resultX;
            case "binary":
                var resultB = _binary.Deserialize<T>(path);
                return resultB;
        }
        return null;
    }

    public void WriteAll<T>(List<T> list, string type, string path) where T : class
    {
        switch (type.ToLower())
        {
            case "json":
                _jp.Serialize(list, path);
                break;
            case "xml":
                _xml.Serialize(list, path);
                break;
            case "binary":
                _binary.Serialize(list, path);
                break;
        }
    }
}