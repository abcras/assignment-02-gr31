namespace Assignment2.Tests;

public class ExtensionsTests
{
    [Fact]
    public void Test1()
    {

    }

    [Fact]
    public void FlattenEnumerableOfEnumerables()
    {
        //Arrange
        List<List<int>> input = new List<List<int>>();
        //input.Append(Enumerable.Empty<int>());
        input.Add(new List<int>() { 1, 2, 3, 4, 5, 6, 7, 10 });

        input.Add(new List<int>() { 12, 34, 56, 710 });

        //Act
        //Assert
        //Assert.Equal(new List<int>() { 1, 2, 3, 4, 5, 6, 7, 10, 12, 34, 56, 710 }, Flatten(input));
    }
    [Fact]
    public void FilterEnumerableWithEvenPredicate()
    {
        //Arrange
        List<int> input = new List<int>()
        {
            1, 2, 3, 4, 5, 6, 7, 10, 12, 34, 56, 710
        };

        //bool Even(int i) => i % 2 == 0;
        Predicate<int> even = (int i) => i % 2 == 0;

        //Act
        //Assert
        //Assert.Equal(new List<int>() { 2, 4, 6, 10, 12, 34, 56, 710 }, Filter(input, even));
    }

    [Fact]
    public void givenHttpsUriReturnFalse() {
        // Arrange
        Uri uri = new("https://www.google.com/");

        //Act
        bool secure = uri.IsSecure();

        //Assert
        Assert.Equal(true, secure);
    }

    [Fact]
    public void GivenHttpUriReturnFalse() {
        // Arrange
        Uri uri = new("http://www.cs.sjsu.edu/~pearce/modules/lectures/web/html/HTTP.htm");

        //Act
        bool secure = uri.IsSecure();

        //Assert
        Assert.Equal(false, secure);
    }

    [Fact]
    public void GivenFiveWordsRetunsFour() {
        // Arrange
        string str = "this string has 4 words";

        //Act
        int count = str.WordCount();

        //Assert
        Assert.Equal(4, count);
    }
}
