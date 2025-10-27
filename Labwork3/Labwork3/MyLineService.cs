using System.Text;
using System.Text.Json;
using System.Xml;
using System.Xml.Serialization;
using MessagePack;
using System.Text.RegularExpressions;
namespace Labwork3;

public class MyLineService
{
    private const string PathJson = "MyLineJson.json";
    private const string PathXml = "MyLineXml.xml";
    private const string PathBinary = "MyLineBinary.bin";
    private const string PathUser = "MyLineUser.txt";
    
    //JSON
    public static void SerializeJson<T>(T lines)
    {
        var json = JsonSerializer.Serialize(lines);
        File.WriteAllText(PathJson, json);
    }

    public static T? DeserializeJson<T>()
    {
        if (!File.Exists(PathJson))
        {
            return default;
        }
        
        var json = File.ReadAllText(PathJson);
        return JsonSerializer.Deserialize<T>(json);
    }

    //XML
    public static void SerializeXml<T>(T lines)
    {
        var serializer = new XmlSerializer(typeof(T));
        using (var writer = XmlWriter.Create(PathXml))
        {
            serializer.Serialize(writer, lines);
        }
    }

    public static T? DeserializeXml<T>()
    {
        if (!File.Exists(PathXml))
        {
            return default;
        }
        
        var serializer = new XmlSerializer(typeof(T));
        using (var reader = XmlReader.Create(PathXml))
        {
            var result = serializer.Deserialize(reader);
            return (T?)result;
        }
    }

    //Binary
    public static void SerializeBinary<T>(T lines)
    {
        byte[] bytes = MessagePackSerializer.Serialize(lines);
        File.WriteAllBytes(PathBinary, bytes);
    }

    public static T? DeserializeBinary<T>()
    {
        if (!File.Exists(PathBinary))
        {
            return default;
        }
        
        byte[] bytes = File.ReadAllBytes(PathBinary);
        var result = MessagePackSerializer.Deserialize<T>(bytes);
        return (T?)result;
    }
    
    //User
    public static void SerializeUser<T>(T lines) where T: IEnumerable<MyLine>
    {
        StringBuilder sb = new StringBuilder();
        
        foreach (var line in lines)
        {
            sb.AppendLine(line.Serialize());
        }
        
        string result = sb.ToString();
        File.WriteAllText(PathUser, result);
    }

    public static List<MyLine>? DeserializeUser()
    {
        if (!File.Exists(PathUser))
            return null;
        
        List<MyLine> lineResult = new List<MyLine>();
        
        string result = File.ReadAllText(PathUser);
        List<string> lines = result.Split('\n').ToList();

        foreach (var line in lines)
        {
            if (line.Contains("{") && line.Contains("}"))
            {
                List<string> clearLine = Regex.Replace(line, "[{}]", "").Split(',').ToList();
                string parsLine = clearLine[0].Split(':')[1];
                lineResult.Add(new MyLine(parsLine));
            }
        }
        return lineResult;
    }
}