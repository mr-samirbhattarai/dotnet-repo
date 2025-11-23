// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

class Program
{
    static void Main(string[] args)
    {
        System.Console.WriteLine("Welcome to Tutorial 5!");
        System.Console.WriteLine("-----------------Encapsulation---------------");
        System.Console.WriteLine("-----------------Bad Account---------------");
        BadBankAccount badBankAccount = new BadBankAccount();
        badBankAccount.balance = 1000;
        badBankAccount.balance = -9999;
        badBankAccount.accountHolderName = "Hello";
        System.Console.WriteLine($"{badBankAccount.accountHolderName} has balance {badBankAccount.balance}");
        System.Console.WriteLine();

        System.Console.WriteLine("-----------------Good Account---------------");
        GoodBankAccount goodBankAccount = new GoodBankAccount();
        goodBankAccount.Balance = 1000;    // This value doesnot get updated
        System.Console.WriteLine($"Good Balance = {goodBankAccount.Balance}");
        goodBankAccount.Balance = -9999;
        System.Console.WriteLine($"Good Balance = {goodBankAccount.Balance}");
        goodBankAccount.Deposit(1000);
        goodBankAccount.Withdraw(199);
        goodBankAccount.Deposit(55);
        System.Console.WriteLine($"{goodBankAccount.Balance}");
        System.Console.WriteLine();

        System.Console.WriteLine("-----------------Inheritance---------------");
        System.Console.WriteLine("-----------------Car---------------");

        Car car1 = new Car();
        car1.Brand = "Toyota";
        car1.Speed = 150;
        car1.Seats = 4;
        System.Console.WriteLine($"Total Seats: {car1.Seats}");
        car1.Start();
        car1.DisplayInfo();
        car1.Stop();
        System.Console.WriteLine();

        System.Console.WriteLine("-----------------Bike---------------");
        Bike bike1 = new Bike();
        bike1.Brand = "TVS";
        bike1.Speed = 100;
        bike1.HasSideBox = true;
        bike1.Start();
        bike1.DisplayInfo();
        System.Console.WriteLine($"Has Sidebox: {bike1.HasSideBox}");
        bike1.Stop();
        System.Console.WriteLine();

        System.Console.WriteLine("-----------------Polymorphism---------------");

        System.Console.WriteLine("-----------------Compile Time, Method Overloading---------------");
        Printer printer = new Printer();
        printer.Print();
        printer.Print("Ram");
        printer.Print(9);
        printer.Print("This is message", 5);
        System.Console.WriteLine();

        System.Console.WriteLine("-----------------Run Time, Method Overriding---------------");
        NepaliTeacher nepaliTeacher = new NepaliTeacher();
        nepaliTeacher.Teaching();
        EnglishTeacher englishTeacher = new EnglishTeacher();
        englishTeacher.Teaching();
        System.Console.WriteLine();

        System.Console.WriteLine("-----------------Abstraction---------------");
        Bus bus = new Bus();
        bus.StartEngine();
        bus.StopEngine();
        bus.Display();
        System.Console.WriteLine();

        MotorCycle motorCycle = new MotorCycle();
        motorCycle.StartEngine();
        motorCycle.StopEngine();
        motorCycle.Display();
        System.Console.WriteLine();

    }
}