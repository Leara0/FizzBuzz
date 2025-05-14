namespace FizzBuzz;

public class TextHelper
{
    public static void IntroText()
    {
        Screen.Print(Text.IntroLine1);
        Thread.Sleep(1000);
        Screen.Print(Text.IntroLine2);
        Screen.Print(Text.IntroLine3);
        Screen.Print(Text.IntroLine4);
        Thread.Sleep(1000);
        Screen.Print(Text.GetInput);
    }

    public static void KeepGoing()
    {
        Screen.Print(Text.GoAgain);
    }
}