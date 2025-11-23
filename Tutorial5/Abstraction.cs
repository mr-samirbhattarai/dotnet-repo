public abstract class Motors
{
    public abstract void StartEngine();

    public abstract void StopEngine();

    public void Display()
    {
        System.Console.WriteLine("This is Motor");
    }
}

public class Bus:Motors
{
    public override void StartEngine()
    {
        System.Console.WriteLine("Start engine with Diesel");
    }
    public override void StopEngine()
    {
        System.Console.WriteLine("Engine stops for bus");
    }
}

public class MotorCycle:Motors
{
    public override void StartEngine()
    {
        System.Console.WriteLine("Start engine with Petrol");
    }
    public override void StopEngine()
    {
        System.Console.WriteLine("Engine stops for motorcycle");
    }
}