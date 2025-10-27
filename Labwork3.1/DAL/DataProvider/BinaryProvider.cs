namespace DAL.DataProvider;
using MessagePack;

public class BinaryProvider: DataProvider
{
    
    public override void Serialize<T>(List<T> persons, string path)
    {
        byte[] bytes = MessagePackSerializer.Serialize(persons);
        File.WriteAllBytes(path, bytes);
    }

    public override List<T>? Deserialize<T>(string path)
    {
        if (!File.Exists(path))
        {
            return default;
        }
        
        byte[] bytes = File.ReadAllBytes(path);
        var result = MessagePackSerializer.Deserialize<List<T>>(bytes);
        return (List<T>?)result;
    }
}