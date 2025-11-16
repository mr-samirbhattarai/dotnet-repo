public class Student
{
    public string name = "";
    public int age;
    public string grade = "";
    public static string schoolName = "ICP";
}

public class Calculator
{
    public int age;
    public void PrintWelcome()
    {
        System.Console.WriteLine("Welcome!!!");
    }

    public int Add(int num1, int num2)
    {
        int sum = num1 + num2;
        return sum;
    }

    public int Multiply(int num1, int num2)
    {
        int multiply = num1 * num2;
        return multiply;
    }

}

public class ParameterDemo
{
    public void ChangeValue(int number)
    {
        number = 100;
        System.Console.WriteLine(number);
    }
    public void RefChangeValue(ref int refNum)
    {
        System.Console.WriteLine(refNum);
    }
}

class Program
{
    static void Main(String[] args)
    {
        Student student1 = new Student(); // this is the instance of the class Student, It is called object
        Student student2 = new Student(); // this is the instance of the class Student, It is called object

        student1.name = "Ram";
        student1.age = 40;

        System.Console.WriteLine("-----Student 1--------");
        System.Console.WriteLine($"Student 1 name: {student1.name}");
        System.Console.WriteLine($"Student 1 age: {student1.age}");

        Calculator calc = new Calculator();
        System.Console.WriteLine(calc.Add(4, 5));

        ParameterDemo demo = new ParameterDemo();
        int myNumber = 50;

        int refNum = 90;
        System.Console.WriteLine(myNumber); // 50
        demo.RefChangeValue(ref refNum); 
        demo.ChangeValue(myNumber); 
        System.Console.WriteLine(myNumber);
        System.Console.WriteLine(refNum);
    }
}
