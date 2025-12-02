// 1. Selecting / Projection
//      • Create a list of integers: [1, 2, 3, 4, 5].
//      • Use LINQ to square each number and store it in a new collection.
//      • Print the squared numbers.
public class SelectionProjection
{
    public static void SquareNumbers()
    {
        int[] numberList = { 1, 2, 3, 4, 5 };
        var squaredNumbers = numberList.Select(n => n * n);
        System.Console.WriteLine($"Squared Numbers: {string.Join(", ", squaredNumbers)}");
    }
}
// 2. Filtering (Where)
//      • A bookstore wants to filter its premium books from their price list. Use LINQ to extract all books priced above Rs. 1000.
//      • [Hint: You need to have a list of books' object]
    
public class Book
{
    public string Title { get; set; }
    public double Price { get; set; }
    
}


// 3. Sorting (OrderBy/OrderByDescending)
//      • Islington college is about to award 10 students AAA scholarship award, sort their name alphabetically.
//      • [Hint: You need to have a list of students' object]

public class Students
{
    public string Name { get; set; }
    public double GPA { get; set; }
}

// 1. Aggregation Operator
//      o A supermarket collected daily sales from its cashiers. Now using LINQ calculate:
//        ▪ Total number of cashiers and total sales of the day
//        ▪ Highest, lowest and average sales
//      o [Hint: Make a list of CashierSales object ]

public class CashierSales
{
    public string CashierName { get; set; }
    public double SalesAmount { get; set; }
}



// 2. Quantifier Operators (Any/All)
//      o You are working in Election Commission office. Now check:
//        ▪ Are there any applicant under 18.
//        ▪ If every applicants are above 16
//        ▪ [Hint: Make a list of Applicants Object]

public class Applicant
{
    public string Name { get; set; }
    public int Age { get; set; }
}
// 3. Element Operators (First, Last, FirstOrDefault)
//      o A music app stores song duration in seconds. Using LINQ, find the following:
//        ▪ First song & Last song
//        ▪ First song with duration above 4 minutes
//        ▪ A safe result for the first song longer than 10 minutes (use FirstOrDefault)
//        ▪ [Hint: Use a list of music object with required fields]
public class Music
{
    public string Title { get; set; }
    public int DurationInSeconds { get; set; }
}



// 1. A travel company stores a list of tour bookings. Each booking contains the following information:
//      o CustomerName
//      o Destination
//      o Price
//      o DurationInDay
//      o IsInternational
// 2. Scenario: The company wants to prepare a summary report for market analysis. Using LINQ, perform following the following:
//      o Filter:
//         ▪ Tours above Rs. 10,000.
//         ▪ Tour duration more than 4 days.
//      o Transform (Project) the filtered list into a new list which will contain:
//         ▪ CustomName
//         ▪ Destination
//         ▪ Category : "International" or "Domestic" based on IsInternational
//      • Now sort the result based on Category (Display domestic category first, then
//        International). Then sort the list based on price as well.
//      • Now display each element of the list in a clean format.

public class TourBooking
{
    public string CustomerName { get; set; }
    public string Destination { get; set; }
    public double Price { get; set; }
    public int DurationInDay { get; set; }
    public bool IsInternational { get; set; }

    public void DisplayBookingDetails()
    {
        string category = IsInternational ? "International" : "Domestic";
        System.Console.WriteLine($"Customer: {CustomerName}, Destination: {Destination}, Price: {Price}, Duration: {DurationInDay} days, Category: {category}");
    }
}

