using MessagePack;

namespace Labwork3;

[MessagePackObject]
public class MyLine
{
    [Key(0)]
    public string Line { get; set; }
    [Key(1)]
    public int Length { get; set; }

    
    public MyLine(string line)
    {
        Line = line;
        Length = line.Length;
    }
    
    public MyLine(){}

    public int CountChar(char ch)
    {
        int count = Line.Count(c => c == ch);
        return count;
    }

    public void Reverse()
    {
        Line = new string(Line.Reverse().ToArray());
    }

    public void AddLine(string newLine)
    {
        Line += newLine;
        Length = Line.Length;
    }

    public override string ToString()
    {
        return Line;
    }

    public string Serialize()
    {
        return $"{{Line: {Line}, Length: {Length}}}";
    }
}