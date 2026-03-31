using Microsoft.Extensions.Logging.Abstractions;
using Project_Add_2_numbers;

namespace Project_Add_2_numbers.Tests;

public class MyBigNumberTests
{
    [Theory]
    [InlineData("0", "0", "0")]
    [InlineData("123", "456", "579")]
    [InlineData("999", "1", "1000")]
    [InlineData("12345678901234567890", "98765432109876543210", "111111111011111111100")]
    public void Sum_ReturnsExpectedResult(string stn1, string stn2, string expected)
    {
        MyBigNumber service = new(NullLogger<MyBigNumber>.Instance);

        string result = service.Sum(stn1, stn2);

        Assert.Equal(expected, result);
    }

    [Fact]
    public void Sum_ReturnsExpectedResult_WithCarry()
    {
        MyBigNumber service = new(NullLogger<MyBigNumber>.Instance);

        string result = service.Sum("95", "7");

        Assert.Equal("102", result);
    }

    [Fact]
    public void Sum_OneMillionTimes()
    {
        MyBigNumber service = new(NullLogger<MyBigNumber>.Instance);
        string result = string.Empty;

        for (int i = 0; i < 1000000; i++)
        {
            result = service.Sum("123", "456");
        }

        Assert.Equal("579", result);
    }
}
