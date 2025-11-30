class OldCalculator
{
    private string calculateModel;
    public string CalculateModel
    {
        get { return calculateModel; }
        set { calculateModel = value; }
    }
    public int Add(int x, int y)
    {
        // Simulate an old, less efficient addition method
        return x + y;
    }

    public void PrintMessage(string message)
    {
        System.Console.WriteLine(message);
    }
}

class NewCalculator
{
    private string calculateModel;
    public string CalculatorModel
    {
        get => calculateModel;
        set => calculateModel = value;
    }

    // when only accessor is used i.e. getter only
    // public int CalculatorModel => calculateModel;

    public int Add(int x, int y) => (x + y);  // (=> lambda operator)

    public void PrintMessage(string message) => System.Console.WriteLine(message);
}