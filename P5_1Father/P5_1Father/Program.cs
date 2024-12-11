namespace P5_1Father;

public class DarthVader
{
    public string Speak()
    {
        return "I am your father.";
    }
}

public class Luke : DarthVader
{
    public string Reply()
    {
        return "No! That's not true! That's impossible!";
    }
}

class Program
{
    static void Main(string[] args)
    {
        Luke luke = new Luke();
        Console.WriteLine(luke.Speak());
        Console.WriteLine(luke.Reply());
    }
}