namespace Labwork3;

class Program
{
    static void Main()
    {
        List<MyLine> lines = new List<MyLine>
        {
            new MyLine("Hello World!"),
            new MyLine("Computer"),
            new MyLine("Python"),
            new MyLine("GPT")
        };
        
        //JSON
        MyLineService.SerializeJson(lines);
        
        List<MyLine>? deserializedJson = MyLineService.DeserializeJson<List<MyLine>>();
        MyLine[]? jsonArray = MyLineService.DeserializeJson<MyLine[]>();
        
        //XML
        MyLineService.SerializeXml(lines);

        List<MyLine>? deserializedXml = MyLineService.DeserializeXml<List<MyLine>>();
        MyLine[]? xmlArray = MyLineService.DeserializeXml<MyLine[]>();
        
        //Binary
        MyLineService.SerializeBinary(lines);

        List<MyLine>? deserializedBinary = MyLineService.DeserializeBinary<List<MyLine>>();
        MyLine[]? binaryArray = MyLineService.DeserializeBinary<MyLine[]>();
        
        //User
        MyLineService.SerializeUser(lines);

        List<MyLine>? deserializedUser = MyLineService.DeserializeUser();
        MyLine[] userArray = MyLineService.DeserializeUser().ToArray();
    }
}