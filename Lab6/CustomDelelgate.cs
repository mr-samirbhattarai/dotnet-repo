// 1. Create a delegate named Calculate that accepts two integers and returns an integer.
//      • Write two methods: Add() and Subtract().
//      • Use the delegate to call both methods.

public delegate int Calculate(int num1, int num2);

public static class Calculator
{
    public static int Add(int a, int b) => a + b;

    public static int Subtract(int a, int b) => a - b;
}



// 2. Define a delegate named DiscountStrategy that takes a price (double) and returns the discounted price.
//      • Create three discount methods:
//      • FestivalDiscount → 20% off
//      • SeasonalDiscount → 10% off
//      • NoDiscount → returns price as it is
public delegate double DiscountStrategy(double price);

public static class Discount
{
    public static double FestivalDiscount(double price) => price * 0.8;

    public static double SeasonalDiscount(double price) => price * 0.9;

    public static double NoDiscount(double price) => price;




// 2.1 Create a method named CalculateFinalPrice(double originalPrice, DiscountStrategy strategy) that:
//      • Accepts the original price
//      • Accepts a delegate as the discount strategy
//      • Returns the final payable amount

    public static double CalculateFinalPrice(double originalPrice, DiscountStrategy finalPayableAmount)
    {
        return finalPayableAmount(originalPrice);
    }
}