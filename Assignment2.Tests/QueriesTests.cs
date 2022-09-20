using static Assignment2.Queries;
namespace Assignment2.Tests;

public class QueriesTests
{
    [Fact]
    public void Given_When()
    {
        // Arrange
        var expected = new List<string> {"Voldemort", "Harry Potter"};

        // Act
        var rowlingList = FindMsRowling();

        // Assert
        Assert.Equal(expected, rowlingList);
    }

    [Fact]
    public void Given_When_When()
    {
        // Arrange
        int expected = 1977;

        // Act
        var year = FindMrDarthSith();

        // Assert
        Assert.Equal(expected, year);
    }

    [Fact]
    public void Given_When_When_When()
    {
        // Arrange
        var expected = new List<(string, int?)> {("Harry Potter", 1997), ("Voldemort", 1997)};

        // Act
        var year = FindAllHarryPotterWizards();

        // Assert
        Assert.Equivalent(expected, year);
    }
}
