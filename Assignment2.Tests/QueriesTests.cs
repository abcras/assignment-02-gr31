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
}
