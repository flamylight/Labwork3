namespace DAL.Entities;

public interface ISerializeUser
{
    public string SerializeData();
    void FromDataString(string line);
}