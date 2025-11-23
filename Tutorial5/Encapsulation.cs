class BadBankAccount
{
    public string? accountHolderName;

    public double balance;
}

class GoodBankAccount
{
    // private string accountNumber;
    private double balance;

    public void Deposit(double amount)
    {
        if (amount >= 0)
        {
            balance += amount;  // balance + amount
        }
        else
        {
            System.Console.WriteLine("Invalid Amount");
        }
    }

    public void Withdraw(double amount)
    {
        if (amount >= 0 && balance >= amount)
        {
            balance -= amount;
        }
        else
        {
            System.Console.WriteLine("Invalid Amount or no sufficient balance");
        }
    }

    public double Balance
    {
        get
        {
            return balance;
        }
        set
        {
            if (value >= 0)
            {
                balance = value;
            }
        }
    }
}