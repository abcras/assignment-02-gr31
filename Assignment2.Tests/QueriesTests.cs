using static Assignment2.Queries;
namespace Assignment2.Tests;

public class QueriesTests
{
    [Fact]
    public void GivenFileWithTwoWizardsByRowlingReturnsVoldemortAndHarryPotter()
    {
        // Arrange
        var expected = new List<string> {"Voldemort", "Harry Potter"};

        // Act
        var rowlingList = FindMsRowling();
        var rowlingListWithExtensions = FindMsRowlingWithExtensions();

        // Assert
        Assert.Equal(expected, rowlingList);
        Assert.Equal(expected, rowlingListWithExtensions);
    }

    [Fact]
    public void GivenFileWithDarthVaderReturns1977()
    {
        // Arrange
        int expected = 1977;

        // Act
        var year = FindMrDarthSith();
        var yearWithExtensions = FindMrDarthSithWithExtensions();

        // Assert
        Assert.Equal(expected, year);
        Assert.Equal(expected, yearWithExtensions);
    }

    [Fact]
    public void GivenFileWithTwoWizardsFromHarryPotterReturnsNameAndYearOfHarryPotterAndVoldemort()
    {
        // Arrange
        var expected = new List<(string, int?)> {("Harry Potter", 1997), ("Voldemort", 1997)};

        // Act
        var harryPotterWizardsList = FindAllHarryPotterWizards();
        var harryPotterWizardsListWithExtensions = FindAllHarryPotterWizardsWithExtensions();

        // Assert
        Assert.Equivalent(expected, harryPotterWizardsList);
        Assert.Equivalent(expected, harryPotterWizardsListWithExtensions);
    }

    [Fact]
    public void GivenFileWithWizardsReturnsWizardsGroupedByCreatorSortedByCreatorAndThenByName()
    {
        // Arrange
        var expected = new List<string> {"Vivi Ornitier", "Thomas Edison", "Harry Dresden", "Harry Blackstone Copperfield Dresden", "Sauron", "Gandalf", "Voldemort", "Harry Potter", "Emperor Palpatine", "Darth Vader", "Anakin Skywalker", "Merlin"};

        //Reverse order for all wizards and creators:
        /*Toshiyuki Itahana: Vivi Ornitier
        Nancy Matthews Elliott: Thomas Edison
        J. R. R. Tolkien: Sauron, Gandalf
        Jim Butcher: Harry Dresden, Harry Blackstone Copperfield Dresden
        J. K. Rowling: Voldemort, Harry Potter
        George Lucas: Emperor Palpatine, Darth Vader, Anakin Skywalker
        Disney: Merlin*/

        // Act
        var groupedWizardsList = FindWizardsGroupedAndSorted();
        var groupedWizardsListWithExtensions = FindWizardsGroupedAndSortedWithExtensions();

        // Assert
        Assert.Equal(expected, groupedWizardsList);
        Assert.Equal(expected, groupedWizardsListWithExtensions);
    }
}
