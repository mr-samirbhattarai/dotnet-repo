class Program
{
    static void Main(string[] args)
    {
        System.Console.WriteLine();
        System.Console.WriteLine("------------------Lab 5 - Assignment------------------");

        System.Console.WriteLine("------------------Encapsulation------------------");
        // Task 1: Encapsulation
        // 4. In Program.cs, create an object of bank Account, display the account number, deposit and then withdraw the money. Then print the remaining balance.
        BankAccount myAccount = new BankAccount("123456789", 500);
        System.Console.WriteLine($"Account Number: {myAccount.AccountNumber}");
        System.Console.WriteLine($"Initial Balance: {myAccount.Balance}");
        myAccount.Deposit(200);
        System.Console.WriteLine($"Balance after deposit: {myAccount.Balance}");
        myAccount.Withdraw(100);
        System.Console.WriteLine($"Balance after withdrawal: {myAccount.Balance}");
        System.Console.WriteLine();


        System.Console.WriteLine("------------------Inheritance------------------");
        // Task 2: Inheritance
        // 3. In Program.cs, do the following:
        //         Create objects of both derived classes
        //         Call the methods of base class and demonstrate the code reusability
        System.Console.WriteLine("------------------Car------------------");
        Car myCar = new Car();
        myCar.Brand = "Toyota";
        myCar.Speed = 120;
        myCar.NumberOfTires = 4;
        System.Console.WriteLine($"Total : {myCar.NumberOfTires}");
        myCar.Start();
        myCar.DisplayInfo();
        myCar.Stop();
        System.Console.WriteLine();

        System.Console.WriteLine("------------------Bike------------------");
        Bike myBike = new Bike();
        myBike.Brand = "Yamaha";
        myBike.Speed = 80;
        myBike.OilCapacity = 12.3;
        System.Console.WriteLine($"Total : {myBike.OilCapacity}");
        myBike.Start();
        myBike.DisplayInfo();
        myBike.Stop();
        System.Console.WriteLine();

        System.Console.WriteLine("------------------Polymorphism------------------");
        // Task 3: Polymorphism - Method Overloading
        // 2.Call all of these methods in Program.cs
        System.Console.WriteLine("------------------Printer Example - (Method Overloading)------------------");
        Printer printer = new Printer();
        printer.Print();
        printer.Print("Hello, World!");
        printer.Print(123);
        printer.Print("Repeat this message", 3);
        System.Console.WriteLine();

        // Task 3: Polymorphism - Method Overriding
        // 3. In Program.cs, create object of derived classes and call all its methods.
        System.Console.WriteLine("-------------------Teacher Example - (Method Overriding)------------------");
        NepaliTeacher nepaliTeacher = new NepaliTeacher();
        nepaliTeacher.Name = "Ram";
        nepaliTeacher.Teaching();
        nepaliTeacher.SalaryInfo();

        EnglishTeacher englishTeacher = new EnglishTeacher();
        englishTeacher.Teaching();

        System.Console.WriteLine("------------------Abstraction------------------");
        // Task 4: Abstraction
        // 3. Now in Program.cs, create an object of both Car and Bike. Then call Display(), StartEngine() and StopEngine() using both objects.
        Jeep myJeep = new Jeep();
        myJeep.Display();
        myJeep.StartEngine();
        myJeep.StopEngine();
        System.Console.WriteLine();

        Motorcycle myMotorcycle = new Motorcycle();
        myMotorcycle.Display();
        myMotorcycle.StartEngine();
        myMotorcycle.StopEngine();
        System.Console.WriteLine();

        // Task 5: OOP - Electronics Store
        // 4. Main Method
        //      Create a ElectronicsStore object
        //      Create Laptop and Smartphone objects with brand and price
        //      Add them to the store
        //      Call ShowAllDeviceDetails() to display info and child-specific behavior
        System.Console.WriteLine("------------------OOP - Electronics Store------------------");
        ElectronicsStore store = new ElectronicsStore();

        Laptop laptop = new Laptop("Dell", 1200.50);
        store.AddDevice(laptop);
        Smartphone smartphone = new Smartphone("Samsung", 899.99);
        store.AddDevice(smartphone);
        store.ShowAllDeviceDetails();
    }
}
