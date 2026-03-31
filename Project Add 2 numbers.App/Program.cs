using Microsoft.Extensions.Logging;
using Project_Add_2_numbers;

class Program
{
    static void Main(string[] args)
    {
        using var loggerFactory = LoggerFactory.Create(builder =>
        {
            builder.AddConsole();
        });

        ILogger<MyBigNumber> logger = loggerFactory.CreateLogger<MyBigNumber>();
        MyBigNumber calculator = new MyBigNumber(logger);

        string result = calculator.Sum("1234", "897");

        Console.WriteLine($"\nFinal Result: {result}");
    }
}