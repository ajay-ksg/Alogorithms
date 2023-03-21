using Algorithms.AlgoApplications;

namespace Algorithms.UnitTest.AlgoApplications;

public class BinarySearchApplicationsTest
{
    [Fact]
    public void ShouldReturnCountOfGivenNumberProvidedSortedArrayWithDuplicates()
    {
        var input = new List<int> { 1, 1, 2, 2, 3, 3, 3, 3, 3, 3, 5 };
        var number = 3;
        var expected = 6;
        var binarySearchApplication = new BinarySearchApplications();
        var actual = binarySearchApplication.GetOccurrenceOfNumber(input, number);
        Assert.Equal(expected,actual);
    }
}