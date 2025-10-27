namespace BLL.Exceptions;

public class StudIdEx: Exception
{
    public StudIdEx() : base(){}
    public StudIdEx(string message) : base(message){}
    public StudIdEx(string message, Exception innerException) 
        : base(message, innerException) { }
}