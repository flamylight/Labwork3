namespace DAL.DataProvider;
using System.Text;


public class UserProvider: DataProvider
{
    public override void Serialize<T>(List<T> persons, string path)
    {
        StringBuilder sb = new StringBuilder();
        
        foreach (var person in persons)
        {
            sb.AppendLine(person.SerializeData());
        }
        
        string result = sb.ToString();
        File.WriteAllText(path, result);
    }

    public override List<T>? Deserialize<T>(string path)
    {
        if (!File.Exists(path))
        {
            return default;
        }

        var list = new List<T>();
        foreach (var line in File.ReadAllLines(path))
        {
            if (string.IsNullOrWhiteSpace(line)) continue;

            T obj = new T();          
            obj.FromDataString(line); 
            list.Add(obj);
        }
        return list;
    }
}