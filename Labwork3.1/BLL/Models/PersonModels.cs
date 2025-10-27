namespace BLL.Models;

public abstract class PersonModels
{
   public string Name { get; set; }
   public string LastName { get; set; }

   public PersonModels() {}
   
   public PersonModels(string name, string lastName)
   {
      Name = name;
      LastName = lastName;
   }
}