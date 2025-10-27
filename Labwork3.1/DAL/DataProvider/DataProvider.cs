namespace DAL.DataProvider;
using Entities;

abstract public class DataProvider
{
    public string PathFile { get; set; }

    abstract public void Serialize<T>(List<T> person, string path) where T : ISerializeUser;
    abstract public List<T>? Deserialize<T>(string pathFile) where T : ISerializeUser, new();
}