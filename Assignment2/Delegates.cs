namespace Assignment2;

public class Delegates
{
    // Create a delegate that takes a string and returns reversed
    public static Func<string, string> reverse = (input) => {
        char[] charArray = input.ToCharArray();
        Array.Reverse(charArray);
        return new string(charArray);
    };

    // Create a delegate that takes two decimals and returns the product
    public static Func<decimal, decimal, decimal> product = (a, b) => a * b;

    // Create a delegate that takes a string and an int and returns true if they are equal: "0042" == 42
    public static Func<string, int, bool> isEqual = (input, number) => int.Parse(input) == number;
}