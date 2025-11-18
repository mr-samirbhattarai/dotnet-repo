// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

// main program
class Program
{
    static void Main(String[] args)
    {
        System.Console.WriteLine("Lab 4 - Assignment");

        Student student1 = new Student();
        student1.name = "Ram Bahadur";
        student1.grade = 'B';
        student1.age = 20;

        Student student2 = new Student();
        student2.name = "Hari Sharma";
        student2.grade = 'A';
        student2.age = 21;

        System.Console.WriteLine();
        System.Console.WriteLine("--------Student 1 Details-------");
        System.Console.WriteLine($"Student1 name : {student1.name}");
        System.Console.WriteLine($"Student1 grade : {student1.grade}");
        System.Console.WriteLine($"Student1 age : {student1.age}");

        System.Console.WriteLine();
        System.Console.WriteLine("--------Student 2 Details-------");
        System.Console.WriteLine($"Student2 name : {student2.name}");
        System.Console.WriteLine($"Student2 grade : {student2.grade}");
        System.Console.WriteLine($"Student2 age : {student2.age}");
        System.Console.WriteLine($"Total Student Count : {Student.totalStudentCount}");
        System.Console.WriteLine();

        Calculator calc = new Calculator();
        calc.PrintWelcome();

        int sum = calc.Add(5, 10);
        System.Console.WriteLine($"Addition: {sum}");

        int product1 = calc.Multiply(5, 2);
        System.Console.WriteLine($"Multiplication with both parameters: {product1}");

        int product2 = calc.Multiply(5);
        System.Console.WriteLine($"Multiplication with one parameter: {product2}");
        System.Console.WriteLine();

        ParameterDemo demo = new ParameterDemo();
        int number = 5;
        demo.Increase(ref number);
        System.Console.WriteLine($"Increased Number: {number}");
        demo.GetFullName(out string fullname);
        System.Console.WriteLine($"Full Name: {fullname}");
        int totalSum = demo.SumAll(1, 2, 3, 4, 5);
        System.Console.WriteLine($"Total Sum: {totalSum}");
        System.Console.WriteLine();

        Player defaultConstructor = new Player();

        Player parameterizedConstructor = new Player("John Doe", 7, "Normal");
        System.Console.WriteLine($"Name = {parameterizedConstructor.playerName}");
        System.Console.WriteLine($"Level = {parameterizedConstructor.level}");
        System.Console.WriteLine($"Health = {parameterizedConstructor.health}");
        System.Console.WriteLine();

        System.Console.WriteLine("Please enter the day:");
        string userInput = Console.ReadLine();

        if (userInput == "friday" || userInput == "saturday")
        {
            System.Console.WriteLine("It is: Weekend");
            System.Console.WriteLine();
        }
        else
        {
            System.Console.WriteLine("It is: Weekday");
            System.Console.WriteLine();
        }

        DebuggingDemo debuggdemo = new DebuggingDemo();
        debuggdemo.CalculatePercentage();
    }
}

// 1. Inside a new class named Student, perform following tasks:
// o Create 3 instance fields for storing any of the student details.
// o Create 1 static field
// 2. In Program.cs class, create two objects of Student.
// 3. Assign different values for instance fields for both object.
// 4. Display the field values of both objects and print the static field.

public class Student
{
    public string name = "";
    public char grade;
    public int age = 0;
    public static int totalStudentCount = 330;
}

// 1. Create a new class Calculator and perform following tasks:
// o Create a void method named PrintWelcome() that prints "Welcome to
// the Calculator".
// o Create a method named Add(int num1, int num2) with suitable return
// type and return the addition.
// o Create another method named Multiply(int num1, int num2) make num2
// an optional parameter and keep its default value as 1 and return the
// multiplication of two numbers.
// 2. In Program.cs, call the methods by creating an object and then print the
// values.

public class Calculator
{
    public void PrintWelcome()
    {
        System.Console.WriteLine("Welcome to the Calculator");
    }
    public int Add(int num1, int num2)
    {
        return num1 + num2;
    }
    public int Multiply(int num1, int num2 = 1)
    {
        return num1 * num2;
    }

}

// 1. Create a new class ParameterDemo.
// o In this class, create a method Increase(ref int number) that increases
// the number by 10.
// o Create a method name GetFullName(out string fullname) which will
// assign your full name into the out parameter.
// o Create a method SumAll(params int[] numbers) which will return the
// sum of all numbers passed into the method.
// 2. Now in Program.cs:
// o Create an object of the ParameterDemo class and call all three
// methods following their respective procedures.

public class ParameterDemo
{
    public void Increase(ref int number)
    {
        number += 10;
    }

    public void GetFullName(out string fullname)
    {
        fullname = "John Doe";
    }

    public int SumAll(params int[] numbers)
    {
        int sum = 0;
        for (int i = 0; i < numbers.Length; i++)
        {
            sum += numbers[i];
        }
        ;
        return sum;
    }
}

// Create a new class Player and perform following tasks:
// o Create instance fields playerName, level, health.
// o Create a default constructor which will only print "Default constructor
// has been called".
// o Create a parameterized constructor which will set the value of all
// three fields. (⚠ Reminder: you set the value while creating
// constructor)
// 2. Now in Program.cs:
// o Create one object using default constructor.
// o Create another object using parameterized constructor.
// o Print the values of the fields using both objects one after another.

public class Player
{
    public string playerName = "";
    public int level = 0;
    public string health = "";

    public Player()
    {
        System.Console.WriteLine("Default constructor has been called");
    }

    public Player(string playerName, int level, string health)
    {
        this.playerName = playerName;
        this.level = level;
        this.health = health;
    }
}

// 1. Create and enum named DayType with values Weekday and Weekend.
// 2. In Program.cs, ask the user to input the day (Example: "Sunday").
// o If the day entered is either Friday or Saturday, print "It is: Weekend"
// otherwise print "It is: Weekday".

enum DayType
{
    Weekday, Weekend
}

// Write the following program and use debugging to analyze what went wrong.
// o Ask the user to input two integers : marks and total.
// o Important: For taking inputs try utilizing the TryParse function provided
// by C# by reading the documentation here. (Hint: Checkout the example)
// o Calculate the value using double percentage = marks / total * 100.
// o Print the percentage.
// 2. Set two breakpoints: 
// o One before the calculation process takes place.
// o One after calculation process.
// 3. Run the program and observe:
// o Why is the output incorrect?
// o How can we correct the program?

public class DebuggingDemo
{
    // public void CalculatePercentage()
    // {
    // System.Console.WriteLine("Enter marks: ");
    //     int.TryParse(System.Console.ReadLine(), out double marks);

    // System.Console.Write("Enter total: ");
    //     int.TryParse(System.Console.ReadLine(), out double total);

    // int percentage = marks / total * 100;

    // System.Console.WriteLine($"Percentage: {percentage}%");
    // output is 0% because of integer division
    // }
    public void CalculatePercentage()
    {
        System.Console.WriteLine("Enter marks: ");
        double.TryParse(System.Console.ReadLine(), out double marks);

        System.Console.Write("Enter total: ");
        double.TryParse(System.Console.ReadLine(), out double total);

        double percentage = marks / total * 100;

        System.Console.WriteLine($"Percentage: {percentage}%");
    }


}