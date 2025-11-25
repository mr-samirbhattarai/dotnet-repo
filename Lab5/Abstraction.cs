// 1. Create an abstract class Vehicle and perform following tasks:
//      Create abstract method method StartEngine() and StopEngine().
//      Add a concrete method Display() which will print "This is a vehicle".

abstract class Motor
{
    public abstract void StartEngine();
    public abstract void StopEngine();

    public void Display()
    {
        System.Console.WriteLine("This is a vehicle");
    }
}

// 2. Now create two derived classes Car and Bike and do the following:
//      Implement both StartEngine() and StopEngine() in both classes
//      Inside the methods, display a suitable message.

class Jeep : Motor
{
    public override void StartEngine()
    {
        System.Console.WriteLine("Jeep engine started");
    }

    public override void StopEngine()
    {
        System.Console.WriteLine("Jeep engine stopped");
    }
}

class Motorcycle : Motor
{
    public override void StartEngine()
    {
        System.Console.WriteLine("Motorcycle engine started");
    }

    public override void StopEngine()
    {
        System.Console.WriteLine("Motorcycle engine stopped");
    }
}