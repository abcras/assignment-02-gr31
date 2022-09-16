using Xunit;
using DataLibrary;

namespace DataLibrary.Tests
{
    public class UnitTest1
    {
        [Theory]
        [MemberData(nameof(testData))]
        public void StudentStatusBusinessLogicTest(ImmutableStudent student, Status expected)
        {
            Assert.Equal(expected, student.status);
        }

        static IEnumerable<object[]> testData(){
            yield return new object[] 
            {new ImmutableStudent(1, "Mads", "Thingvad", new DateTime(2020, 08, 01), new DateTime(2023, 08, 01), new DateTime(2023, 08, 01)), Status.Active};

            yield return new object[]
            {new ImmutableStudent(2, "Markus", "Sørensen", new DateTime(2022, 09, 15), new DateTime(2025, 09, 15), new DateTime(2025, 09, 15)), Status.New};

            yield return new object[]
            {new ImmutableStudent(3, "Laurits", "Andersen", new DateTime(2020, 05, 15), new DateTime(2022, 06, 16), new DateTime(2023, 05, 15)), Status.Dropout};

            yield return new object[]
            {new ImmutableStudent(4, "Mark", "Marksen", new DateTime(2018, 01, 01), new DateTime(2021, 01, 01), new DateTime(2021, 01, 01)), Status.Graduated};
        }

    }
}