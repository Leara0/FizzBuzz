namespace FizzBuzz;

public class Screen
{
    public static void Print(string text)
    {
        var padding = (Console.WindowWidth + text.Length) / 2;
        
        Console.WriteLine(text.PadLeft(padding));
    }
}