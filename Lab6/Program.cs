class Program
{
    static void Main(string[] args)
    {
        System.Console.WriteLine("-------------------------Lab 6 - Assignment-------------------------");
        System.Console.WriteLine();
        System.Console.WriteLine("-------------------------Expression Bodied Members-------------------------");

        Rectangle rect = new Rectangle();
        rect.Length = 5;
        rect.Breadth = 10;
        System.Console.WriteLine(rect.ShowDetails());
        System.Console.WriteLine($"Area: {rect.GetArea()}");
        System.Console.WriteLine();


        System.Console.WriteLine("-------------------------Custom Delegate-------------------------");
        System.Console.WriteLine("-------------------------Calculate-------------------------");
        Calculate calculate = Calculator.Add;
        int sum = calculate(5, 7);
        System.Console.WriteLine($"Add: {sum}");
        calculate = Calculator.Subtract;
        int difference = calculate(10, 4);
        System.Console.WriteLine($"Subtract: {difference}");
        System.Console.WriteLine();

        System.Console.WriteLine("-------------------------DiscountStrategy-------------------------");
        DiscountStrategy discountStrategy = Discount.FestivalDiscount;
        double festivalPrice = discountStrategy(1000);
        System.Console.WriteLine($"Festival Discount Price: {festivalPrice}");
        discountStrategy = Discount.SeasonalDiscount;
        double seasonalPrice = discountStrategy(1000);
        System.Console.WriteLine($"Seasonal Discount Price: {seasonalPrice}");
        discountStrategy = Discount.NoDiscount;
        double noDiscountPrice = discountStrategy(1000);
        System.Console.WriteLine($"No Discount Price: {noDiscountPrice}");
        double finalPrice = Discount.CalculateFinalPrice(1000, price => price * 0.7);
        System.Console.WriteLine($"Final Price after 30% discount: {finalPrice}");
        System.Console.WriteLine();


        System.Console.WriteLine("-------------------------Built-in Delegate-------------------------");
        int[] numbers = { 1, 2, 3, 4, 5, 11, 12, 13, 14, 15 };
        System.Console.WriteLine("Even Numbers:");
        BuiltInDelegate.ProcessNumbers(numbers, number => (number % 2 == 0) && (number > 10));
        System.Console.WriteLine("Numbers Greater than 10:");
        BuiltInDelegate.ProcessNumbers(numbers, number => number > 10);
        System.Console.WriteLine();

        System.Console.WriteLine("-------------------------LINQ Basics-------------------------");
        System.Console.WriteLine("-------------------------Selection / Projection - Squared Numbers:-------------------------");
        SelectionProjection.SquareNumbers();
        System.Console.WriteLine();

        System.Console.WriteLine("-------------------------Filtering - Premium Books (Price > 1000):-------------------------");
        var books = new List<Book>
        {
            new Book { Title = "C# Programming", Price = 1200 },
            new Book { Title = "Introduction to LINQ", Price = 800 },
            new Book { Title = "Advanced .NET", Price = 1500 },
            new Book { Title = "Database Systems", Price = 950 },
            new Book { Title = "Web Development", Price = 1100 },
            new Book { Title = "Data Structures", Price = 700 },
            new Book { Title = "Algorithms", Price = 1300 }
        };
        var premiumBooks = books.Where(book => book.Price > 1000);
        foreach (var book in premiumBooks)
        {
            System.Console.WriteLine($"Title: {book.Title}, Price: {book.Price}");
        }

        System.Console.WriteLine();
        System.Console.WriteLine("-------------------------Sorting - Students Names Alphabetically:-------------------------");
        var students = new List<Students>
        {
            new Students { Name = "John", GPA = 3.5 },
            new Students { Name = "Alice", GPA = 3.8 },
            new Students { Name = "Bob", GPA = 3.2 },
            new Students { Name = "Diana", GPA = 3.9 },
            new Students { Name = "Charlie", GPA = 3.6 },
            new Students { Name = "Eve", GPA = 3.7 },
            new Students { Name = "Frank", GPA = 3.4 },
            new Students { Name = "Grace", GPA = 3.3 },
            new Students { Name = "Hannah", GPA = 3.1 },
            new Students { Name = "Ian", GPA = 3.0 },
            new Students { Name = "Jack", GPA = 2.9 },
            new Students { Name = "Karen", GPA = 2.8 }
        };
        var sortedStudents = students.OrderBy(student => student.Name);
        foreach (var student in sortedStudents)
        {
            System.Console.WriteLine($"Name: {student.Name}, GPA: {student.GPA}");
        }
        System.Console.WriteLine();

        System.Console.WriteLine("-------------------------Aggregation Operators - Cashier Sales:-------------------------");
        var cashierSalesList = new List<CashierSales>
        {
            new CashierSales { CashierName = "Alice", SalesAmount = 1500 },
            new CashierSales { CashierName = "Bob", SalesAmount = 2000 },
            new CashierSales { CashierName = "Charlie", SalesAmount = 1800 },
            new CashierSales { CashierName = "Diana", SalesAmount = 2200 },
            new CashierSales { CashierName = "Eve", SalesAmount = 1700 }
        };
        int totalCashiers = cashierSalesList.Count();
        double totalSales = cashierSalesList.Sum(cs => cs.SalesAmount);
        double highestSales = cashierSalesList.Max(cs => cs.SalesAmount);
        double lowestSales = cashierSalesList.Min(cs => cs.SalesAmount);
        double averageSales = cashierSalesList.Average(cs => cs.SalesAmount);
        System.Console.WriteLine($"Total Cashiers: {totalCashiers}");
        System.Console.WriteLine($"Total Sales: {totalSales}");
        System.Console.WriteLine($"Highest Sales: {highestSales}");
        System.Console.WriteLine($"Lowest Sales: {lowestSales}");
        System.Console.WriteLine($"Average Sales: {averageSales}");
        System.Console.WriteLine();

        System.Console.WriteLine("-------------------------Quantifier Operators - Election Applicants:-------------------------");
        var applicants = new List<(string Name, int Age)>
        {
            ("Alice", 20),
            ("Bob", 17),
            ("Charlie", 19),
            ("Diana", 16),
            ("Eve", 22)
        };
        bool anyUnder18 = applicants.Any(applicant => applicant.Age < 18);
        bool allAbove16 = applicants.All(applicant => applicant.Age > 16);
        System.Console.WriteLine($"Any applicant under 18: {anyUnder18}");
        System.Console.WriteLine($"All applicants above 16: {allAbove16}");
        System.Console.WriteLine();

        System.Console.WriteLine("-------------------------Element Operators - Music App Songs:-------------------------");
        var songs = new List<(string Title, int DurationInSeconds)>
        {
            ("Song A", 210),
            ("Song B", 300),
            ("Song C", 150),
            ("Song D", 400),
            ("Song E", 600),
            ("Song F", 720)
        };
        var firstSong = songs.First();
        var lastSong = songs.Last();
        var firstAbove4Min = songs.First(song => song.DurationInSeconds > 240);
        var firstAbove10Min = songs.FirstOrDefault(song => song.DurationInSeconds > 600);
        System.Console.WriteLine($"First Song: {firstSong.Title}, Duration: {firstSong.DurationInSeconds} seconds");
        System.Console.WriteLine($"Last Song: {lastSong.Title}, Duration: {lastSong.DurationInSeconds} seconds");
        System.Console.WriteLine($"First Song above 4 minutes: {firstAbove4Min.Title}, Duration: {firstAbove4Min.DurationInSeconds} seconds");
        if (firstAbove10Min.Title != null)
        {
            System.Console.WriteLine($"First Song above 10 minutes: {firstAbove10Min.Title}, Duration: {firstAbove10Min.DurationInSeconds} seconds");
        }
        else
        {
            System.Console.WriteLine("No song found above 10 minutes.");
        }
        System.Console.WriteLine();
        System.Console.WriteLine("-------------------------Tour Bookings - Market Analysis:-------------------------");
        var tourBookings = new List<(string CustomerName, string Destination, double Price, int DurationInDay, bool IsInternational)>
        {
            ("John Doe", "Paris", 12000, 5, true),
            ("Jane Smith", "New York", 8000, 3, true),
            ("Alice Johnson", "Kathmandu", 5000, 7, false),
            ("Bob Brown", "Tokyo", 15000, 6, true),
            ("Charlie Davis", "London", 11000, 4, true)
        };
        var filteredTours = tourBookings.Where(tour => tour.Price > 10000 && tour.DurationInDay > 4);
        foreach (var tour in filteredTours)
        {
            System.Console.WriteLine($"Customer: {tour.CustomerName}, Destination: {tour.Destination}, Price: {tour.Price}, Duration: {tour.DurationInDay} days, International: {tour.IsInternational}");
        }
        System.Console.WriteLine();
    }
}