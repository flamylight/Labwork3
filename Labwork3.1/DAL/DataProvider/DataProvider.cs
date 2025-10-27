namespace DAL.DataProvider;

abstract public class DataProvider
{
    public string PathFile { get; set; }
    
    abstract public void Serialize<T>(List<T> person, string path);
    abstract public List<T>? Deserialize<T>(string pathFile);
}