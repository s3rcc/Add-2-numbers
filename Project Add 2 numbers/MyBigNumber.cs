using System.Text;
using Microsoft.Extensions.Logging;

namespace Project_Add_2_numbers;

public class MyBigNumber
{
    private readonly ILogger<MyBigNumber> _logger;

    public MyBigNumber(ILogger<MyBigNumber> logger)
    {
        _logger = logger ?? throw new ArgumentNullException(nameof(logger));
    }

    public string Sum(string stn1, string stn2)
    {
        StringBuilder result = new(Math.Max(stn1.Length, stn2.Length) + 1);
        int carry = 0;
        int step = 1;
        int i = stn1.Length - 1;
        int j = stn2.Length - 1;

        while (i >= 0 || j >= 0)
        {
            int x1 = i >= 0 ? stn1[i] - '0' : 0;
            int x2 = j >= 0 ? stn2[j] - '0' : 0;
            int incomingCarry = carry;
            int sum = x1 + x2 + incomingCarry;
            int digit = sum % 10;

            carry = sum / 10;
            result.Insert(0, digit);

            _logger.LogInformation(
                "Step {Step}: {Digit1} + {Digit2} + carry {IncomingCarry} = {Sum}; write {ResultDigit}, next carry {NextCarry}.",
                step,
                x1,
                x2,
                incomingCarry,
                sum,
                digit,
                carry);

            i--;
            j--;
            step++;
        }

        if (carry > 0)
        {
            result.Insert(0, carry);
            _logger.LogInformation(
                "Step {Step}: no more digits, write remaining carry {Carry}.",
                step,
                carry);
        }

        string finalResult = result.ToString();

        _logger.LogInformation(
            "Completed sum of {FirstNumber} and {SecondNumber}. Result = {Result}.",
            stn1,
            stn2,
            finalResult);

        return finalResult;
    }
}
