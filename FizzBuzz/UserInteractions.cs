using System.Runtime.Intrinsics.X86;

namespace FizzBuzz;

public class UserInteractions
{
    public static int GetInput()
    {
        while (true)
        {
            int y = Console.CursorTop;
            Console.SetCursorPosition(Console.WindowWidth / 2, y);
            var input = Console.ReadLine();
            if (int.TryParse(input, out int number) && number > 0 && number < 101) return number;
            Screen.Print(Text.Correction);
            Screen.Print(Text.GetInput);
        }
    }

    public static int InteractiveMenu()
    {
        Screen.Print(Text.HowToPickAnItem + "\n");

        int optionSelected = 1; //changed from 0
        ConsoleKeyInfo key;
        bool isSelected = false;
        (int x, int y) = Console.GetCursorPosition();
        string selected = "--> \u001b[36m";

        while (!isSelected)
        {
            Console.SetCursorPosition(x, y);
            Screen.Print($"{(optionSelected == 2 ? "   \u001b[0m" : selected)}yes\u001b[0m");
            Screen.Print($"{(optionSelected == 1 ? "   \u001b[0m" : selected)}no\u001b[0m");

            key = Console.ReadKey();

            switch (key.Key)
            {
                case ConsoleKey.UpArrow:
                    if (optionSelected == 1)
                    {
                        optionSelected = 2;
                        break;
                    }

                    optionSelected--;
                    break;
                case ConsoleKey.DownArrow:
                    if (optionSelected == 2)
                    {
                        optionSelected = 1;
                        break;
                    }

                    optionSelected++;
                    break;
                case ConsoleKey.Enter:
                    isSelected = true;
                    break;
            }
        }

        return optionSelected;
    }
}