namespace FizzBuzz;

public class Method
{
    public static string FizzBuzz(int number)
    {
        var fizz= false;
        var buzz = false;

        if (number % 3 == 0)  fizz = true;
        if (number % 5 == 0)  buzz = true;

        if (fizz && buzz) return "fizzbuzz";
        if (fizz) return "fizz";
        if (buzz) return "buzz";
        return "";
    }

}