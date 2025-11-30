public static class LINQExample
{
    public static void Examples()
    {
        int[] numbers = { 1, 3, 4, 5, 6 };
        var evenNumbers = numbers.Where(n => n % 2 == 0);
        System.Console.WriteLine($"Even Numbers: {string.Join(", ", evenNumbers)}");

        var squaredNumbers = from n in numbers where n % 2 != 0 select n;
        System.Console.WriteLine($"Odd Numbers: {string.Join(", ", squaredNumbers)}");


        
    }


    // > 60, < 80

    public static void Score1()
    {
        int[] scores = { 11, 9, 50, 15, 45, 78, 92, 61, 55, 89, 73, 84 };
        var score = scores.Where(s => s > 60 && s < 80);
        System.Console.WriteLine($"Scores between 60 and 80: {string.Join(", ", score)}");
    }
    public static void Score2()
    {
        int[] scores = { 11, 9, 50, 15, 45, 78, 92, 61, 55, 89, 73, 84 };
        var score2 = from s in scores where s > 40 && s < 60 select s;
        System.Console.WriteLine($"Scores between 40 and 60: {string.Join(", ", score2)}");
    }
    public static void Score3()
    {
        int[] scores = { 11, 9, 50, 15, 45, 78, 92, 61, 55, 89, 73, 84 };
        var score3 = scores.Where(s => s > 0).Where(s => s < 40);
        System.Console.WriteLine($"Scores between 20 and 40: {string.Join(", ", score3)}");
    }

    // scores.Count()
    public static void Score4()
    {
        int[] scores = { 11, 9, 50, 15, 45, 78, 92, 61, 55, 89, 73, 84 };
        var count = scores.Count(s => s > 50);
        System.Console.WriteLine($"Count of scores greater than 50: {count}");
    }

    // scores.Sum()
    public static void Score5()
    {
        int[] scores = { 11, 9, 50, 15, 45, 78, 92, 61, 55, 89, 73, 84 };
        var sum = scores.Sum();
        System.Console.WriteLine($"Sum of all scores: {sum}");
    }
    // scores.Average()
    public static void Score6()
    {
        int[] scores = { 11, 9, 50, 15, 45, 78, 92, 61, 55, 89, 73, 84 };
        var average = scores.Average();
        System.Console.WriteLine($"Average of all scores: {average}");
    }
    // scores.Min()
    public static void Score7()
    {
        int[] scores = { 11, 9, 50, 15, 45, 78, 92, 61, 55, 89, 73, 84 };
        var min = scores.Min();
        System.Console.WriteLine($"Minimum score: {min}");
    }
    // scores.Max()
    public static void Score8()
    {
        int[] scores = { 11, 9, 50, 15, 45, 78, 92, 61, 55, 89, 73, 84 };
        var max = scores.Max();
        System.Console.WriteLine($"Maximum score: {max}");
    }
    // scores.OrderBy()
    public static void Score9()
    {
        int[] scores = { 11, 9, 50, 15, 45, 78, 92, 61, 55, 89, 73, 84 };
        var orderedScores = scores.OrderBy(s => s);
        System.Console.WriteLine($"Scores in ascending order: {string.Join(", ", orderedScores)}");
    }
    // scores.OrderByDescending()
    public static void Score10()
    {
        int[] scores = { 11, 9, 50, 15, 45, 78, 92, 61, 55, 89, 73, 84 };
        var orderedScoresDesc = scores.OrderByDescending(s => s);
        System.Console.WriteLine($"Scores in descending order: {string.Join(", ", orderedScoresDesc)}");
    }
}