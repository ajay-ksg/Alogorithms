using Algorithms.Sorting;
using FluentAssertions;

namespace Algorithms.UnitTest.Sorting;

public class SortArrayTest
{
    [Theory]
    [MemberData(nameof(GetInputForSorting))]
    public void ShouldReturnASortedArray(string scenario , ISort sortAlgo, List<int> input, List<int> expected)
    {
        var actual = sortAlgo.Sort(input);
        expected.Should().Equal(actual);

    }

    private static IEnumerable<object[]> GetInputForSorting()
    {
        return new List<object[]>()
        {
            new Object[]
            {
                "Bubble Sort", new BubbleSort(), new List<int>() { 3, 5, 2, 4, 1 }, new List<int>() { 1, 2, 3, 4, 5 }
            },
            new Object[]
            {
                "Selection Sort", new SelectionSort(), new List<int>() { 3, 5, 2, 4, 1 }, new List<int>() { 1, 2, 3, 4, 5 }
            },
            new Object[]
            {
                "Selection Sort", new InsertionSort(), new List<int>() { 3, 5, 2, 4, 1,8,6,10,7,9 }, new List<int>() { 1, 2, 3, 4, 5,6,7,8,9,10 }
            }
        };
    }
}