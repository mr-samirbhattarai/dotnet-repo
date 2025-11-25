
// 1. Create a class BankAccount and perform following tasks:
//      Create private fields accountNumber and balance.
//      Create two public properties:
//          AccountNumber with only get and not set. (Hint you will pass the value using constructor).
//          Balance with a condition that doesn’t allow negative or 0 values.
//          (Make set private)

public class BankAccount
{
    private string accountNumber;
    private double balance;

    public string AccountNumber
    {
        get { return accountNumber; }
    }

    public double Balance
    {
        get { return balance; }
        private set
        {
            if (value > 0)
            {
                balance = value;
            }
            else
            {
                throw new ArgumentException("Negative or zero balance not allowed!");
            }
        }
    }

    public BankAccount(string accNumber, double initialBalance)
    {
        accountNumber = accNumber;
        Balance = initialBalance;
    }



// 2. Create two methods Deposit(double amount) and withdraw(double amount) these methods will change amount in the balance private field.
// 3. Add a conditions in both method and verify the amounts.
    public void Deposit(double amount)
    {
        if (amount > 0)
        {
            Balance += amount;
        }
        else
        {
            throw new ArgumentException("Deposit amount must be positive.");
        }
    }

    public void Withdraw(double amount)
    {
        if (amount > 0 && amount <= Balance)
        {
            Balance -= amount;
        }
        else
        {
            throw new ArgumentException("Invalid withdraw amount.");
        }
    }
}