using Algorithms.AlgoApplications;
using FluentAssertions;

namespace Algorithms.UnitTest.Sorting;

public class SortingProblemsTest
{
    private SortingApplication _sortingApplications;
    /*
     * Q1: Given an array of n integers find the smallest sub-array such that  
     *      if we sort this array whole array will become sorted array.
     *
     * Approach 1: Brute Force: Check for each sub array , sort the sub-array
     * and check first and last out-of-index element. n^2*n*log(n)
     *
     * Approach 2: Start from left side of array, and find first out of order element say i,
     * similarly start from right side and find first out of order element say j.
     * Now find min and max between index of i and index of j.
     * Find the place of i in subarray from [0..index(i)] and same for j find correct place
     * from [index(j)..n] and return this range. 
     */

    [Fact]
    public void ShouldReturnMinUnsortedSubarray()
    {
        _sortingApplications = new SortingApplication();
        var input = new List<int>() { 1, 2, 5, 7, 3, 19, 12, 13, 11, 18, 20 };
        //{startIndex,endIndex}
        var expected = new List<int> {2, 9};
        var actual = _sortingApplications.GetMinUnSortedSubarray(input);
        actual.Should().Equal(expected);
    }
    
}