namespace BLL.Models;

public class BakerModel: PersonModels
{
    public int Age { get; set; }
    public int IdCode { get; set; }

    public BakerModel(): base(){}

    public BakerModel(string name, string lastName, int age, int idCode) :
        base(name, lastName)
    {
        Age = age;
        IdCode = idCode;
    }
}