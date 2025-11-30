// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

class Program
{
    static void Main(string[] args)
    {
        System.Console.WriteLine("------------------Tutorial 6------------------");
        System.Console.WriteLine();

        // Old Calculator
        System.Console.WriteLine("------------------Old Calculator------------------");
        OldCalculator oldCalc = new OldCalculator();
        oldCalc.PrintMessage($"Old Calculator");
        int result1 = oldCalc.Add(5, 10);
        oldCalc.CalculateModel = "Abacus";
        System.Console.WriteLine(oldCalc.CalculateModel);
        System.Console.WriteLine(result1);
        System.Console.WriteLine();
        // New Calculator
        System.Console.WriteLine("------------------New Calculator------------------");
        NewCalculator newCalc = new NewCalculator();
        newCalc.PrintMessage($"New Calculator");
        int result2 = newCalc.Add(5, 10);
        newCalc.CalculatorModel = "casio";
        System.Console.WriteLine(newCalc.CalculatorModel);
        System.Console.WriteLine(result2);
        System.Console.WriteLine();

        // Delegates
        System.Console.WriteLine("------------------Delegates------------------");
        System.Console.WriteLine("------------------ Notification Service ------------------");
        NotifyUser notify;
        notify = NotificationService.SendSMS;
        notify("Message via SMS");

        notify = NotificationService.SendEmail;
        notify("Message via Email");

        notify = NotificationService.ShowPopup;
        notify("Message via PopUp");
        System.Console.WriteLine();

        System.Console.WriteLine("------------------ Lambda Expressions ------------------");
        MathDelegate operation;
        operation = (a, b) => a + b; // Lambda expression for addition
        System.Console.WriteLine($"ADD: {operation(10,5)}");

        operation = (a, b) => a - b; // Lambda expression for subtraction
        System.Console.WriteLine($"SUBTRACT: {operation(10,5)}");
        System.Console.WriteLine();

        System.Console.WriteLine("------------------ LINQ Example ------------------");
        LINQExample.Score1();
        LINQExample.Score2();
        LINQExample.Score3();
        LINQExample.Score4();
        LINQExample.Score5();
        LINQExample.Score6();
        LINQExample.Score7();
        LINQExample.Score8();
        LINQExample.Score9();
        LINQExample.Score10();
        System.Console.WriteLine();
    }
}