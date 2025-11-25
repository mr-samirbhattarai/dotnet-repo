// 1.  Abstract Class: ElectronicDevice
//      Create an abstract class ElectronicDevice.
//      Add private fields brand and price.
//      Provide public properties Brand and Price to access these fields (implement encapsulation).
//      Add an abstract method ShowInfo() to display device information.
//      Add a constructor to initialize Brand and Price

abstract class ElectronicDevice
{
    private string brand;
    private double price;

    public string Brand
    {
        get { return brand; }
        set { brand = value; }
    }

    public double Price
    {
        get { return price; }
        set { price = value; }
    }

    abstract public void ShowInfo();

    public ElectronicDevice(string brand, double price)
    {
        Brand = brand;
        Price = price;
    }
}

// 2. Derived Classes
//      Laptop
//      - Inherit from ElectronicDevice.
//      - Add an extra method TurnOnBattery() to simulate turning on the laptop battery.
//      - Override the ShowInfo() method to display laptop details.
//      Smartphone
//      - Inherit from ElectronicDevice.
//          dd an extra method EnableCamera() to simulate enabling the smartphone camera.
//          Override the ShowInfo() method to display smartphone details

class Laptop : ElectronicDevice
{
    public Laptop(string brand, double price) : base(brand, price) { }

    public void TurnOnBattery()
    {
        System.Console.WriteLine("Laptop battery is now ON");
        System.Console.WriteLine();
    }

    public override void ShowInfo()
    {
        System.Console.WriteLine($"Laptop Brand: {Brand}, Price: {Price}");
    }
}

class Smartphone : ElectronicDevice
{
    public Smartphone(string brand, double price) : base(brand, price) { }

    public void EnableCamera()
    {
        System.Console.WriteLine("Smartphone camera is now ENABLED");
        System.Console.WriteLine();
    }

    public override void ShowInfo()
    {
        System.Console.WriteLine($"Smartphone Brand: {Brand}, Price: {Price}");
    }
}




// 3. Create Store Class: ElectronicsStore
//      Create a class ElectronicsStore.
//      Maintain a list of ElectronicDevice objects.
//      Implement the following methods:
//      - AddDevice(ElectronicDevice device) → to add a device to the store.
//      - RemoveDevice(ElectronicDevice device) → to remove a device from the store.
//      - ShowAllDeviceDetails() → to display information of all devices in the store.
//        (Hint: Call ShowInfo() for each device.)
//      Downcast and call child specific methods too. 

class ElectronicsStore
{
    private List<ElectronicDevice> devices = new List<ElectronicDevice>();


    public void AddDevice(ElectronicDevice device)
    {
        devices.Add(device);
    }
    public void RemoveDevice(ElectronicDevice device)
    {
        devices.Remove(device);
    }
    public void ShowAllDeviceDetails()
    {
        for (int i = 0; i < devices.Count; i++)
        {
            var device = devices[i];
            device.ShowInfo();
            if (device is Laptop laptop)
            {
                laptop.TurnOnBattery();
            }
            else if (device is Smartphone smartphone)
            {
                smartphone.EnableCamera();
            }
        }
    }
}