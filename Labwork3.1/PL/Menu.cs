namespace PL;
using PLModels;
using BLL.Models;
using BLL.EntityServices;
using MappersBLLPL;

public class Menu
{
    private string choices = "1) Add student\n" +
                             "2) Add baker\n" +
                             "3) Add entrepreneur\n" +
                             "4) All students\n" +
                             "5) All bakers\n" +
                             "6) All entrepreneurs\n" +
                             "7) Delete student\n" +
                             "8) Delete baker\n" +
                             "9) Delete entrepreneur\n" +
                             "10) Task\n" +
                             "11) Exit";
    private bool isActive = true;
    private StudentService studentService = new StudentService();
    private BakerService bakerService = new BakerService();
    private EntrepreneurService entrepService = new EntrepreneurService();
    
    public void Run()
    {
        while (isActive)
        {
            Console.WriteLine(choices);
            Console.Write("Please choose an option:");
            string input = Console.ReadLine();

            switch (input)
            {
                case "1":
                    Console.Write("Name: ");
                    string name = Console.ReadLine();
                    Console.Write("Last name: ");
                    string lastName = Console.ReadLine();
                    Console.Write("Course: ");
                    int course = int.Parse(Console.ReadLine());
                    Console.Write("Student ID: ");
                    string studId = Console.ReadLine();
                    Console.Write("Date of birth: ");
                    DateTime dateOfBirth = DateTime.Parse(Console.ReadLine());
                    Console.Write("Type: ");
                    string type = Console.ReadLine();
                    Console.Write("Path: ");
                    string path = Console.ReadLine();
                    StudentPL student = new StudentPL(name, lastName, course, studId, dateOfBirth);
                    try
                    {
                        studentService.AddStudent(student.ToBLL(), type, path);
                        Console.Clear();
                        Console.WriteLine("Student added");
                        break;
                    }
                    catch (Exception e)
                    {
                        Console.Clear();
                        Console.WriteLine(e.Message);
                        break;
                    }
                    
                case "2":
                    Console.Write("Name: ");
                    string nameB = Console.ReadLine();
                    Console.Write("Last name: ");
                    string lastNameB = Console.ReadLine();
                    Console.Write("Age: ");
                    int ageB = int.Parse(Console.ReadLine());
                    Console.Write("ID Code: ");
                    int codeB = int.Parse(Console.ReadLine());
                    Console.Write("Type: ");
                    string typeB = Console.ReadLine();
                    Console.Write("Path: ");
                    string pathB = Console.ReadLine();
                    BakerPL baker = new BakerPL(nameB, lastNameB, ageB, codeB);
                    try
                    {
                        bakerService.AddBaker(baker.ToBLL(), typeB, pathB);
                        Console.Clear();
                        Console.WriteLine("Baker added");
                        break;
                    }
                    catch (Exception e)
                    {
                        Console.Clear();
                        Console.WriteLine(e.Message);
                        break;
                    }
                    
                case "3":
                    Console.Write("Name: ");
                    string nameE = Console.ReadLine();
                    Console.Write("Last name: ");
                    string lastNameE = Console.ReadLine();
                    Console.Write("Age: ");
                    int ageE = int.Parse(Console.ReadLine());
                    Console.Write("ID Code: ");
                    int codeE = int.Parse(Console.ReadLine());
                    Console.Write("Type: ");
                    string typeE = Console.ReadLine();
                    Console.Write("Path: ");
                    string pathE = Console.ReadLine();
                    EntrepreneurPL entrepreneur = new EntrepreneurPL(nameE, lastNameE, ageE, codeE);
                    try
                    {
                        entrepService.AddEntrepreneur(entrepreneur.ToBLL(), typeE, pathE);
                        Console.Clear();
                        Console.WriteLine("Enterpreneur added");
                        break;
                    }
                    catch (Exception e)
                    {
                        Console.Clear();
                        Console.WriteLine(e.Message);
                        break;
                    }
                    
                case "4":
                    Console.Write("Type: ");
                    string typeAll = Console.ReadLine();
                    Console.Write("Path: ");
                    string pathAll = Console.ReadLine();
                    List<StudentModel> models = studentService.GetStudents(typeAll, pathAll);
                    if (models != null || models.Count != 0)
                    {
                        foreach (StudentModel model in models)
                        {
                            Console.WriteLine(model.ToPL());
                        }

                        break;
                    }
                    Console.WriteLine("Not found");
                    break;
                case "5":
                    Console.Write("Type: ");
                    string typeAllB = Console.ReadLine();
                    Console.Write("Path: ");
                    string pathAllB = Console.ReadLine();
                    List<BakerModel> modelsB = bakerService.GetBakers(typeAllB, pathAllB);
                    if (modelsB != null || modelsB.Count != 0)
                    {
                        foreach (BakerModel model in modelsB)
                        {
                            Console.WriteLine(model.ToPL().ToString());
                        }

                        break;
                    }
                    Console.WriteLine("Not found");
                    break;
                case "6":
                    Console.Write("Type: ");
                    string typeAllE = Console.ReadLine();
                    Console.Write("Path: ");
                    string pathAllE = Console.ReadLine();
                    List<EntrepreneurModel> modelsE = entrepService.GetEntrepreneurs(typeAllE, pathAllE);
                    if (modelsE != null || modelsE.Count != 0)
                    {
                        foreach (EntrepreneurModel model in modelsE)
                        {
                            Console.WriteLine(model.ToPL());
                        }

                        break;
                    }
                    Console.WriteLine("Not found");
                    break;
                case "7":
                    Console.Write("Type: ");
                    string typeD = Console.ReadLine();
                    Console.Write("Path: ");
                    string pathD = Console.ReadLine();
                    Console.Write("Student ID: ");
                    string studIdD = Console.ReadLine();
                    try
                    {
                        studentService.DeleteStudent(studIdD, typeD, pathD);
                        Console.Clear();
                        Console.WriteLine("Student deleted");
                        break;
                    }
                    catch (Exception e)
                    {
                        Console.Clear();
                        Console.WriteLine(e.Message);
                        break;
                    }
                    
                case "8":
                    Console.Write("Type: ");
                    string typeDB = Console.ReadLine();
                    Console.Write("Path: ");
                    string pathDB = Console.ReadLine();
                    Console.Write("ID code: ");
                    int idCodeB = int.Parse(Console.ReadLine());
                    try
                    {
                        bakerService.DeleteBaker(idCodeB, typeDB, pathDB);
                        Console.Clear();
                        Console.WriteLine("Baker deleted");
                        break;
                    }
                    catch (Exception e)
                    {
                        Console.Clear();
                        Console.WriteLine(e.Message);
                        break;
                    }
                case "9":
                    Console.Write("Type: ");
                    string typeDE = Console.ReadLine();
                    Console.Write("Path: ");
                    string pathDE = Console.ReadLine();
                    Console.Write("ID code: ");
                    int idCodeE = int.Parse(Console.ReadLine());
                    try
                    {
                        entrepService.DeleteEntrepreneur(idCodeE, typeDE, pathDE);
                        Console.Clear();
                        Console.WriteLine("Entrepreneur deleted");
                        break;
                    }
                    catch (Exception e)
                    {
                        Console.Clear();
                        Console.WriteLine(e.Message);
                        break;
                    }
                case "10":
                    Console.Write("Type: ");
                    string typeT = Console.ReadLine();
                    Console.Write("Path: ");
                    string pathT = Console.ReadLine();
                    var students = studentService.Task(typeT, pathT);
                    if (students != null && students.Count != 0)
                    {
                        foreach (StudentModel stud in students)
                        {
                            Console.WriteLine(stud.ToPL());
                        }

                        break;
                    }
                    Console.WriteLine("Not found");
                    break;
                
                case "11":
                    isActive =  false;
                    break;
            }
        }
    }
}