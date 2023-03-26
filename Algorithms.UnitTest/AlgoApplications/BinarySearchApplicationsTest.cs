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

    [Fact]
    public void ShouldReturnIndexOfGivenNumberProvidedRotatedSortedArray()
    {
        var input = new List<int> { 15, 20, 21, 25,1, 2, 3, 4, 5, 6, 10 };
        var expectedIndex = 1;
        var number = input[expectedIndex];
        var binarySearchApplication = new BinarySearchApplications();
        var actual = binarySearchApplication.SearchInRotatedSortedArray(input, number);
        Assert.Equal(expectedIndex,actual);
    }
    
    [Fact]
    public void ShouldReturnIndexOfTheNumberWhichHasExactOneOccurrenceProvidedSortedArrayHasEveryNumberIsPresentTwiceExpectOne()
    {
        var input = new List<int> { 1,1,2,2,3,3,4,4,5,5,6,7,7 };
        var expectedIndex = 10;
        var binarySearchApplication = new BinarySearchApplications();
        var actual = binarySearchApplication.SearchNumberWithSingleOccurrence(input);
        Assert.Equal(expectedIndex,actual);
    }
    
    [Fact]
    public void ShouldReturnTheNumberWhichOccursTwiceProvidedSortedArrayHasEveryNumberIsPresentOnceExpectOneAndNumbersAreInRange1toNMinus1()
    {
        var input = new List<int> { 1,2,3,4,5,6,7,8,9,10,11,11};
        var expectedIndex = 11;
        var binarySearchApplication = new BinarySearchApplications();
        var actual = binarySearchApplication.SearchDuplicatedNumberInSortedArrayHavingUniqueElementsFrom1ToNMinus1(input);
        Assert.Equal(expectedIndex,actual);
    }
    
}