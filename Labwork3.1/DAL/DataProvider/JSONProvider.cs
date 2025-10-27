namespace DAL.DataProvider;
using System.Text.Json;

public class JSONProvider: DataProvider
{

    public override void Serialize<T>(List<T> persons, string path)
    {
        var json = JsonSerializer.Serialize(persons);
        File.WriteAllText(path, json);
    }

    public override List<T>? Deserialize<T>(string pathFile)
    {
        if (!File.Exists(pathFile))
        {
            return default;
        }

        var json = File.ReadAllText(pathFile);
        return JsonSerializer.Deserialize<List<T>>(json);
    }
}