// 1. Create a base class Vehicle with following:
//      o Properties: Brand, Speed
//      o Methods: Start(), Stop(), DisplayInfo()

public class Vehicle
{
    public string Brand { get; set; }
    public double Speed { get; set; }
    public void Start()
    {
        System.Console.WriteLine("Vehicle Started");
    }
    public void Stop()
    {
        System.Console.WriteLine("Vehicle Stopped");
    }
    public void DisplayInfo()
    {
        System.Console.WriteLine($"Brand: {Brand}, Speed: {Speed}");
    }
}

// 2. Create two derived classes Car and Motorcycle. Each class must add one unique field like seats for class Car. 
// Override the DisplayInfo() and also display the unique field added.

public class Car : Vehicle
{
    public int NumberOfTires { get; set; }
}

public class Bike : Vehicle
{
    public double OilCapacity { get; set; }
}