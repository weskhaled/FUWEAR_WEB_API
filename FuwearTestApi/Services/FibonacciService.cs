using FuwearTestApi.Abstractions;

namespace FuwearTestApi.Services;

public class FibonacciService : IFibonacciService
{
    public int GetFibonacciNumber(int n)
    {
        if (n < 0)
        {
            throw new ArgumentOutOfRangeException(nameof(n), "n must be greater than or equal to 0");
        }

        if (n == 0 || n == 1)
        {
            return n;
        }

        var previous = 0;
        var current = 1;
        for (var i = 2; i <= n; i++)
        {
            var next = previous + current;
            previous = current;
            current = next;
        }

        return current;
    }
}

