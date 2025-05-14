// See https://aka.ms/new-console-template for more information

using FizzBuzz;
Console.CursorVisible = false;
TextHelper.IntroText();
var goAgain = 1;

while(goAgain ==1)
{
    var number = UserInteractions.GetInput();
    Console.WriteLine();
    Screen.Print(Method.FizzBuzz(number));
    Console.WriteLine();
    Screen.Print(Text.GoAgain);
    Console.WriteLine();
    goAgain = UserInteractions.InteractiveMenu();
    if (goAgain == 1)
    {
        Console.Clear();
        Screen.Print(Text.LetsPlayAgain);
    }
}
Console.Clear();
Screen.Print(Text.ThanksForPlaying);