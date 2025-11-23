class Vehicle
{
    public string Brand {get; set;}
    public double Speed {get; set;}

    public void Start()
    {
        System.Console.WriteLine("Starting......");
    }
    public void Stop()
    {
        System.Console.WriteLine("Stopping......");
    }

    public void DisplayInfo()
    {
        System.Console.WriteLine($"Brand: {Brand}");
        System.Console.WriteLine($"Speed: {Speed}km/h");
    }
}






class Car : Vehicle
{
    public int Seats{get; set;}
}

class Bike : Vehicle
{
    public bool HasSideBox{get; set;}
}