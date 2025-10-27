namespace DAL.DataProvider;
using System.Xml;
using System.Xml.Serialization;

public class XMLProvider: DataProvider
{
    
    public override void Serialize<T>(List<T> persons, string path)
    {
        var serializer = new XmlSerializer(typeof(List<T>));
        using (var writer = XmlWriter.Create(path))
        {
            serializer.Serialize(writer, persons);
        }
    }

    public override List<T>? Deserialize<T>(string path)
    {
        if (!File.Exists(path) || new FileInfo(path).Length == 0)
        {
            return default; 
        }
        
        var serializer = new XmlSerializer(typeof(List<T>));
        using (var reader = XmlReader.Create(path))
        {
            var result = serializer.Deserialize(reader);
            return (List<T>?)result;
        }
    }
}