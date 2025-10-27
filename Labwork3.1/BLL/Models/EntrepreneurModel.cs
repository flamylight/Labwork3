namespace BLL.Models;

public class EntrepreneurModel: PersonModels
{
    public int Age { get; set; }
    public int IdCode { get; set; }

    public EntrepreneurModel(): base() {}
    
    public EntrepreneurModel(string name, string lastName, int age, int idCode) :
        base(name, lastName)
    {
        Age = age;
        IdCode = idCode;
    }
}