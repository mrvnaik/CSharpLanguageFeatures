using System;
using System.Linq;
using static System.Console;
public static class MainClass
{
    public static int Main(string [] args)
    {
        WriteLine("Hello There!");
        var output = GetSumWithCase(null);
        WriteLine($"Sum of when null passed is {output}");

        output = GetSumWithCase(10);
        WriteLine($"Sum of when 10 passed is {output}");

        output = GetSumWithCase("10");
        WriteLine($"Sum of when '10' (as string) passed is {output}");

        try
        {
            output = GetSumWithCase("xyz");
        }
        catch (ArgumentException ex)
        {
            WriteLine($"Argument Exception when 'xyz' passed: {ex.Message}");
        }

        ReadKey();
        return (0);
    }

    static int GetSum(object input)
    {
        if (input is null)
        {
            return 0;
        }

        if (input is int i)
        {
            return Enumerable.Range(1, i).Sum();
        }

        if (int.TryParse(input.ToString(), out i))
        {
            return Enumerable.Range(1, i).Sum();
        }

        throw new ArgumentException("argument must be either int or string or string conversion should be parsable to int", nameof(input));
    }

    static int GetSumWithCase(object input)
    {
        switch (input)
        {
            case null: return 0;
            case int i: return Enumerable.Range(1, i).Sum();
            default:
                if (int.TryParse(input.ToString(), out int i2))
                {
                    return Enumerable.Range(1, i2).Sum();
                }

                throw new ArgumentException("argument must be either int or string or string conversion should be parsable to int", nameof(input));
        }
    }
}