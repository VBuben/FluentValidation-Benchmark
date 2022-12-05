namespace FluentValidation_Benchmark.Helpers;

public static class RandomGenerator
{
    private static readonly Random Random = new Random();
    
    public static string RandomString(int length)
    {
        const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
        return new string(Enumerable.Repeat(chars, length)
            .Select(s => s[Random.Next(s.Length)]).ToArray());
    }

    public static int RandomInt(int min = 0, int max = 2147483647) => Random.Next(min, max);

    public static DateTime RandomDateTime() => 
        new DateTime(
            year: Random.Next(1, 2022), 
            month: Random.Next(1, 12),
            day: Random.Next(1, 28), 
            hour: Random.Next(0, 23), 
            minute: Random.Next(0, 59), 
            second: Random.Next(0, 59)
        );
}