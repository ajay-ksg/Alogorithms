using Algorithms.Sorting;
using FluentAssertions;

namespace Algorithms.UnitTest.Sorting;

public class BubbleSortTest
{
    [Fact]
    public void ShouldReturnASortedArray()
    {
        var input = new List<int>() { 3, 5, 2, 4, 1 };
        var expected = new List<int>() { 1, 2, 3, 4, 5 };
        var sortAlgo = new BubbleSort();
        var actual = sortAlgo.Sort(input);
        expected.Should().Equal(actual);

    }
}