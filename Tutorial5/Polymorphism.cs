// 1. Different numbers of parameters
// 2. Different types of parameters if same number of parameters

// Method Overloading - Compile Time Overloading
class Printer
{
    public void Print()
    {
        System.Console.WriteLine("Print function without any params");
    }


    public void Print(string name)
    {
        // System.Console.WriteLine("Enter your name");
        // name = System.Console.ReadLine();
        System.Console.WriteLine($"Your name is {name}");
    }

    public void Print(int number)
    {
        System.Console.WriteLine($"NUmber: {number}");
    }

    public void Print(string message, int number)
    {
        for (int i = 0; i<number; i++)
        {
            System.Console.WriteLine($"{message}");
        }
    }
}

// Method Overloading - Run Time Overloading

class Teacher
{
    // public string name{get; set;}

    public virtual void Teaching()
    {
        System.Console.WriteLine("Teacher teaches");
    }
    public virtual void SalaryInfo(){
        System.Console.WriteLine("33,333");
    }
}

class NepaliTeacher: Teacher
{
    public override void Teaching()
    {
        System.Console.WriteLine("Nepali Teacher teaches in Nepali");
        // base.Teaching();
    }
    public sealed override void SalaryInfo()
    {
        System.Console.WriteLine("40,000");
    }
}

class PrimaryNepaliTeacher : NepaliTeacher
{
    // public override void SalaryInfo(){}
}

class EnglishTeacher: Teacher
{
    public override void Teaching()
    {
        System.Console.WriteLine("English Teacher teaches in English");
        // base.Teaching();
    }
}