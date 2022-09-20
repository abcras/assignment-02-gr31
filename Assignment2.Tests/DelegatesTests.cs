namespace Assignment2.Tests;

public class DelegatesTests
{
    [Fact]
    public void Given_When_When_When_When_When_When_When_When()
    {
        // Arrange
        string str = "reverse my order";

        Func<string, string> reversed = x => new string(x.Reverse().ToArray<char>());

        // Act 
        string reversedstr = reversed(str);

        // Assert
        Assert.Equal("redro ym esrever", reversedstr);
    }

    [Fact]
    public void Given_When_When_When_When_When_When_When_When_When_When_When_When_When_When_When_When()
    {
        // Arrange
        double myx = 4.5, myy = 8.5;

        Func<double, double, double> multiply = (x, y) => x*y;

        // Act 
        double product = multiply(myx, myy);

        // Assert
        Assert.Equal(38.25, product);
    }

    [Fact]
    public void Given_When_When_When_When_When_When_When_When_When_When_When_When_When_When_When_When_When_When_When_When_When_When_When_When()
    {
        // Arrange
        string str = " 0042";
        int num = 42;

        Func<string, int, bool> NumericallyEqual = (x, y) => int.Parse(x) == y;

        // Act 
        bool result = NumericallyEqual(str, num);

        // Assert
        Assert.Equal(true, result);
    }
}
