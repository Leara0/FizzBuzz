using FizzBuzz;

namespace FizzBuzzTest;

public class MethodTest
{
    
    [Theory]
    [InlineData (3, "fizz")]
    [InlineData (5, "buzz")]
    [InlineData (15, "fizzbuzz")]
    [InlineData (4, "")]
    [InlineData (40, "buzz")]
    [InlineData (18, "fizz")]
    public static void FizzBuzzTest(int number, string expected)
    {
        var actual = Method.FizzBuzz(number);
        Assert.Equal(expected, actual);


    }

}