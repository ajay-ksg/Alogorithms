using Algorithms.Searching;
namespace Algorithms.UnitTest;

public class BinarySearchTests
{
    [Fact]
    public void ShouldReturnRightIndexOfElementGivenSortedArrayWithUniqueElements()
    {
        List<int> input = new List<int> { 2, 3, 5, 6, 7, 8, 9 };
        var expectedIndex = 5;
        var searchEle = input[expectedIndex];
        var binarySearch = new BinarySearch();
        var actualIndex = binarySearch.Search(input,searchEle);
        Assert.Equal(expectedIndex, actualIndex);

    }
    
    [Fact]
    public void ShouldReturnMinusOneIfElementDoesNotExistGivenSortedArrayWithUniqueElements()
    {
        List<int> input = new List<int> { 2, 3, 5, 6, 7, 8, 9 };
        var expectedIndex = -1;
        var searchEle = 10;
        var binarySearch = new BinarySearch();
        var actualIndex = binarySearch.Search(input,searchEle);
        Assert.Equal(expectedIndex, actualIndex);

    }

    [Fact]
    public void ShouldReturnFirstOccurrenceOfElementGivenSortedArrayWithDuplicateElements()
    {
        List<int> input = new List<int> { 10, 10,10, 10, 10, 18, 20, 20 };
        var expectedIndex = 0;
        var searchEle = input[expectedIndex];
        var binarySearch = new BinarySearch();
        var actualIndex = binarySearch.SearchFirstOccurrence(input,searchEle);
        Assert.Equal(expectedIndex, actualIndex);
    }
}