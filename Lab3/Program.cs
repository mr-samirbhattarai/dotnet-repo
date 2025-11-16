using System.Runtime.CompilerServices;
using System.Transactions;

namespace Lab3
{
    // Create the following methods inside the Operators class:
    // • Add(int a, int b) — prints the sum of two numbers
    // • Subtract(int a, int b) — prints the difference
    // • Multiply(int a, int b) — prints the product
    // • Divide(int a, int b) — prints the result of division
    // 2. Create another method inside the same class:
    // • OddEvenFinder(int number) — determines whether the given number
    // is Odd or Even using the Ternary Operator (? :) and prints the
    // message "Even Number" or "Odd Number".
    // 3. In Program.cs:
    // • Call all the methods of the Operators class
    class Operators
    {

        static void Main(string[] args)
        {

            int a = 23;
            int b = 94;
            int number = 11;

            Add(a, b);
            Subtract(a, b);
            Multiply(a, b);
            Divide(a, b);
            OddEvenFinder(number);
            NullOperations.PerformNullChecks();
            ClassifyByAge();
            DayOfWeek();
            SumToN();
            PrintNumbers();
            SumOfArray();
            ExceptionHandlingDemo();
            PasswordValidation();
        }

        public static void Add(int a, int b)
        {
            System.Console.WriteLine("-------------------------Addition-------------------------");
            System.Console.WriteLine($"The sum of {a} and {b} is {a + b}");
            System.Console.WriteLine();
        }
        public static void Subtract(int a, int b)
        {
            System.Console.WriteLine($"-------------------------Subtraction-------------------------");
            System.Console.WriteLine($"The difference between {a} and {b} is {a - b}");
            System.Console.WriteLine();
        }
        public static void Multiply(int a, int b)
        {
            System.Console.WriteLine($"-------------------------Multiplication-------------------------");
            System.Console.WriteLine($"The product of {a} and {b} is {a * b}");
            System.Console.WriteLine();
        }
        public static void Divide(int a, int b)
        {
            System.Console.WriteLine($"-------------------------Division-------------------------");
            System.Console.WriteLine($"The result of dividing {a} by {b} is {a / b}");
            System.Console.WriteLine();
        }

        public static void OddEvenFinder(int number)
        {
            System.Console.WriteLine($"-------------------------Odd or Even-------------------------");
            string oddOrEven = (number % 2 == 0) ? "Even" : "Odd";
            System.Console.WriteLine($"The number {number} is {oddOrEven}");
            System.Console.WriteLine();
        }

        public static void ClassifyByAge()
        {
            System.Console.WriteLine($"-------------------------Classify By Age-------------------------");
            System.Console.WriteLine("Please enter your age: ");
            System.Console.WriteLine();
            int age = int.Parse(Console.ReadLine());
            switch (age)
            {
                case (> 0 and < 13):
                    System.Console.WriteLine("You are a Child.");
                    System.Console.WriteLine();
                    break;
                case (>= 13 and < 20):
                    System.Console.WriteLine("You are a Teenager.");
                    System.Console.WriteLine();
                    break;
                case >= 20:
                    System.Console.WriteLine("You are an Adult.");
                    System.Console.WriteLine();
                    break;
                default:
                    System.Console.WriteLine("Invalid age.");
                    System.Console.WriteLine();
                    break;
            }
        }

        public static void DayOfWeek()
        {
            System.Console.WriteLine($"-------------------------Day Of Week-------------------------");
            System.Console.WriteLine("Please enter number between 1-7: ");
            int day = int.Parse(Console.ReadLine());
            switch (day)
            {
                case 1:
                    System.Console.WriteLine("Sunday");
                    System.Console.WriteLine();
                    break;
                case 2:
                    System.Console.WriteLine("Monday");
                    System.Console.WriteLine();
                    break;
                case 3:
                    System.Console.WriteLine("Tuesday");
                    System.Console.WriteLine();
                    break;
                case 4:
                    System.Console.WriteLine("Wednesday");
                    System.Console.WriteLine();
                    break;
                case 5:
                    System.Console.WriteLine("Thursday");
                    System.Console.WriteLine();
                    break;
                case 6:
                    System.Console.WriteLine("Friday");
                    System.Console.WriteLine();
                    break;
                case 7:
                    System.Console.WriteLine("Saturday");
                    System.Console.WriteLine();
                    break;
                default:
                    System.Console.WriteLine("Please select correct number");
                    System.Console.WriteLine();
                    break;
            }
        }


