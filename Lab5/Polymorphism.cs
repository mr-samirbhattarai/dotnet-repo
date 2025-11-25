// 1. Create a class Printer with the following overloaded methods:
//       Print(string message), Print(int number) and Print(string message, int count)

class Printer
{
    public void Print()
    {
        System.Console.WriteLine("Default Print Method without parameters");
    }
    public void Print(string message)
    {
        System.Console.WriteLine($"Message: {message}");
    }

    public void Print(int number)
    {
        System.Console.WriteLine($"Number: {number}");
    }

    public void Print(string message, int count)
    {
        for (int i = 0; i < count; i++)
        {
            System.Console.WriteLine($"Message {i + 1}: {message}");
        }
    }
}

// 1. Create a class named Teacher with the following specifications:
//       A property called Name.
//       A method Teaching() that prints "Teacher teaches in English".
//       Another method SalaryInfo() that cannot be overridden by any child classes.

class Teacher
{
    public string Name { get; set; }

    public virtual void Teaching()
    {
        System.Console.WriteLine("Teacher teaches in English");
    }
    // TODO: Make this method sealed
    public void SalaryInfo()
    {
        System.Console.WriteLine("Salary cannot be overridden by child classes");
    }
}
// 2. Then, create the following derived classes:
//      NepaliTeacher: Inherits from Teacher and overrides the Teaching() method to provide its own behavior.
//      EnglishTeacher: Inherits from Teacher and demonstrates that it is not necessary to override the Teaching() method.

class NepaliTeacher : Teacher
{
    public override void Teaching()
    {
        System.Console.WriteLine("Nepali Teacher teaches in Nepali");
    }
}

class EnglishTeacher : Teacher{}
