// 1. Create a method:
//      • void ProcessNumbers(int[] numbers, Func<int, bool> condition)
// 2. Use it to print:
//      • Only even numbers
//      • Only numbers greater than 10
//      (Pass a Func delegate for the condition.)

public class BuiltInDelegate
{
    public static void ProcessNumbers(int[] numbers, System.Func<int, bool> condition)
    {
        foreach (var num in numbers)
        {
            if (condition(num))
            {
                System.Console.WriteLine(num);
            }
        }
    }
}