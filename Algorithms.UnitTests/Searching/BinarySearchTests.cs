using Algorithms.Searching;

namespace Algorithms.UnitTests.Searching;

public class BinarySearchTests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void ShouldReturnRightIndexOfElementGivenSortedArrayWithUniqueElements()
    {
        List<int> input = new List<int> { 2, 3, 5, 6, 7, 8, 9 };
        var expectedIndex = 0;
        var searchEle = input[expectedIndex];
        var binarySearch = new BinarySearch();
        var actualIndex = binarySearch.Search(input,searchEle);
        AreEquals(expectedIndex, actualIndex);

    }
}