        // 1. Ask the user to input a number N.
        //  Using a for loop, calculate and print the sum from 1 to N
        public static void SumToN()
        {
            System.Console.WriteLine($"-------------------------Sum To N-------------------------");
            System.Console.WriteLine("Enter a number");
            int n = int.Parse(Console.ReadLine());
            int sum = 0;
            for (int i = 1; i <= n; i++)
            {
                sum = sum + i;
            }
            System.Console.WriteLine($"The imput is {n} and the output is {sum}");
            System.Console.WriteLine();
        }

        // 2. Print numbers from 1 to 20 using while loop:
        // • Skip (continue) multiples of 4
        // • Stop (break) when number is 15
        public static void PrintNumbers()
        {
            int number = 1;
            while (number <= 20)
            {
                if (number % 4 == 0)
                {
                    number++;
                    continue;
                }
                if (number == 15)
                {
                    break;
                }
                System.Console.WriteLine($"-------------------------Print Numbers-------------------------");
                System.Console.WriteLine(number);
                System.Console.WriteLine();
                number++;
            }
        }

        // 3. Write a program to find the sum of all elements in an array using a foreach loop
        public static void SumOfArray()
        {
            int[] numbers = { 1, 2, 3, 4, 5, 6 };
            int total = 0;
            foreach (int num in numbers)
            {
                total += num;
            }
            System.Console.WriteLine($"-------------------------Sum Of Array-------------------------");
            System.Console.WriteLine($"The sum of all elements in the array is: {total}");
            System.Console.WriteLine();
        }

        public static void ExceptionHandlingDemo()
        {
            System.Console.WriteLine($"-------------------------Exception Handling Demo-------------------------");
            System.Console.WriteLine("Enter a number ");
            try
            {
                int n = int.Parse(Console.ReadLine());
            }
            catch (FormatException)
            {
                System.Console.WriteLine("Invalid number format");
                System.Console.WriteLine();
            }
            finally
            {
                System.Console.WriteLine("Program Executed");
                System.Console.WriteLine();
            }
        }

        public static void PasswordValidation()
        {
            System.Console.WriteLine($"-------------------------Password Validation-------------------------");
            System.Console.WriteLine("Enter password: ");
            try
            {
                string password = Console.ReadLine();
                if (password.Length < 6)
                {
                    throw new Exception("Password must be at least 6 characters long.");
                    System.Console.WriteLine();
                }
                System.Console.WriteLine("Password satisfied the requirement.");
                System.Console.WriteLine();
            }
            catch (Exception ex)
            {
                System.Console.WriteLine($"Error: {ex.Message}");
            }
            finally
            {
                System.Console.WriteLine("Password validation completed.");
                System.Console.WriteLine();
            }
        }
    }

    class NullOperations
    {
        public static void PerformNullChecks()
        {
            string? username = null;

            // Ternary Operator
            System.Console.WriteLine($"-------------------------Null Checks-------------------------");
            string ternaryChecking = (username == null) ? "Ternary Check: Username is not available" : username;
            System.Console.WriteLine(ternaryChecking);

            // Null Coalescing Operator
            string NullCoalescingChecking = username ?? "Null Coalescing Check: Username Not Available";
            System.Console.WriteLine(NullCoalescingChecking);

            // Null Coalescing Assignment Operator
            username ??= "Samir";
            System.Console.WriteLine($"Null Coalescing Assignment: {username}");
            System.Console.WriteLine();

        }
    }
}
