// Delegate = Remote control 
// You don't call the TV directly,
// You press button on remote control
// Remote control TV what to do

// Similarly:
// You don't call the method directly
// You call the delegate
// Delegate tell which method to call;

public delegate void NotifyUser(string message);
public static class NotificationService
{
    public static void SendSMS(string message)
    {
        System.Console.WriteLine($"SMS: {message}");
    }
    public static void SendEmail(string message) => System.Console.WriteLine($"Email : {message}");
    public static void ShowPopup(string message) => System.Console.WriteLine($"PopUp: {message}");
}