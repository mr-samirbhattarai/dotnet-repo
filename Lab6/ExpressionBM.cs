// Task 1: Expression Bodied Members [10 Minutes]
// 1. The class below calculates the area of a rectangle. Convert both properties and methods into expression-bodied members. Also add a method to calculate its perimeter.

public class QuestionRectangle
{
    private double length;
    private double breadth;

    public double Length
    {
        get { return length; }
        set { length = value; }
    }
    public double Breadth
    {
        get { return breadth; }
        set { breadth = value; }
    }
    public double GetArea()
    {
        return length * breadth;
    }
    public string ShowDetails()
    {
        return $"Length: {length}, Breadth: {breadth}";
    }
}

    // IN EXORESSION BODIES MEMBERS
public class Rectangle
{
    private double length;
    private double breadth;

    public double Length
    {
        get => length;
        set => length = value;
    }
    public double Breadth
    {
        get => breadth;
        set => breadth = value;
    }
    public double GetArea() => length * breadth;

    public string ShowDetails() => $"Length: {length}, Breadth: {breadth}";
}