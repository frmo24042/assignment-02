namespace Assignment2.Tests;

public class DelegatesTests
{
    [Fact]
    public void Given_a_string_prints_in_reverse_order()
    {
        // Given
        string input = "Hello World";
        string expected = "dlroW olleH";
        // When
        string result = Delegates.reverse(input);
        // Then
        Assert.Equal(expected, result);
    }

    [Fact]
    public void Given_two_decimals_returns_the_product()
    {
        // Given
        decimal a = 2;
        decimal b = 3;
        // When
        decimal result = Delegates.product(a, b);
    
        // Then
        Assert.Equal(6, result);
    }

    [Fact]
    public void Given_nummerical_equal_number_and_string_returns_true()
    {
        // Given
        string input = "0042";
        int number = 42;
    
        // When
        bool result = Delegates.isEqual(input, number);
    
        // Then
        Assert.True(result);
    }
}
